namespace csharp_fundamentos
{
    partial class CaixaEletronico
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
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnInvestir = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(120, 36);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(151, 62);
            this.btnSacar.TabIndex = 0;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnInvestir
            // 
            this.btnInvestir.Location = new System.Drawing.Point(120, 120);
            this.btnInvestir.Name = "btnInvestir";
            this.btnInvestir.Size = new System.Drawing.Size(151, 62);
            this.btnInvestir.TabIndex = 1;
            this.btnInvestir.Text = "Investimento";
            this.btnInvestir.UseVisualStyleBackColor = true;
            this.btnInvestir.Click += new System.EventHandler(this.btnInvestir_Click);
            // 
            // btnContas
            // 
            this.btnContas.Location = new System.Drawing.Point(120, 202);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(151, 62);
            this.btnContas.TabIndex = 2;
            this.btnContas.Text = "Contas";
            this.btnContas.UseVisualStyleBackColor = true;
            this.btnContas.Click += new System.EventHandler(this.btnContas_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(120, 290);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(151, 62);
            this.btnTransferencia.TabIndex = 3;
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(120, 380);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(151, 62);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(330, 36);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(203, 22);
            this.txtTitular.TabIndex = 5;
            // 
            // CaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 505);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnContas);
            this.Controls.Add(this.btnInvestir);
            this.Controls.Add(this.btnSacar);
            this.Name = "CaixaEletronico";
            this.Text = "CaixaEletronico";
            this.Load += new System.EventHandler(this.CaixaEletronico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnInvestir;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtTitular;
    }
}