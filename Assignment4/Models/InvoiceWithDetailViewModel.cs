using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Assignment4.EntityModels;

namespace Assignment4.Models
{
    public class InvoiceWithDetailViewModel : InvoiceBaseViewModel
    {
        public InvoiceWithDetailViewModel()
        {
            InvoiceLines = new List<InvoiceLineWithDetailViewModel>();
        }
      
        public IEnumerable<InvoiceLineWithDetailViewModel> InvoiceLines { get; set; }

      
        public virtual Customer Customer { get; set; }
      
        public virtual Employee Employee { get; set; }

      
        public string CustomerFirstName { get; set; }

     
        public string CustomerLastName { get; set; }

     
        public string CustomerCity { get; set; }

    
        public string CustomerState { get; set; }

     
        public string CustomerEmployeeFirstName { get; set; }

        
        public string CustomerEmployeeLastName { get; set; }

       
    
    }
}