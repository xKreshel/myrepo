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
    public partial class Form2 : Form
    {
        Database1Entities context = new Database1Entities(); //Creating context
        public Form2()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "mov_title";

            //Adding some design
            FormDesign();
            dataGridViewDesign();
            this.Text = "Movies To Ratings";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        //Filling listbox datasource from textbox
        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Movies
                                   where i.mov_title.StartsWith(textBox1.Text)
                                   select i).ToList();
        }

        //Adding rating to a selected movie
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)listBox1.SelectedItem;
            var movies = from x in context.Ratings
                         where x.mov_id == movie.ID
                         select new
                         {
                             NumberOfRatings = x.number_o_ratings,
                             RevStar = x.rev_stars
                         };

            dataGridView1.DataSource = movies.ToList();
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
