using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CRM_Bakalavr
{
    class Retreival
    {
        public static void getOrderIDsWRTDate(DateTime date,ComboBox cb=null, ListBox lb=null)
        {
            try
            {
                cb.Items.Clear();
                
                SqlCommand cmd = new SqlCommand("st_getOrdersWRTDate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "ID";
                cb.ValueMember = "ID";
                if (cb == null)
                {
                    lb.DataSource = dt;
                }
                else if (lb == null)
                {
                    cb.DataSource = dt;
                }
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }

        }
        public static Int16 getTaxID(string taxType)
        {
            Int16 id = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTaxID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", taxType);
                MainClass.con.Open();
                id = Convert.ToInt16(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch(Exception )
            {
                MainClass.con.Close();
            }
            return id;
        }
        public static void loadBillReport(ReportDocument rd, CrystalReportViewer crv, Int16 status, Int64 orderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderReport", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@status", status);
                 
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\billReport.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch(Exception ex)
            {
                if(rd != null)
                {
                    rd.Close();
                }
                MainClass.showMessage(ex.Message, "Error");
            }
           
        }
        public static void getTax(DataGridView gv, DataGridViewColumn taxIDGV, DataGridViewColumn typeGV, DataGridViewColumn valueGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTax", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                taxIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                typeGV.DataPropertyName = dt.Columns["Type"].ToString();
                valueGV.DataPropertyName = dt.Columns["Value"].ToString();
                
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getOrder4Bill(string phone, DataGridView gv, DataGridViewColumn itemGV, 
            DataGridViewColumn quantGV, DataGridViewColumn amountGV, DataGridViewColumn orderIDGV, 
            DataGridViewColumn totalAmountGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetailsWRTPhone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amountGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static bool getOrder4Bill(int tableID, DataGridView gv, DataGridViewColumn itemGV, DataGridViewColumn quantGV, DataGridViewColumn amountGV, DataGridViewColumn orderIDGV, DataGridViewColumn totalAmountGV)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetailsWRTTable", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableID", tableID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amountGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;
                if (gv.Rows.Count > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
            return check;
        }
            
        public static void getPendingOrderDetails(Int64 orderID, DataGridView gv, DataGridViewColumn proGV, DataGridViewColumn quanGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID",orderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proGV.DataPropertyName = dt.Columns["Item"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getPendingOrders(DataGridView gv, DataGridViewColumn orderIDGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrders", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderIDGV.DataPropertyName = dt.Columns["Order ID"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        private static string customer, address;
        public static string CUSTOMER
        {
            
            get
            {
                return customer;
            }
            private set
            {
                customer = value;
            }
        }
        public static string ADDRESS
        {

            get
            {
                return address;
            }
            private set
            {
                address = value;
            }
        }
        public static Int64 getCustomerIDWRTPhone(string phone) //taking cust ID by phone number
        {
            Int64 custID = 0; 
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustIdWRTPhone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                MainClass.con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        custID = Convert.ToInt64(dr["CustomerID"].ToString());
                        CUSTOMER = dr["Name"].ToString();
                        ADDRESS = dr["Address"].ToString();
                    }
                }
                else
                {
                    custID = 0;
                    CUSTOMER = "";
                    ADDRESS = "";
                }
                MainClass.con.Close();
            }
            catch(Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
                
            }
            return custID;
        }
        public static void getMenu(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV,
            DataGridViewColumn menuItemGV, DataGridViewColumn menuItemIDGV,DataGridViewColumn priceGV,
            DataGridViewColumn statusGV, DataGridViewColumn imageGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMenu", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                menuItemGV.DataPropertyName = dt.Columns["Menu Item"].ToString();
                menuItemIDGV.DataPropertyName = dt.Columns["MenuID"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                imageGV.DataPropertyName = dt.Columns["Image"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getCategory(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategories", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
               
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getTables(DataGridView gv, DataGridViewColumn floorIDGv, DataGridViewColumn floorNameGV,
            DataGridViewColumn tableNameGv, DataGridViewColumn tableidGV, DataGridViewColumn chairsGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGv.DataPropertyName = dt.Columns["Floor ID"].ToString();
                floorNameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                tableNameGv.DataPropertyName = dt.Columns["Table Number"].ToString();
                tableidGV.DataPropertyName = dt.Columns["Table ID"].ToString();
                chairsGV.DataPropertyName = dt.Columns["Chairs"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getFloors(DataGridView gv, DataGridViewColumn floorIDGv, DataGridViewColumn nameGV,
            DataGridViewColumn floorNumberGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGv.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                floorNumberGV.DataPropertyName = dt.Columns["Floor Number"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getCustomers(DataGridView gv, DataGridViewColumn custIDgv, DataGridViewColumn nameGV,
            DataGridViewColumn phoneGV,
            DataGridViewColumn addressGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustomers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                custIDgv.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Customer"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static void getRoles(DataGridView gv,DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["RoleID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        private static string name;
        private static string role;
        public static string USER
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }
        public static bool isValidUser(string user,string pass) //checking the validation of user

        {
            bool status = false;
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getUsersForAuth", MainClass.con); // procedura z bd/ validacia
                cmd.CommandType = CommandType.StoredProcedure; //vizivaye z BD
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (user == dr["Username"].ToString() && pass == dr["Password"].ToString())
                        {
                            USER = dr["User"].ToString(); // otrimuye z bd user i zapisue v USER
                            ROLE = dr["Role"].ToString(); // otrimuye z bd ROLE i zapisue v USER
                            status = true;
                        }
                        else
                        {
                            MainClass.showMessage("Invalid username or password","Error");
                            status = false;
                        }
                        
                    }
                }
                else
                {
                    MainClass.showMessage("Invalid username or password", "Error");
                    status = false;
                }
                MainClass.con.Close();

            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
            return status;
        }
        public static void getUsers(DataGridView gv, DataGridViewColumn userIDgv, DataGridViewColumn nameGV, 
            DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn phoneGV, 
            DataGridViewColumn addressGV, DataGridViewColumn roleIDGV, DataGridViewColumn roleGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDgv.DataPropertyName = dt.Columns["User ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["User"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                roleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
                roleGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "snoGV"); //rahuye kilkis't ryadkiv v roles i users
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error");
            }
        }
        public static Image getItemImage(int mid)
        {
            byte[] arr;
            Image i = null;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getItemimage", MainClass.con); //connect to DB proc st_getItemimage
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", mid);
                MainClass.con.Open();
                arr = (byte[])cmd.ExecuteScalar(); //receiving arr
                MemoryStream ms = new MemoryStream(arr);
                i = Image.FromStream(ms); //image is in 'i'
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error");
            }
            return i;
        }
        public static void loadItems(string proc, ComboBox cb, string dMember, string vMember, string param=null, int val = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param == null && val == 0)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public static void loadItems(string proc, ListBox cb, string dMember, string vMember, string param = null, int val = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param == null && val == 0)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static int categoryID;
        private static string categoryName;
        public static int CATEGORYID
        {
            get
            {
                return categoryID;
            }
            private set
            {
                categoryID = value;
            }
        }
        public static string CATEGORYNAME
        {
            get
            {
                return categoryName;
            }
            private set
            {
                categoryName = value;
            }
        }
        public static void loadCategoryWRTItem(string item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoryWRTItem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",item);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CATEGORYID = Convert.ToInt32(dr[0].ToString());
                        CATEGORYNAME = dr[1].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Int64 lastOrderID()
        {
            Int64 orderID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastOrderID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
            }
            return orderID;
        }
        public static bool CheckTableStatus(int tableID, Int16 floorID) //checking is the table empty
        {
            bool stat = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkTableBusyFree", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableID", tableID);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    stat = true;
                }
                else
                {
                    stat = false;
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
            }
            return stat;
        }
    }
}
