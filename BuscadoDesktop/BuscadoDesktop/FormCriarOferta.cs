using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscadoDesktop
{
    public partial class FormCriarOferta : Form
    {
        public FormCriarOferta(int idMercado)
        {
            InitializeComponent();
        }

        private void FormCriarOferta_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            using(var context = new BuscadoEntities())
            {
                var query = from Mercado_has_Produto in context.Mercado_has_Produto
                            join Produto in context.Produto on Mercado_has_Produto.idProduto equals Produto.idProduto
                            where Produto.CodigoDeBarras == tbCodigodeBarras.Text
                            select Mercado_has_Produto.idProduto;

                if(query.Count() <= 0)
                {
                    MessageBox.Show("Este produto não existe no seu mercado.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //cadastra a oferta
                    if (String.IsNullOrEmpty(tbDescricao.Text))
                    {
                        MessageBox.Show("Adicione uma descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var query2 = from Mercado_has_Produto in context.Mercado_has_Produto
                                    join Produto in context.Produto on Mercado_has_Produto.idProduto equals Produto.idProduto
                                    where Produto.CodigoDeBarras == tbCodigodeBarras.Text
                                    select Mercado_has_Produto.idMercado_has_Produto;

                        Oferta oferta = new Oferta();
                        oferta.idMercado_has_Produto = query2.FirstOrDefault();
                        oferta.Descricao = tbDescricao.Text;
                        context.Oferta.Add(oferta);
                        context.SaveChanges();
                        MessageBox.Show("Oferta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void tbCodigodeBarras_TextChanged(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities()) {
                var query = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbCodigodeBarras.Text
                            select Produto.Imagem;

                pictureBox2.ImageLocation = query.FirstOrDefault();
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
