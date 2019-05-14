using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Form1
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada Login = new Entrada();
            this.Hide();
            Login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_minimizar_normal.Visible = true;
            btn_maximizar.Visible = false;

        }

        private void btn_minimizar_normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_minimizar_normal.Visible = false;
            btn_maximizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //codigo para fazer mover o form
        private void up_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //codigo para abrir o painel da escolha entre o painel
        //do login ou o do registo
        private void abrirPainel_escolha(object Formlog)
        {
            if (this.panel_receive.Controls.Count > 0)
            {
                this.panel_receive.Controls.RemoveAt(0);
            }

            panel_welcome log = new panel_welcome();
            log.TopLevel = false;
            this.panel_receive.Controls.Add(log);
            this.panel_receive.Tag = log;
            log.Show();
        }
        private void Comecar_Click(object sender, EventArgs e)
        {
            abrirPainel_escolha(new Welcome());
        }
    }
}
