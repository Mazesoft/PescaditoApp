//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionPuntoDeVenta
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int IdOrderDetail { get; set; }
        public int IdOrder { get; set; }
        public int IdMenu { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
    }
}
