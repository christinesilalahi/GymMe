using PSD_FINAL_LAB__1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_FINAL_LAB__1.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement InsertSupplement(string name, DateTime expdate, int price, int typeid)
        {
            MsSupplement newSupplement = new MsSupplement()
            {
                SupplementName = name,
                SupplementExpiryDate = expdate.Date,
                SupplementPrice = price,
                SupplementTypeID = typeid
            };

            return newSupplement;
        }
    }
}