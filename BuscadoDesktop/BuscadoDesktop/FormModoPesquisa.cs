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
    public partial class FormModoPesquisa : Form
    {
        int idMercado;
        List<string> produtos;
        public FormModoPesquisa(int idMercado)
        {
            InitializeComponent();
            using (var context = new BuscadoEntities())
            {
                var query = from Mercado_has_Produto in context.Mercado_has_Produto
                        join Produto in context.Produto on Mercado_has_Produto.idProduto equals Produto.idProduto
                        where idMercado == Mercado_has_Produto.idMercado
                        select Produto.Nome;
                produtos = query.ToList();
            }
        }

        private void FormModoPesquisa_Load(object sender, EventArgs e)
        {

        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            resultado.Items.Clear();
            foreach (var item in produtos)
            {
                if (item.StartsWith(tbBusca.Text))
                {
                    resultado.Items.Add(item);
                }
            }

        }
    }
}
