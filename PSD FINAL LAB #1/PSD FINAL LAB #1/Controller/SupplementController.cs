﻿using PSD_FINAL_LAB__1.Handler;
using PSD_FINAL_LAB__1.Models;
using PSD_FINAL_LAB__1.Utils;
using PSD_FINAL_LAB__1.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_FINAL_LAB__1.Controller
{
    public class SupplementController
    {
        public static bool InsertSupplement(string name, DateTime expdate, int price, int typeid)
        {
            SupplementWebService ws = new SupplementWebService();
            return JsonUtils.Decode<bool>(ws.InsertSupplement(name, expdate, price, typeid));
        }

        public static bool UpdateSupplement(int id, string name, DateTime expdate, int price, int typeid)
        {
            SupplementWebService ws = new SupplementWebService();
            return JsonUtils.Decode<bool>(ws.UpdateSupplement(id, name, expdate, price, typeid));
        }

        public static List<MsSupplement> GetAllSupplement()
        {
            SupplementWebService ws = new SupplementWebService();
            string response = ws.GetAllSupplements();
            return JsonUtils.Decode<List<MsSupplement>>(response);
        }

        public static MsSupplement GetSupplementByID(int id)
        {
            return SupplementHandler.GetSupplementById(id);
        }

        public static bool DeleteSupplement(int id)
        {
            // Call the corresponding method in the SupplementHandler to delete the supplement
            MsSupplement deletedSupplement = SupplementHandler.DeleteSupplement(id);
            // Check if the deletion was successful
            if (deletedSupplement != null)
            {
                return true;
            }
            else
            {
                // Supplement not found, return false
                return false;
            }
        }
    }
}