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
    public partial class Form6 : Form
    {
        Login usuario = new Login();
        List<Login> ListUsuarios = new List<Login>();
        public Form6()
        {
            InitializeComponent();
            ExibirDados();
        }
        public void CarregarDados()
        {
            usuario.idUser = int.Parse(txtID.Text);
            usuario.loginUser = txtLogin.Text;
            usuario.senhaUser = txtSenha.Text;
            ListUsuarios.Add(usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListUsuarios;
        }

        private void ExibirDados()
        {
            ListUsuarios = Login.carregarUsuarios(@"C:\Bd\BdLogin.json");
            dataGridView1.DataSource = ListUsuarios;
        }


        private void BtnAdicionar_Click_1(object sender, EventArgs e)
        {
            CarregarDados();
            if (usuario.SalvarDados(ListUsuarios, @"C:\Bd\BdLogin.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtID.Text += 1;
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var elem = ListUsuarios.Where<Login>(x => x.idUser == id).FirstOrDefault();
            int index = ListUsuarios.IndexOf(elem);


            ListUsuarios[index].loginUser = txtLogin.Text;
            ListUsuarios[index].senhaUser = txtSenha.Text;
            if (usuario.SalvarDados(ListUsuarios, @"C:\Bd\BdLogin.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }

        private void BtnRemover_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var elem = ListUsuarios.Where<Login>(x => x.idUser == id).FirstOrDefault();
            ListUsuarios.Remove(elem);

            if (usuario.SalvarDados(ListUsuarios, @"C:\Bd\BdLanchonete.json"))
            {
                MessageBox.Show("Dados removidos");
            }
            ExibirDados();
        }
        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                txtID.Text = gridViewRow.Cells[0].Value.ToString();
                txtLogin.Text = gridViewRow.Cells[1].Value.ToString();
                txtSenha.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }
    }
}
