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
    
    public partial class FormCadastro : Form
    {
        public bool EmailValido(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
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
        public FormCadastro()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;

            //adiciona todos os estados no combo box
            tbEstado.Items.Add("Acre");
            tbEstado.Items.Add("Alagoas");
            tbEstado.Items.Add("Amapá");
            tbEstado.Items.Add("Amazonas");
            tbEstado.Items.Add("Bahia");
            tbEstado.Items.Add("Ceará");
            tbEstado.Items.Add("Distrito Federal");
            tbEstado.Items.Add("Espírito Santo");
            tbEstado.Items.Add("Goiás");
            tbEstado.Items.Add("Maranhão");
            tbEstado.Items.Add("Mato Grosso");
            tbEstado.Items.Add("Mato Grosso do Sul");
            tbEstado.Items.Add("Minas Gerais");
            tbEstado.Items.Add("Pará");
            tbEstado.Items.Add("Paraíba");
            tbEstado.Items.Add("Paraná");
            tbEstado.Items.Add("Pernambuco");
            tbEstado.Items.Add("Piauí");
            tbEstado.Items.Add("Rio de Janeiro");
            tbEstado.Items.Add("Rio Grande do Norte");
            tbEstado.Items.Add("Rio Grande do Sul");
            tbEstado.Items.Add("Rondônia");
            tbEstado.Items.Add("Roraima");
            tbEstado.Items.Add("Santa Catarina");
            tbEstado.Items.Add("São Paulo");
            tbEstado.Items.Add("Sergipe");
            tbEstado.Items.Add("Tocantins");
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos os campos marcados com * devem ser preenchidos\nPreencha a seção Nome e Endereço com as informações do mercado\n\npreencha a seção Contato Com o endereço de email e numero de telefone do mercado\n\npreencha a seção administrador com os dados do funcionario responsavel pela administração do Buscado\n\nApós o cadastro do mercado, será possivel cadastrar mais administradores utilizando o modo editor","Ajuda",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            
            if (tbNome.Text.Length > 0 && tbRua.Text.Length > 0 && tbBairro.Text.Length > 0 && tbCidade.Text.Length > 0 && tbCidade.Text.Length > 0 && tbEstado.Text.Length > 0 && mtbCep.Text.Length > 0 && tbNomeAdm.Text.Length > 0 && tbUsuario.Text.Length > 0 && tbSenha.Text.Length > 0 && tbConfSenha.Text.Length > 0)
            {
                if(mtbEmail.Text.Length > 0)
                {
                    if (!EmailValido(mtbEmail.Text))
                    {
                        MessageBox.Show("O email inserido é invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(tbSenha.Text == tbConfSenha.Text)
                {
                    if(tbUsuario.Text.Contains(' ')||tbSenha.Text.Contains(' '))
                    {
                        MessageBox.Show("O usuario e senha não podem conter espaços", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool usuarioExiste = false;
                        using (var b = new BuscadoEntities())
                        {
                            
                            var query = from Administrador in b.Administrador
                                        where Administrador.Usuario == tbUsuario.Text
                                        select Administrador.Usuario;

                            if (query.FirstOrDefault() != null)
                            {
                                usuarioExiste = true;
                            }
                        }
                        if (usuarioExiste)
                        {
                            MessageBox.Show("O usuario informado já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            //Insere os dados no Model1 e manda pro banco -- nao sei se ta certo!
                            using (var b = new BuscadoEntities())
                            {
                                Mercado mercado = new Mercado();
                                mercado.Nome = tbNome.Text;
                                mercado.Rua = tbRua.Text;
                                mercado.Bairro = tbBairro.Text;
                                mercado.Cidade = tbCidade.Text;
                                mercado.Estado = tbEstado.Text;
                                if (!String.IsNullOrEmpty(tbNumero.Text))
                                    mercado.Numero = int.Parse(tbNumero.Text);
                                mercado.CEP = mtbCep.Text.Remove(5, 1);
                                b.Mercado.Add(mercado);

                                Administrador adm = new Administrador();
                                adm.Nome = tbNomeAdm.Text;
                                adm.Usuario = tbUsuario.Text;
                                adm.Senha = GetPasswordHash(tbSenha.Text); //encryptada + ou -
                                adm.idMercado = mercado.idMercado;
                                b.Administrador.Add(adm);

                                //para que nao crie uma tabela vazia, verifica se existem dados no campo telefone
                                if (!mtbTelefone.Text.Contains("(  )     -"))
                                {
                                    Telefone telefone = new Telefone();
                                    telefone.Telefone1 = mtbTelefone.Text.Remove(0, 1).Remove(2, 1).Remove(7, 1);
                                    telefone.idMercado = mercado.idMercado;
                                    b.Telefone.Add(telefone);
                                }

                                //para que não crie uma tabela vazia, verifica se existem dados no campo email
                                if (!String.IsNullOrEmpty(mtbEmail.Text))
                                {
                                    Email email = new Email();
                                    email.Email1 = mtbEmail.Text;
                                    email.idMercado = mercado.idMercado;
                                    b.Email.Add(email);
                                }
                                b.SaveChanges();
                            }
                            MessageBox.Show("Cadastro Realizado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Hide();
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("As senhas inseridas são diferentes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
