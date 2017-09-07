//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpenseTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public short PayTo { get; set; }
        public string Month { get; set; }
        public short Year { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Description { get; set; }
    }
}
