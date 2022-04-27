using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Bakalavr
{
    public partial class menuWindow : Sample2
    {
        public menuWindow()
        {
            InitializeComponent();
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteMenuItem", "@mid", menuId);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategory(dataGridView1, catIDGv, catGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getMenu(dataGridView1, catIDGv, catGV, MenuItemGV, menuIDGV, priceGV, statusGV, imageGV);
        }
        int menuId;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                Int16 status = statusDD.SelectedItem.ToString() == "Available" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                if (edit == 0) // save
                {
                    
                    Insertion.insertMenuItem(menuItemTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(catDD.SelectedValue.ToString()),status, pictureBox1.Image);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getMenu(dataGridView1, catIDGv, catGV, MenuItemGV, menuIDGV, priceGV, statusGV, imageGV);
                }
                else if (edit == 1)//update
                {
                    Updation.updateMenuItem(menuId, menuItemTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(catDD.SelectedValue.ToString()), status, pictureBox1.Image);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getMenu(dataGridView1, catIDGv, catGV, MenuItemGV, menuIDGV, priceGV, statusGV, imageGV);
                }

            }
            else
            {
                MessageBox.Show("Please enter all requaired fills!");
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                menuId = Convert.ToInt32(row.Cells["menuIDGV"].Value.ToString());
                catDD.SelectedValue = row.Cells["catIDGv"].Value;
                menuItemTxt.Text = row.Cells["MenuItemGV"].Value.ToString();
                priceTxt.Text = row.Cells["priceGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();

              
              
            }
        }

        private void menuWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getCategories", catDD, "Category", "ID");
            catDD.SelectedIndex = -1;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK) //vidkricaye open file dlya zagruzki image
            {
                Image im = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = im;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
