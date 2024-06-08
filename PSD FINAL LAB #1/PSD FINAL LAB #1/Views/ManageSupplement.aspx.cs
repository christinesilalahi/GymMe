using PSD_FINAL_LAB__1.Controller;
using PSD_FINAL_LAB__1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_FINAL_LAB__1.Views
{
    public partial class ManageSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = SupplementController.GetAllSupplement();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            // Delete the supplement
            SupplementController.DeleteSupplement(id);
            // Refresh the GridView
            GridView1.DataSource = SupplementController.GetAllSupplement();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value);
            Response.Redirect("~/Views/UpdateSupplement.aspx?ID=" + id);
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertSupplement.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                MsSupplement supplement = (MsSupplement)e.Row.DataItem;
                e.Row.Cells[1].Text = supplement.SupplementExpiryDate.ToString("yyyy-MM-dd");
            }
        }
    }
}