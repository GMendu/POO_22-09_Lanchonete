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
        public Form3()
        {
            InitializeComponent();
            ExibirDados();
        }
        private void ExibirDados()
        {
            listarCliente = Cliente.carregarCliente(@"C:\Bd\BdLanchonete.json");
            dataGridView1.DataSource = listarCliente;
        }

        private void Mostrar(object sender, DataGridViewCellEventArgs e)
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
