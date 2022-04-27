using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace CRM_Bakalavr
{
    class Updation
    {
        public static int updateOrder(Int64 orderID, double amt)
        {
            int res = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateOrderAmount", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amount", amt);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                MainClass.con.Open(); //connection from mainclass
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                //if (res > 0)
                //{
                //    MainClass.showMessage("Order updated successfully!", "Success");
                //}
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update Order!", "Error");
            }
            return res;
        }
        public static int updateOrder(Int64 orderID, float amtPaid, float amtReturned, Int16 status, Int16 taxType, float taxAmount)
        {
            int res = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amtPaid", amtPaid);
                cmd.Parameters.AddWithValue("@amtReturned", amtReturned);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@taxType", taxType);
                cmd.Parameters.AddWithValue("@taxAmount", taxAmount);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                MainClass.con.Open(); //connection from mainclass
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                //if (res > 0)
                //{
                //    MainClass.showMessage("Order updated successfully!", "Success");
                //}
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update Order!", "Error");
            }
            return res;
        }
        public static void updateTax(Int16 taxID, float value, string type)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateTax", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taxID", taxID);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@type", type);

                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Tax updated successfully!", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update Tax!", "Error");
            }
        }
        public static void updateOrderStatus(Int64 OrderID  , Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateOrderStatus", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Order status updated!", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update order status.", "Error");
            }
        }
        public static void updateMenuItem(int menuID, string menuItem, float price, int catID, Int16 status, Image im)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                im.Save(ms, ImageFormat.Png); //save the image
                byte[] arr = ms.ToArray(); //image convertuyetsa v byte i v array
                SqlCommand cmd = new SqlCommand("st_updateMenuItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", menuItem);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@mid", menuID);
                cmd.Parameters.AddWithValue("@image", arr);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(menuItem + "updated successfully into the system", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update Menu Item.\nPossible error : \nMenu Item may exist already.", "Error");
            }
        }
        public static void updateCategory(int id,string category)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", category);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(category + "updated successfully into the system", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update category.\nPossible error : \nCategory may exist already.", "Error");
            }
        }
        public static void updateTable(int tableID, int tableNUmber, Int16 chairs, Int16 floorID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNUmber);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tableID);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tableNUmber + "updated successfully into the system", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update table.\nPossible error : \nTable may exist already.", "Error");
            }
        }
        public static void updateFloors(Int16 floorID, string name, Int16 number)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_updateFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorNumber", number);
                cmd.Parameters.AddWithValue("@floorID", floorID);

                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added successfully into the system", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update floor.\nPossible error : \nFloor may exist already.", "Error");
            }
        }
        public static void updateCustomer(Int64 cid,string name, string phone, string address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@cID", cid);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "updated successfully into the system", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update customer.\nPossible error : \nCustomer may exist already.", "Error");
            }
        }
        public static void updateRole(string role, Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                cmd.Parameters.AddWithValue("@rid", roleID);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(role + "updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void updateUsers(int userID, string name, string uname, string pass, string address, string phone, Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                cmd.Parameters.AddWithValue("@userID", userID);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(" updated successfully into the system", "success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to update user.\nPossible error :", "Error");
            }
        }
    }
}
