using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    public class PrintInvoice
    {
        private Invoice _invoice;
        public PrintInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }
        public void Print()
        {
            Console.WriteLine("Invoice Details");
            Console.WriteLine(_invoice.InvoiceDescription);
            Console.WriteLine("Actual Cost " + _invoice.Product.Amount);
            Console.WriteLine("Discount " + _invoice.Product.DiscountPercent + " %");
            //Console.WriteLine("Discount Amount -" + _invoice.CalculateDiscountAmount());
            Console.WriteLine("Tax Percent " + _invoice.Product.TaxPercent + " %");
            //Console.WriteLine("Tax Amount +" + _invoice.CalculateTaxAmount());
            Console.WriteLine("Final Amount " + _invoice.CalculateFinalAmount());
        }
    }
}
