
namespace POO_22_09_Lanchonetinha
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnRemover = new FontAwesome.Sharp.IconButton();
            this.BtnAdicionar = new FontAwesome.Sharp.IconButton();
            this.labelMesa = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.ComboBox();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMesa,
            this.ColumnCliente});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(199, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Editar);
            // 
            // BtnEditar
            // 
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnEditar.IconColor = System.Drawing.Color.Black;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(12, 399);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(89, 39);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRemover.IconColor = System.Drawing.Color.Black;
            this.BtnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRemover.IconSize = 30;
            this.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemover.Location = new System.Drawing.Point(107, 399);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(105, 39);
            this.BtnRemover.TabIndex = 2;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAdicionar.IconColor = System.Drawing.Color.Black;
            this.BtnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdicionar.IconSize = 30;
            this.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.Location = new System.Drawing.Point(381, 246);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(105, 39);
            this.BtnAdicionar.TabIndex = 3;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.Location = new System.Drawing.Point(334, 104);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(35, 15);
            this.labelMesa.TabIndex = 4;
            this.labelMesa.Text = "Mesa";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(386, 149);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 23);
            this.txtCliente.TabIndex = 6;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(334, 152);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 7;
            this.labelNome.Text = "Nome";
            // 
            // txtMesa
            // 
            this.txtMesa.FormattingEnabled = true;
            this.txtMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.txtMesa.Location = new System.Drawing.Point(386, 101);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(121, 23);
            this.txtMesa.TabIndex = 9;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.DataPropertyName = "NomeCliente";
            this.ColumnCliente.FillWeight = 149.2386F;
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            // 
            // ColumnMesa
            // 
            this.ColumnMesa.DataPropertyName = "idCliente";
            this.ColumnMesa.FillWeight = 50.76142F;
            this.ColumnMesa.HeaderText = "Mesa";
            this.ColumnMesa.Name = "ColumnMesa";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelMesa);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnRemover;
        private FontAwesome.Sharp.IconButton BtnAdicionar;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ComboBox txtMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
    }
}