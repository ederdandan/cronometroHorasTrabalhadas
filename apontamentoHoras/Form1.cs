using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace apontamentoHoras
{
    public partial class formApontamento : Form
    {
        Stopwatch cronometro = new Stopwatch();
        ContextMenu contextMenu = new ContextMenu();

        private readonly int qtdeHoraPorDia = Convert.ToInt32(ConfigurationManager.AppSettings["qtdeHoraPorDia"].ToString());
        private readonly int qtdeMinutosSoneca = Convert.ToInt32(ConfigurationManager.AppSettings["qtdeMinutosSoneca"].ToString());

        private List<string> _listSonecas = new List<string> { "Bora Zé Ruela!", "Vai Maluco!", "Cavalo. Some.", "Some Daqui!", "Sai Fora Maluco!" };

        public formApontamento()
        {
            InitializeComponent();
            CriarMenuIcone();
            InicialisarTimerCronometro();
            InicialisarTimerApontamento();
            txtDataHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void InicialisarTimerApontamento()
        {
            tmrApontamento.Interval = ConverterHoraEmMiliSegundos(qtdeHoraPorDia);
            tmrApontamento.Tick += TmrApontamento_Tick;
        }

        private void InicialisarTimerSoneca()
        {
            tmrSoneca.Interval = ConverterMinutosEmMiliSegundos(qtdeMinutosSoneca);
            tmrSoneca.Tick += TmrSoneca_Tick;
            tmrSoneca.Enabled = true;
            tmrSoneca.Start();
            ManipularVisaoSoneca(true);
        }

        private void InicialisarTimerCronometro()
        {
            tmrCronometro.Interval = 1;
            tmrCronometro.Tick += TmrCronometro_Tick;
        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
            cronometro.Start();    
            tmrCronometro.Start();
            tmrApontamento.Start();

            ManipularCorLabel(Color.White);
            ManipularEnableBotoesApontar();
            MessageBox.Show("Bora Trampar!");
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            tmrCronometro.Stop();
            tmrApontamento.Stop();
            tmrSoneca.Stop();

            ManipularCorLabel(Color.Red);
            ManipularEnableBotoesParar();
            ManipularVisaoSoneca(false);
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Zerar o apontamento?", "Apontamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                cronometro.Reset();
                tmrCronometro.Stop();
                tmrApontamento.Stop();
                tmrSoneca.Stop();
                ManipularVisaoSoneca(false);
                ManipularCorLabel(Color.White);
                ManipularEnableBotoesZerar();
                ZerarLabel();
            }
        }

        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            if (cronometro.Elapsed.Hours < 10)
                lblHoras.Text = "0" + cronometro.Elapsed.Hours.ToString();
            else
                lblHoras.Text = cronometro.Elapsed.Hours.ToString();
            if (cronometro.Elapsed.Minutes < 10)
                lblMinutos.Text = "0" + cronometro.Elapsed.Minutes.ToString();
            else
                lblMinutos.Text = cronometro.Elapsed.Minutes.ToString();
            if (cronometro.Elapsed.Seconds < 10)
                lblSegundos.Text = "0" + cronometro.Elapsed.Seconds.ToString();
            else
                lblSegundos.Text = cronometro.Elapsed.Seconds.ToString();
            lblMilisegundos.Text = cronometro.Elapsed.Milliseconds.ToString();
        }

        private void TmrApontamento_Tick(object sender, EventArgs e)
        {
            InicialisarTimerSoneca();
            AddMenuPararSoneca();
            MessageBox.Show("Bora Maluco!");
        }

        private void TmrSoneca_Tick(object sender, EventArgs e)
        {
            var rnd = new Random();
            var msg = _listSonecas[rnd.Next(0, _listSonecas.Count - 1)];
            MessageBox.Show(msg);
        }

        private void formApontamento_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void pbSoneca_Click(object sender, EventArgs e)
        {
            contextMenu.MenuItems.RemoveAt(4);
            ManipularVisaoSoneca(false);
            tmrSoneca.Enabled = false;
            tmrSoneca.Stop();
            MessageBox.Show("Soneca Cancelado!");
        }

        private void espiar_Click(object sender, EventArgs e)
        {
            var tempo = $"{lblHoras.Text}:{lblMinutos.Text}:{lblSegundos.Text}:{lblMilisegundos.Text}";
            notifyIcon1.BalloonTipText = tempo;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void CriarMenuIcone()
        {
            contextMenu.MenuItems.Add("INICIAR", btnApontar_Click);
            contextMenu.MenuItems.Add("PARAR", btnParar_Click);
            contextMenu.MenuItems.Add("ZERAR", btnZerar_Click);
            contextMenu.MenuItems.Add("ESPIAR", espiar_Click);

            ManipularEnableBotoesZerar();

            notifyIcon1.Icon = new Icon("despertador1.ico");
            notifyIcon1.ContextMenu = contextMenu;
        }

        private void ManipularCorLabel(Color color) => lblHoras.ForeColor = lblMinutos.ForeColor = lblSegundos.ForeColor = lblMilisegundos.ForeColor = lblDoisPontos1.ForeColor = lblDoisPontos2.ForeColor = color;

        private void ManipularEnableBotoesApontar()
        {
            btnIniciar.Enabled = contextMenu.MenuItems[0].Enabled = false;
            btnParar.Enabled = contextMenu.MenuItems[1].Enabled = true;
            btnZerar.Enabled = contextMenu.MenuItems[2].Enabled = true;
        }

        private void ManipularEnableBotoesParar()
        {
            btnIniciar.Enabled = contextMenu.MenuItems[0].Enabled = true;
            btnParar.Enabled = contextMenu.MenuItems[1].Enabled = false;
            btnZerar.Enabled = contextMenu.MenuItems[2].Enabled = true;
        }

        private void ManipularEnableBotoesZerar()
        {
            btnIniciar.Enabled = contextMenu.MenuItems[0].Enabled = true;
            btnZerar.Enabled = contextMenu.MenuItems[1].Enabled = false;
            btnParar.Enabled = contextMenu.MenuItems[2].Enabled = false;
        }

        private void ManipularVisaoSoneca(bool visualiza) => pbSoneca.Visible = visualiza;

        private void ZerarLabel() => lblHoras.Text = lblMinutos.Text = lblSegundos.Text = lblMilisegundos.Text = "00";

        private void AddMenuPararSoneca()
        {
            contextMenu.MenuItems.Add("PARAR SONECA", pbSoneca_Click);
        }

        private int ConverterHoraEmMiliSegundos(int hora)
        {
            return int.Parse(TimeSpan.FromHours(hora).TotalMilliseconds.ToString());
        }

        private int ConverterMinutosEmMiliSegundos(int minuto)
        {
            return int.Parse(TimeSpan.FromMinutes(minuto).TotalMilliseconds.ToString());
        }
    }
}
