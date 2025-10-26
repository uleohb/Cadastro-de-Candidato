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
    public partial class fml_TelaCadastro : Form
    {
        public fml_TelaCadastro()
        {
            InitializeComponent();

            //Fundo geral do formulário
            this.BackColor = ColorTranslator.FromHtml("#0E1A2B");

            //Panel central (borda do formulário)
            pnl_Cadastro.BackColor = ColorTranslator.FromHtml("#1E2A3A");
            pnl_Cadastro.BorderStyle = BorderStyle.FixedSingle;

            //Labels
            lbl_CadastroCandidato.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Nome.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Email.ForeColor = ColorTranslator.FromHtml("#E6E6E6");

            //TextBox
            txt_Nome.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Nome.ForeColor = Color.White;
            txt_Nome.BorderStyle = BorderStyle.FixedSingle;

            txt_Email.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Email.ForeColor = Color.White;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;

            txt_Senha.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Senha.ForeColor = Color.White;
            txt_Senha.BorderStyle = BorderStyle.FixedSingle;

            txt_Telefone.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Telefone.ForeColor = Color.White;
            txt_Telefone.BorderStyle = BorderStyle.FixedSingle;

            txt_Endereco.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_Endereco.ForeColor = Color.White;
            txt_Endereco.BorderStyle = BorderStyle.FixedSingle;

            txt_CidadeEstado.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            txt_CidadeEstado.ForeColor = Color.White;
            txt_CidadeEstado.BorderStyle = BorderStyle.FixedSingle;

            //Botão principal
            btn_Cadastrar.BackColor = ColorTranslator.FromHtml("#4A90E2");
            btn_Cadastrar.ForeColor = Color.White;
            btn_Cadastrar.FlatStyle = FlatStyle.Flat;
            btn_Cadastrar.FlatAppearance.BorderSize = 0;

            //Botão secundário
            btn_Voltar.BackColor = ColorTranslator.FromHtml("#B0B0B0");
            btn_Voltar.ForeColor = Color.Black;
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.FlatAppearance.BorderSize = 0;

            //Efeito hover
            btn_Cadastrar.MouseEnter += (s, e) => btn_Cadastrar.BackColor = ColorTranslator.FromHtml("#5AA0FF");
            btn_Cadastrar.MouseLeave += (s, e) => btn_Cadastrar.BackColor = ColorTranslator.FromHtml("#4A90E2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            string conexaoString = @"Server=DESKTOP-TKES5KV;Database=CANDIDATURA;User Id = LEONARDO_ADMIN; Password=LEONARDO_ADMIN;";

            if (string.IsNullOrWhiteSpace(txt_Nome.Text) ||
               string.IsNullOrWhiteSpace(txt_Email.Text) ||
               string.IsNullOrWhiteSpace(txt_Telefone.Text) ||
               string.IsNullOrWhiteSpace(txt_Senha.Text) ||
               string.IsNullOrWhiteSpace(txt_Endereco.Text) ||
               string.IsNullOrWhiteSpace(txt_CidadeEstado.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios",
                                "Campos obrigatórios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;

            }

            using (SqlConnection conexao = new SqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string query = @"INSERT INTO CANDIDATO 
                                   (NOME,EMAIL,TELEFONE,SENHA,ENDERECO,CIDADE_ESTADO)
                                   VALUES(@NomeCompleto, @Email, @Telefone, @Senha, @Endereco, @Cidade_Estado)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeCompleto", txt_Nome.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txt_Telefone.Text);
                        cmd.Parameters.AddWithValue("@Senha", txt_Senha.Text);
                        cmd.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
                        cmd.Parameters.AddWithValue("@Cidade_Estado", txt_CidadeEstado.Text);

                        cmd.ExecuteNonQuery();  
                    }

                    MessageBox.Show("Cadastro realizado com sucesso.");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                                   
                }
                catch (Exception ex )
                {
                    MessageBox.Show("Ocorreu um erro, tente novamente." + ex.Message,
                                    "Erro no cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            


            
        }

        private void lbl_NomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Senha_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

