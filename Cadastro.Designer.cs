namespace CadastroCandidato
{
    partial class fml_TelaCadastro
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
            this.lbl_CadastroCandidato = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_CidadeEstado = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_CidadeEstado = new System.Windows.Forms.TextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.pnl_Cadastro = new System.Windows.Forms.Panel();
            this.pnl_Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CadastroCandidato
            // 
            this.lbl_CadastroCandidato.AutoSize = true;
            this.lbl_CadastroCandidato.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroCandidato.ForeColor = System.Drawing.Color.White;
            this.lbl_CadastroCandidato.Location = new System.Drawing.Point(117, 29);
            this.lbl_CadastroCandidato.Name = "lbl_CadastroCandidato";
            this.lbl_CadastroCandidato.Size = new System.Drawing.Size(344, 35);
            this.lbl_CadastroCandidato.TabIndex = 0;
            this.lbl_CadastroCandidato.Text = "Cadastro do Candidato";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.lbl_Nome.Location = new System.Drawing.Point(78, 125);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(134, 19);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome Completo";
            this.lbl_Nome.Click += new System.EventHandler(this.lbl_NomeCompleto_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(78, 192);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(57, 19);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "E-mail";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Telefone.ForeColor = System.Drawing.Color.White;
            this.lbl_Telefone.Location = new System.Drawing.Point(78, 252);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(74, 19);
            this.lbl_Telefone.TabIndex = 3;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Senha.ForeColor = System.Drawing.Color.White;
            this.lbl_Senha.Location = new System.Drawing.Point(78, 311);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(58, 19);
            this.lbl_Senha.TabIndex = 4;
            this.lbl_Senha.Text = "Senha";
            this.lbl_Senha.Click += new System.EventHandler(this.lbl_Senha_Click);
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Endereco.ForeColor = System.Drawing.Color.White;
            this.lbl_Endereco.Location = new System.Drawing.Point(78, 371);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(84, 19);
            this.lbl_Endereco.TabIndex = 5;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_CidadeEstado
            // 
            this.lbl_CidadeEstado.AutoSize = true;
            this.lbl_CidadeEstado.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_CidadeEstado.ForeColor = System.Drawing.Color.White;
            this.lbl_CidadeEstado.Location = new System.Drawing.Point(78, 433);
            this.lbl_CidadeEstado.Name = "lbl_CidadeEstado";
            this.lbl_CidadeEstado.Size = new System.Drawing.Size(123, 19);
            this.lbl_CidadeEstado.TabIndex = 6;
            this.lbl_CidadeEstado.Text = "Cidade/Estado";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(255, 116);
            this.txt_Nome.Multiline = true;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(206, 28);
            this.txt_Nome.TabIndex = 7;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Cadastrar.Location = new System.Drawing.Point(317, 524);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(144, 32);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(255, 183);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(206, 28);
            this.txt_Email.TabIndex = 9;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(255, 243);
            this.txt_Telefone.Multiline = true;
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(206, 28);
            this.txt_Telefone.TabIndex = 10;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(255, 302);
            this.txt_Senha.Multiline = true;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(206, 28);
            this.txt_Senha.TabIndex = 11;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(255, 362);
            this.txt_Endereco.Multiline = true;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(206, 28);
            this.txt_Endereco.TabIndex = 12;
            // 
            // txt_CidadeEstado
            // 
            this.txt_CidadeEstado.Location = new System.Drawing.Point(255, 424);
            this.txt_CidadeEstado.Multiline = true;
            this.txt_CidadeEstado.Name = "txt_CidadeEstado";
            this.txt_CidadeEstado.Size = new System.Drawing.Size(206, 28);
            this.txt_CidadeEstado.TabIndex = 13;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(82, 524);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(144, 32);
            this.btn_Voltar.TabIndex = 14;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // pnl_Cadastro
            // 
            this.pnl_Cadastro.Controls.Add(this.lbl_CadastroCandidato);
            this.pnl_Cadastro.Controls.Add(this.btn_Voltar);
            this.pnl_Cadastro.Controls.Add(this.lbl_Nome);
            this.pnl_Cadastro.Controls.Add(this.txt_CidadeEstado);
            this.pnl_Cadastro.Controls.Add(this.lbl_Email);
            this.pnl_Cadastro.Controls.Add(this.txt_Endereco);
            this.pnl_Cadastro.Controls.Add(this.lbl_Telefone);
            this.pnl_Cadastro.Controls.Add(this.txt_Senha);
            this.pnl_Cadastro.Controls.Add(this.lbl_Senha);
            this.pnl_Cadastro.Controls.Add(this.txt_Telefone);
            this.pnl_Cadastro.Controls.Add(this.lbl_Endereco);
            this.pnl_Cadastro.Controls.Add(this.txt_Email);
            this.pnl_Cadastro.Controls.Add(this.lbl_CidadeEstado);
            this.pnl_Cadastro.Controls.Add(this.btn_Cadastrar);
            this.pnl_Cadastro.Controls.Add(this.txt_Nome);
            this.pnl_Cadastro.Location = new System.Drawing.Point(466, 39);
            this.pnl_Cadastro.Name = "pnl_Cadastro";
            this.pnl_Cadastro.Size = new System.Drawing.Size(546, 587);
            this.pnl_Cadastro.TabIndex = 15;
            // 
            // fml_TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1452, 697);
            this.Controls.Add(this.pnl_Cadastro);
            this.Name = "fml_TelaCadastro";
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Cadastro.ResumeLayout(false);
            this.pnl_Cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CadastroCandidato;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_CidadeEstado;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_CidadeEstado;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Panel pnl_Cadastro;
    }
}

