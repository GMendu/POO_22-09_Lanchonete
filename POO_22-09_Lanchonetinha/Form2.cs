using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO_22_09_Lanchonetinha
{
    public partial class Form2 : Form
    {
        Cliente cliente = new Cliente();
        List<Cliente> listarCliente = new List<Cliente>();
        public Form2()
        {
            InitializeComponent();
            ExibirDados();
        }
        public void CarregarDados()
        {
            cliente.idCliente = int.Parse(txtMesa.Text);
            cliente.NomeCliente = txtCliente.Text;
            listarCliente.Add(cliente);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listarCliente;
        }
            
        private void ExibirDados()
        {
            listarCliente = Cliente.carregarCliente(@"C:\Bd\BdLanchonete.json");
            dataGridView1.DataSource = listarCliente;
        }

            
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            if (cliente.SalvarDados(listarCliente, @"C:\Bd\BdLanchonete.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            txtMesa.Text = null;
            txtCliente.Text = null;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMesa.Text);
            var elem = listarCliente.Where<Cliente>(x => x.idCliente == id).FirstOrDefault();
            int index = listarCliente.IndexOf(elem);
            

            listarCliente[index].NomeCliente = txtCliente.Text;
            if (cliente.SalvarDados(listarCliente, @"C:\Bd\BdLanchonete.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMesa.Text);
            var elem = listarCliente.Where<Cliente>(x => x.idCliente == id).FirstOrDefault();
            listarCliente.Remove(elem);

            if (cliente.SalvarDados(listarCliente, @"C:\Bd\BdLanchonete.json"))
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
                txtMesa.Text = gridViewRow.Cells[0].Value.ToString();
                txtCliente.Text = gridViewRow.Cells[1].Value.ToString();
            }
        }
    }
}
