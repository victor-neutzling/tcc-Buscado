using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscadoDesktop
{
    public partial class FormModoEditor : Form
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
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }
        //idMercado - usar para distinguir qual mercado está logado
        int idMercado;
        public FormModoEditor(int id)
        {
            InitializeComponent();
            idMercado = id;
            using (var context = new BuscadoEntities())
            {
                var query = from Mercado in context.Mercado
                            where Mercado.idMercado == id
                            select Mercado.Nome;
                labelMercado.Text = query.FirstOrDefault();

            }
            using (var context = new BuscadoEntities())
            {
                var query2 = from Mercado_has_Produto in context.Mercado_has_Produto
                             join Oferta in context.Oferta on Mercado_has_Produto.idMercado_has_Produto equals Oferta.idMercado_has_Produto
                             where Mercado_has_Produto.idMercado == idMercado
                             select Oferta.Descricao;
                BindingSource bs = new BindingSource();
                bs.DataSource = query2.ToList();
                comboBoxOferta.DataSource = bs;
                var query3 = from Mercado_has_Produto in context.Mercado_has_Produto
                             join Mercado in context.Mercado on Mercado_has_Produto.idMercado equals Mercado.idMercado
                             join Setor in context.Setor on Mercado.idMercado equals Setor.idMercado
                             where Mercado_has_Produto.idMercado == idMercado
                             select Setor.Nome;
                BindingSource bs2 = new BindingSource();
                bs2.DataSource = query3.ToList();
                comboBox1.DataSource = bs2;

            }
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            List<int> q;
            using(var context = new BuscadoEntities())
            {
                var query = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbAdicionarProduto.Text
                            select Produto.idProduto;
                q = query.ToList();
            }
            if(IsEmpty(q))
            {
                DialogResult dialog = MessageBox.Show("Este produto Não existe No banco de produtos, Deseja Adicioná-lo\n\nAntes de adicionar o produto,  verifique se o código foi digitado corretamente.", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialog == DialogResult.Yes)
                {
                    //tela de adicionar produto no banco, nao no mercado
                    FormAdicionarProdutoAoBanco formAdicionarProdutoAoBanco = new FormAdicionarProdutoAoBanco(tbAdicionarProduto.Text, idMercado);
                    Hide();
                    formAdicionarProdutoAoBanco.ShowDialog();


                }
                else
                {
                    return;
                }
            }
            int id;
            string nome;
            using (var context = new BuscadoEntities())
            {
                var query = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbAdicionarProduto.Text
                            select Produto.idProduto;
                id = query.FirstOrDefault();
                var query2 = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbAdicionarProduto.Text
                            select Produto.Nome;
                nome = query2.FirstOrDefault();
            }
            FormAdicionarProduto fap = new FormAdicionarProduto(idMercado, id, nome, tbAdicionarProduto.Text);
            Hide();
                fap.ShowDialog();    
        }

        private void labelMercado_Click(object sender, EventArgs e)
        {

        }

        private void tbAdicionarProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAdicionarProduto_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btEditarOferta_Click(object sender, EventArgs e)
        {
            using (var form = new FormEditarOferta(comboBoxOferta.Text, idMercado))
            {
                this.Hide();
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja sair?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                var query = from Administrador in context.Administrador
                            select Administrador.Nome;
                if(query.ToList().Count() == 1)
                {
                    MessageBox.Show("Não é possível excluir o único administrador cadastrado no sistema. Para excluir este administrador, adicione outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //nao sei se funciona -- testar depois.
                    DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir este administrador?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        var query2 = from Administrador in context.Administrador
                                     where Administrador.Nome == tbUsuario.Text
                                     select Administrador.id;

                        Administrador adm = new Administrador() {id = query2.FirstOrDefault() };
                        context.Administrador.Attach(adm);
                        context.Administrador.Remove(adm);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void tbConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCriarOferta_Click(object sender, EventArgs e)
        {
            using (var context = new FormCriarOferta(idMercado))
            {
                this.Hide();
                context.ShowDialog();
                this.Show();
                
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using (var context = new FormCriarSetor2(idMercado))
            {
                this.Hide();
                context.ShowDialog();
                
            }
            using (var context = new FormModoEditor(idMercado))
            {
                this.Hide();
                context.ShowDialog();
            }
        }

        private void btCadastrarAdm_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                var Adm = new Administrador();
                Adm.idMercado = idMercado;
                Adm.Nome = tbUsuario.Text;
                Adm.Usuario = tbUsuario.Text;
                Adm.Senha = GetPasswordHash(tbSenha.Text);
                

                if(tbSenha.Text != tbConfirmarSenha.Text)
                {
                    MessageBox.Show("As senhas inseridas são diferentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    var query = from Administrador in context.Administrador
                                where Administrador.idMercado == idMercado
                                select Administrador.Usuario;



                    if (query.Contains(tbUsuario.Text))
                    {
                        MessageBox.Show("Usuário já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        context.Administrador.Add(Adm);
                        context.SaveChanges();
                        MessageBox.Show("Administrador cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var context = new FormEditarSetor(idMercado,comboBox1.Text))
            {
                this.Hide();
                context.ShowDialog();
            }
            using (var context = new FormModoEditor(idMercado))
            {
                this.Hide();
                context.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //excluir oferta
            using (var context = new BuscadoEntities())
            {
                var query = from Oferta in context.Oferta
                            where Oferta.Descricao == comboBoxOferta.Text
                            select Oferta.idOferta;
                Oferta o = new Oferta() { idOferta = query.FirstOrDefault() };
                context.Oferta.Attach(o);
                context.Oferta.Remove(o);
                context.SaveChanges();
            }
            MessageBox.Show("Oferta excluida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.ShowDialog();
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //excluir setor
            //setor com problema
            using (var context = new BuscadoEntities())
            {
                var query = from Setor in context.Setor
                            where Setor.Nome == comboBox1.Text
                            select Setor.idSetor;
                Setor s = new Setor() { idSetor = query.FirstOrDefault() };
                context.Setor.Attach(s);
                context.Setor.Remove(s);
                context.SaveChanges();
            }
            MessageBox.Show("Setor com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
