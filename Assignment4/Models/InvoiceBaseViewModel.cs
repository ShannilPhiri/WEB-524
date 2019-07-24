using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Assignment4.EntityModels;

namespace Assignment4.Models
{
    public class InvoiceBaseViewModel 
    {    [Key]
         [DisplayName("Invoice number")]
        public int InvoiceId { get; set; }

        [DisplayName("Customer ID")]
        public int CustomerId { get; set; }

        [DisplayName("Invoice date")]
        public DateTime InvoiceDate { get; set; }

        [StringLength(70)]
        [DisplayName("Billing address")]
        public string BillingAddress { get; set; }

        [StringLength(40)]
        [DisplayName("Billing city")]
        public string BillingCity { get; set; }

        [StringLength(40)]
        [DisplayName("Billing state")]
        public string BillingState { get; set; }

        [StringLength(40)]
        [DisplayName("Billing country")]
        public string BillingCountry { get; set; }

        [StringLength(10)]
        [DisplayName("Postal code")]
        public string BillingPostalCode { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Invoice total")]
        public decimal Total { get; set; }

      //  public virtual Customer Customer { get; set; }
    }
}