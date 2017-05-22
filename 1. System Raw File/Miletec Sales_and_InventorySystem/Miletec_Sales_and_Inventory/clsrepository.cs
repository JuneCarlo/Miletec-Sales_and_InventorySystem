using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miletec_Sales_and_Inventory
{
    class clsrepository
    {
       static db_MiletecDataContext db = null;
        public static List<sp_ViewSupplierDetailsResult> displaysupdetails()
        {
            db = new db_MiletecDataContext();
            List<sp_ViewSupplierDetailsResult> list1 = db.sp_ViewSupplierDetails().ToList<sp_ViewSupplierDetailsResult>();
            return list1;
        
        }

        public static List<sp_viewproductResult> displayProductDetails()
        {
            db = new db_MiletecDataContext();
            List<sp_viewproductResult> list2 = db.sp_viewproduct().ToList<sp_viewproductResult>();
            return list2;

        }

        public static List<sp_vieworderResult> displayprod()
        {
            db = new db_MiletecDataContext();
            List<sp_vieworderResult> list3 = db.sp_vieworder().ToList<sp_vieworderResult>();
            return list3;
        }

        public static List<sp_viewDeliveryResult> displayDelivery()
        {
            db = new db_MiletecDataContext();

            List<sp_viewDeliveryResult> list4 = db.sp_viewDelivery().ToList<sp_viewDeliveryResult>();
            return list4;


        }



        public static List<sp_view_customerdetailsResult> customer()
        {

            db = new db_MiletecDataContext();
            List<sp_view_customerdetailsResult> cust = db.sp_view_customerdetails().ToList<sp_view_customerdetailsResult>();
            return cust;
        }

        public static void deletecus(tblcustomerdetail tbl)
        {
            db = new db_MiletecDataContext();
            db.sp_deleteCustomerdetails(tbl.CustomerID);


        }

        public static void delete(tblOrderDetail t)
        {
            db = new db_MiletecDataContext();
            db.sp_DeleteOrderDetails(t.OrderID,t.ProdID);
        }

        public static List<sp_searchcustomerdetailsResult> Search(string search)
        {
            db = new db_MiletecDataContext();
            List<sp_searchcustomerdetailsResult> searchcus = db.sp_searchcustomerdetails(search).ToList<sp_searchcustomerdetailsResult>();
            return searchcus;
        }


        public static List<sp_view_customertrandetailsResult> customertransaction()
        {
            db = new db_MiletecDataContext();
            List<sp_view_customertrandetailsResult> custtransdetails = db.sp_view_customertrandetails().ToList<sp_view_customertrandetailsResult>();
            return custtransdetails;


        }

        public static List<sp_displayCusdetailsResult> dispcust()
        {
            db = new db_MiletecDataContext();
            List<sp_displayCusdetailsResult> dispcust = db.sp_displayCusdetails().ToList<sp_displayCusdetailsResult>();
            return dispcust;

        }

        public static List<sp_view_stockResult> dissock()
        {
            db = new db_MiletecDataContext();
            List<sp_view_stockResult> disstock = db.sp_view_stock().ToList<sp_view_stockResult>();
            return disstock;
        
        }
    

    }

   
}
