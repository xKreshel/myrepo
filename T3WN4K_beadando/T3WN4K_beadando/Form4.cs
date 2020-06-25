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
    public partial class Form4 : Form
    {
        Database1Entities context = new Database1Entities(); //Creating context
        public Form4()
        {
            InitializeComponent();
            //Loading essential data
            try
            {
                context.Directors.Load();
                context.Movies.Load();
                context.Movies_Director.Load();
                movieBindingSource.DataSource = context.Movies.Local;
                directorBindingSource.DataSource = context.Directors.Local;
                movies_DirectorBindingSource.DataSource = context.Movies_Director.Local;
            } catch(Exception e)
            {
                MessageBox.Show("An exception occured when loading table data" + e);
            }
          
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //Displaying all data
            //Adding some design
            FormDesign();
            dataGridViewDesign();
            this.Text = "Directors To Movies";
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

        //DataError DataGridView
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
    }
}
