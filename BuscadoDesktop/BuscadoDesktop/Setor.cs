//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuscadoDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Setor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Setor()
        {
            this.Mercado_has_Produto_has_Setor = new HashSet<Mercado_has_Produto_has_Setor>();
        }
    
        public int idSetor { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public Nullable<int> idMercado { get; set; }
    
        public virtual Mercado Mercado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mercado_has_Produto_has_Setor> Mercado_has_Produto_has_Setor { get; set; }
    }
}
