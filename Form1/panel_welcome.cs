using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class panel_welcome : Form
    {
        public panel_welcome()
        {
            InitializeComponent();
        }

        //este é o botao para abrir o painel do login
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (this.panel_wel.Controls.Count > 0)
            {
                this.panel_wel.Controls.RemoveAt(0);
            }

            Entrada log = new Entrada();
            log.TopLevel = false;
            log.Tag = this;
            this.panel_wel.Controls.Add(log);
            log.Show();
            this.btn_login.Visible = false;
        }

        //este é o botao para abrir o painel do registo
        private void btn_registo_Click(object sender, EventArgs e)
        {
            if (this.panel_wel.Controls.Count > 0)
            {
                this.panel_wel.Controls.RemoveAt(0);
            }

            Registar log = new Registar();
            log.TopLevel = false;
            log.Tag = this;
            this.panel_wel.Controls.Add(log);
            log.Show();
            this.btn_login.Visible = false;
        }
    }
}
