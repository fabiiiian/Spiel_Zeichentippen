using System.Diagnostics;

namespace Spiel
{
    public partial class Form1 : Form
    {
        Stopwatch stoppuhr = new Stopwatch();
        string zufälligeZeichen = "";
        int zeichenIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            stoppuhr.Restart();

            // Zurücksetzen
            zufälligeZeichen = "";
            zeichenIndex = 0;
            string alleZeichen = "";

            // alle Zeichen geordnet
            string easyZeichen = "abcdefghijklmnopqrstuvwxyzüäö";
            string mediumZeichen = "ABCDEFGHIJKLMNOPQRSTUVWXYZÜÄÖ1234567890";
            string hardZeichen = "<>|.:,;-_#'*+~?\\)][({/&%$§}=²\"!^°€@";

            if (Easyradiobutton.Checked)
            {
                alleZeichen = easyZeichen;
            }
            else if (MediumradioButton.Checked)
            {
                alleZeichen = easyZeichen + mediumZeichen;
            }
            else
            {
                alleZeichen = easyZeichen + mediumZeichen + hardZeichen;
            }

            // Zufallszeichenkette erzeugen
            List<char> allezeichenListe = new List<char>(alleZeichen);
            Random random = new Random();

            while (allezeichenListe.Count > 0)
            {
                int zufallsindex = random.Next(allezeichenListe.Count);
                char zufallszeichen = allezeichenListe[zufallsindex];
                zufälligeZeichen = zufälligeZeichen + zufallszeichen;
                allezeichenListe.RemoveAt(zufallsindex);
            }

            ZeigeZeichen();
            this.Focus(); // damit Keypress der Form funktioniert

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //wenn noch nicht Start gedrückt dann darf kein nichts Eingeben werden.
            if (ZeichenLabel.Text.Length == 0)
            {
                return;
            }
            char zeichen = zufälligeZeichen[zeichenIndex];
            if (e.KeyChar == zeichen)
            {
                zeichenIndex++;
                ZeigeZeichen();
            }

        }

        void ZeigeZeichen()
        {
            if (zeichenIndex == zufälligeZeichen.Length)
            {
                ZeichenLabel.Text = "";
                Restzeichenlabel.Text = "";
                Stop();
            }
            else
            {
                char zeichen = zufälligeZeichen[zeichenIndex];

                if (zeichen == '&')
                    ZeichenLabel.Text = "&&";
                else
                    ZeichenLabel.Text = zeichen.ToString();

                int restZeichen = zufälligeZeichen.Length - zeichenIndex;
                Restzeichenlabel.Text = "Es sind noch " + restZeichen + " Zeichen übrig.";
            }
        }

        private void Stop()
        {
            StopButton.Enabled = false;
            StartButton.Enabled = true;
            stoppuhr.Stop();
            MessageBox.Show(
                string.Format("Du hast {0:0.00} Sekunden benötigt.", stoppuhr.Elapsed.TotalSeconds));
        }
    }
}
