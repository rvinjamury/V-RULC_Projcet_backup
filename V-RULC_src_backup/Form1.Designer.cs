namespace TEST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homepanelleft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.routingbtn = new System.Windows.Forms.Button();
            this.packtruckbtn = new System.Windows.Forms.Button();
            this.customerdetailsbtn = new System.Windows.Forms.Button();
            this.homepaneltop = new System.Windows.Forms.Panel();
            this.tabLocation = new System.Windows.Forms.Label();
            this.homelbl = new System.Windows.Forms.Label();
            this.Hometab = new System.Windows.Forms.TabControl();
            this.CustomertabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.customernamesearchtxtbox = new System.Windows.Forms.TextBox();
            this.customernamesearchbtn = new System.Windows.Forms.Button();
            this.customerdataGridView = new System.Windows.Forms.DataGridView();
            this.txtCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmailAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoOfPackages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packtab = new System.Windows.Forms.TabPage();
            this.packagingPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.widthtxtvalue = new System.Windows.Forms.TextBox();
            this.heighttxtvalue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchByNameTxt = new System.Windows.Forms.TextBox();
            this.searchByName = new System.Windows.Forms.Button();
            this.packtruckdataGridView = new System.Windows.Forms.DataGridView();
            this.Routingtab = new System.Windows.Forms.TabPage();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.homepanelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.homepaneltop.SuspendLayout();
            this.Hometab.SuspendLayout();
            this.CustomertabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerdataGridView)).BeginInit();
            this.Packtab.SuspendLayout();
            this.packagingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packtruckdataGridView)).BeginInit();
            this.Routingtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepanelleft
            // 
            this.homepanelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.homepanelleft.Controls.Add(this.pictureBox1);
            this.homepanelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.homepanelleft.Location = new System.Drawing.Point(0, 0);
            this.homepanelleft.Margin = new System.Windows.Forms.Padding(2);
            this.homepanelleft.Name = "homepanelleft";
            this.homepanelleft.Size = new System.Drawing.Size(298, 1033);
            this.homepanelleft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // routingbtn
            // 
            this.routingbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.routingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routingbtn.Image = ((System.Drawing.Image)(resources.GetObject("routingbtn.Image")));
            this.routingbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.routingbtn.Location = new System.Drawing.Point(504, 84);
            this.routingbtn.Margin = new System.Windows.Forms.Padding(2);
            this.routingbtn.Name = "routingbtn";
            this.routingbtn.Size = new System.Drawing.Size(222, 71);
            this.routingbtn.TabIndex = 2;
            this.routingbtn.Text = "Routing";
            this.routingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.routingbtn.UseVisualStyleBackColor = false;
            this.routingbtn.Click += new System.EventHandler(this.Routingbtn_Click);
            // 
            // packtruckbtn
            // 
            this.packtruckbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.packtruckbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packtruckbtn.Image = ((System.Drawing.Image)(resources.GetObject("packtruckbtn.Image")));
            this.packtruckbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.packtruckbtn.Location = new System.Drawing.Point(262, 84);
            this.packtruckbtn.Margin = new System.Windows.Forms.Padding(2);
            this.packtruckbtn.Name = "packtruckbtn";
            this.packtruckbtn.Size = new System.Drawing.Size(222, 71);
            this.packtruckbtn.TabIndex = 1;
            this.packtruckbtn.Text = "Packaging and Truck";
            this.packtruckbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.packtruckbtn.UseVisualStyleBackColor = false;
            this.packtruckbtn.Click += new System.EventHandler(this.Packtruckbtn_Click);
            // 
            // customerdetailsbtn
            // 
            this.customerdetailsbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerdetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerdetailsbtn.Image = ((System.Drawing.Image)(resources.GetObject("customerdetailsbtn.Image")));
            this.customerdetailsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerdetailsbtn.Location = new System.Drawing.Point(12, 84);
            this.customerdetailsbtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerdetailsbtn.Name = "customerdetailsbtn";
            this.customerdetailsbtn.Size = new System.Drawing.Size(222, 71);
            this.customerdetailsbtn.TabIndex = 0;
            this.customerdetailsbtn.Text = "Customer Details";
            this.customerdetailsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerdetailsbtn.UseVisualStyleBackColor = false;
            this.customerdetailsbtn.Click += new System.EventHandler(this.Customerdetailsbtn_Click);
            // 
            // homepaneltop
            // 
            this.homepaneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.homepaneltop.Controls.Add(this.tabLocation);
            this.homepaneltop.Controls.Add(this.homelbl);
            this.homepaneltop.Controls.Add(this.routingbtn);
            this.homepaneltop.Controls.Add(this.customerdetailsbtn);
            this.homepaneltop.Controls.Add(this.packtruckbtn);
            this.homepaneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.homepaneltop.Location = new System.Drawing.Point(298, 0);
            this.homepaneltop.Margin = new System.Windows.Forms.Padding(2);
            this.homepaneltop.Name = "homepaneltop";
            this.homepaneltop.Size = new System.Drawing.Size(1484, 190);
            this.homepaneltop.TabIndex = 1;
            // 
            // tabLocation
            // 
            this.tabLocation.AutoSize = true;
            this.tabLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(1036, 138);
            this.tabLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(95, 17);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Tab Location:";
            // 
            // homelbl
            // 
            this.homelbl.AutoSize = true;
            this.homelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.homelbl.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homelbl.Location = new System.Drawing.Point(498, 13);
            this.homelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homelbl.Name = "homelbl";
            this.homelbl.Size = new System.Drawing.Size(462, 35);
            this.homelbl.TabIndex = 0;
            this.homelbl.Text = "Vehicle Routing and Loading Solutions";
            // 
            // Hometab
            // 
            this.Hometab.Controls.Add(this.CustomertabPage);
            this.Hometab.Controls.Add(this.Packtab);
            this.Hometab.Controls.Add(this.Routingtab);
            this.Hometab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hometab.Location = new System.Drawing.Point(298, 169);
            this.Hometab.Margin = new System.Windows.Forms.Padding(2);
            this.Hometab.Name = "Hometab";
            this.Hometab.SelectedIndex = 0;
            this.Hometab.Size = new System.Drawing.Size(2250, 1250);
            this.Hometab.TabIndex = 2;
            // 
            // CustomertabPage
            // 
            this.CustomertabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(139)))), ((int)(((byte)(132)))));
            this.CustomertabPage.Controls.Add(this.label2);
            this.CustomertabPage.Controls.Add(this.customernamesearchtxtbox);
            this.CustomertabPage.Controls.Add(this.customernamesearchbtn);
            this.CustomertabPage.Controls.Add(this.customerdataGridView);
            this.CustomertabPage.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomertabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomertabPage.Margin = new System.Windows.Forms.Padding(2);
            this.CustomertabPage.Name = "CustomertabPage";
            this.CustomertabPage.Padding = new System.Windows.Forms.Padding(2);
            this.CustomertabPage.Size = new System.Drawing.Size(2242, 1221);
            this.CustomertabPage.TabIndex = 0;
            this.CustomertabPage.Text = "Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Customer Details";
            // 
            // customernamesearchtxtbox
            // 
            this.customernamesearchtxtbox.Location = new System.Drawing.Point(57, 553);
            this.customernamesearchtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.customernamesearchtxtbox.Name = "customernamesearchtxtbox";
            this.customernamesearchtxtbox.Size = new System.Drawing.Size(145, 28);
            this.customernamesearchtxtbox.TabIndex = 2;
            // 
            // customernamesearchbtn
            // 
            this.customernamesearchbtn.Location = new System.Drawing.Point(57, 602);
            this.customernamesearchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.customernamesearchbtn.Name = "customernamesearchbtn";
            this.customernamesearchbtn.Size = new System.Drawing.Size(173, 92);
            this.customernamesearchbtn.TabIndex = 1;
            this.customernamesearchbtn.Text = "Search Customer Name";
            this.customernamesearchbtn.UseVisualStyleBackColor = true;
            this.customernamesearchbtn.Click += new System.EventHandler(this.Customernamesearchbtn_Click);
            // 
            // customerdataGridView
            // 
            this.customerdataGridView.AllowUserToOrderColumns = true;
            this.customerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustId,
            this.txtCustName,
            this.txtEmailAdd,
            this.txtAdd,
            this.txtNoOfPackages,
            this.txtDeliveryDate,
            this.txtDueDate});
            this.customerdataGridView.Location = new System.Drawing.Point(15, 109);
            this.customerdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customerdataGridView.Name = "customerdataGridView";
            this.customerdataGridView.RowHeadersWidth = 82;
            this.customerdataGridView.RowTemplate.Height = 33;
            this.customerdataGridView.Size = new System.Drawing.Size(1200, 370);
            this.customerdataGridView.TabIndex = 0;
            this.customerdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellDoubleClick);
            this.customerdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellValueChanged);
            // 
            // txtCustId
            // 
            this.txtCustId.DataPropertyName = "CustId";
            this.txtCustId.HeaderText = "Customer Id";
            this.txtCustId.MinimumWidth = 6;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Visible = false;
            this.txtCustId.Width = 125;
            // 
            // txtCustName
            // 
            this.txtCustName.DataPropertyName = "CustName";
            this.txtCustName.HeaderText = "Customer Name";
            this.txtCustName.MinimumWidth = 6;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Width = 125;
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.DataPropertyName = "EmailAdd";
            this.txtEmailAdd.HeaderText = "Email Address";
            this.txtEmailAdd.MinimumWidth = 6;
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Width = 125;
            // 
            // txtAdd
            // 
            this.txtAdd.DataPropertyName = "Address";
            this.txtAdd.HeaderText = "Address";
            this.txtAdd.MinimumWidth = 6;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Width = 125;
            // 
            // txtNoOfPackages
            // 
            this.txtNoOfPackages.DataPropertyName = "NoOfPackages";
            this.txtNoOfPackages.HeaderText = "No. Of Packages";
            this.txtNoOfPackages.MinimumWidth = 6;
            this.txtNoOfPackages.Name = "txtNoOfPackages";
            this.txtNoOfPackages.Width = 125;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.DataPropertyName = "DeliveryDate";
            this.txtDeliveryDate.HeaderText = "Delivery Date";
            this.txtDeliveryDate.MinimumWidth = 6;
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Width = 125;
            // 
            // txtDueDate
            // 
            this.txtDueDate.DataPropertyName = "DueDate";
            this.txtDueDate.HeaderText = "Due Date";
            this.txtDueDate.MinimumWidth = 6;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Width = 125;
            // 
            // Packtab
            // 
            this.Packtab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(139)))), ((int)(((byte)(132)))));
            this.Packtab.Controls.Add(this.packagingPanel);
            this.Packtab.Controls.Add(this.submitBtn);
            this.Packtab.Controls.Add(this.widthtxtvalue);
            this.Packtab.Controls.Add(this.heighttxtvalue);
            this.Packtab.Controls.Add(this.label4);
            this.Packtab.Controls.Add(this.label3);
            this.Packtab.Controls.Add(this.label1);
            this.Packtab.Controls.Add(this.searchByNameTxt);
            this.Packtab.Controls.Add(this.searchByName);
            this.Packtab.Controls.Add(this.packtruckdataGridView);
            this.Packtab.Location = new System.Drawing.Point(4, 25);
            this.Packtab.Margin = new System.Windows.Forms.Padding(2);
            this.Packtab.Name = "Packtab";
            this.Packtab.Padding = new System.Windows.Forms.Padding(2);
            this.Packtab.Size = new System.Drawing.Size(2242, 1221);
            this.Packtab.TabIndex = 1;
            this.Packtab.Text = "Packaging & Truck Details";
            // 
            // packagingPanel
            // 
            this.packagingPanel.Controls.Add(this.label5);
            this.packagingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.packagingPanel.Location = new System.Drawing.Point(704, 2);
            this.packagingPanel.Name = "packagingPanel";
            this.packagingPanel.Size = new System.Drawing.Size(1536, 1217);
            this.packagingPanel.TabIndex = 10;
            this.packagingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PackagingPanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Package Loading Layout";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(350, 520);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit ";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // widthtxtvalue
            // 
            this.widthtxtvalue.Location = new System.Drawing.Point(350, 468);
            this.widthtxtvalue.Name = "widthtxtvalue";
            this.widthtxtvalue.Size = new System.Drawing.Size(100, 22);
            this.widthtxtvalue.TabIndex = 8;
            // 
            // heighttxtvalue
            // 
            this.heighttxtvalue.Location = new System.Drawing.Point(489, 468);
            this.heighttxtvalue.Name = "heighttxtvalue";
            this.heighttxtvalue.Size = new System.Drawing.Size(100, 22);
            this.heighttxtvalue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter details for ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Package Details";
            // 
            // searchByNameTxt
            // 
            this.searchByNameTxt.Location = new System.Drawing.Point(143, 404);
            this.searchByNameTxt.Name = "searchByNameTxt";
            this.searchByNameTxt.Size = new System.Drawing.Size(127, 22);
            this.searchByNameTxt.TabIndex = 2;
            // 
            // searchByName
            // 
            this.searchByName.Location = new System.Drawing.Point(143, 449);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(127, 60);
            this.searchByName.TabIndex = 1;
            this.searchByName.Text = "Search Package Info";
            this.searchByName.UseVisualStyleBackColor = true;
            this.searchByName.Click += new System.EventHandler(this.SearchByName_Click);
            // 
            // packtruckdataGridView
            // 
            this.packtruckdataGridView.AllowUserToOrderColumns = true;
            this.packtruckdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packtruckdataGridView.Location = new System.Drawing.Point(143, 73);
            this.packtruckdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.packtruckdataGridView.Name = "packtruckdataGridView";
            this.packtruckdataGridView.RowHeadersWidth = 82;
            this.packtruckdataGridView.RowTemplate.Height = 33;
            this.packtruckdataGridView.Size = new System.Drawing.Size(372, 304);
            this.packtruckdataGridView.TabIndex = 0;
            this.packtruckdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PacktruckdataGridView_CellDoubleClick);
            // 
            // Routingtab
            // 
            this.Routingtab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(139)))), ((int)(((byte)(132)))));
            this.Routingtab.Controls.Add(this.map);
            this.Routingtab.Location = new System.Drawing.Point(4, 25);
            this.Routingtab.Margin = new System.Windows.Forms.Padding(2);
            this.Routingtab.Name = "Routingtab";
            this.Routingtab.Size = new System.Drawing.Size(2242, 1221);
            this.Routingtab.TabIndex = 2;
            this.Routingtab.Text = "Routing";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(52, 40);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1204, 595);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1782, 1033);
            this.Controls.Add(this.homepaneltop);
            this.Controls.Add(this.Hometab);
            this.Controls.Add(this.homepanelleft);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "V-RULC";
            this.homepanelleft.ResumeLayout(false);
            this.homepanelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.homepaneltop.ResumeLayout(false);
            this.homepaneltop.PerformLayout();
            this.Hometab.ResumeLayout(false);
            this.CustomertabPage.ResumeLayout(false);
            this.CustomertabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerdataGridView)).EndInit();
            this.Packtab.ResumeLayout(false);
            this.Packtab.PerformLayout();
            this.packagingPanel.ResumeLayout(false);
            this.packagingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packtruckdataGridView)).EndInit();
            this.Routingtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homepanelleft;
        private System.Windows.Forms.Button routingbtn;
        private System.Windows.Forms.Button packtruckbtn;
        private System.Windows.Forms.Button customerdetailsbtn;
        private System.Windows.Forms.Panel homepaneltop;
        private System.Windows.Forms.Label homelbl;
        private System.Windows.Forms.TabControl Hometab;
        private System.Windows.Forms.TabPage CustomertabPage;
        private System.Windows.Forms.DataGridView customerdataGridView;
        private System.Windows.Forms.TabPage Packtab;
        private System.Windows.Forms.TabPage Routingtab;
        private System.Windows.Forms.TextBox customernamesearchtxtbox;
        private System.Windows.Forms.Button customernamesearchbtn;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label tabLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmailAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoOfPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDueDate;
        private System.Windows.Forms.TextBox searchByNameTxt;
        private System.Windows.Forms.Button searchByName;
        private System.Windows.Forms.DataGridView packtruckdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox widthtxtvalue;
        private System.Windows.Forms.TextBox heighttxtvalue;
        private System.Windows.Forms.Panel packagingPanel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

