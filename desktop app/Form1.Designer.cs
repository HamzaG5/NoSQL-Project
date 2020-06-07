namespace desktop_app
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMonitoringSystem = new FontAwesome.Sharp.IconButton();
            this.btnFaq = new FontAwesome.Sharp.IconButton();
            this.btnIncidents = new FontAwesome.Sharp.IconButton();
            this.btnUserManager = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.PnlDashBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOpenTicketCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblInProgressTicketCount = new System.Windows.Forms.Label();
            this.lblTicketCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartTickets = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.pnlUserManagment = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewUserMnagment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnAddUser = new FontAwesome.Sharp.IconButton();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.btnPasswordHideShow = new FontAwesome.Sharp.IconButton();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnDiscardAddUser = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdateIncident = new System.Windows.Forms.Label();
            this.btnComfirmAddUser = new FontAwesome.Sharp.IconButton();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtLastnameAdd = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtFirstNameAdd = new System.Windows.Forms.TextBox();
            this.txtSearchIncident = new System.Windows.Forms.TextBox();
            this.listViewIncidents = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlIncidentManagement = new System.Windows.Forms.Panel();
            this.btnDeleteIncident = new System.Windows.Forms.Button();
            this.btnEditIncident = new System.Windows.Forms.Button();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.btnSearchIncident = new FontAwesome.Sharp.IconButton();
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.lblUpdateTicket = new System.Windows.Forms.Label();
            this.dtpDateReported = new System.Windows.Forms.DateTimePicker();
            this.cmbReportedUsers = new System.Windows.Forms.ComboBox();
            this.cmbTypeIncident = new System.Windows.Forms.ComboBox();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblReportedUser = new System.Windows.Forms.Label();
            this.lblTypeIncident = new System.Windows.Forms.Label();
            this.lblSubjectIncident = new System.Windows.Forms.Label();
            this.txtSubjectIncident = new System.Windows.Forms.TextBox();
            this.lblDateReported = new System.Windows.Forms.Label();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.lblCreateNewTicket = new System.Windows.Forms.Label();
            this.pnlFaq = new System.Windows.Forms.Panel();
            this.btnFilterShowAll = new System.Windows.Forms.Button();
            this.btnAddFaq = new System.Windows.Forms.Button();
            this.btnFilterService = new System.Windows.Forms.Button();
            this.btnFilterSoftware = new System.Windows.Forms.Button();
            this.btnFilterHardware = new System.Windows.Forms.Button();
            this.listViewFaq = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Questions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFaq = new System.Windows.Forms.Label();
            this.pnlAddFaq = new System.Windows.Forms.Panel();
            this.btnCancelFaq = new System.Windows.Forms.Button();
            this.cmbTypeQuestion = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnSubmitFaq = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAddNewFaq = new System.Windows.Forms.Label();
            this.pnlMonitoring = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAnalysis = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWeekDates = new System.Windows.Forms.Label();
            this.btnWeekDecrement = new System.Windows.Forms.Button();
            this.btnWeekIncrement = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            this.btnAnalysisBack = new System.Windows.Forms.Button();
            this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlDashBoard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTickets)).BeginInit();
            this.pnlUserManagment.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.pnlIncidentManagement.SuspendLayout();
            this.pnlCreateTicket.SuspendLayout();
            this.pnlFaq.SuspendLayout();
            this.pnlAddFaq.SuspendLayout();
            this.pnlAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.btnMonitoringSystem);
            this.pnlMenu.Controls.Add(this.btnFaq);
            this.pnlMenu.Controls.Add(this.btnIncidents);
            this.pnlMenu.Controls.Add(this.btnUserManager);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 3106);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnMonitoringSystem
            // 
            this.btnMonitoringSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitoringSystem.FlatAppearance.BorderSize = 0;
            this.btnMonitoringSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoringSystem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMonitoringSystem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonitoringSystem.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnMonitoringSystem.IconColor = System.Drawing.Color.LightGray;
            this.btnMonitoringSystem.IconSize = 52;
            this.btnMonitoringSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitoringSystem.Location = new System.Drawing.Point(0, 380);
            this.btnMonitoringSystem.Name = "btnMonitoringSystem";
            this.btnMonitoringSystem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMonitoringSystem.Rotation = 0D;
            this.btnMonitoringSystem.Size = new System.Drawing.Size(220, 60);
            this.btnMonitoringSystem.TabIndex = 7;
            this.btnMonitoringSystem.Text = "Alert && Monitoring System";
            this.btnMonitoringSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitoringSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonitoringSystem.UseVisualStyleBackColor = true;
            this.btnMonitoringSystem.Click += new System.EventHandler(this.MenuBtnClick);
            // 
            // btnFaq
            // 
            this.btnFaq.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFaq.FlatAppearance.BorderSize = 0;
            this.btnFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaq.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFaq.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFaq.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnFaq.IconColor = System.Drawing.Color.LightGray;
            this.btnFaq.IconSize = 52;
            this.btnFaq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaq.Location = new System.Drawing.Point(0, 320);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFaq.Rotation = 0D;
            this.btnFaq.Size = new System.Drawing.Size(220, 60);
            this.btnFaq.TabIndex = 6;
            this.btnFaq.Text = "FAQ";
            this.btnFaq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaq.UseVisualStyleBackColor = true;
            this.btnFaq.Click += new System.EventHandler(this.MenuBtnClick);
            // 
            // btnIncidents
            // 
            this.btnIncidents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncidents.FlatAppearance.BorderSize = 0;
            this.btnIncidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidents.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnIncidents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIncidents.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnIncidents.IconColor = System.Drawing.Color.LightGray;
            this.btnIncidents.IconSize = 52;
            this.btnIncidents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidents.Location = new System.Drawing.Point(0, 260);
            this.btnIncidents.Name = "btnIncidents";
            this.btnIncidents.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIncidents.Rotation = 0D;
            this.btnIncidents.Size = new System.Drawing.Size(220, 60);
            this.btnIncidents.TabIndex = 5;
            this.btnIncidents.Text = "Overview Tickets";
            this.btnIncidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncidents.UseVisualStyleBackColor = true;
            this.btnIncidents.Click += new System.EventHandler(this.MenuBtnClick);
            // 
            // btnUserManager
            // 
            this.btnUserManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManager.FlatAppearance.BorderSize = 0;
            this.btnUserManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManager.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserManager.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnUserManager.IconColor = System.Drawing.Color.LightGray;
            this.btnUserManager.IconSize = 52;
            this.btnUserManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManager.Location = new System.Drawing.Point(0, 200);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUserManager.Rotation = 0D;
            this.btnUserManager.Size = new System.Drawing.Size(220, 60);
            this.btnUserManager.TabIndex = 3;
            this.btnUserManager.Text = "User Managment";
            this.btnUserManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManager.UseVisualStyleBackColor = true;
            this.btnUserManager.Click += new System.EventHandler(this.MenuBtnClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnDashboard.IconColor = System.Drawing.Color.LightGray;
            this.btnDashboard.IconSize = 52;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.MenuBtnClick);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3007, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(796, 45);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(63, 13);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "current user";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHeader.Location = new System.Drawing.Point(57, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(80, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Section";
            // 
            // PnlDashBoard
            // 
            this.PnlDashBoard.Controls.Add(this.panel2);
            this.PnlDashBoard.Controls.Add(this.btnAnalysis);
            this.PnlDashBoard.Location = new System.Drawing.Point(230, 109);
            this.PnlDashBoard.Name = "PnlDashBoard";
            this.PnlDashBoard.Size = new System.Drawing.Size(945, 507);
            this.PnlDashBoard.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblTicketCount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.chartTickets);
            this.panel2.Location = new System.Drawing.Point(273, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 371);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(182)))), ((int)(((byte)(47)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblOpenTicketCount);
            this.panel4.Location = new System.Drawing.Point(202, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 29);
            this.panel4.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(57, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Open";
            // 
            // lblOpenTicketCount
            // 
            this.lblOpenTicketCount.AutoSize = true;
            this.lblOpenTicketCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(142)))), ((int)(((byte)(37)))));
            this.lblOpenTicketCount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenTicketCount.ForeColor = System.Drawing.Color.White;
            this.lblOpenTicketCount.Location = new System.Drawing.Point(0, 0);
            this.lblOpenTicketCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblOpenTicketCount.Name = "lblOpenTicketCount";
            this.lblOpenTicketCount.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblOpenTicketCount.Size = new System.Drawing.Size(28, 29);
            this.lblOpenTicketCount.TabIndex = 0;
            this.lblOpenTicketCount.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblInProgressTicketCount);
            this.panel3.Location = new System.Drawing.Point(58, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 29);
            this.panel3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "In Progress";
            // 
            // lblInProgressTicketCount
            // 
            this.lblInProgressTicketCount.AutoSize = true;
            this.lblInProgressTicketCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(114)))), ((int)(((byte)(53)))));
            this.lblInProgressTicketCount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgressTicketCount.ForeColor = System.Drawing.Color.White;
            this.lblInProgressTicketCount.Location = new System.Drawing.Point(0, 0);
            this.lblInProgressTicketCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblInProgressTicketCount.Name = "lblInProgressTicketCount";
            this.lblInProgressTicketCount.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblInProgressTicketCount.Size = new System.Drawing.Size(28, 29);
            this.lblInProgressTicketCount.TabIndex = 0;
            this.lblInProgressTicketCount.Text = "0";
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketCount.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCount.Location = new System.Drawing.Point(155, 163);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTicketCount.Size = new System.Drawing.Size(79, 40);
            this.lblTicketCount.TabIndex = 6;
            this.lblTicketCount.Text = "0";
            this.lblTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unresolved Tickets";
            // 
            // chartTickets
            // 
            this.chartTickets.BackColor = System.Drawing.Color.Transparent;
            this.chartTickets.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartTickets.ChartAreas.Add(chartArea3);
            this.chartTickets.Location = new System.Drawing.Point(72, 54);
            this.chartTickets.Name = "chartTickets";
            this.chartTickets.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Name = "Series1";
            this.chartTickets.Series.Add(series3);
            this.chartTickets.Size = new System.Drawing.Size(245, 260);
            this.chartTickets.TabIndex = 2;
            this.chartTickets.Text = "chart1";
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(124)))), ((int)(((byte)(218)))));
            this.btnAnalysis.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnalysis.Location = new System.Drawing.Point(824, 460);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(106, 36);
            this.btnAnalysis.TabIndex = 5;
            this.btnAnalysis.Text = "Show Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = false;
            this.btnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_Click);
            // 
            // pnlUserManagment
            // 
            this.pnlUserManagment.Controls.Add(this.label7);
            this.pnlUserManagment.Controls.Add(this.label8);
            this.pnlUserManagment.Controls.Add(this.listViewUserMnagment);
            this.pnlUserManagment.Controls.Add(this.txtSearchBar);
            this.pnlUserManagment.Controls.Add(this.btnAddUser);
            this.pnlUserManagment.Location = new System.Drawing.Point(227, 108);
            this.pnlUserManagment.Name = "pnlUserManagment";
            this.pnlUserManagment.Size = new System.Drawing.Size(945, 507);
            this.pnlUserManagment.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "-Just write what are you searching for";
            // 
            // listViewUserMnagment
            // 
            this.listViewUserMnagment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Email,
            this.FirstName,
            this.LastName,
            this.Tickets,
            this.UserType});
            this.listViewUserMnagment.HideSelection = false;
            this.listViewUserMnagment.Location = new System.Drawing.Point(35, 87);
            this.listViewUserMnagment.MultiSelect = false;
            this.listViewUserMnagment.Name = "listViewUserMnagment";
            this.listViewUserMnagment.Size = new System.Drawing.Size(857, 411);
            this.listViewUserMnagment.TabIndex = 5;
            this.listViewUserMnagment.UseCompatibleStateImageBehavior = false;
            this.listViewUserMnagment.View = System.Windows.Forms.View.Details;
            this.listViewUserMnagment.Click += new System.EventHandler(this.listViewUserMnagment_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 250;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 150;
            // 
            // Tickets
            // 
            this.Tickets.Text = "Tickets";
            this.Tickets.Width = 196;
            // 
            // UserType
            // 
            this.UserType.Text = "Type";
            this.UserType.Width = 70;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(37, 42);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(322, 22);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.SearchedText_Changed);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddUser.IconColor = System.Drawing.Color.Black;
            this.btnAddUser.IconSize = 32;
            this.btnAddUser.Location = new System.Drawing.Point(720, 32);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Rotation = 0D;
            this.btnAddUser.Size = new System.Drawing.Size(171, 42);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "ADD NEW USER";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.label1);
            this.pnlAddUser.Controls.Add(this.comboBoxUserType);
            this.pnlAddUser.Controls.Add(this.btnPasswordHideShow);
            this.pnlAddUser.Controls.Add(this.lblErrorMessage);
            this.pnlAddUser.Controls.Add(this.btnDiscardAddUser);
            this.pnlAddUser.Controls.Add(this.label4);
            this.pnlAddUser.Controls.Add(this.label3);
            this.pnlAddUser.Controls.Add(this.label2);
            this.pnlAddUser.Controls.Add(this.lblUpdateIncident);
            this.pnlAddUser.Controls.Add(this.btnComfirmAddUser);
            this.pnlAddUser.Controls.Add(this.txtPasswordAdd);
            this.pnlAddUser.Controls.Add(this.txtLastnameAdd);
            this.pnlAddUser.Controls.Add(this.txtEmailAdd);
            this.pnlAddUser.Controls.Add(this.txtFirstNameAdd);
            this.pnlAddUser.Location = new System.Drawing.Point(226, 109);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(948, 507);
            this.pnlAddUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "privileges:";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Manager",
            "User"});
            this.comboBoxUserType.Location = new System.Drawing.Point(311, 338);
            this.comboBoxUserType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(322, 21);
            this.comboBoxUserType.TabIndex = 12;
            // 
            // btnPasswordHideShow
            // 
            this.btnPasswordHideShow.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordHideShow.FlatAppearance.BorderSize = 0;
            this.btnPasswordHideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordHideShow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPasswordHideShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnPasswordHideShow.IconColor = System.Drawing.Color.Black;
            this.btnPasswordHideShow.IconSize = 32;
            this.btnPasswordHideShow.Location = new System.Drawing.Point(590, 234);
            this.btnPasswordHideShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasswordHideShow.Name = "btnPasswordHideShow";
            this.btnPasswordHideShow.Rotation = 0D;
            this.btnPasswordHideShow.Size = new System.Drawing.Size(43, 32);
            this.btnPasswordHideShow.TabIndex = 11;
            this.btnPasswordHideShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPasswordHideShow.UseVisualStyleBackColor = false;
            this.btnPasswordHideShow.Click += new System.EventHandler(this.PasswordHideShow);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(314, 362);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMessage.TabIndex = 10;
            // 
            // btnDiscardAddUser
            // 
            this.btnDiscardAddUser.BackColor = System.Drawing.Color.Crimson;
            this.btnDiscardAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscardAddUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDiscardAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscardAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiscardAddUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDiscardAddUser.IconColor = System.Drawing.Color.Black;
            this.btnDiscardAddUser.IconSize = 32;
            this.btnDiscardAddUser.Location = new System.Drawing.Point(314, 404);
            this.btnDiscardAddUser.Name = "btnDiscardAddUser";
            this.btnDiscardAddUser.Rotation = 0D;
            this.btnDiscardAddUser.Size = new System.Drawing.Size(140, 42);
            this.btnDiscardAddUser.TabIndex = 9;
            this.btnDiscardAddUser.Text = "Discard";
            this.btnDiscardAddUser.UseVisualStyleBackColor = false;
            this.btnDiscardAddUser.Click += new System.EventHandler(this.ConfirmDeclineBtn);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // lblUpdateIncident
            // 
            this.lblUpdateIncident.AutoSize = true;
            this.lblUpdateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateIncident.Location = new System.Drawing.Point(308, 31);
            this.lblUpdateIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateIncident.Name = "lblUpdateIncident";
            this.lblUpdateIncident.Size = new System.Drawing.Size(101, 20);
            this.lblUpdateIncident.TabIndex = 5;
            this.lblUpdateIncident.Text = "First Name:";
            // 
            // btnComfirmAddUser
            // 
            this.btnComfirmAddUser.BackColor = System.Drawing.Color.PaleGreen;
            this.btnComfirmAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComfirmAddUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnComfirmAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirmAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComfirmAddUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnComfirmAddUser.IconColor = System.Drawing.Color.Black;
            this.btnComfirmAddUser.IconSize = 32;
            this.btnComfirmAddUser.Location = new System.Drawing.Point(488, 404);
            this.btnComfirmAddUser.Name = "btnComfirmAddUser";
            this.btnComfirmAddUser.Rotation = 0D;
            this.btnComfirmAddUser.Size = new System.Drawing.Size(144, 42);
            this.btnComfirmAddUser.TabIndex = 4;
            this.btnComfirmAddUser.Text = "Confirm";
            this.btnComfirmAddUser.UseVisualStyleBackColor = false;
            this.btnComfirmAddUser.Click += new System.EventHandler(this.ConfirmDeclineBtn);
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdd.Location = new System.Drawing.Point(311, 268);
            this.txtPasswordAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(322, 26);
            this.txtPasswordAdd.TabIndex = 3;
            // 
            // txtLastnameAdd
            // 
            this.txtLastnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastnameAdd.Location = new System.Drawing.Point(311, 127);
            this.txtLastnameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastnameAdd.Name = "txtLastnameAdd";
            this.txtLastnameAdd.Size = new System.Drawing.Size(322, 26);
            this.txtLastnameAdd.TabIndex = 2;
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdd.Location = new System.Drawing.Point(311, 195);
            this.txtEmailAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(322, 26);
            this.txtEmailAdd.TabIndex = 1;
            // 
            // txtFirstNameAdd
            // 
            this.txtFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameAdd.Location = new System.Drawing.Point(311, 59);
            this.txtFirstNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstNameAdd.Name = "txtFirstNameAdd";
            this.txtFirstNameAdd.Size = new System.Drawing.Size(322, 26);
            this.txtFirstNameAdd.TabIndex = 0;
            // 
            // txtSearchIncident
            // 
            this.txtSearchIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIncident.Location = new System.Drawing.Point(37, 42);
            this.txtSearchIncident.Name = "txtSearchIncident";
            this.txtSearchIncident.Size = new System.Drawing.Size(322, 22);
            this.txtSearchIncident.TabIndex = 1;
            // 
            // listViewIncidents
            // 
            this.listViewIncidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Subject,
            this.User,
            this.Date,
            this.Priority,
            this.Status});
            this.listViewIncidents.FullRowSelect = true;
            this.listViewIncidents.GridLines = true;
            this.listViewIncidents.HideSelection = false;
            this.listViewIncidents.Location = new System.Drawing.Point(37, 92);
            this.listViewIncidents.Name = "listViewIncidents";
            this.listViewIncidents.Size = new System.Drawing.Size(857, 357);
            this.listViewIncidents.TabIndex = 3;
            this.listViewIncidents.UseCompatibleStateImageBehavior = false;
            this.listViewIncidents.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 65;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 220;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 210;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 140;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 110;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 110;
            // 
            // pnlIncidentManagement
            // 
            this.pnlIncidentManagement.Controls.Add(this.btnDeleteIncident);
            this.pnlIncidentManagement.Controls.Add(this.btnEditIncident);
            this.pnlIncidentManagement.Controls.Add(this.btnCreateIncident);
            this.pnlIncidentManagement.Controls.Add(this.listViewIncidents);
            this.pnlIncidentManagement.Controls.Add(this.btnSearchIncident);
            this.pnlIncidentManagement.Controls.Add(this.txtSearchIncident);
            this.pnlIncidentManagement.Location = new System.Drawing.Point(226, 106);
            this.pnlIncidentManagement.Name = "pnlIncidentManagement";
            this.pnlIncidentManagement.Size = new System.Drawing.Size(962, 509);
            this.pnlIncidentManagement.TabIndex = 7;
            // 
            // btnDeleteIncident
            // 
            this.btnDeleteIncident.BackColor = System.Drawing.Color.Red;
            this.btnDeleteIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIncident.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeleteIncident.Location = new System.Drawing.Point(200, 462);
            this.btnDeleteIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteIncident.Name = "btnDeleteIncident";
            this.btnDeleteIncident.Size = new System.Drawing.Size(134, 32);
            this.btnDeleteIncident.TabIndex = 8;
            this.btnDeleteIncident.Text = "REMOVE";
            this.btnDeleteIncident.UseVisualStyleBackColor = false;
            this.btnDeleteIncident.Click += new System.EventHandler(this.btnDeleteIncident_Click);
            // 
            // btnEditIncident
            // 
            this.btnEditIncident.BackColor = System.Drawing.Color.Green;
            this.btnEditIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIncident.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditIncident.Location = new System.Drawing.Point(37, 462);
            this.btnEditIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditIncident.Name = "btnEditIncident";
            this.btnEditIncident.Size = new System.Drawing.Size(134, 32);
            this.btnEditIncident.TabIndex = 7;
            this.btnEditIncident.Text = "UPDATE";
            this.btnEditIncident.UseVisualStyleBackColor = false;
            this.btnEditIncident.Click += new System.EventHandler(this.CreateEditTicketBtn);
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateIncident.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateIncident.Location = new System.Drawing.Point(751, 32);
            this.btnCreateIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(144, 41);
            this.btnCreateIncident.TabIndex = 4;
            this.btnCreateIncident.Text = "CREATE INCIDENT";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.CreateEditTicketBtn);
            // 
            // btnSearchIncident
            // 
            this.btnSearchIncident.BackColor = System.Drawing.Color.White;
            this.btnSearchIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIncident.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchIncident.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchIncident.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchIncident.IconColor = System.Drawing.Color.Black;
            this.btnSearchIncident.IconSize = 32;
            this.btnSearchIncident.Location = new System.Drawing.Point(374, 38);
            this.btnSearchIncident.Name = "btnSearchIncident";
            this.btnSearchIncident.Rotation = 0D;
            this.btnSearchIncident.Size = new System.Drawing.Size(134, 30);
            this.btnSearchIncident.TabIndex = 2;
            this.btnSearchIncident.Text = "Search Incident";
            this.btnSearchIncident.UseVisualStyleBackColor = false;
            this.btnSearchIncident.Click += new System.EventHandler(this.btnSearchIncident_Click);
            // 
            // pnlCreateTicket
            // 
            this.pnlCreateTicket.Controls.Add(this.dtpDeadline);
            this.pnlCreateTicket.Controls.Add(this.cmbPriority);
            this.pnlCreateTicket.Controls.Add(this.lblPriority);
            this.pnlCreateTicket.Controls.Add(this.cmbStatus);
            this.pnlCreateTicket.Controls.Add(this.btnUpdateTicket);
            this.pnlCreateTicket.Controls.Add(this.lblUpdateTicket);
            this.pnlCreateTicket.Controls.Add(this.dtpDateReported);
            this.pnlCreateTicket.Controls.Add(this.cmbReportedUsers);
            this.pnlCreateTicket.Controls.Add(this.cmbTypeIncident);
            this.pnlCreateTicket.Controls.Add(this.btnSubmitTicket);
            this.pnlCreateTicket.Controls.Add(this.lblDescription);
            this.pnlCreateTicket.Controls.Add(this.txtDescription);
            this.pnlCreateTicket.Controls.Add(this.lblDeadline);
            this.pnlCreateTicket.Controls.Add(this.lblStatus);
            this.pnlCreateTicket.Controls.Add(this.lblReportedUser);
            this.pnlCreateTicket.Controls.Add(this.lblTypeIncident);
            this.pnlCreateTicket.Controls.Add(this.lblSubjectIncident);
            this.pnlCreateTicket.Controls.Add(this.txtSubjectIncident);
            this.pnlCreateTicket.Controls.Add(this.lblDateReported);
            this.pnlCreateTicket.Controls.Add(this.btnCancelTicket);
            this.pnlCreateTicket.Controls.Add(this.lblCreateNewTicket);
            this.pnlCreateTicket.Location = new System.Drawing.Point(226, 107);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(945, 507);
            this.pnlCreateTicket.TabIndex = 8;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(412, 301);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(328, 23);
            this.dtpDeadline.TabIndex = 28;
            // 
            // cmbPriority
            // 
            this.cmbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbPriority.Location = new System.Drawing.Point(412, 232);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(328, 23);
            this.cmbPriority.TabIndex = 27;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(242, 236);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(52, 17);
            this.lblPriority.TabIndex = 26;
            this.lblPriority.Text = "Priority";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "In Progress",
            "Closed"});
            this.cmbStatus.Location = new System.Drawing.Point(412, 265);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(328, 23);
            this.cmbStatus.TabIndex = 25;
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateTicket.Location = new System.Drawing.Point(612, 465);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(128, 32);
            this.btnUpdateTicket.TabIndex = 24;
            this.btnUpdateTicket.Text = "UPDATE TICKET";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // lblUpdateTicket
            // 
            this.lblUpdateTicket.AutoSize = true;
            this.lblUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F);
            this.lblUpdateTicket.Location = new System.Drawing.Point(331, 32);
            this.lblUpdateTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateTicket.Name = "lblUpdateTicket";
            this.lblUpdateTicket.Size = new System.Drawing.Size(286, 31);
            this.lblUpdateTicket.TabIndex = 23;
            this.lblUpdateTicket.Text = "Update Incident Ticket";
            // 
            // dtpDateReported
            // 
            this.dtpDateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateReported.Location = new System.Drawing.Point(412, 97);
            this.dtpDateReported.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateReported.Name = "dtpDateReported";
            this.dtpDateReported.Size = new System.Drawing.Size(328, 23);
            this.dtpDateReported.TabIndex = 22;
            // 
            // cmbReportedUsers
            // 
            this.cmbReportedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportedUsers.FormattingEnabled = true;
            this.cmbReportedUsers.Location = new System.Drawing.Point(412, 200);
            this.cmbReportedUsers.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReportedUsers.Name = "cmbReportedUsers";
            this.cmbReportedUsers.Size = new System.Drawing.Size(328, 23);
            this.cmbReportedUsers.TabIndex = 19;
            // 
            // cmbTypeIncident
            // 
            this.cmbTypeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeIncident.FormattingEnabled = true;
            this.cmbTypeIncident.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.cmbTypeIncident.Location = new System.Drawing.Point(412, 165);
            this.cmbTypeIncident.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeIncident.Name = "cmbTypeIncident";
            this.cmbTypeIncident.Size = new System.Drawing.Size(328, 23);
            this.cmbTypeIncident.TabIndex = 18;
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSubmitTicket.Location = new System.Drawing.Point(612, 465);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(128, 32);
            this.btnSubmitTicket.TabIndex = 16;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = true;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(242, 344);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(412, 340);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(328, 109);
            this.txtDescription.TabIndex = 14;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(242, 306);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(137, 17);
            this.lblDeadline.TabIndex = 13;
            this.lblDeadline.Text = "Deadline / Follow Up";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(242, 270);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // lblReportedUser
            // 
            this.lblReportedUser.AutoSize = true;
            this.lblReportedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportedUser.Location = new System.Drawing.Point(242, 205);
            this.lblReportedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportedUser.Name = "lblReportedUser";
            this.lblReportedUser.Size = new System.Drawing.Size(120, 17);
            this.lblReportedUser.TabIndex = 9;
            this.lblReportedUser.Text = "Reported by User";
            // 
            // lblTypeIncident
            // 
            this.lblTypeIncident.AutoSize = true;
            this.lblTypeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeIncident.Location = new System.Drawing.Point(242, 170);
            this.lblTypeIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeIncident.Name = "lblTypeIncident";
            this.lblTypeIncident.Size = new System.Drawing.Size(109, 17);
            this.lblTypeIncident.TabIndex = 7;
            this.lblTypeIncident.Text = "Type of Incident";
            // 
            // lblSubjectIncident
            // 
            this.lblSubjectIncident.AutoSize = true;
            this.lblSubjectIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectIncident.Location = new System.Drawing.Point(242, 136);
            this.lblSubjectIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjectIncident.Name = "lblSubjectIncident";
            this.lblSubjectIncident.Size = new System.Drawing.Size(124, 17);
            this.lblSubjectIncident.TabIndex = 5;
            this.lblSubjectIncident.Text = "Subject of Incident";
            // 
            // txtSubjectIncident
            // 
            this.txtSubjectIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectIncident.Location = new System.Drawing.Point(412, 132);
            this.txtSubjectIncident.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectIncident.Name = "txtSubjectIncident";
            this.txtSubjectIncident.Size = new System.Drawing.Size(328, 23);
            this.txtSubjectIncident.TabIndex = 4;
            // 
            // lblDateReported
            // 
            this.lblDateReported.AutoSize = true;
            this.lblDateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReported.Location = new System.Drawing.Point(242, 100);
            this.lblDateReported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReported.Name = "lblDateReported";
            this.lblDateReported.Size = new System.Drawing.Size(144, 17);
            this.lblDateReported.TabIndex = 3;
            this.lblDateReported.Text = "Date / Time Reported";
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelTicket.Location = new System.Drawing.Point(412, 464);
            this.btnCancelTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(118, 32);
            this.btnCancelTicket.TabIndex = 2;
            this.btnCancelTicket.Text = "CANCEL";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // lblCreateNewTicket
            // 
            this.lblCreateNewTicket.AutoSize = true;
            this.lblCreateNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F);
            this.lblCreateNewTicket.Location = new System.Drawing.Point(308, 32);
            this.lblCreateNewTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateNewTicket.Name = "lblCreateNewTicket";
            this.lblCreateNewTicket.Size = new System.Drawing.Size(342, 31);
            this.lblCreateNewTicket.TabIndex = 0;
            this.lblCreateNewTicket.Text = "Create New Incident Ticket";
            // 
            // pnlFaq
            // 
            this.pnlFaq.Controls.Add(this.btnFilterShowAll);
            this.pnlFaq.Controls.Add(this.btnAddFaq);
            this.pnlFaq.Controls.Add(this.btnFilterService);
            this.pnlFaq.Controls.Add(this.btnFilterSoftware);
            this.pnlFaq.Controls.Add(this.btnFilterHardware);
            this.pnlFaq.Controls.Add(this.listViewFaq);
            this.pnlFaq.Controls.Add(this.lblFaq);
            this.pnlFaq.Location = new System.Drawing.Point(225, 106);
            this.pnlFaq.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFaq.Name = "pnlFaq";
            this.pnlFaq.Size = new System.Drawing.Size(946, 509);
            this.pnlFaq.TabIndex = 22;
            // 
            // btnFilterShowAll
            // 
            this.btnFilterShowAll.Location = new System.Drawing.Point(52, 458);
            this.btnFilterShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterShowAll.Name = "btnFilterShowAll";
            this.btnFilterShowAll.Size = new System.Drawing.Size(82, 28);
            this.btnFilterShowAll.TabIndex = 13;
            this.btnFilterShowAll.Text = "Show All";
            this.btnFilterShowAll.UseVisualStyleBackColor = true;
            this.btnFilterShowAll.Click += new System.EventHandler(this.btnFilterShowAll_Click);
            // 
            // btnAddFaq
            // 
            this.btnAddFaq.Location = new System.Drawing.Point(826, 454);
            this.btnAddFaq.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFaq.Name = "btnAddFaq";
            this.btnAddFaq.Size = new System.Drawing.Size(82, 28);
            this.btnAddFaq.TabIndex = 12;
            this.btnAddFaq.Text = "Add FAQ";
            this.btnAddFaq.UseVisualStyleBackColor = true;
            this.btnAddFaq.Click += new System.EventHandler(this.SwitchPanel);
            // 
            // btnFilterService
            // 
            this.btnFilterService.Location = new System.Drawing.Point(390, 458);
            this.btnFilterService.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterService.Name = "btnFilterService";
            this.btnFilterService.Size = new System.Drawing.Size(82, 28);
            this.btnFilterService.TabIndex = 11;
            this.btnFilterService.Text = "Service";
            this.btnFilterService.UseVisualStyleBackColor = true;
            this.btnFilterService.Click += new System.EventHandler(this.btnFilterService_Click);
            // 
            // btnFilterSoftware
            // 
            this.btnFilterSoftware.Location = new System.Drawing.Point(279, 458);
            this.btnFilterSoftware.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterSoftware.Name = "btnFilterSoftware";
            this.btnFilterSoftware.Size = new System.Drawing.Size(82, 28);
            this.btnFilterSoftware.TabIndex = 10;
            this.btnFilterSoftware.Text = "Software";
            this.btnFilterSoftware.UseVisualStyleBackColor = true;
            this.btnFilterSoftware.Click += new System.EventHandler(this.btnFilterSoftware_Click);
            // 
            // btnFilterHardware
            // 
            this.btnFilterHardware.Location = new System.Drawing.Point(165, 458);
            this.btnFilterHardware.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterHardware.Name = "btnFilterHardware";
            this.btnFilterHardware.Size = new System.Drawing.Size(82, 28);
            this.btnFilterHardware.TabIndex = 9;
            this.btnFilterHardware.Text = "Hardware";
            this.btnFilterHardware.UseVisualStyleBackColor = true;
            this.btnFilterHardware.Click += new System.EventHandler(this.btnFilterHardware_Click);
            // 
            // listViewFaq
            // 
            this.listViewFaq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Questions,
            this.Answers});
            this.listViewFaq.FullRowSelect = true;
            this.listViewFaq.GridLines = true;
            this.listViewFaq.HideSelection = false;
            this.listViewFaq.Location = new System.Drawing.Point(52, 63);
            this.listViewFaq.Name = "listViewFaq";
            this.listViewFaq.Size = new System.Drawing.Size(857, 373);
            this.listViewFaq.TabIndex = 4;
            this.listViewFaq.UseCompatibleStateImageBehavior = false;
            this.listViewFaq.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Questions
            // 
            this.Questions.Text = "Questions";
            this.Questions.Width = 550;
            // 
            // Answers
            // 
            this.Answers.Text = "Answers";
            this.Answers.Width = 550;
            // 
            // lblFaq
            // 
            this.lblFaq.AutoSize = true;
            this.lblFaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaq.Location = new System.Drawing.Point(48, 24);
            this.lblFaq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaq.Name = "lblFaq";
            this.lblFaq.Size = new System.Drawing.Size(236, 22);
            this.lblFaq.TabIndex = 0;
            this.lblFaq.Text = "Frequently Asked Questions";
            // 
            // pnlAddFaq
            // 
            this.pnlAddFaq.Controls.Add(this.btnCancelFaq);
            this.pnlAddFaq.Controls.Add(this.cmbTypeQuestion);
            this.pnlAddFaq.Controls.Add(this.lblType);
            this.pnlAddFaq.Controls.Add(this.txtAnswer);
            this.pnlAddFaq.Controls.Add(this.lblAnswer);
            this.pnlAddFaq.Controls.Add(this.btnSubmitFaq);
            this.pnlAddFaq.Controls.Add(this.txtQuestion);
            this.pnlAddFaq.Controls.Add(this.lblQuestion);
            this.pnlAddFaq.Controls.Add(this.lblAddNewFaq);
            this.pnlAddFaq.Location = new System.Drawing.Point(224, 108);
            this.pnlAddFaq.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddFaq.Name = "pnlAddFaq";
            this.pnlAddFaq.Size = new System.Drawing.Size(948, 509);
            this.pnlAddFaq.TabIndex = 14;
            // 
            // btnCancelFaq
            // 
            this.btnCancelFaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFaq.Location = new System.Drawing.Point(377, 313);
            this.btnCancelFaq.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelFaq.Name = "btnCancelFaq";
            this.btnCancelFaq.Size = new System.Drawing.Size(112, 36);
            this.btnCancelFaq.TabIndex = 9;
            this.btnCancelFaq.Text = "CANCEL";
            this.btnCancelFaq.UseVisualStyleBackColor = true;
            this.btnCancelFaq.Click += new System.EventHandler(this.btnCancelFaq_Click);
            // 
            // cmbTypeQuestion
            // 
            this.cmbTypeQuestion.FormattingEnabled = true;
            this.cmbTypeQuestion.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.cmbTypeQuestion.Location = new System.Drawing.Point(377, 267);
            this.cmbTypeQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeQuestion.Name = "cmbTypeQuestion";
            this.cmbTypeQuestion.Size = new System.Drawing.Size(328, 21);
            this.cmbTypeQuestion.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(275, 262);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(377, 227);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(328, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(275, 227);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(54, 17);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answer";
            // 
            // btnSubmitFaq
            // 
            this.btnSubmitFaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitFaq.Location = new System.Drawing.Point(578, 313);
            this.btnSubmitFaq.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitFaq.Name = "btnSubmitFaq";
            this.btnSubmitFaq.Size = new System.Drawing.Size(127, 36);
            this.btnSubmitFaq.TabIndex = 4;
            this.btnSubmitFaq.Text = "SUBMIT FAQ";
            this.btnSubmitFaq.UseVisualStyleBackColor = true;
            this.btnSubmitFaq.Click += new System.EventHandler(this.btnSubmitFaq_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(377, 191);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(328, 20);
            this.txtQuestion.TabIndex = 3;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(275, 191);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(65, 17);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question";
            // 
            // lblAddNewFaq
            // 
            this.lblAddNewFaq.AutoSize = true;
            this.lblAddNewFaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F);
            this.lblAddNewFaq.Location = new System.Drawing.Point(273, 84);
            this.lblAddNewFaq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewFaq.Name = "lblAddNewFaq";
            this.lblAddNewFaq.Size = new System.Drawing.Size(459, 31);
            this.lblAddNewFaq.TabIndex = 1;
            this.lblAddNewFaq.Text = "Add New Frequently Asked Question";
            // 
            // pnlMonitoring
            // 
            this.pnlMonitoring.Location = new System.Drawing.Point(227, 106);
            this.pnlMonitoring.Name = "pnlMonitoring";
            this.pnlMonitoring.Size = new System.Drawing.Size(3000, 3000);
            this.pnlMonitoring.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(0, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "*Click on the User ID to Edit User";
            // 
            // pnlAnalysis
            // 
            this.pnlAnalysis.Controls.Add(this.label5);
            this.pnlAnalysis.Controls.Add(this.lblWeekDates);
            this.pnlAnalysis.Controls.Add(this.btnWeekDecrement);
            this.pnlAnalysis.Controls.Add(this.btnWeekIncrement);
            this.pnlAnalysis.Controls.Add(this.lblWeek);
            this.pnlAnalysis.Controls.Add(this.btnAnalysisBack);
            this.pnlAnalysis.Controls.Add(this.chartAnalysis);
            this.pnlAnalysis.Location = new System.Drawing.Point(238, 111);
            this.pnlAnalysis.Name = "pnlAnalysis";
            this.pnlAnalysis.Size = new System.Drawing.Size(945, 507);
            this.pnlAnalysis.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tickets";
            // 
            // lblWeekDates
            // 
            this.lblWeekDates.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekDates.Location = new System.Drawing.Point(349, 34);
            this.lblWeekDates.Name = "lblWeekDates";
            this.lblWeekDates.Size = new System.Drawing.Size(266, 23);
            this.lblWeekDates.TabIndex = 9;
            this.lblWeekDates.Text = "2020 Jan 13 - 2020 Jan 19";
            this.lblWeekDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWeekDecrement
            // 
            this.btnWeekDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekDecrement.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekDecrement.Location = new System.Drawing.Point(420, 80);
            this.btnWeekDecrement.Name = "btnWeekDecrement";
            this.btnWeekDecrement.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.btnWeekDecrement.Size = new System.Drawing.Size(20, 26);
            this.btnWeekDecrement.TabIndex = 8;
            this.btnWeekDecrement.Text = "<";
            this.btnWeekDecrement.UseVisualStyleBackColor = true;
            this.btnWeekDecrement.Click += new System.EventHandler(this.BtnWeekDecrement_Click);
            // 
            // btnWeekIncrement
            // 
            this.btnWeekIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekIncrement.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekIncrement.Location = new System.Drawing.Point(533, 80);
            this.btnWeekIncrement.Name = "btnWeekIncrement";
            this.btnWeekIncrement.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.btnWeekIncrement.Size = new System.Drawing.Size(20, 26);
            this.btnWeekIncrement.TabIndex = 7;
            this.btnWeekIncrement.Text = ">";
            this.btnWeekIncrement.UseVisualStyleBackColor = true;
            this.btnWeekIncrement.Click += new System.EventHandler(this.BtnWeekIncrement_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.Location = new System.Drawing.Point(438, 81);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(100, 23);
            this.lblWeek.TabIndex = 6;
            this.lblWeek.Text = "Week 1";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnalysisBack
            // 
            this.btnAnalysisBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(124)))), ((int)(((byte)(218)))));
            this.btnAnalysisBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnalysisBack.Location = new System.Drawing.Point(865, 459);
            this.btnAnalysisBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalysisBack.Name = "btnAnalysisBack";
            this.btnAnalysisBack.Size = new System.Drawing.Size(65, 36);
            this.btnAnalysisBack.TabIndex = 5;
            this.btnAnalysisBack.Text = "Back";
            this.btnAnalysisBack.UseVisualStyleBackColor = false;
            this.btnAnalysisBack.Click += new System.EventHandler(this.BtnAnalysisBack_Click);
            // 
            // chartAnalysis
            // 
            this.chartAnalysis.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartAnalysis.ChartAreas.Add(chartArea4);
            this.chartAnalysis.Location = new System.Drawing.Point(201, 121);
            this.chartAnalysis.Name = "chartAnalysis";
            this.chartAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Name = "Series1";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chartAnalysis.Series.Add(series4);
            this.chartAnalysis.Size = new System.Drawing.Size(551, 316);
            this.chartAnalysis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1251, 699);
            this.Controls.Add(this.pnlUserManagment);
            this.Controls.Add(this.PnlDashBoard);
            this.Controls.Add(this.pnlAnalysis);
            this.Controls.Add(this.pnlFaq);
            this.Controls.Add(this.pnlIncidentManagement);
            this.Controls.Add(this.pnlMonitoring);
            this.Controls.Add(this.pnlCreateTicket);
            this.Controls.Add(this.pnlAddUser);
            this.Controls.Add(this.pnlAddFaq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlDashBoard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTickets)).EndInit();
            this.pnlUserManagment.ResumeLayout(false);
            this.pnlUserManagment.PerformLayout();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            this.pnlIncidentManagement.ResumeLayout(false);
            this.pnlIncidentManagement.PerformLayout();
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.pnlFaq.ResumeLayout(false);
            this.pnlFaq.PerformLayout();
            this.pnlAddFaq.ResumeLayout(false);
            this.pnlAddFaq.PerformLayout();
            this.pnlAnalysis.ResumeLayout(false);
            this.pnlAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnUserManager;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel PnlDashBoard;
        private System.Windows.Forms.Panel pnlUserManagment;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTickets;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.TextBox txtFirstNameAdd;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.TextBox txtLastnameAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private FontAwesome.Sharp.IconButton btnComfirmAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdateIncident;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnDiscardAddUser;
        private System.Windows.Forms.Label lblErrorMessage;
        private FontAwesome.Sharp.IconButton btnPasswordHideShow;
        private FontAwesome.Sharp.IconButton btnFaq;
        private FontAwesome.Sharp.IconButton btnIncidents;
        private System.Windows.Forms.TextBox txtSearchIncident;
        private FontAwesome.Sharp.IconButton btnSearchIncident;
        private System.Windows.Forms.ListView listViewIncidents;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Panel pnlIncidentManagement;
        private System.Windows.Forms.Panel pnlCreateTicket;
        private System.Windows.Forms.ComboBox cmbReportedUsers;
        private System.Windows.Forms.ComboBox cmbTypeIncident;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblReportedUser;
        private System.Windows.Forms.Label lblTypeIncident;
        private System.Windows.Forms.Label lblSubjectIncident;
        private System.Windows.Forms.TextBox txtSubjectIncident;
        private System.Windows.Forms.Label lblDateReported;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Panel pnlFaq;
        private System.Windows.Forms.Button btnAddFaq;
        private System.Windows.Forms.Button btnFilterService;
        private System.Windows.Forms.Button btnFilterSoftware;
        private System.Windows.Forms.Button btnFilterHardware;
        private System.Windows.Forms.ListView listViewFaq;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Questions;
        private System.Windows.Forms.ColumnHeader Answers;
        private System.Windows.Forms.Label lblFaq;
        private System.Windows.Forms.Panel pnlAddFaq;
        private System.Windows.Forms.ComboBox cmbTypeQuestion;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnSubmitFaq;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAddNewFaq;
        private System.Windows.Forms.DateTimePicker dtpDateReported;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.Button btnCancelFaq;
        private System.Windows.Forms.Button btnDeleteIncident;
        private System.Windows.Forms.Button btnEditIncident;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Label lblUpdateTicket;
        private System.Windows.Forms.Label lblCreateNewTicket;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.ListView listViewUserMnagment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Tickets;
        private System.Windows.Forms.ColumnHeader UserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private FontAwesome.Sharp.IconButton btnMonitoringSystem;
        private System.Windows.Forms.Panel pnlMonitoring;
        private System.Windows.Forms.ColumnHeader Priority;
		private System.Windows.Forms.Button btnAnalysis;
		private System.Windows.Forms.Panel pnlAnalysis;
		private System.Windows.Forms.Label lblWeekDates;
		private System.Windows.Forms.Button btnWeekDecrement;
		private System.Windows.Forms.Button btnWeekIncrement;
		private System.Windows.Forms.Label lblWeek;
		private System.Windows.Forms.Button btnAnalysisBack;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
		private System.Windows.Forms.Label lblTicketCount;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnFilterShowAll;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblInProgressTicketCount;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblOpenTicketCount;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

