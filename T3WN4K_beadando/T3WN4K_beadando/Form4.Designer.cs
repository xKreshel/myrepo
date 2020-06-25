namespace T3WN4K_beadando
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DirectorFK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MovieFK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieFKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorFKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movies_DirectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movies_DirectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirectorFK,
            this.dataGridViewComboBoxColumn4,
            this.MovieFK,
            this.iDDataGridViewTextBoxColumn1,
            this.movieFKDataGridViewTextBoxColumn1,
            this.directorFKDataGridViewTextBoxColumn1,
            this.directorDataGridViewTextBoxColumn1,
            this.movieDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.movies_DirectorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // DirectorFK
            // 
            this.DirectorFK.DataPropertyName = "DirectorFK";
            this.DirectorFK.DataSource = this.directorBindingSource;
            this.DirectorFK.DisplayMember = "dir_fname";
            this.DirectorFK.HeaderText = "First Name";
            this.DirectorFK.Name = "DirectorFK";
            this.DirectorFK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DirectorFK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DirectorFK.ValueMember = "ID";
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(T3WN4K_beadando.Director);
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.DataPropertyName = "DirectorFK";
            this.dataGridViewComboBoxColumn4.DataSource = this.directorBindingSource;
            this.dataGridViewComboBoxColumn4.DisplayMember = "dir_lname";
            this.dataGridViewComboBoxColumn4.HeaderText = "Last Name";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "ID";
            // 
            // MovieFK
            // 
            this.MovieFK.DataPropertyName = "MovieFK";
            this.MovieFK.DataSource = this.movieBindingSource;
            this.MovieFK.DisplayMember = "mov_title";
            this.MovieFK.HeaderText = "Movie Title";
            this.MovieFK.Name = "MovieFK";
            this.MovieFK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MovieFK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MovieFK.ValueMember = "ID";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(T3WN4K_beadando.Movie);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // movieFKDataGridViewTextBoxColumn1
            // 
            this.movieFKDataGridViewTextBoxColumn1.DataPropertyName = "MovieFK";
            this.movieFKDataGridViewTextBoxColumn1.HeaderText = "MovieFK";
            this.movieFKDataGridViewTextBoxColumn1.Name = "movieFKDataGridViewTextBoxColumn1";
            this.movieFKDataGridViewTextBoxColumn1.Visible = false;
            // 
            // directorFKDataGridViewTextBoxColumn1
            // 
            this.directorFKDataGridViewTextBoxColumn1.DataPropertyName = "DirectorFK";
            this.directorFKDataGridViewTextBoxColumn1.HeaderText = "DirectorFK";
            this.directorFKDataGridViewTextBoxColumn1.Name = "directorFKDataGridViewTextBoxColumn1";
            this.directorFKDataGridViewTextBoxColumn1.Visible = false;
            // 
            // directorDataGridViewTextBoxColumn1
            // 
            this.directorDataGridViewTextBoxColumn1.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn1.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn1.Name = "directorDataGridViewTextBoxColumn1";
            this.directorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // movieDataGridViewTextBoxColumn1
            // 
            this.movieDataGridViewTextBoxColumn1.DataPropertyName = "Movie";
            this.movieDataGridViewTextBoxColumn1.HeaderText = "Movie";
            this.movieDataGridViewTextBoxColumn1.Name = "movieDataGridViewTextBoxColumn1";
            this.movieDataGridViewTextBoxColumn1.Visible = false;
            // 
            // movies_DirectorBindingSource
            // 
            this.movies_DirectorBindingSource.DataSource = typeof(T3WN4K_beadando.Movies_Director);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Director";
            this.dataGridViewComboBoxColumn1.HeaderText = "DirectorFK";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Director";
            this.dataGridViewComboBoxColumn2.HeaderText = "Column1";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "Director";
            this.dataGridViewComboBoxColumn3.HeaderText = "Column1";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // movieFKDataGridViewTextBoxColumn
            // 
            this.movieFKDataGridViewTextBoxColumn.DataPropertyName = "MovieFK";
            this.movieFKDataGridViewTextBoxColumn.HeaderText = "MovieFK";
            this.movieFKDataGridViewTextBoxColumn.Name = "movieFKDataGridViewTextBoxColumn";
            // 
            // directorFKDataGridViewTextBoxColumn
            // 
            this.directorFKDataGridViewTextBoxColumn.DataPropertyName = "DirectorFK";
            this.directorFKDataGridViewTextBoxColumn.HeaderText = "DirectorFK";
            this.directorFKDataGridViewTextBoxColumn.Name = "directorFKDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // movieDataGridViewTextBoxColumn
            // 
            this.movieDataGridViewTextBoxColumn.DataPropertyName = "Movie";
            this.movieDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directors To Movies";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movies_DirectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource movies_DirectorBindingSource;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn DirectorFK;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn MovieFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieFKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorFKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
    }
}