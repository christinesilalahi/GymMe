﻿using PSD_FINAL_LAB__1.Models;
using PSD_FINAL_LAB__1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_FINAL_LAB__1.Handler
{
    public class SupplementHandler
    {
        public static bool InsertSupplement(string name, DateTime expdate, int price, int typeid)
        {
            MsSupplement newSupplement = new MsSupplement()
            {
                SupplementName = name,
                SupplementExpiryDate = expdate.Date,
                SupplementPrice = price,
                SupplementTypeID = typeid
            };

            SupplementRepository.InsertSupplement(newSupplement);
            return true;
        }

        public static List<MsSupplement> GetAllSupplements()
        {
            return SupplementRepository.GetAllSupplements();
        }

        public static MsSupplement GetSupplementById(int id)
        {
            return SupplementRepository.GetSupplementById(id);
        }

        public static bool UpdateSupplement(int id, string name, DateTime expdate, int price, int typeid)
        {
            MsSupplement updatedSupplement = SupplementRepository.UpdateSupplement(id, name, expdate, price, typeid);

            if (updatedSupplement == null)
            {
                throw new KeyNotFoundException("Failed to update the supplement. Supplement not found.");
            }

            return true;
        }

        public static MsSupplement DeleteSupplement(int id)
        {
            MsSupplement deletedSupplement = SupplementRepository.DeleteSupplement(id);

            if (deletedSupplement == null)
            {
                throw new KeyNotFoundException("Failed to delete the supplement. Supplement not found.");
            }

            return deletedSupplement;
        }
    }
}