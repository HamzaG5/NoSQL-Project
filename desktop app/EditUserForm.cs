using MongoDB.Bson;
using NoSql_Logic;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app
{
    public partial class EditUserForm : Form
    {
        #region static inputs
        //margin
        int x = 50;
        int y = 50;
        //names array
        int txtBoxIndex = 0;
        string[] textBoxesNames = {"Email", "firstName", "LastName", "Tickets" };
        #endregion
        public EditUserForm(string[] item)
        {
            InitializeComponent();
            InputsSet(item);
            //User_Service userService = new User_Service();
            //User user = userService.GetUserByID(3);
            //lblUserDataTest.Text = user.Type + ", " + user.Password;
        }
        private void InputsSet(string[] item)
        {
            //create ID label
            CreateIDLabel(item[0]);
            for (int i = 1; i < item.Length; i++)
            {
                string input = item[i];
                //inner margin
                Point lblPoint = new Point(x, y);
                //x,y txtBox
                Point txtBoxPoint = new Point(x, y + 30);
                //create label
                CreateLbels(lblPoint);
                //create txtBox
                CreateTxtBoxes(txtBoxPoint, input);
                txtBoxIndex++;
                y += 100;
            }
        }

        private void CreateIDLabel(string id)
        {
            Label lbl = new Label();
            //Point 
            Point idPoint = new Point(10, 10);
            //label
            lbl.Location = idPoint;
            lbl.Name = "lblUserId";
            lbl.Tag = id;
            lbl.Text = "User ID: " + id;
            this.Controls.Add(lbl);
        }

        private void CreateTxtBoxes(Point txtBoxPoint, string input)
        {
            TextBox txtBox = new TextBox();
            txtBox.Name = "txtBox" + textBoxesNames[txtBoxIndex];
            txtBox.Location = txtBoxPoint;
            txtBox.Text = input;
            txtBox.Size = new Size(325, 22);
            this.Controls.Add(txtBox);
        }

        private void CreateLbels(Point lblPoint)
        {
            //Create label
            Label lbl = new Label();
            lbl.Text = textBoxesNames[txtBoxIndex];
            lbl.Location = lblPoint;
            this.Controls.Add(lbl);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Control FindControl(string controlName)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name == controlName)
                {
                    return item;
                }
            }
            return null;
        }
        private void BtnEdit_userManager_Click(object sender, EventArgs e)
        {
            Control txtBoxFirstName = FindControl("txtBox" + textBoxesNames[1]);
            Control txtBoxLastName = FindControl("txtBox" + textBoxesNames[2]);
            Control txtBoxEmail = FindControl("txtBox" + textBoxesNames[0]);            
            Control txtBoxTickets = FindControl("txtBox"+ textBoxesNames[3]);
            Control lblID = FindControl("lblUserId");            
            User_Service userService = new User_Service();
            User user = userService.GetUserByID(int.Parse(lblID.Tag.ToString()));           
            BsonDocument replacement = new BsonDocument
            {
               { "_id",lblID.Tag.ToString()},
               { "firstName", txtBoxFirstName.Text},
               { "lastName", txtBoxLastName.Text},
               { "email",txtBoxEmail.Text},
               { "userName", txtBoxFirstName.Text },
               { "password", user.Password},
               { "type", user.Type},
               { "ticket", txtBoxTickets.Text}
            };
            userService = new User_Service();
            foreach (var item in replacement)
            {                
                userService.UpdateUserById(replacement, lblID.Tag.ToString(), item.Name, item.Value.ToString());
            }            
            MessageBox.Show("chenged successfully");
            this.Close();
        }

        private void BtnDelete_userManager_Click(object sender, EventArgs e)
        {
            Control lblID = FindControl("lblUserId");            
            User_Service userService = new User_Service();
            userService.DeleteUser(lblID.Tag.ToString());
        }
    }
}
