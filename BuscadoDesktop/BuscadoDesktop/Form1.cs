using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BuscadoDesktop
{
    public partial class Form1 : Form
    {
        public string GetPasswordHash(string password)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = Encoding.UTF8.GetBytes(password);
                var generatedHash = sha1.ComputeHash(hash);
                var generatedHashString = Convert.ToBase64String(generatedHash);
                return generatedHashString;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            btLogin.Visible = tbUsuario.Text.Length > 0 && tbSenha.Text.Length > 0;
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
                tbSenha.PasswordChar = '\0';
            if (!cbMostrarSenha.Checked)
                tbSenha.PasswordChar = '●';
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string senhaencriptada = GetPasswordHash(tbSenha.Text);
            //função loginentityframwork
            using (var context = new BuscadoEntities())
            {
                
                var query = from Administrador in context.Administrador
                            where Administrador.Usuario == tbUsuario.Text && Administrador.Senha == senhaencriptada
                            select Administrador.idMercado;
                //logar, query = id do mercado no qual o administrador esta cadastrado
                if(query.FirstOrDefault() == null)
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Login Efetuado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //login, mandar o id do mercado para o construtor do form
                    if (cbModoEditor.Checked)
                    {
                        //login modo editor
                        Hide();
                        FormModoEditor fme = new FormModoEditor(int.Parse(query.First().ToString()));
                        fme.ShowDialog();
                    }
                    else
                    {
                        using (var context2 = new FormModoPesquisa((int)query.FirstOrDefault()))
                        {
                            this.Hide();
                            context2.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
        }

        private void cbModoEditor_CheckedChanged(object sender, EventArgs e)
        {
            if(cbModoEditor.Checked)
            MessageBox.Show("Ao ativar o modo editor, o usuário tem acesso ao banco de dados do mercado, podendo assim, alterar e remover dados.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();

        }
    }
}
