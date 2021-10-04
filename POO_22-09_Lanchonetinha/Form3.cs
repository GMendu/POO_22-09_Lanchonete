using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POO_22_09_Lanchonetinha
{
    public partial class Form3 : Form
    {
        Cliente cliente = new Cliente();
        List<Cliente> listarCliente = new List<Cliente>();
        Produtos produto = new Produtos();
        List<Produtos> listProd = new List<Produtos>();
        Pedido pedido = new Pedido();
        List<Pedido> Listped = new List<Pedido>();
        public Form3()
        {
            InitializeComponent();
            ExibirDados();
        }
        private void ExibirDados()
        {
            listarCliente = Cliente.carregarCliente(@"C:\Bd\BdLanchonete.json");
            dataGridView1.DataSource = listarCliente;
            listProd = Produtos.carregarProdutos(@"C:\Bd\BdProdutos.json");
            dataGridView2.DataSource = listProd;
            Listped = Pedido.carregarPedido(@"C:\Bd\BdPedidin.json");
            dataGridView3.DataSource = Listped;

        }

        private void Mostar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                txtMesa.Text = gridViewRow.Cells[1].Value.ToString();
                txtCliente.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }



        public void CarregarDados()
        {
            pedido.idProd = int.Parse(txtPid.Text);
            pedido.nomeProd = txtPnome.Text;
            pedido.precoProd = double.Parse(txtPpre.Text);
            Listped.Add(pedido);
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Listped;
        }
            private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            if (pedido.SalvarDados(Listped, @"C:\Bd\BdPedidin.json"))
            {
                MessageBox.Show("Adicionado ao carrinho");
            }
            txtPid.Text = null;
            txtPnome.Text = null;
            txtPpre.Text = null;
        }

        private void Guardar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridView2.Rows[e.RowIndex];
                txtPid.Text = gridViewRow.Cells[0].Value.ToString();
                txtPnome.Text = gridViewRow.Cells[1].Value.ToString();
                txtPpre.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }
    }
}
