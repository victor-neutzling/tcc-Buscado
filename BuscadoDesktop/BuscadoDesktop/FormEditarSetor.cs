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
    public partial class FormEditarSetor : Form
    {
        int idMercado;
        string nome;
        public FormEditarSetor(int idMercado, string nome)
        {
            InitializeComponent();
            this.idMercado = idMercado;
            this.nome = nome;
        }

        private void btEditarSetor_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                var query = from setor in context.Setor
                            where setor.Nome == nome
                            select setor.idSetor;

                Setor s = new Setor() { idSetor = query.FirstOrDefault() };
                context.Setor.Attach(s);
                s.Nome = tbSetor.Text;
                context.SaveChanges();
            }
            MessageBox.Show("Setor alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
