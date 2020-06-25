using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3WN4K_beadando.Properties;

namespace T3WN4K_beadando
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities(); //Creating context

        public Form1()
        {
            InitializeComponent();
            //Data loading/binding
            try
            {
                context.Directors.Load();
                directorBindingSource.DataSource = context.Directors.Local;
            } catch(Exception e)
            {
                MessageBox.Show("Exception " + e);
            }
            
            //Adding some design
            FormDesign();
            directorsDataGridViewDesign();
            this.Text = "Directors Details";

            //Setting button visibilities to false
            moviesDataGridView.Visible = false;
            awardsDataGridView.Visible = false;
            this.backButton.Visible = false;
            saveFileMovies.Visible = false;
            loadFileMovies.Visible = false;
            saveFileAwards.Visible = false;
            loadFileAwards.Visible = false;

            //Setting visible button features
            awardsButton.Width = 75;
            awardsButton.Height = 50;
            moviesButton.Width = 75;
            moviesButton.Height = 50;
        }

        //Form and DataGridViewDesigns
        private void FormDesign()
        {
            this.bindingNavigatorDeleteItem.Enabled = true;
            this.BackColor = Color.FromArgb(20, 25, 72);
            this.menuStrip1.BackColor = Color.FromArgb(20, 25, 72);
            this.menuStrip1.ForeColor = Color.White;
            this.bindingNavigator1.BackColor = Color.FromArgb(20, 25, 72);
            this.bindingNavigator1.ForeColor = Color.White;
            this.moviesToRatingsToolStripMenuItem1.BackColor = Color.FromArgb(20, 25, 72);
            this.moviesToRatingsToolStripMenuItem1.ForeColor = Color.White;
            this.label1.BackColor = Color.FromArgb(20, 25, 72);
            this.directorsToAwardsToolStripMenuItem.BackColor = Color.FromArgb(20, 25, 72);
            this.directorsToAwardsToolStripMenuItem.ForeColor = Color.White;
            this.moviesToDirectorsToolStripMenuItem1.BackColor = Color.FromArgb(20, 25, 72);
            this.moviesToDirectorsToolStripMenuItem1.ForeColor = Color.White;
        }

        private void directorsDataGridViewDesign()
        {
            directorsDataGridView.BorderStyle = BorderStyle.None;
            directorsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            directorsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            directorsDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            directorsDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            directorsDataGridView.BackgroundColor = Color.FromArgb(20, 25, 72);
            directorsDataGridView.EnableHeadersVisualStyles = false;
            directorsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            directorsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            directorsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void moviesDataGridViewDesign()
        {
            movieBindingSource.DataSource = context.Movies.Local;
            moviesDataGridView.BorderStyle = BorderStyle.None;
            moviesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            moviesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            moviesDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            moviesDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            moviesDataGridView.BackgroundColor = Color.FromArgb(20, 25, 72);
            moviesDataGridView.EnableHeadersVisualStyles = false;
            moviesDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            moviesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            moviesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void awardsDataGridViewDesign()
        {
            awardBindingSource.DataSource = context.Awards.Local;
            awardsDataGridView.BorderStyle = BorderStyle.None;
            awardsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            awardsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            awardsDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            awardsDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            awardsDataGridView.BackgroundColor = Color.FromArgb(20, 25, 72);
            awardsDataGridView.EnableHeadersVisualStyles = false;
            awardsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            awardsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            awardsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            awardsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //Displaying all data
        }

        //Save Button for all Tables
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            directorsDataGridView.EndEdit();
            moviesDataGridView.EndEdit();
            awardsDataGridView.EndEdit();
            try
            {
                context.SaveChanges(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba történt a mentéskor, a pontos hiba: " + ex.Message);
            }
            directorsDataGridView.Refresh();
            moviesDataGridView.Refresh();
            awardsDataGridView.Refresh();
        }

        //Exit Button
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Biztosan ki akarsz lépni?",
                                        "Kilépés?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        //Delete Row Button
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int rowIndex = directorsDataGridView.CurrentCell.RowIndex;
            directorsDataGridView.Rows.RemoveAt(rowIndex);
        }

        private void deleteAward(object sender, EventArgs e)
        {
            int rowIndex3 = awardsDataGridView.CurrentCell.RowIndex;
            awardsDataGridView.Rows.RemoveAt(rowIndex3);
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            int rowIndex2 = moviesDataGridView.CurrentCell.RowIndex;
            moviesDataGridView.Rows.RemoveAt(rowIndex2);
        }

        //Show new pages
        private void moviesToDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void directorsToAwardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void moviesToDirectorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        //Change DataGridView to Awards/Movies and change back to Directors
        private void backButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Directors";
            this.Text = "Directors Details";
            directorsDataGridView.Visible = true;
            moviesDataGridView.Visible = false;
            awardsDataGridView.Visible = false;
            directorsDataGridViewDesign();
            saveFileDirectors.Visible = true;
            loadFileDirectors.Visible = true;
            awardsButton.Visible = true;
            moviesButton.Visible = true;
            saveFileMovies.Visible = false;
            loadFileMovies.Visible = false;
            saveFileAwards.Visible = false;
            loadFileAwards.Visible = false;
            this.backButton.Visible = false;
            deleteAwardButton.Visible = false;
            deleteMovieButton.Visible = false;
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Movies";
            this.Text = "Movies Details";
            context.Movies.Load();
            directorsDataGridView.Visible = false;
            moviesDataGridView.Visible = true;
            moviesDataGridViewDesign();
            loadFileDirectors.Visible = false;
            saveFileDirectors.Visible = false;
            this.backButton.Visible = true;
            saveFileMovies.Visible = true;
            loadFileMovies.Visible = true;
            moviesButton.Visible = false;
            awardsButton.Visible = false;
            deleteMovieButton.Visible = true;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void awardsButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Awards";
            this.Text = "Awards Details";
            context.Awards.Load();
            
            directorsDataGridView.Visible = false;
            awardsDataGridView.Visible = true;
            awardsDataGridViewDesign();
            loadFileDirectors.Visible = false;
            saveFileDirectors.Visible = false;
            this.backButton.Visible = true;
            saveFileAwards.Visible = true;
            loadFileAwards.Visible = true;
            moviesButton.Visible = false;
            awardsButton.Visible = false;
            deleteAwardButton.Visible = true;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        //Save, Load Files for Directors Table
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    foreach (var s in context.Directors.Local)
                    {
                        sw.Write(s.ID);
                        sw.Write(";");
                        sw.Write(s.dir_fname);
                        sw.Write(";");
                        sw.Write(s.dir_lname);
                        sw.Write(";");
                        sw.Write(s.dir_gender);
                        sw.Write(";");
                        sw.Write(s.dir_born.ToString());
                        sw.Write(";");
                        sw.Write(s.dir_born_place);
                        sw.Write("\n");
                    }
                }
            }
            catch (IOException io)
            {
                MessageBox.Show("The file could not be opened:" + io);
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    directorBindingSource.Clear();
                    while (!sr.EndOfStream)
                    {

                        string[] sor = sr.ReadLine().Split(';');

                        Director s = new Director();

                        s.ID = int.Parse(sor[0]);
                        s.dir_fname = sor[1];
                        s.dir_lname = sor[2];
                        s.dir_gender = sor[3];
                        try
                        {
                            s.dir_born = Convert.ToDateTime(sor[4]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        s.dir_born_place = sor[5];

                        directorBindingSource.Add(s);
                    }
                }
            } 
            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show("Can not open this type of file: " + ex);
            }
            catch (FileNotFoundException ex1)
            {
                MessageBox.Show("The file was not found: " + ex1);
            }
            catch (DirectoryNotFoundException ex2)
            {
                MessageBox.Show("The directory was not found: " + ex2);
            }
            catch (IOException ex3)
            {
                MessageBox.Show("The file could not be opened: " + ex3);
            }
        }

        //Save, Load Files for Movies Table
        private void saveFileMovies_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    foreach (var s in context.Movies.Local)
                    {
                        sw.Write(s.ID);
                        sw.Write(";");
                        sw.Write(s.mov_title);
                        sw.Write(";");
                        sw.Write(s.mov_release);
                        sw.Write(";");
                        sw.Write(s.mov_rel_country);
                        sw.Write("\n");
                    }
                }
            } catch(IOException io)
            {
                MessageBox.Show("The file could not be opened:" + io);
            }
        }

        private void loadFileMovies_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    movieBindingSource.Clear();
                    while (!sr.EndOfStream)
                    {

                        string[] sor = sr.ReadLine().Split(';');

                        Movie s = new Movie();

                        s.ID = int.Parse(sor[0]);
                        s.mov_title = sor[1];
                        try
                        {
                            s.mov_release = Convert.ToDateTime(sor[2]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        s.mov_rel_country = sor[3];

                        movieBindingSource.Add(s);
                    }
                }
            } catch(FileNotFoundException ex)
            {
                MessageBox.Show("The file was not found: " + ex);
            }
            catch (DirectoryNotFoundException ex2)
            {
                MessageBox.Show("The directory was not found: " + ex2);
            }
            catch (IOException ex3)
            {
                MessageBox.Show("The file could not be opened: " + ex3);
            }

        }

        //Save, Load Files for Awards Table
        private void saveFileAwards_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    foreach (var s in context.Awards.Local)
                    {
                        sw.Write(s.dir_id);
                        sw.Write(";");
                        sw.Write(s.num_o_awards);
                        sw.Write(";");
                        sw.Write(s.main_award);
                        sw.Write("\n");
                    }
                }
            } catch(IOException io)
            {
                MessageBox.Show("The file could not be opened:" + io);
            }
            
        }

        private void loadFileAwards_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    awardBindingSource.Clear();
                    while (!sr.EndOfStream)
                    {

                        string[] sor = sr.ReadLine().Split(';');

                        Award s = new Award();

                        s.dir_id = int.Parse(sor[0]);
                        s.num_o_awards = int.Parse(sor[1]);
                        s.main_award = sor[2];

                        awardBindingSource.Add(s);
                    }

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The file was not found: " + ex);
            }
            catch (DirectoryNotFoundException ex2)
            {
                MessageBox.Show("The directory was not found: " + ex2);
            }
            catch (IOException ex3)
            {
                MessageBox.Show("The file could not be opened: " + ex3);
            }
        }

        //DataError Directors DataGridView
        private void directorsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            DataGridView_DataError(sender, anError);
        }

        //DataError Movies DataGridView
        private void moviesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            DataGridView_DataError(sender, anError);
        }

        //DataError Awards DataGridView
        private void awardsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            DataGridView_DataError(sender, anError);
        }

        //Common DataError Handling
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
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
