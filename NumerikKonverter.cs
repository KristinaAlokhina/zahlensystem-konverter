using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumerikKonverterGui
{
    public class Program : Form
    {
        // Erstellen von Schnittstellenelementen
        private TextBox txtInput = new TextBox() { Location = new Point(20, 40), Width = 200 };
        private Button btnConvert = new Button() { Text = "Konvertieren", Location = new Point(20, 80), Width = 200 };
        private Label lblResultDez = new Label() { Text = "Dezimal: -", Location = new Point(20, 130), Width = 200 };
        private Label lblResultBin = new Label() { Text = "Binär (Base 2): -", Location = new Point(20, 160), Width = 200 };
        private Label lblResultHex = new Label() { Text = "Hex (Base 16): -", Location = new Point(20, 190), Width = 200 };

        public Program()
        {
            // Einstellungen für das Hauptfenster
            this.Text = "IT-Zahlensystem-Konverter";
            this.Size = new Size(260, 270);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Fügen wir eine Hinweis für den Benutzer hinzu
            Label lblPrompt = new Label() { Text = "Bitte Ganzzahl (Dezimal) eingeben:", Location = new Point(20, 15), Width = 200 };
            
            this.Controls.AddRange(new Control[] { lblPrompt, txtInput, btnConvert, lblResultDez, lblResultBin, lblResultHex });

            // Binden wir den Klick auf die Schaltfläche an die Konvertierungslogik (Ihre Logik aus der Konsole)
            btnConvert.Click += BtnConvert_Click;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            // Ihre Validierungs- und Konvertierungslogik aus der Konsolenanwendung
            if (int.TryParse(input, out int decimalNumber))
            {
                string binary = Convert.ToString(decimalNumber, 2);
                string hexadecimal = Convert.ToString(decimalNumber, 16).ToUpper();

                // Ausgabe des Ergebnisses auf dem Anwendungsfenster
                lblResultDez.Text = $"Dezimal: {decimalNumber}";
                lblResultBin.Text = $"Binär (Base 2): {binary}";
                lblResultHex.Text = $"Hex (Base 16): 0x{hexadecimal}";
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte eine korrekte Zahl eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
    }
}