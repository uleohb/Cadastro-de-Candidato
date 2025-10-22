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
    public partial class fml_Habilidades : Form
    {

        private int candidatoId;
        private string connectionString = @"Server=DESKTOP-TKES5KV;Database=CANDIDATURA;User Id=LEONARDO_ADMIN;Password=LEONARDO_ADMIN;";
        public fml_Habilidades(int id)
        {
            InitializeComponent();
            candidatoId = id;

            //Fundo geral do formulário
            this.BackColor = ColorTranslator.FromHtml("#0E1A2B");

            //Panel central (borda do formulário)
            pnl_Habilidades.BackColor = ColorTranslator.FromHtml("#1E2A3A");
            pnl_Habilidades.BorderStyle = BorderStyle.FixedSingle;

            lbl_CSharp.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Net.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Sql.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_HtmlCss.ForeColor = ColorTranslator.FromHtml("#E6E6E6");
            lbl_Java.ForeColor = ColorTranslator.FromHtml("#E6E6E6");

            //Botão principal
            btn_RegistrarHabilidades.BackColor = ColorTranslator.FromHtml("#4A90E2");
            btn_RegistrarHabilidades.ForeColor = Color.White;
            btn_RegistrarHabilidades.FlatStyle = FlatStyle.Flat;
            btn_RegistrarHabilidades.FlatAppearance.BorderSize = 0;

            //Botão secundário
            btn_Voltar.BackColor = ColorTranslator.FromHtml("#B0B0B0");
            btn_Voltar.ForeColor = Color.Black;
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.FlatAppearance.BorderSize = 0;

            // Efeito hover
            btn_RegistrarHabilidades.MouseEnter += (s, e) => btn_RegistrarHabilidades.BackColor = ColorTranslator.FromHtml("#5AA0FF");
            btn_RegistrarHabilidades.MouseLeave += (s, e) => btn_RegistrarHabilidades.BackColor = ColorTranslator.FromHtml("#4A90E2");
        }

        private void Habilidades_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarHabilidades_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    InserirHabilidade(conn, "C#", cmb_CSharp.Text);
                    InserirHabilidade(conn, ".NET", cmb_NET.Text);
                    InserirHabilidade(conn, "SQL Server", cmb_SQL.Text);
                    InserirHabilidade(conn, "HTML/CSS", cmb_HTMLCSS.Text);
                    InserirHabilidade(conn, "Java", cmb_JAVA.Text);
                }

                MessageBox.Show("Habilidades salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar habilidades: " + ex.Message);
            }
        }
        private void InserirHabilidade(SqlConnection conn, string linguagem, string nivel)
        {
            //se o usuário escolher um nível, ele salva no banco de dados
            if (!string.IsNullOrWhiteSpace(nivel))
            {
                string query = "INSERT INTO HABILIDADES (CANDIDATO_ID, LINGUAGEM, NIVEL) VALUES (@CandidatoID, @Linguagem, @Nivel)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CandidatoID", candidatoId);
                    cmd.Parameters.AddWithValue("@Linguagem", linguagem);
                    cmd.Parameters.AddWithValue("@Nivel", nivel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}

