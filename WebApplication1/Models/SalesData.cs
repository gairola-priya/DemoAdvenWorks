using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public  class SalesData
    {
        
        public SalesData()
        {
        }
        public SalesData(sp_getSalesAvgData_Result f_SalesAvgData)
        {
            this.PostalCode = f_SalesAvgData.PostalCode;
            this.TransactionDate = f_SalesAvgData.OrderDate;
            this.AvgAmount = f_SalesAvgData.AvgAmount;
        }

        public String PostalCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public Decimal? AvgAmount { get; set; }

    }
}