//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shoppingx.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuprod
    {
        public int UsuProdId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public string Acao { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
