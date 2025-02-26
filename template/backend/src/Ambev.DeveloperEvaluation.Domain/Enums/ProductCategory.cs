using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Enums
{
    public enum ProductCategory
    {
        [Description("Invalid")]
        None = 0,
        [Description("Electronics")]
        Electronics,
        [Description("Food And Beverages")]
        Food,
        [Description("Clothing")]
        Clothing,
        [Description("Housewears and Appliences")]
        Housewears
    }
}
