using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3WN4K_beadando
{
    public partial class Form3 : Form
    {
        Database1Entities context = new Database1Entities(); //Creating context
        public Form3()
        {
            InitializeComponent();
            //Loading essential data
            try
            {
                context.Directors.Load();
            } catch(Exception e)
            {
                MessageBox.Show("An exception occured when loading table data" + e);
            }
            
            FillDataSource();
            listBox1.DisplayMember = "dir_fname";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //Displaying all data
            //Adding some design
            FormDesign();
            dataGridViewDesign();
            this.Text = "Directors To Awards";
        }

        //Filling listbox datasource from textbox
        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Directors
            where i.dir_fname.StartsWith(textBox1.Text)
            select i).ToList();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        //Adding award to a selected director
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Director director = (Director)listBox1.SelectedItem;
            var directors = from x in context.Awards
                         where x.dir_id == director.ID
                         select new
                         {
                             DirectorLastName = director.dir_lname,
                             NumberOfAwards = x.num_o_awards,
                             MainAward = x.main_award
                         };

            dataGridView1.DataSource = directors.ToList();
        }

        //Form and DataGridView Design
        private void FormDesign()
        {

            this.BackColor = Color.FromArgb(20, 25, 72);
            this.label1.ForeColor = Color.White;
            this.label1.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void dataGridViewDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(20, 25, 72);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
