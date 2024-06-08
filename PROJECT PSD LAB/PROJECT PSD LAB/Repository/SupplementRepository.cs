using PROJECT_PSD_LAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD_LAB.Repository
{
    public class SupplementRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static List<MsSupplement> GetAllSupplements()
        {
            return db.MsSupplements.ToList();
        }

        public static MsSupplement InsertSupplement(MsSupplement newSupplement)
        {
            db.MsSupplements.Add(newSupplement);
            db.SaveChanges();
            return newSupplement;
        }

        public static MsSupplement GetSupplementById(int id)
        {
            return db.MsSupplements.Find(id);
        }

        public static MsSupplement UpdateSupplement(int id, string name, DateTime expdate, int price, int typeid)
        {
            MsSupplement toBeUpdatedSupplement = GetSupplementById(id);

            if (toBeUpdatedSupplement != null)
            {
                toBeUpdatedSupplement.SupplementName = name;
                toBeUpdatedSupplement.SupplementExpiryDate = expdate.Date;
                toBeUpdatedSupplement.SupplementPrice = price;
                toBeUpdatedSupplement.SupplementTypeID = typeid;

                db.SaveChanges();
            }

            return toBeUpdatedSupplement;
        }

        public static MsSupplement DeleteSupplement(int id)
        {
            MsSupplement toBeDeletedSupplement = GetSupplementById(id);

            if (toBeDeletedSupplement != null)
            {
                db.MsSupplements.Remove(toBeDeletedSupplement);
                db.SaveChanges();
            }

            return toBeDeletedSupplement;
        }
    }
}