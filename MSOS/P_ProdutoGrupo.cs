//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class P_ProdutoGrupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_ProdutoGrupo()
        {
            this.P_Produto = new HashSet<P_Produto>();
        }
    
        public int ID_PRODUTO_GRUPO { get; set; }
        public string NOME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Produto> P_Produto { get; set; }
    }
}
