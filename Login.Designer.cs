namespace CadastroCandidato
{
    partial class Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_CriarConta = new System.Windows.Forms.Button();
            this.lbl_Ou = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.Location = new System.Drawing.Point(129, 29);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(95, 35);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(21, 132);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(57, 19);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "E-mail";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.Color.White;
            this.lbl_Senha.Location = new System.Drawing.Point(21, 187);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(58, 19);
            this.lbl_Senha.TabIndex = 2;
            this.lbl_Senha.Text = "Senha";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(112, 122);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(199, 25);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(112, 181);
            this.txt_Senha.Multiline = true;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(199, 25);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Location = new System.Drawing.Point(132, 253);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(92, 32);
            this.btn_Entrar.TabIndex = 5;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_CriarConta
            // 
            this.btn_CriarConta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarConta.Location = new System.Drawing.Point(112, 353);
            this.btn_CriarConta.Name = "btn_CriarConta";
            this.btn_CriarConta.Size = new System.Drawing.Size(133, 32);
            this.btn_CriarConta.TabIndex = 6;
            this.btn_CriarConta.Text = "Criar conta";
            this.btn_CriarConta.UseVisualStyleBackColor = true;
            this.btn_CriarConta.Click += new System.EventHandler(this.btn_CriarConta_Click);
            // 
            // lbl_Ou
            // 
            this.lbl_Ou.AutoSize = true;
            this.lbl_Ou.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ou.ForeColor = System.Drawing.Color.White;
            this.lbl_Ou.Location = new System.Drawing.Point(165, 306);
            this.lbl_Ou.Name = "lbl_Ou";
            this.lbl_Ou.Size = new System.Drawing.Size(27, 19);
            this.lbl_Ou.TabIndex = 7;
            this.lbl_Ou.Text = "ou";
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.btn_CriarConta);
            this.pnl_Login.Controls.Add(this.lbl_Ou);
            this.pnl_Login.Controls.Add(this.lbl_Login);
            this.pnl_Login.Controls.Add(this.lbl_Email);
            this.pnl_Login.Controls.Add(this.btn_Entrar);
            this.pnl_Login.Controls.Add(this.lbl_Senha);
            this.pnl_Login.Controls.Add(this.txt_Senha);
            this.pnl_Login.Controls.Add(this.txt_Email);
            this.pnl_Login.Location = new System.Drawing.Point(524, 73);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(360, 428);
            this.pnl_Login.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1460, 657);
            this.Controls.Add(this.pnl_Login);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_CriarConta;
        private System.Windows.Forms.Label lbl_Ou;
        private System.Windows.Forms.Panel pnl_Login;
    }
}