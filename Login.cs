using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCandidato
{
    public partial class Login : Form
    {
        private string connectionString = @"Server=DESKTOP-TKES5KV;Database=CANDIDATURA;User Id=LEONARDO_ADMIN;Password=LEONARDO_ADMIN;";

        public Login()
        {
            InitializeComponent();

            // Fundo geral do formulário
            this.BackColor = ColorTranslator.FromHtml("#0E1A2B");

            // Panel central (borda do formulário)
            pnl_Login.BackColor = ColorTranslator.FromHtml("#1E2A3A");
            pnl_Login.BorderStyle = BorderStyle.FixedSingle;

            lbl_Login.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Email.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Senha.ForeColor = ColorTranslator.FromHtml("#E6E6E6");

            txt_Email.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Email.ForeColor = Color.White;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;

            txt_Senha.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Senha.ForeColor = Color.White;
            txt_Senha.BorderStyle = BorderStyle.FixedSingle;

            // Botão principal
            btn_Entrar.BackColor = ColorTranslator.FromHtml("#4A90E2");
            btn_Entrar.ForeColor = Color.White;
            btn_Entrar.FlatStyle = FlatStyle.Flat;
            btn_Entrar.FlatAppearance.BorderSize = 0;

            // Botão secundário
            btn_CriarConta.BackColor = ColorTranslator.FromHtml("#B0B0B0");
            btn_CriarConta.ForeColor = Color.Black;
            btn_CriarConta.FlatStyle = FlatStyle.Flat;
            btn_CriarConta.FlatAppearance.BorderSize = 0;

            // Efeito hover
            btn_Entrar.MouseEnter += (s, e) => btn_Entrar.BackColor = ColorTranslator.FromHtml("#5AA0FF");
            btn_Entrar.MouseLeave += (s, e) => btn_Entrar.BackColor = ColorTranslator.FromHtml("#4A90E2");
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            fml_TelaCadastro cadastro  = new fml_TelaCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            string senha = txt_Senha.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha o email e a senha.");
                return;
            }

            if (ValidarLogin(email, senha))
            {
                int idCandidato = ObterIdCandidato(email, senha);

                if (idCandidato > 0)
                {
                    MessageBox.Show("Login válido!");
                    fml_Habilidades habilidades = new fml_Habilidades(idCandidato);
                    habilidades.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Erro ao recuperar ID do candidato.");
                }
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorreta.");
            }

        }
        private int ObterIdCandidato(string email, string senha)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM CANDIDATO WHERE EMAIL = @Email AND SENHA = @Senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private bool ValidarLogin(string email, string senha)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM CANDIDATO WHERE EMAIL = @Email AND SENHA = @Senha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message);
                return false; 
            }
            
        }
    }
}
