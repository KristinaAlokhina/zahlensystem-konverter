using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumerikKonverterGui
{
    public class Program : Form
    {
        // Schnittstellenelemente (UI-Komponenten)
        private ComboBox cmbInputType;
        private TextBox txtInput;
        private Button btnConvert;
        private Button btnClear;
        private Label lblResultDez;
        private Label lblResultBin;
        private Button btnCopyBin;
        private Label lblResultOkt;
        private Label lblResultHex;
        private Label lblPrompt;

        // Zustandsspeicherung (verhindert fehleranfälliges Parsen von UI-Texten)
        private string currentBinary = string.Empty;

        public Program()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Einstellungen für das Hauptfenster
            this.Text = "IT-Zahlensystem-Konverter";
            this.Size = new Size(280, 350); // Höhe für das Dropdown-Menü vergrößert
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Komponenten-Initialisierung
            lblPrompt = new Label() { Text = "Eingabetyp und Zahl wählen:", Location = new Point(20, 15), Width = 220 };
            
            // Dropdown-Liste zur Auswahl des Zahlensystems (Eingabe)
            cmbInputType = new ComboBox() { Location = new Point(20, 40), Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbInputType.Items.AddRange(new string[] { "Dezimal (Base 10)", "Binär (Base 2)", "Oktal (Base 8)", "Hexadezimal (Base 16)" });
            cmbInputType.SelectedIndex = 0; // Standardmäßig Dezimal

            txtInput = new TextBox() { Location = new Point(20, 70), Width = 220 };
            btnConvert = new Button() { Text = "Konvertieren", Location = new Point(20, 110), Width = 105 };
            btnClear = new Button() { Text = "Löschen", Location = new Point(135, 110), Width = 105 };
            
            lblResultDez = new Label() { Text = "Dezimal: -", Location = new Point(20, 160), Width = 220 };
            lblResultBin = new Label() { Text = "Binär (Base 2): -", Location = new Point(20, 190), Width = 160 };
            btnCopyBin = new Button() { Text = "📋", Location = new Point(190, 185), Width = 50, Height = 23, Visible = false };
            
            lblResultOkt = new Label() { Text = "Oktal (Base 8): -", Location = new Point(20, 220), Width = 220 };
            lblResultHex = new Label() { Text = "Hex (Base 16): -", Location = new Point(20, 250), Width = 220 };

            // Elemente zum Formular hinzufügen
            this.Controls.AddRange(new Control[] { 
                lblPrompt, cmbInputType, txtInput, btnConvert, btnClear, 
                lblResultDez, lblResultBin, btnCopyBin, lblResultOkt, lblResultHex 
            });

            // Ereignisbindung (Event-Handling)
            btnConvert.Click += BtnConvert_Click;
            btnClear.Click += BtnClear_Click;
            btnCopyBin.Click += BtnCopyBin_Click;
            txtInput.KeyPress += TxtInput_KeyPress;
            cmbInputType.SelectedIndexChanged += CmbInputType_SelectedIndexChanged;
            
            this.AcceptButton = btnConvert; 
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input)) return;

            int fromBase = GetSelectedBase();
            
            try
            {
                // Bei Hexadezimal das Präfix "0x" entfernen, falls der Benutzer es eingegeben hat
                if (fromBase == 16 && input.StartsWith("0X", StringComparison.OrdinalIgnoreCase))
                {
                    input = input.Substring(2);
                }

                // Schritt 1: Konvertierung VOM gewählten System IN eine Dezimalzahl (int)
                int decimalNumber = Convert.ToInt32(input, fromBase);

                // Schritt 2: Konvertierung von Dezimal in alle anderen Systeme
                currentBinary = Convert.ToString(decimalNumber, 2);
                string octal = Convert.ToString(decimalNumber, 8);
                string hexadecimal = Convert.ToString(decimalNumber, 16).ToUpper();

                // Ergebnisausgabe im UI
                lblResultDez.Text = $"Dezimal: {decimalNumber}";
                lblResultBin.Text = $"Binär (Base 2): {currentBinary}";
                lblResultOkt.Text = $"Oktal (Base 8): {octal}";
                lblResultHex.Text = $"Hex (Base 16): 0x{hexadecimal}";
                
                // Kopieren-Button einblenden, sobald Ergebnisse vorliegen
                btnCopyBin.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ungültiges Format für die gewählte Basis.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ermittelt die mathematische Basis anhand der Auswahl im ComboBox
        private int GetSelectedBase()
        {
            switch (cmbInputType.SelectedIndex)
            {
                case 1: return 2;  // Binär
                case 2: return 8;  // Oktal
                case 3: return 16; // Hexadezimal
                default: return 10; // Dezimal
            }
        }

        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            int currentBase = GetSelectedBase();

            // Intelligente Eingabevalidierung basierend auf dem ausgewählten Zahlensystem
            switch (currentBase)
            {
                case 2: // Nur 0 und 1 erlauben
                    if (e.KeyChar != '0' && e.KeyChar != '1') e.Handled = true;
                    break;

                case 8: // Nur Ziffern von 0 bis 7 erlauben
                    if (e.KeyChar < '0' || e.KeyChar > '7') e.Handled = true;
                    break;

                case 10: // Ziffern und Minuszeichen für negative Zahlen erlauben
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-') e.Handled = true;
                    if (e.KeyChar == '-' && ((sender as TextBox).SelectionStart != 0 || (sender as TextBox).Text.Contains("-"))) e.Handled = true;
                    break;

                case 16: // Ziffern (0-9) und Buchstaben (A-F, Case-Insensitive) erlauben
                    char upperChar = char.ToUpper(e.KeyChar);
                    bool isValidHex = char.IsDigit(e.KeyChar) || (upperChar >= 'A' && upperChar <= 'F');
                    if (!isValidHex) e.Handled = true;
                    break;
            }
        }

        private void CmbInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eingabefeld bei Systemwechsel leeren, um Validierungskonflikte zu vermeiden
            txtInput.Clear();
            txtInput.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Formular in den Ausgangszustand zurücksetzen
            txtInput.Clear();
            currentBinary = string.Empty;
            lblResultDez.Text = "Dezimal: -";
            lblResultBin.Text = "Binär (Base 2): -";
            lblResultOkt.Text = "Oktal (Base 8): -";
            lblResultHex.Text = "Hex (Base 16): -";
            btnCopyBin.Visible = false;
            txtInput.Focus();
        }

        private void BtnCopyBin_Click(object sender, EventArgs e)
        {
            // Binärcode in die Zwischenablage kopieren
            if (!string.IsNullOrEmpty(currentBinary))
            {
                Clipboard.SetText(currentBinary);
                MessageBox.Show("Binärcode wurde in die Zwischenablage kopiert!", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Ressourcenbereinigung beim Schließen des Fensters (Verhindert Memory Leaks)
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                cmbInputType?.Dispose();
                txtInput?.Dispose();
                btnConvert?.Dispose();
                btnClear?.Dispose();
                lblResultDez?.Dispose();
                lblResultBin?.Dispose();
                btnCopyBin?.Dispose();
                lblResultOkt?.Dispose();
                lblResultHex?.Dispose();
                lblPrompt?.Dispose();
            }
            base.Dispose(disposing);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }
    }
}
