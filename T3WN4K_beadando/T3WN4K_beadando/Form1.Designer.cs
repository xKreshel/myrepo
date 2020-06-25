namespace T3WN4K_beadando
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directorsDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveChangesButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToDirectorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directorsToAwardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToRatingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToDirectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.awardsDataGridView = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteAwardButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.moviesButton = new System.Windows.Forms.Button();
            this.loadFileAwards = new System.Windows.Forms.Button();
            this.saveFileAwards = new System.Windows.Forms.Button();
            this.awardsButton = new System.Windows.Forms.Button();
            this.loadFileMovies = new System.Windows.Forms.Button();
            this.saveFileMovies = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.loadFileDirectors = new System.Windows.Forms.Button();
            this.saveFileDirectors = new System.Windows.Forms.Button();
            this.diridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numoawardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainawardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movreleaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movrelcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesDirectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirbornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirbornplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.directorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // directorsDataGridView
            // 
            this.directorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorsDataGridView.AutoGenerateColumns = false;
            this.directorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dirfnameDataGridViewTextBoxColumn,
            this.dirlnameDataGridViewTextBoxColumn,
            this.dirgenderDataGridViewTextBoxColumn,
            this.dirbornDataGridViewTextBoxColumn,
            this.dirbornplaceDataGridViewTextBoxColumn});
            this.directorsDataGridView.DataSource = this.directorBindingSource;
            this.directorsDataGridView.Location = new System.Drawing.Point(145, 100);
            this.directorsDataGridView.Name = "directorsDataGridView";
            this.directorsDataGridView.Size = new System.Drawing.Size(670, 285);
            this.directorsDataGridView.TabIndex = 0;
            this.directorsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.directorsDataGridView_DataError);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveChangesButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(984, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveChangesButton.Image = ((System.Drawing.Image)(resources.GetObject("saveChangesButton.Image")));
            this.saveChangesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(23, 22);
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToDirectorsToolStripMenuItem1,
            this.directorsToAwardsToolStripMenuItem,
            this.moviesToRatingsToolStripMenuItem1});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(44, 20);
            this.View.Text = "View";
            // 
            // moviesToDirectorsToolStripMenuItem1
            // 
            this.moviesToDirectorsToolStripMenuItem1.Name = "moviesToDirectorsToolStripMenuItem1";
            this.moviesToDirectorsToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.moviesToDirectorsToolStripMenuItem1.Text = "Directors To Movies";
            this.moviesToDirectorsToolStripMenuItem1.Click += new System.EventHandler(this.moviesToDirectorsToolStripMenuItem1_Click);
            // 
            // directorsToAwardsToolStripMenuItem
            // 
            this.directorsToAwardsToolStripMenuItem.Name = "directorsToAwardsToolStripMenuItem";
            this.directorsToAwardsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.directorsToAwardsToolStripMenuItem.Text = "Directors To Awards";
            this.directorsToAwardsToolStripMenuItem.Click += new System.EventHandler(this.directorsToAwardsToolStripMenuItem_Click);
            // 
            // moviesToRatingsToolStripMenuItem1
            // 
            this.moviesToRatingsToolStripMenuItem1.Name = "moviesToRatingsToolStripMenuItem1";
            this.moviesToRatingsToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.moviesToRatingsToolStripMenuItem1.Text = "Movies To Ratings";
            this.moviesToRatingsToolStripMenuItem1.Click += new System.EventHandler(this.moviesToDirectorsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToDirectorsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // moviesToDirectorsToolStripMenuItem
            // 
            this.moviesToDirectorsToolStripMenuItem.Name = "moviesToDirectorsToolStripMenuItem";
            this.moviesToDirectorsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moviesToDirectorsToolStripMenuItem.Text = "MoviesToRatings";
            this.moviesToDirectorsToolStripMenuItem.Click += new System.EventHandler(this.moviesToDirectorsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Directors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviesDataGridView.AutoGenerateColumns = false;
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.movtitleDataGridViewTextBoxColumn,
            this.movreleaseDataGridViewTextBoxColumn,
            this.movrelcountryDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.moviesDirectorDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.moviesDataGridView.DataSource = this.movieBindingSource;
            this.moviesDataGridView.Location = new System.Drawing.Point(259, 100);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.Size = new System.Drawing.Size(445, 285);
            this.moviesDataGridView.TabIndex = 7;
            this.moviesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.moviesDataGridView_DataError);
            // 
            // awardsDataGridView
            // 
            this.awardsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.awardsDataGridView.AutoGenerateColumns = false;
            this.awardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diridDataGridViewTextBoxColumn,
            this.numoawardsDataGridViewTextBoxColumn,
            this.mainawardDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn});
            this.awardsDataGridView.DataSource = this.awardBindingSource;
            this.awardsDataGridView.Location = new System.Drawing.Point(283, 100);
            this.awardsDataGridView.Name = "awardsDataGridView";
            this.awardsDataGridView.Size = new System.Drawing.Size(438, 285);
            this.awardsDataGridView.TabIndex = 15;
            this.awardsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.awardsDataGridView_DataError);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1-10049_projector-free-download-and-movie-icon-black-and.png");
            this.imageList1.Images.SetKeyName(1, "images.png");
            // 
            // deleteAwardButton
            // 
            this.deleteAwardButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteAwardButton.BackColor = System.Drawing.Color.White;
            this.deleteAwardButton.Location = new System.Drawing.Point(862, 163);
            this.deleteAwardButton.Name = "deleteAwardButton";
            this.deleteAwardButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAwardButton.TabIndex = 17;
            this.deleteAwardButton.Text = "Delete Row";
            this.deleteAwardButton.UseVisualStyleBackColor = false;
            this.deleteAwardButton.Visible = false;
            this.deleteAwardButton.Click += new System.EventHandler(this.deleteAward);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteMovieButton.BackColor = System.Drawing.Color.White;
            this.deleteMovieButton.Location = new System.Drawing.Point(862, 213);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(75, 23);
            this.deleteMovieButton.TabIndex = 18;
            this.deleteMovieButton.Text = "Delete Row";
            this.deleteMovieButton.UseVisualStyleBackColor = false;
            this.deleteMovieButton.Visible = false;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "letöltés.png");
            this.imageList2.Images.SetKeyName(1, "images (1).png");
            this.imageList2.Images.SetKeyName(2, "340.png");
            // 
            // moviesButton
            // 
            this.moviesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moviesButton.BackColor = System.Drawing.Color.White;
            this.moviesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moviesButton.ImageIndex = 0;
            this.moviesButton.ImageList = this.imageList1;
            this.moviesButton.Location = new System.Drawing.Point(862, 192);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(75, 23);
            this.moviesButton.TabIndex = 16;
            this.moviesButton.Text = "Movies";
            this.moviesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moviesButton.UseVisualStyleBackColor = false;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
            // 
            // loadFileAwards
            // 
            this.loadFileAwards.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadFileAwards.BackColor = System.Drawing.Color.White;
            this.loadFileAwards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadFileAwards.ImageIndex = 1;
            this.loadFileAwards.ImageList = this.imageList2;
            this.loadFileAwards.Location = new System.Drawing.Point(560, 450);
            this.loadFileAwards.Name = "loadFileAwards";
            this.loadFileAwards.Size = new System.Drawing.Size(75, 23);
            this.loadFileAwards.TabIndex = 14;
            this.loadFileAwards.Text = "Load File";
            this.loadFileAwards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadFileAwards.UseVisualStyleBackColor = false;
            this.loadFileAwards.Click += new System.EventHandler(this.loadFileAwards_Click);
            // 
            // saveFileAwards
            // 
            this.saveFileAwards.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveFileAwards.BackColor = System.Drawing.Color.White;
            this.saveFileAwards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileAwards.ImageKey = "letöltés.png";
            this.saveFileAwards.ImageList = this.imageList2;
            this.saveFileAwards.Location = new System.Drawing.Point(366, 450);
            this.saveFileAwards.Name = "saveFileAwards";
            this.saveFileAwards.Size = new System.Drawing.Size(75, 23);
            this.saveFileAwards.TabIndex = 13;
            this.saveFileAwards.Text = "Save File";
            this.saveFileAwards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFileAwards.UseVisualStyleBackColor = false;
            this.saveFileAwards.Click += new System.EventHandler(this.saveFileAwards_Click);
            // 
            // awardsButton
            // 
            this.awardsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.awardsButton.BackColor = System.Drawing.Color.White;
            this.awardsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.awardsButton.ImageIndex = 1;
            this.awardsButton.ImageList = this.imageList1;
            this.awardsButton.Location = new System.Drawing.Point(862, 134);
            this.awardsButton.Name = "awardsButton";
            this.awardsButton.Size = new System.Drawing.Size(75, 23);
            this.awardsButton.TabIndex = 11;
            this.awardsButton.Text = "Awards";
            this.awardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.awardsButton.UseVisualStyleBackColor = false;
            this.awardsButton.Click += new System.EventHandler(this.awardsButton_Click);
            // 
            // loadFileMovies
            // 
            this.loadFileMovies.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadFileMovies.BackColor = System.Drawing.Color.White;
            this.loadFileMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadFileMovies.ImageIndex = 1;
            this.loadFileMovies.ImageList = this.imageList2;
            this.loadFileMovies.Location = new System.Drawing.Point(560, 420);
            this.loadFileMovies.Name = "loadFileMovies";
            this.loadFileMovies.Size = new System.Drawing.Size(75, 23);
            this.loadFileMovies.TabIndex = 10;
            this.loadFileMovies.Text = "Load File";
            this.loadFileMovies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadFileMovies.UseVisualStyleBackColor = false;
            this.loadFileMovies.Click += new System.EventHandler(this.loadFileMovies_Click);
            // 
            // saveFileMovies
            // 
            this.saveFileMovies.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveFileMovies.BackColor = System.Drawing.Color.White;
            this.saveFileMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileMovies.ImageIndex = 0;
            this.saveFileMovies.ImageList = this.imageList2;
            this.saveFileMovies.Location = new System.Drawing.Point(366, 420);
            this.saveFileMovies.Name = "saveFileMovies";
            this.saveFileMovies.Size = new System.Drawing.Size(75, 23);
            this.saveFileMovies.TabIndex = 9;
            this.saveFileMovies.Text = "Save File";
            this.saveFileMovies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFileMovies.UseVisualStyleBackColor = false;
            this.saveFileMovies.Click += new System.EventHandler(this.saveFileMovies_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.ImageIndex = 2;
            this.backButton.ImageList = this.imageList2;
            this.backButton.Location = new System.Drawing.Point(862, 242);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loadFileDirectors
            // 
            this.loadFileDirectors.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadFileDirectors.BackColor = System.Drawing.Color.White;
            this.loadFileDirectors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadFileDirectors.ImageIndex = 1;
            this.loadFileDirectors.ImageList = this.imageList2;
            this.loadFileDirectors.Location = new System.Drawing.Point(560, 391);
            this.loadFileDirectors.Name = "loadFileDirectors";
            this.loadFileDirectors.Size = new System.Drawing.Size(75, 23);
            this.loadFileDirectors.TabIndex = 3;
            this.loadFileDirectors.Text = "Load File";
            this.loadFileDirectors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadFileDirectors.UseVisualStyleBackColor = false;
            this.loadFileDirectors.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // saveFileDirectors
            // 
            this.saveFileDirectors.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveFileDirectors.BackColor = System.Drawing.Color.White;
            this.saveFileDirectors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileDirectors.ImageIndex = 0;
            this.saveFileDirectors.ImageList = this.imageList2;
            this.saveFileDirectors.Location = new System.Drawing.Point(366, 391);
            this.saveFileDirectors.Name = "saveFileDirectors";
            this.saveFileDirectors.Size = new System.Drawing.Size(75, 23);
            this.saveFileDirectors.TabIndex = 2;
            this.saveFileDirectors.Text = "Save File";
            this.saveFileDirectors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFileDirectors.UseVisualStyleBackColor = false;
            this.saveFileDirectors.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // diridDataGridViewTextBoxColumn
            // 
            this.diridDataGridViewTextBoxColumn.DataPropertyName = "dir_id";
            this.diridDataGridViewTextBoxColumn.HeaderText = "dir_id";
            this.diridDataGridViewTextBoxColumn.Name = "diridDataGridViewTextBoxColumn";
            // 
            // numoawardsDataGridViewTextBoxColumn
            // 
            this.numoawardsDataGridViewTextBoxColumn.DataPropertyName = "num_o_awards";
            this.numoawardsDataGridViewTextBoxColumn.HeaderText = "num_o_awards";
            this.numoawardsDataGridViewTextBoxColumn.Name = "numoawardsDataGridViewTextBoxColumn";
            // 
            // mainawardDataGridViewTextBoxColumn
            // 
            this.mainawardDataGridViewTextBoxColumn.DataPropertyName = "main_award";
            this.mainawardDataGridViewTextBoxColumn.HeaderText = "main_award";
            this.mainawardDataGridViewTextBoxColumn.Name = "mainawardDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.Visible = false;
            // 
            // awardBindingSource
            // 
            this.awardBindingSource.DataSource = typeof(T3WN4K_beadando.Award);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // movtitleDataGridViewTextBoxColumn
            // 
            this.movtitleDataGridViewTextBoxColumn.DataPropertyName = "mov_title";
            this.movtitleDataGridViewTextBoxColumn.HeaderText = "Movie Title";
            this.movtitleDataGridViewTextBoxColumn.Name = "movtitleDataGridViewTextBoxColumn";
            // 
            // movreleaseDataGridViewTextBoxColumn
            // 
            this.movreleaseDataGridViewTextBoxColumn.DataPropertyName = "mov_release";
            this.movreleaseDataGridViewTextBoxColumn.HeaderText = "Movie Release";
            this.movreleaseDataGridViewTextBoxColumn.Name = "movreleaseDataGridViewTextBoxColumn";
            // 
            // movrelcountryDataGridViewTextBoxColumn
            // 
            this.movrelcountryDataGridViewTextBoxColumn.DataPropertyName = "mov_rel_country";
            this.movrelcountryDataGridViewTextBoxColumn.HeaderText = "Movie Release Country";
            this.movrelcountryDataGridViewTextBoxColumn.Name = "movrelcountryDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Visible = false;
            // 
            // moviesDirectorDataGridViewTextBoxColumn
            // 
            this.moviesDirectorDataGridViewTextBoxColumn.DataPropertyName = "Movies_Director";
            this.moviesDirectorDataGridViewTextBoxColumn.HeaderText = "Movies_Director";
            this.moviesDirectorDataGridViewTextBoxColumn.Name = "moviesDirectorDataGridViewTextBoxColumn";
            this.moviesDirectorDataGridViewTextBoxColumn.Visible = false;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Visible = false;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(T3WN4K_beadando.Movie);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dirfnameDataGridViewTextBoxColumn
            // 
            this.dirfnameDataGridViewTextBoxColumn.DataPropertyName = "dir_fname";
            this.dirfnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.dirfnameDataGridViewTextBoxColumn.Name = "dirfnameDataGridViewTextBoxColumn";
            // 
            // dirlnameDataGridViewTextBoxColumn
            // 
            this.dirlnameDataGridViewTextBoxColumn.DataPropertyName = "dir_lname";
            this.dirlnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.dirlnameDataGridViewTextBoxColumn.Name = "dirlnameDataGridViewTextBoxColumn";
            // 
            // dirgenderDataGridViewTextBoxColumn
            // 
            this.dirgenderDataGridViewTextBoxColumn.DataPropertyName = "dir_gender";
            this.dirgenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.dirgenderDataGridViewTextBoxColumn.Name = "dirgenderDataGridViewTextBoxColumn";
            // 
            // dirbornDataGridViewTextBoxColumn
            // 
            this.dirbornDataGridViewTextBoxColumn.DataPropertyName = "dir_born";
            this.dirbornDataGridViewTextBoxColumn.HeaderText = "Born Date";
            this.dirbornDataGridViewTextBoxColumn.Name = "dirbornDataGridViewTextBoxColumn";
            // 
            // dirbornplaceDataGridViewTextBoxColumn
            // 
            this.dirbornplaceDataGridViewTextBoxColumn.DataPropertyName = "dir_born_place";
            this.dirbornplaceDataGridViewTextBoxColumn.HeaderText = "Born Place";
            this.dirbornplaceDataGridViewTextBoxColumn.Name = "dirbornplaceDataGridViewTextBoxColumn";
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(T3WN4K_beadando.Director);
            // 
            // ratingBindingSource
            // 
            this.ratingBindingSource.DataSource = typeof(T3WN4K_beadando.Rating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.deleteAwardButton);
            this.Controls.Add(this.moviesButton);
            this.Controls.Add(this.awardsDataGridView);
            this.Controls.Add(this.loadFileAwards);
            this.Controls.Add(this.saveFileAwards);
            this.Controls.Add(this.awardsButton);
            this.Controls.Add(this.loadFileMovies);
            this.Controls.Add(this.saveFileMovies);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moviesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadFileDirectors);
            this.Controls.Add(this.saveFileDirectors);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.directorsDataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.directorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView directorsDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveChangesButton;
        private System.Windows.Forms.Button saveFileDirectors;
        private System.Windows.Forms.Button loadFileDirectors;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToDirectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem moviesToRatingsToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirbornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirbornplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem directorsToAwardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToDirectorsToolStripMenuItem1;
        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveFileMovies;
        private System.Windows.Forms.Button loadFileMovies;
        private System.Windows.Forms.Button awardsButton;
        private System.Windows.Forms.BindingSource awardBindingSource;
        private System.Windows.Forms.Button saveFileAwards;
        private System.Windows.Forms.Button loadFileAwards;
        private System.Windows.Forms.DataGridView awardsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movreleaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movrelcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviesDirectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ratingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn diridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numoawardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainawardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button deleteAwardButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

