using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumerikKonverterGui
{
    public class Program : Form
    {
        // Erstellen von Schnittstellenelementen
        private TextBox txtInput = new TextBox() { Location = new Point(20, 40), Width = 220 };
        private Button btnConvert = new Button() { Text = "Konvertieren", Location = new Point(20, 80), Width = 105 };
        private Button btnClear = new Button() { Text = "Löschen", Location = new Point(135, 80), Width = 105 }; // NEU: Löschen-Button
        
        private Label lblResultDez = new Label() { Text = "Dezimal: -", Location = new Point(20, 130), Width = 220 };
        private Label lblResultBin = new Label() { Text = "Binär (Base 2): -", Location = new Point(20, 160), Width = 160 };
        private Button btnCopyBin = new Button() { Text = "📋", Location = new Point(190, 155), Width = 50, Height = 23, Visible = false }; // NEU: Kopieren-Button
        
        private Label lblResultOkt = new Label() { Text = "Oktal (Base 8): -", Location = new Point(20, 190), Width = 220 }; // NEU: Oktalsystem
        private Label lblResultHex = new Label() { Text = "Hex (Base 16): -", Location = new Point(20, 220), Width = 220 };

        public Program()
        {
            // Einstellungen für das Hauptfenster
            this.Text = "IT-Zahlensystem-Konverter";
            this.Size = new Size(280, 300); // Fenster leicht vergrößert für neue Elemente
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Fenstergröße fixiert
            this.MaximizeBox = false; // Maximieren deaktiviert

            // Hinweis für den Benutzer
            Label lblPrompt = new Label() { Text = "Bitte Ganzzahl (Dezimal) eingeben:", Location = new Point(20, 15), Width = 220 };
            
            this.Controls.AddRange(new Control[] { 
                lblPrompt, txtInput, btnConvert, btnClear, 
                lblResultDez, lblResultBin, btnCopyBin, lblResultOkt, lblResultHex 
            });

            // Ereignisbindung
            btnConvert.Click += BtnConvert_Click;
            btnClear.Click += BtnClear_Click; // NEU: Event für Löschen
            btnCopyBin.Click += BtnCopyBin_Click; // NEU: Event für Kopieren
            
            // NEU: Aktiviert die Konvertierung beim Drücken der Enter-Taste im Textfeld
            this.AcceptButton = btnConvert; 
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            // Validierungs- und Konvertierungslogik
            if (int.TryParse(input, out int decimalNumber))
            {
                string binary = Convert.ToString(decimalNumber, 2);
                string octal = Convert.ToString(decimalNumber, 8); // NEU: Konvertierung in Oktal
                string hexadecimal = Convert.ToString(decimalNumber, 16).ToUpper();

                // Ausgabe des Ergebnisses
                lblResultDez.Text = $"Dezimal: {decimalNumber}";
                lblResultBin.Text = $"Binär (Base 2): {binary}";
                lblResultOkt.Text = $"Oktal (Base 8): {octal}"; // NEU
                lblResultHex.Text = $"Hex (Base 16): 0x{hexadecimal}";
                
                // Kopieren-Button anzeigen, wenn Ergebnisse da sind
                btnCopyBin.Visible = true;
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte eine korrekte Ganzzahl eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NEU: Logik für das Zurücksetzen des Fensters
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblResultDez.Text = "Dezimal: -";
            lblResultBin.Text = "Binär (Base 2): -";
            lblResultOkt.Text = "Oktal (Base 8): -";
            lblResultHex.Text = "Hex (Base 16): -";
            btnCopyBin.Visible = false;
            txtInput.Focus();
        }

        // NEU: Logik zum Kopieren des Binärcodes in die Zwischenablage
        private void BtnCopyBin_Click(object sender, EventArgs e)
        {
            if (lblResultBin.Text.Contains(": "))
            {
                string rawBinary = lblResultBin.Text.Split(new string[] { ": " }, StringSplitOptions.None)[1];
                Clipboard.SetText(rawBinary);
                MessageBox.Show("Binärcode in die Zwischenablage kopiert!", "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
