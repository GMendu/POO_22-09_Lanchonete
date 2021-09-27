
namespace POO_22_09_Lanchonetinha
{
    partial class Form4
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
            this.labelProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.BtnAdicionar = new FontAwesome.Sharp.IconButton();
            this.BtnRemover = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(333, 151);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(50, 15);
            this.labelProduto.TabIndex = 16;
            this.labelProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(385, 148);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(121, 23);
            this.txtProduto.TabIndex = 15;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(333, 103);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(37, 15);
            this.labelPreco.TabIndex = 14;
            this.labelPreco.Text = "Preço";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAdicionar.IconColor = System.Drawing.Color.Black;
            this.BtnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdicionar.IconSize = 30;
            this.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.Location = new System.Drawing.Point(380, 245);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(105, 39);
            this.BtnAdicionar.TabIndex = 13;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            this.BtnRemover.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRemover.IconColor = System.Drawing.Color.Black;
            this.BtnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRemover.IconSize = 30;
            this.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemover.Location = new System.Drawing.Point(106, 398);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(105, 39);
            this.BtnRemover.TabIndex = 12;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnEditar.IconColor = System.Drawing.Color.Black;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(11, 398);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(89, 39);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnProd,
            this.ColumnPreco});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(199, 380);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Editar);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "idProd";
            this.ColumnID.FillWeight = 50.76142F;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnProd
            // 
            this.ColumnProd.DataPropertyName = "NomeProd";
            this.ColumnProd.FillWeight = 149.2386F;
            this.ColumnProd.HeaderText = "Produto";
            this.ColumnProd.Name = "ColumnProd";
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.DataPropertyName = "precoProd";
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(385, 100);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(121, 23);
            this.txtPreco.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(385, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 23);
            this.txtID.TabIndex = 18;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(350, 59);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label labelPreco;
        private FontAwesome.Sharp.IconButton BtnAdicionar;
        private FontAwesome.Sharp.IconButton BtnRemover;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
    }
}