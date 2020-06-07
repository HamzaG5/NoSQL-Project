using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Globalization;

using MongoDB.Driver;
using MongoDB.Bson;
using FontAwesome.Sharp;
//using EASendMail;

using NoSql_Logic;
using NoSql_Model;



namespace desktop_app
{
    public partial class Form1 : Form
    {
        #region MyClass definition
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //colors struct 
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Services
        private Faq_Service faq_Service = new Faq_Service();
        private User_Service user_Service = new User_Service();
        private Ticket_Service ticket_Service = new Ticket_Service();
        #endregion
        public Form1(User user)
        {
            InitializeComponent();            
            lblUserID.Text = "User ID: "+user.Id.ToString()+", User Name: "+user.UserName;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //test user show params
            CreateAlertPanelElements();
            //fill user managment test view 
            txtPasswordAdd.UseSystemPasswordChar = true;
            FillUserManagerPanel();
            //filter text bar test items
            FilterTextChanged();
            //hide all panels
            HideAllPanels();
            //password secured
            //ticket Data
            DisplayTicketsOverview(); // display ticket list
            FillCmbReportedUser(); // fill combobox with users
            //display faq data
            DisplayFaqOverview();
            CreateUserPrevilege(user.Type);
            MenuBtnClick(btnDashboard,new EventArgs());
        }
        private void CreateUserPrevilege(string privilege)
        {
            Label userPrivilege = new Label();
            userPrivilege.Name = "lblPrivilege";
            userPrivilege.Tag = privilege;
            userPrivilege.Text = privilege;
            userPrivilege.Location = new Point(100,100);
            userPrivilege.ForeColor = Color.Black; 
            this.Controls.Add(userPrivilege);
        }
		#region Dashboard
		public void InitDashboard()
		{
			Dashboard_Service dashboardService = new Dashboard_Service();

			List<Ticket> openTickets = dashboardService.GetTicketsByStatus("Open");
			List<Ticket> inProgressTickets = dashboardService.GetTicketsByStatus("In Progress");

			lblTicketCount.Text = (openTickets.Count + inProgressTickets.Count).ToString();
			lblOpenTicketCount.Text = openTickets.Count.ToString();
			lblInProgressTicketCount.Text = inProgressTickets.Count.ToString();

			chartTickets.Series[0].Points.Clear();
			chartTickets.Series[0].Points.AddY(openTickets.Count);
			chartTickets.Series[0].Points.AddY(inProgressTickets.Count);
			chartTickets.Series[0].Points[0].Color = Color.FromArgb(225, 182, 47);
			chartTickets.Series[0].Points[1].Color = Color.FromArgb(255, 143, 67);
		}

		private void BtnAnalysis_Click(object sender, EventArgs e)
		{
			ShowHidePanel((Button)sender);
		}
		#endregion

		#region Analysis
		public void InitAnalysis()
		{
			Analysis_Service analysisService = new Analysis_Service();
			List<Ticket> tickets = analysisService.GetTickets();
			DateTime week = Analysis_Service.Week;
			Console.WriteLine("Loaded: " + week);
			lblWeek.Text = "Week " + analysisService.GetWeekOfYear(week);

			DateTime startOfWeek = analysisService.StartOfWeek(week);
			DateTime endOfWeek = analysisService.EndOfWeek(week);
			lblWeekDates.Text = string.Format("{0} {1} {2} - {3} {4} {5}",
				startOfWeek.Year, startOfWeek.ToString("MMM"), startOfWeek.Day,
				endOfWeek.Year, endOfWeek.ToString("MMM"), endOfWeek.Day);

			List<Ticket>[] ticketsByDayOfWeek = analysisService.SortTicketsByDayOfWeek(tickets, week);
			chartAnalysis.Series[0].Points.Clear();
			chartAnalysis.Series[0].Points.AddXY("Mon", ticketsByDayOfWeek[1].Count);
			chartAnalysis.Series[0].Points.AddXY("Tue", ticketsByDayOfWeek[2].Count);
			chartAnalysis.Series[0].Points.AddXY("Wed", ticketsByDayOfWeek[3].Count);
			chartAnalysis.Series[0].Points.AddXY("Thu", ticketsByDayOfWeek[4].Count);
			chartAnalysis.Series[0].Points.AddXY("Fri", ticketsByDayOfWeek[5].Count);
			chartAnalysis.Series[0].Points.AddXY("Sat", ticketsByDayOfWeek[6].Count);
			chartAnalysis.Series[0].Points.AddXY("Sun", ticketsByDayOfWeek[0].Count);
		}

		private void BtnWeekIncrement_Click(object sender, EventArgs e)
		{
			Analysis_Service analysisService = new Analysis_Service();
			Analysis_Service.Week = Analysis_Service.Week.AddDays(7);
			InitAnalysis();
		}

		private void BtnWeekDecrement_Click(object sender, EventArgs e)
		{
			Analysis_Service analysisService = new Analysis_Service();
			Analysis_Service.Week = Analysis_Service.Week.AddDays(-7);
			InitAnalysis();
		}

		private void BtnAnalysisBack_Click(object sender, EventArgs e)
		{
			ShowHidePanel((Button)sender);
		}
		#endregion

		#region ADD User_UserManagement_Rasheed
		private void PasswordHideShow(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            IconChar icon = new IconChar();
            IconChar eye = (IconChar)61550;
            IconChar eyeSlash = (IconChar)61552;

            if (btn.IconChar == eye)
            {
                icon = eyeSlash;
                txtPasswordAdd.UseSystemPasswordChar = false;
            }
            else
            {
                icon = eye;
                txtPasswordAdd.UseSystemPasswordChar = true;
            }
            btn.IconChar = icon;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion
        #region Hide&Show Panels
        private void HideAllPanels()
        {
			PnlDashBoard.Hide();
			pnlAnalysis.Hide();
			pnlUserManagment.Hide();
			pnlAddUser.Hide();
            pnlIncidentManagement.Hide();
            pnlCreateTicket.Hide();
            pnlFaq.Hide();
            pnlAddFaq.Hide();
            pnlMonitoring.Hide();
        }
        private void ShowHidePanel(Button btn)
        {
            HideAllPanels();

			if (btn.Name == "btnDashboard" || btn.Name == "btnAnalysisBack")
			{
				InitDashboard();
				PnlDashBoard.Show();
			}
			else if (btn.Name == "btnAnalysis")
			{
				InitAnalysis();
				pnlAnalysis.Show();
			}
			else if (btn.Name == "btnUserManager")
			{
                pnlUserManagment.Show();

            }
            else if (btn.Name == "btnDashboard")
            {
                PnlDashBoard.Show();
            }
            else if (btn.Name == "btnAddUser")
            {
                pnlAddUser.Show();
            }
            else if (btn.Name == "btnIncidents" || btn.Name == "btnSubmitTicket" || btn.Name == "btnUpdateTicket" || btn.Name == "btnCancelTicket")
            {
                listViewIncidents.Items.Clear(); //  clear listview incidents
                DisplayTicketsOverview(); // display ticket list
                pnlIncidentManagement.Show();
            }
            else if (btn.Name == "btnFaq" || btn.Name == "btnSubmitFaq" || btn.Name == "btnCancelFaq")
            {
                pnlFaq.Show();
                listViewFaq.Items.Clear();
                DisplayFaqOverview();
            }
            else if (btn.Name == "btnAddFaq")
            {
                pnlAddFaq.Show();
            }
            else if (btn.Name == "btnMonitoringSystem")
            {
                pnlMonitoring.Show();
            }
        }
        #endregion
        #region UI_Rasheed
        private Color ColorSelector(Button btn)
        {
            if (btn.Name == "btnUserManager")
            {
                return RGBColors.color2;
            }
            else if (btn.Name == "btnDashboard")
            {
                return RGBColors.color1;
            }
            else if (btn.Name == "btnTest")
            {
                return RGBColors.color3;
            }
            else if (btn.Name == "btnIncidents")
            {
                return RGBColors.color6;
            }
            else if (btn.Name == "btnFaq")
            {
                return RGBColors.color3;
            }
            else if (btn.Name == "btnMonitoringSystem")
            {
                return RGBColors.color4;
            }
            return RGBColors.color5;
        }
        private void CreateAlertPanelElements()
        {
            //get tickets
            Ticket_Service ticketService = new Ticket_Service();
            List<Ticket> tickets = ticketService.GetTickets();
            //Assign margin
            int marginLeft = 0;
            int marginTop = 0;
            int i = 0;
            int numberInSet = 0;
            
            foreach (Ticket ticket in tickets)
            {
                int modelo = numberInSet % 4;
                i++;
                string panelName = "ticket" + i;
                Panel ticketPanel = PaintTicketAlertPanel(panelName, marginLeft, marginTop);
                pnlMonitoring.Controls.Add(ticketPanel);
                Color urgency = ReporTicketDateTimeUrgency(ticket);
                PaintTicketAlertPanelElements(0, 0, ticketPanel, ticket.User, ticket.Id.ToString(), ticket.Status, ticket.Subject, urgency);
                marginTop += 110;
                if (numberInSet>3 && modelo ==0)
                {
                    marginLeft+= 310;
                    marginTop = 0;
                }
                numberInSet++;
            }
        }
        
        private int AlertTicketsAlign(int input)
        {
            int align = input + 310;
            return align;
        }
        private Color ReporTicketDateTimeUrgency(Ticket ticket)
        {
            Color color = new Color();
            string priority = ticket.Priority;
            if (priority == "Medium")
            {
                return Color.Yellow;
            }
            
            else if (priority == "High")
            {
                return Color.OrangeRed;
            }
            return Color.Black;
        }
        private void PaintAlertPanel()
        {
            int marginTop = 10;
            int marginLeft = 10;

        }
        private Panel PaintTicketAlertPanel(string pnlName, int marginLeft, int marginTop)
        {
            //create a panel 
            Panel ticketAlarmPanel = new Panel();
            ticketAlarmPanel.Location = new Point(marginLeft, marginTop);            
            ticketAlarmPanel.BackColor = Color.LightBlue;
            ticketAlarmPanel.Size = new Size(300, 100);
            ticketAlarmPanel.Name = pnlName;
            pnlMonitoring.Controls.Add(ticketAlarmPanel);
            return ticketAlarmPanel;
        }
        private void PaintTicketAlertPanelElements(int marginTop, int marginLeft,Panel pnl, string userId, string ticketId,string ticketStatus ,string ticketDesc, Color urgency)
        {            
            Font font = new Font("Calibri", 10);
            
            //ticketAlarmPanel.Size;
            //create the warning sign
            IconPictureBox iconBox = new IconPictureBox();
            iconBox.IconChar = IconChar.Clock;
            iconBox.IconSize = 32;
            iconBox.Location = new Point(marginLeft, marginTop);
            iconBox.IconColor = urgency;
            pnl.Controls.Add(iconBox);
            //create the UserID label
            Point lblUidLocation = new Point(marginLeft + 40, marginTop + 5);
            Label lblUserIDWarning = new Label();
            lblUserIDWarning.Text = "User ID: " + userId;
            lblUserIDWarning.Font = font;
            lblUserIDWarning.AutoSize = true;
            lblUserIDWarning.BackColor = Color.Transparent;
            lblUserIDWarning.Location = lblUidLocation;
            pnl.Controls.Add(lblUserIDWarning);
            //ticket Id
            Point lblTidLocation = new Point(marginLeft + 40, marginTop + 20);
            Label lblTicketIDWarning = new Label();
            lblTicketIDWarning.Text = "Ticket Number: "+ticketId;
            lblTicketIDWarning.Font = font;
            lblTicketIDWarning.ForeColor = Color.Black;
            lblTicketIDWarning.AutoSize = true;
            lblTicketIDWarning.Location = lblTidLocation;
            pnl.Controls.Add(lblTicketIDWarning);
            //Create status
            Point lblStatusLocation = new Point(marginLeft+40, marginTop+40);
            Label lblTicketStatus = new Label();
            lblTicketStatus.Text = "Ticket status: " + ticketStatus;
            lblTicketStatus.Font = font;
            lblTicketStatus.ForeColor = Color.Black;
            lblTicketStatus.AutoSize = true;
            lblTicketStatus.Location = lblStatusLocation;
            pnl.Controls.Add(lblTicketStatus);
            //Create description
            Point descLocation = new Point(marginLeft+40, marginTop+60);
            Label lblTicketDesc = new Label();
            lblTicketDesc.Text = "Ticket description: " +ticketDesc;
            lblTicketDesc.Font = font;
            lblTicketDesc.ForeColor = Color.Black;
            lblTicketDesc.AutoSize = true;
            lblTicketDesc.Location = descLocation;
            pnl.Controls.Add(lblTicketDesc);            
        }
        #endregion
        #region Menu_navigator_Rasheed
        private void MenuBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Color color = ColorSelector(btn);
            lblHeader.Text = btn.Text;
            lblHeader.ForeColor = color;
            //Show panel
            ShowHidePanel(btn);
            //change btn color and font
            ActivateButton(btn, color);
        }
        
        private void SwitchPanel(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //Show panel
            ShowHidePanel(btn);
        }
        #endregion
        #region user_manager_functions_Rasheed
        private void FillUserManagerPanel()
        {
            List<User> users = new List<User>();
            User_Service userService = new User_Service();

            users = userService.GetUsers();

            foreach (var user in users)
            {
                fillGridView(user);
            }
            
        }
        private string TestUser()
        {
            User_Service userService = new User_Service();
            User user = userService.GetLastUser();
            string userString = user.Email;
            return userString;
        }
        private void fillGridView(User user)
        {
            //int tickets = int.Parse(user.Ticket);
            string[] userString = { user.Id.ToString(), user.Email, user.UserName, user.Lastname, user.Ticket.ToString(), user.Type };
            var listViewItem = new ListViewItem(userString);
            listViewUserMnagment.Items.Add(listViewItem);
        }
        private void ConfirmDeclineBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string firstname = txtFirstNameAdd.Text;
            string lastName = txtLastnameAdd.Text;
            string email = txtEmailAdd.Text;
            string password = txtPasswordAdd.Text;
            string type = comboBoxUserType.Text;
            if (firstname.Length>0 && lastName.Length>0 && email.Length>0 && password.Length>0 && type.Length>0)
            {
                if (btn.Name == "btnComfirmAddUser")
                {                    
                    var document = new BsonDocument
                    {
                        { "_id",UserIdAutoIncrement()},
                        { "firstName", firstname},
                        { "lastName", lastName},
                        { "email",email},
                        { "userName", firstname },
                        { "password", password},
                        { "type", type},
                        { "ticket", "0"}//chcek here with hamza
                    };
                    AddUserToDB(document);
                    MessageBox.Show("User has been add to the database succesfully");
                    listViewUserMnagment.Items.Clear();
                    ShowNeededPanel(pnlUserManagment);
                    FillUserManagerPanel();
                    ClearUserInputs();
                }
            }
            else if (btn.Name == "btnDiscardAddUser")
            {
                //hide panel and back to previous
                ClearUserInputs();
                HideAllPanels();
                pnlUserManagment.Show();
                MessageBox.Show("All Inopts has been cleared");
            }
            else
            {
               lblErrorMessage.Text = AddUserErrorMessage(firstname, lastName, password, email, type);
            }
        }
        private void AddUserToDB(BsonDocument userDocument)
        {
            User_Service userService = new User_Service();
            userService.InserUser(userDocument);
        }
        private void ShowNeededPanel(Panel pnl)
        {
            HideAllPanels();
            pnl.Show();
        }
        private int UserIdAutoIncrement()
        {
            User_Service userService = new User_Service();
            int id = int.Parse(userService.GetLastUserID());
            id++;
            return id;
        }
        private void ClearUserInputs()
        {
            txtFirstNameAdd.Clear();
            txtLastnameAdd.Clear();
            txtEmailAdd.Clear();
            txtPasswordAdd.Clear();
        }

        private string AddUserErrorMessage(string firstName, string lastName, string password, string email, string type)
        {
            if (firstName.Length == 0)
            {
                return "*please fill the FirstName field";
            }
            else if (lastName.Length == 0)
            {
                return "*please fill the LastName field";
            }
            else if (email.Length == 0)
            {
                return "*please fill the email field";
            }
            else if (password.Length == 0)
            {
                return "*please fill the Password";
            }
            else if (type.Length == 0)
            {
                return "*please choose a privilege for the user";
            }
            return "";
        }
        #endregion
        
        #region user_manager_filter_textBox_Rasheed
        private void FilterTextChanged()
        {
            txtSearchBar.TextChanged += SearchedText_Changed;
        }
        private void FilterData(string searchTxt)
        {
            if (searchTxt != "")
            {
                foreach (ListViewItem item in listViewUserMnagment.Items)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (searchTxt == item.SubItems[i].Text)
                        {
                            ItemsColorsDefault(listViewUserMnagment);
                            item.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
        private void ItemsColorsDefault(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                item.ForeColor = Color.Black;
            }
        }
        private void SearchedText_Changed(object sender, EventArgs e)
        {
            FilterData(txtSearchBar.Text);
        }
        #endregion
        #region UI_Buttons
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                
                if (item.Name == "lblPrivilege")
                {
                    if (item.Text == "Manager")
                    {
                        Button btn = (Button)sender;
                        ShowHidePanel(btn);
                    }
                    else
                    {
                        MessageBox.Show("you need a certain privilege level to be able to add users");
                    }
                }
            }                    
        }
        #endregion

        #region Hamza - Ticket Functions
        private void DisplayTicketsOverview()
        {
            int counter = 1;
            listViewIncidents.Items.Clear();
            List<Ticket> ticketList = ticket_Service.GetTickets();

            if(ticketList != null) {
                
                foreach (Ticket ticket in ticketList)
                {
                    ListViewItem li = new ListViewItem(counter++.ToString());
                    li.SubItems.Add(ticket.Subject);
                    li.SubItems.Add(ticket.User);
                    li.SubItems.Add(ticket.DateReported.ToString("dd/MM/yyyy"));
                    li.SubItems.Add(ticket.Priority);
                    li.SubItems.Add(ticket.Status);
                    li.Tag = ticket.Id;

                    listViewIncidents.Items.Add(li);
                }
            } else {
                MessageBox.Show("Can't connect to database. Please try again.");
            }
        }

        private void DisplayTicketData(string ticketId)
        {
            Ticket ticket = ticket_Service.GetTicket("_id", ticketId, true); // get ticket data

            // display ticket info in textboxes
            dtpDateReported.Text = ticket.DateReported.ToString();
            txtSubjectIncident.Text = ticket.Subject;
            cmbTypeIncident.Text = ticket.Type;
            cmbReportedUsers.Text = ticket.User;
            cmbPriority.Text = ticket.Priority;
            cmbStatus.Text = ticket.Status;
            dtpDeadline.Text = ticket.Deadline.ToString();
            txtDescription.Text = ticket.Description;
        }

        private void CreateEditTicketBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (btn.Name == "btnCreateIncident")
            {
                ShowNeededPanel(pnlCreateTicket);
                FillCmbReportedUser(); // fill combobox of users
                lblUpdateTicket.Hide();
                lblCreateNewTicket.Show();
                btnSubmitTicket.Show();
                btnUpdateTicket.Hide();
            }
            else
            {
                foreach (Control item in this.Controls)
                {

                    if (item.Name == "lblPrivilege")
                    {
                        if (item.Text == "Manager")
                        {
                            ShowNeededPanel(pnlCreateTicket);
                            FillCmbReportedUser(); // fill combobox of users
                            if (btn.Name == "btnEditIncident")
                            {
                                lblUpdateTicket.Show();
                                lblCreateNewTicket.Hide();
                                btnSubmitTicket.Hide();
                                btnUpdateTicket.Show();

                                if (listViewIncidents.SelectedItems.Count > 0)
                                {
                                    string ticketId = listViewIncidents.SelectedItems[0].Tag.ToString(); // get ticket id
                                    DisplayTicketData(ticketId); // display ticket info
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("you need a certain privilege level to be able to add users");
                        }
                    }
                }
            }                        
        }

        private void btnSearchIncident_Click(object sender, EventArgs e)
        {
            int counter = 1;
            listViewIncidents.Items.Clear();
            string email = txtSearchIncident.Text;
            Ticket ticket = ticket_Service.GetTicket("subject", email, false); // search ticket

            if (ticket != null)
            {
                ListViewItem li = new ListViewItem(counter++.ToString());
                li.SubItems.Add(ticket.Subject);
                li.SubItems.Add(ticket.User);
                li.SubItems.Add(ticket.DateReported.ToString("dd/MM/yyyy"));
                li.SubItems.Add(ticket.Priority);
                li.SubItems.Add(ticket.Status);
                li.Tag = ticket.Id;
                listViewIncidents.Items.Add(li); // display ticket in listview
            } else {
                MessageBox.Show("Incorrect subject inserted. Please enter valid subject");
            }

            txtSearchIncident.Text = ""; // reset search box


        }
        
        private void FillCmbReportedUser()
        {
            cmbReportedUsers.Items.Clear(); // reset combobox
            List<User> userList = user_Service.GetUsers(); // get users

            foreach (User user in userList)
            {
                cmbReportedUsers.Items.Add(user.Email); // add user to combobox
            }
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            string subject = txtSubjectIncident.Text;
            string user = cmbReportedUsers.Text;
            DateTime dateReported = DateTime.Parse(dtpDateReported.Text);
            string type = cmbTypeIncident.Text;
            string priority = cmbPriority.Text;
            string status = cmbStatus.Text;
            DateTime deadline = DateTime.Parse(dtpDeadline.Text);
            string description = txtDescription.Text; 

            Ticket ticket = new Ticket(subject, user, dateReported, priority, status, type, deadline, description);
            ticket_Service.InsertTicket(ticket);

            Button btn = (Button)sender;
            ShowHidePanel(btn); // go to ticket overview

            dtpDateReported.Text = "";
            txtSubjectIncident.Text = "";
            cmbTypeIncident.Text = "";
            cmbReportedUsers.Text = "";
            cmbPriority.Text = "";
            cmbStatus.Text = "";
            dtpDeadline.Text = "";
            txtDescription.Text = "";

            listViewIncidents.Items.Clear(); //  clear listview incidents
            DisplayTicketsOverview(); // display ticket list

            sendConfirmationEmail(user, subject, priority, dateReported, description); //  send email
            //call method
        }
        //add method for email using ^^


        #region brandon individual email part
        static void sendConfirmationEmail(string user, string subject, string priority, DateTime dateReported, string description )
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp-mail.outlook.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential("gardengroup6@outlook.com", "gardengroup1234");

                //mail details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("gardengroup6@outlook.com");
                mailDetails.To.Add($"{user}");
                //bcc .bcc.add();
                mailDetails.Subject = $"Ticket Confirmation - {subject}";
                mailDetails.IsBodyHtml = true;
                mailDetails.Body = $"New Ticket has been logged at {dateReported}." +
                    $" This ticket is of {priority} level." +
                    $"Important Notes: {description}";
                //file attachment
                /*
                if (fileName.Length>0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }*/
                clientDetails.Send(mailDetails);
            }
            catch (Exception)
            {

                throw ;
            }
        }
        #endregion
        private void btnDeleteIncident_Click(object sender, EventArgs e)
        {
            if (listViewIncidents.SelectedItems.Count > 0) // check if item is selected
            {
                String selectedDocument = listViewIncidents.SelectedItems[0].Tag.ToString(); // get ticket ID
                ticket_Service.DeleteTicket(selectedDocument);
                DisplayTicketsOverview(); // show ticket overview
            }
            else
            {
                MessageBox.Show("Please select item first.");
            }
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            string subject = txtSubjectIncident.Text;
            string user = cmbReportedUsers.Text;
            string dateReported = dtpDateReported.Text;
            string type = cmbTypeIncident.Text;
            string priority = cmbPriority.Text;
            string status = cmbStatus.Text;
            string deadline = dtpDeadline.Text;
            string description = txtDescription.Text;

            string ticketId = listViewIncidents.SelectedItems[0].Tag.ToString(); // get ticket ID
            string[] fieldName = { "subject", "user", "date", "type", "priority", "status", "deadline", "description" }; // list of fields to edit
            string[] fieldValue = { subject, user, dateReported, type, priority, status, deadline, description }; // list of values to update

            for (int i = 0; i < fieldName.Length; i++)
            {
                if (fieldName[i] == "date" || fieldName[i] == "deadline")
                {
                    ticket_Service.UpdateTicket(ticketId, fieldName[i], fieldValue[i], true); // edit date field
                    continue;
                }
                ticket_Service.UpdateTicket(ticketId, fieldName[i], fieldValue[i], false); // edit fields
            }

            Button btn = (Button)sender;
            ShowHidePanel(btn); // go to ticket overview

            dtpDateReported.Text = "";
            txtSubjectIncident.Text = "";
            cmbTypeIncident.Text = "";
            cmbReportedUsers.Text = "";
            cmbPriority.Text = "";
            cmbStatus.Text = "";
            dtpDeadline.Text = "";
            txtDescription.Text = "";

            listViewIncidents.Items.Clear(); //  clear listview incidents
            DisplayTicketsOverview(); // display ticket list
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            // reset textboxes
            dtpDateReported.Text = "";
            txtSubjectIncident.Text = "";
            cmbTypeIncident.Text = "";
            cmbReportedUsers.Text = "";
            cmbPriority.Text = "";
            cmbStatus.Text = "";
            dtpDeadline.Text = "";
            txtDescription.Text = "";

            Button btn = (Button)sender;
            ShowHidePanel(btn); // go to ticket overview
        }
        // End Ticket Functions
        #endregion

        #region Hamza - FAQ Functions
        private void FaqOverview(List<Faq> faqList)
        {
            listViewFaq.Items.Clear();

            foreach (Faq faq in faqList)
            {
                ListViewItem li = new ListViewItem(faq.Type);
                li.SubItems.Add(faq.Question);
                li.SubItems.Add(faq.Answer);

                listViewFaq.Items.Add(li); // fill list view with faq data
            }
        }

        private void DisplayFaqOverview()
        {
            List<Faq> faqList = faq_Service.GetAllFaq();
            FaqOverview(faqList);
        }

        private void btnFilterShowAll_Click(object sender, EventArgs e)
        {
            listViewFaq.Items.Clear();
            DisplayFaqOverview();
        }

        private void btnFilterHardware_Click(object sender, EventArgs e)
        {
            List<Faq> specificFaqList = faq_Service.GetSpecificFaq("type", "Hardware"); // filter faq
            FaqOverview(specificFaqList);
        }

        private void btnFilterSoftware_Click(object sender, EventArgs e)
        {
            List<Faq> specificFaqList = faq_Service.GetSpecificFaq("type", "Software"); // filter faq
            FaqOverview(specificFaqList);
        }

        private void btnFilterService_Click(object sender, EventArgs e)
        {
            List<Faq> specificFaqList = faq_Service.GetSpecificFaq("type", "Service"); // filter faq
            FaqOverview(specificFaqList);
        }

        private void btnSubmitFaq_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text;
            string answer = txtAnswer.Text;
            string type = cmbTypeQuestion.Text;

            Faq faq = new Faq(question, answer, type);
            faq_Service.InsertFaq(faq);

            Button btn = (Button)sender;
            ShowHidePanel(btn); // go to faq overview

            txtQuestion.Text = "";
            txtAnswer.Text = "";
            cmbTypeQuestion.Text = "";
        }

        private void btnCancelFaq_Click(object sender, EventArgs e)
        {
            // reset textboxes
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            cmbTypeQuestion.Text = "";

            Button btn = (Button)sender;
            ShowHidePanel(btn); // go to ticket overview
        }

        // End Faq Functions
        #endregion

        private void listViewUserMnagment_Click(object sender, EventArgs e)
        {
            string[] item = ListViewItemString(listViewUserMnagment.SelectedItems[0]);
            EditUserForm form = new EditUserForm(item);
            form.Show();
        }
        private string[] ListViewItemString(ListViewItem listViewItem)
        {
            string firstItem = listViewItem.SubItems[0].Text;
            string secondItem = listViewItem.SubItems[1].Text;
            string thirdItem = listViewItem.SubItems[2].Text;
            string fourthItem = listViewItem.SubItems[3].Text;
            string fifthItem = listViewItem.SubItems[4].Text;
            string[] item = { firstItem, secondItem, thirdItem, fourthItem, fifthItem };
            return item;
        }
	}
}
