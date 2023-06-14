namespace iRh.Windows.Cadastros
{
    partial class frmFuncionario
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbDocumentoIdentidade = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME COMPLETO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(248, 56);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(191, 20);
            this.txtCpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA NASCIMENTO";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(456, 56);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(151, 20);
            this.txtDataNascimento.TabIndex = 5;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(39, 167);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(98, 20);
            this.txtCep.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(143, 164);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(39, 213);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(280, 20);
            this.txtLogradouro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "LOGRADOURO";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(416, 213);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(191, 20);
            this.txtBairro.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "BAIRRO";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(39, 262);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(191, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CIDADE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "UF/ESTADO";
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(248, 262);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 21);
            this.cmbEstados.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(325, 214);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 20);
            this.txtNumero.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "NÚMERO";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::iRh.Windows.Properties.Resources._124034;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(278, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 20);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(39, 316);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(28, 20);
            this.txtDdd.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "DDD";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(81, 316);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(191, 20);
            this.txtTelefone.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "TELEFONE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(304, 314);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 24);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "chamar no zap";
            // 
            // cmbDocumentoIdentidade
            // 
            this.cmbDocumentoIdentidade.FormattingEnabled = true;
            this.cmbDocumentoIdentidade.Location = new System.Drawing.Point(39, 103);
            this.cmbDocumentoIdentidade.Name = "cmbDocumentoIdentidade";
            this.cmbDocumentoIdentidade.Size = new System.Drawing.Size(191, 21);
            this.cmbDocumentoIdentidade.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "DOCUMENTO DE INDENTIFICAÇÃO";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 431);
            this.Controls.Add(this.cmbDocumentoIdentidade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbDocumentoIdentidade;
        private System.Windows.Forms.Label label12;
    }
}