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
    class Insertion
    {
        public static void insertTax(float value, string type)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertTax", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@type", type);
                
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Tax placed successfully!", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save Tax!", "Error");
            }
        }
        public static void insertOrder(DateTime date, Int64 custID, Int16 orderType, Int16 floorID, 
            Int16 tableID, float tamount, float amtPaid, float amtReturned, Int16 status, Int16 taxType, float taxAmount)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_insertOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@orderType", orderType);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tableID);
                cmd.Parameters.AddWithValue("@tAmount", tamount);
                cmd.Parameters.AddWithValue("@amtPaid", amtPaid);
                cmd.Parameters.AddWithValue("@amtReturned", amtReturned);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@taxType", taxType);
                cmd.Parameters.AddWithValue("@taxAmount", taxAmount);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("Order placed successfully!", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save Order!", "Error");
            }
        }
        public static int insertOrderDetails(Int64 orderID, int proID, Int16 quan)
        {
            int res = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertOrderDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);

                MainClass.con.Open(); //connection from mainclass
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save Order!", "Error");
            }
            return res;
        }
        public static void insertMenuItem(string menuItem, float price, int catID, Int16 status, Image im)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                im.Save(ms, ImageFormat.Png); //save the image
                byte[] arr = ms.ToArray(); //image convertuyetsa v byte i v array
                SqlCommand cmd = new SqlCommand("st_insertMenuItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", menuItem);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@image", arr);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(menuItem + "added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save Menu Item.\nPossible error : \nMenu Item may exist already.", "Error");
            }
        }
        public static void insertCategory(string category)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", category);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(category + "added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save category.\nPossible error : \nCategory may exist already.", "Error");
            }
        }
        public static void insertTable(int tableNUmber, Int16 chairs, Int16 floorID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNUmber);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tableNUmber + "added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save table.\nPossible error : \nTable may exist already.", "Error");
            }
        }
        public static void insertFloors(string name, Int16 number)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorNumber", number);

                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save floor.\nPossible error : \nFloor may exist already.", "Error");
            }
        }
        public static void insertCustomer(string name, string phone, string address)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);

                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save customer.\nPossible error : \nCustomer may exist already.", "Error");
            }
        }
        public static void insertRole(string role) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(role + "added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible error : \nRole may exist already.", "Error");
            }
        }
        public static void insertUsers(string name, string uname, string pass, string address, string phone, Int16 roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                MainClass.con.Open(); //connection from mainclass
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name +" added successfully into the system", "Success");
                }
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save user.\nPossible error : \nUser may exist already.", "Error");
            }
        }
    }
}
