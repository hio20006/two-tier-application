using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11105506_two_tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void system_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'function_3DataSet.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter1.Fill(this.function_3DataSet.List);
            // TODO: 這行程式碼會將資料載入 'function_3DataSet.system_info' 資料表。您可以視需要進行移動或移除。
            this.system_infoTableAdapter.Fill(this.function_3DataSet.system_info);
            // TODO: 這行程式碼會將資料載入 'function_2.system_info1' 資料表。您可以視需要進行移動或移除。
            this.system_info1TableAdapter.Fill(this.function_2.system_info1);
            // TODO: 這行程式碼會將資料載入 'function_2.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter.Fill(this.function_2.List);
            // TODO: 這行程式碼會將資料載入 'function_1.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.function_1.DataTable1);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
