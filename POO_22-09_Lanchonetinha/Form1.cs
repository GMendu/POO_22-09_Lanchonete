using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_22_09_Lanchonetinha
{
    public partial class Form1 : Form
    {
        private Form currentChildForm;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                //Open only form
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelgeral.Controls.Add(ChildForm);
            panelgeral.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            //lblTitleChildForm.Text = ChildForm.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());

        }
    }
}
