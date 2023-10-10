using System.IO.MemoryMappedFiles;
using System.Text;

namespace NobelDijGUI
{
    public partial class FrmNobelDij : Form
    {
        public FrmNobelDij()
        {
            InitializeComponent();
            btnMentes.Click += BtnMentesClick;
        }

        private void BtnMentesClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEv.Text) 
                || string.IsNullOrEmpty(tbxNev.Text)
                || string.IsNullOrEmpty(tbxSzH.Text)
                || string.IsNullOrEmpty(tbxOrszag.Text))
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "T�lts�n ki minden mez�t!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else if (int.Parse(tbxEv.Text) < 1989)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "Az �vsz�m nem megfelel�!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string eleresiUt = @"..\..\..\src\uj_dijazott.txt";
                    bool letezik = File.Exists(eleresiUt);
                    using StreamWriter sw = new(eleresiUt, true, Encoding.UTF8);
                    if (!letezik) sw.WriteLine("�v;N�v;Sz�let�sHal�loz�s;Orsz�gk�d");
                    sw.WriteLine($"{tbxEv.Text};{tbxNev.Text};{tbxSzH.Text};{tbxOrszag.Text}");

                    tbxEv.Clear();
                    tbxNev.Clear();
                    tbxSzH.Clear();
                    tbxOrszag.Clear();
                }
                catch
                {
                    _ = MessageBox.Show(
                        caption: "HIBA!",
                        text: "Hiba az �llom�ny �r�s�n�l!",
                        icon: MessageBoxIcon.Error,
                        buttons: MessageBoxButtons.OK);
                }
            }
        }
    }
}