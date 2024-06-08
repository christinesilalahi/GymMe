using PROJECT_PSD_LAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD_LAB.Factory
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