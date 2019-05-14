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

namespace Form1
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }
        private string userInserido = "";
        private string passInserida = "";

        private static string _connectionString = "Server=localhost;Database=projeto2019;Uid=root;Pwd=Tr_2017&;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userInserido = Convert.ToString(userTextBox.Text);
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passInserida = Convert.ToString(passTextBox.Text);
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
                Registar Registo = new Registar();
                this.Hide();
                Registo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome Welcome = new Welcome();
            Welcome.Show();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            try
            {
                //
                //POR ISTO A RESOLVER PRIMEIRO ---- IMPORTANTE
                //
                db.Open();
                if (userTextBox.Text == "Nome de Utilizador")
                {
                    MessageBox.Show("Escreva o seu Username !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (passTextBox.Text == "Palavra-passe")
                {
                    MessageBox.Show("Escreva o seu username !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //confirmar se esta campros em grande
                if (!string.IsNullOrEmpty(userInserido) && !string.IsNullOrEmpty(passInserida))
                {
                    MessageBox.Show("Campos em branco !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    PaginaPrincipal Loja = new PaginaPrincipal();
                    Loja.Show();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
            finally
            {
                if (db.State == System.Data.ConnectionState.Open)
                {
                    db.Close();
                    Console.WriteLine("Ligação à BD fechada entrada.");
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.panel_entrada.Visible = false;
            panel_welcome painel = new panel_welcome();
            painel.TopLevel = false;
            this.Controls.Add(painel);
            this.Tag = painel;
            painel.Show();
        }

        private void userTextBox_Enter(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Nome de Utilizador")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.Black;
                userTextBox.UseSystemPasswordChar = false;
            }
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Nome de Utilizador";
                userTextBox.ForeColor = Color.Black;
                userTextBox.UseSystemPasswordChar = false;
            }
        }

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if (passTextBox.Text == "Palavra-passe")
            {
                passTextBox.Text = "";
                passTextBox.ForeColor = Color.Black;
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Palavra-passe";
                passTextBox.ForeColor = Color.Black;
                passTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
