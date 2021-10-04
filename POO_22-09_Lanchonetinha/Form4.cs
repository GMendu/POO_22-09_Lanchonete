using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace POO_22_09_Lanchonetinha
{
    public partial class Form4 : Form
    {
        Produtos produto = new Produtos();
        List<Produtos> listProd = new List<Produtos>();
        public Form4()
        {
            InitializeComponent();
            ExibirDados();
        }
        public void CarregarDados()
        {
            produto.idProd = int.Parse(txtID.Text);
            produto.nomeProd = txtProduto.Text;
            produto.precoProd = double.Parse(txtPreco.Text);
            listProd.Add(produto);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listProd;
        }

        private void ExibirDados()
        {
            listProd = Produtos.carregarProdutos(@"C:\Bd\BdProdutos.json");
            dataGridView1.DataSource = listProd;
        }


        private void BtnAdicionar_Click_1(object sender, EventArgs e)
        {
            CarregarDados();
            if (produto.SalvarDados(listProd, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            txtID.Text = (produto.idProd+1).ToString();
            txtProduto.Text = null;
            txtPreco.Text = null;
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var elem = listProd.Where<Produtos>(x => x.idProd == id).FirstOrDefault();
            listProd.Remove(elem);
            

            if (produto.SalvarDados(listProd, @"C:\Bd\BdProdutos.json"))
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
                txtProduto.Text = gridViewRow.Cells[1].Value.ToString();
                txtPreco.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var elem = listProd.Where<Produtos>(x => x.idProd == id).FirstOrDefault();
            int index = listProd.IndexOf(elem);

            listProd[index].nomeProd = txtProduto.Text;
            listProd[index].precoProd = double.Parse(txtPreco.Text);
            if (produto.SalvarDados(listProd, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }
    }
}
