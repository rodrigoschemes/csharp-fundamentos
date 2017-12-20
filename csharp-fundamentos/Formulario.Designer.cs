namespace csharp_fundamentos
{
    partial class Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositarPoupanca = new System.Windows.Forms.Button();
            this.txtPoupanca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conta";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(151, 90);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(254, 22);
            this.txtTitular.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(151, 129);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(254, 22);
            this.txtSaldo.TabIndex = 4;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(151, 214);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(254, 22);
            this.txtConta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(151, 295);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(301, 22);
            this.txtValor.TabIndex = 7;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(151, 339);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(136, 48);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar (Conta)";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(322, 339);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(136, 48);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar (Conta)";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositarPoupanca
            // 
            this.btnDepositarPoupanca.Location = new System.Drawing.Point(151, 406);
            this.btnDepositarPoupanca.Name = "btnDepositarPoupanca";
            this.btnDepositarPoupanca.Size = new System.Drawing.Size(136, 48);
            this.btnDepositarPoupanca.TabIndex = 10;
            this.btnDepositarPoupanca.Text = "Depositar (Poupança)";
            this.btnDepositarPoupanca.UseVisualStyleBackColor = true;
            this.btnDepositarPoupanca.Click += new System.EventHandler(this.btnDepositarPoupanca_Click);
            // 
            // txtPoupanca
            // 
            this.txtPoupanca.Location = new System.Drawing.Point(151, 167);
            this.txtPoupanca.Name = "txtPoupanca";
            this.txtPoupanca.Size = new System.Drawing.Size(254, 22);
            this.txtPoupanca.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Poupança";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sacar (Poupança)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSacarPoupanca_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(494, 339);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(136, 48);
            this.btnRelatorio.TabIndex = 14;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(151, 34);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(254, 24);
            this.comboContas.TabIndex = 15;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Escolha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Transferência";
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(537, 36);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(254, 24);
            this.destinoDaTransferencia.TabIndex = 17;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(494, 406);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(136, 48);
            this.btnTransferir.TabIndex = 19;
            this.btnTransferir.Text = "Transferência";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 529);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPoupanca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDepositarPoupanca);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositarPoupanca;
        private System.Windows.Forms.TextBox txtPoupanca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.Button btnTransferir;
    }
}