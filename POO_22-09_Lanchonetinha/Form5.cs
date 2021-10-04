using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace POO_22_09_Lanchonetinha
{
    public partial class Form5 : Form
    {
        List<Login> ListUsuarios = new List<Login>();

        public Form5()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void ExibirDados()
        {
            ListUsuarios = Login.carregarUsuarios(@"C:\Bd\BdLogin.json");
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            var elem = ListUsuarios.Where<Login>(x => x.loginUser == login).FirstOrDefault();
            int index = ListUsuarios.IndexOf(elem);

            if (index == -1)
            {
                MessageBox.Show("Usuario incorreto");
            }
            else {
                if (ListUsuarios[index].senhaUser == txtSenha.Text)
                {
                    MessageBox.Show("Usuario logado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
        }
    }
}
