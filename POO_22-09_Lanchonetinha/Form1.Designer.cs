
namespace POO_22_09_Lanchonetinha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelbotões = new System.Windows.Forms.Panel();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnConfig = new FontAwesome.Sharp.IconButton();
            this.btnPedido = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelgeral = new System.Windows.Forms.Panel();
            this.panelEsquerdo.SuspendLayout();
            this.panelbotões.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.Controls.Add(this.panelbotões);
            this.panelEsquerdo.Controls.Add(this.panellogo);
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(159, 450);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // panelbotões
            // 
            this.panelbotões.BackColor = System.Drawing.Color.DarkRed;
            this.panelbotões.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbotões.Controls.Add(this.BtnClientes);
            this.panelbotões.Controls.Add(this.BtnConfig);
            this.panelbotões.Controls.Add(this.btnPedido);
            this.panelbotões.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbotões.Location = new System.Drawing.Point(0, 100);
            this.panelbotões.Name = "panelbotões";
            this.panelbotões.Size = new System.Drawing.Size(159, 350);
            this.panelbotões.TabIndex = 1;
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.BtnClientes.IconColor = System.Drawing.Color.Black;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 30;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(3, 75);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(153, 63);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.IndianRed;
            this.BtnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConfig.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.BtnConfig.IconColor = System.Drawing.Color.Black;
            this.BtnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfig.IconSize = 30;
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.Location = new System.Drawing.Point(5, 282);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(153, 63);
            this.BtnConfig.TabIndex = 1;
            this.BtnConfig.Text = "Configurações";
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.IndianRed;
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPedido.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnPedido.IconColor = System.Drawing.Color.Black;
            this.btnPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPedido.IconSize = 30;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(3, 6);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(153, 63);
            this.btnPedido.TabIndex = 0;
            this.btnPedido.Text = "Fazer Pedido";
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.Maroon;
            this.panellogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(159, 100);
            this.panellogo.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Maroon;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(159, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(641, 75);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelgeral
            // 
            this.panelgeral.BackColor = System.Drawing.Color.Brown;
            this.panelgeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelgeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgeral.Location = new System.Drawing.Point(159, 75);
            this.panelgeral.Name = "panelgeral";
            this.panelgeral.Size = new System.Drawing.Size(641, 375);
            this.panelgeral.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelgeral);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelEsquerdo);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEsquerdo.ResumeLayout(false);
            this.panelbotões.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panelbotões;
        private FontAwesome.Sharp.IconButton btnPedido;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton BtnConfig;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelgeral;
        private FontAwesome.Sharp.IconButton BtnClientes;
    }
}

