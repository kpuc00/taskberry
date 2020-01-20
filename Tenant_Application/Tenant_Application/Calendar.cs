using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant_Application
{
    public partial class Calendar : Form
    {
        DataAccess db = new DataAccess();
        List<CalendarDay> calendars;


        List<Label> labels; //Stores the labels that need to be updated
        public Calendar()
        {
            InitializeComponent();
            this.calendars = db.GetCalendar();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //No user resizing

            //Each chore is a seperate method for ease of fixing in the future
            //Cramming them inside 1 method will be harder to bugfix
            UpdateAll();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        public void UpdateAll()
        {
            //Each chore is a seperate method for ease of fixing in the future
            //Cramming them inside 1 method will be harder to bugfix
            Chore1();
            UpdateThird(0, labels);
            Chore2();
            UpdateThird(1, labels);
            Chore3();
            UpdateThird(2, labels);
            Chore4();
            UpdateThird(3, labels);
            Chore5();
            UpdateThird(4, labels);
        }

        void Chore1()
        {
            labels = new List<Label>();
            Label[] lbs = { lblMondayThrowThrash, lblTuesdayThrowThrash, lblWednesdayThrowThrash, lblThursdayThrowThrash,
            lblFridayThrowThrash, lblSaturdayThrowThrash, lblSundayThrowThrash };

            labels.AddRange(lbs);
        }

        void Chore2()
        {
            labels.Clear();
            Label[] lbs = { lblMondayWashDishes, lblTuesdayWashDishes, lblWednesdayWashDishes, lblThursdayWashDishes,
            lblFridayWashDishes, lblSaturdayWashDishes, lblSundayWashDishes };

            labels.AddRange(lbs);
        }

        void Chore3()
        {
            labels.Clear();
            Label[] lbs = { lblMondayVacuumFloor, lblTuesdayVacuumFloor, lblWednesdayVacuumFloor, lblThursdayVacuumFloor,
            lblFridayVacuumFloor, lblSaturdayVacuumFloor, lblSundayVacuumFloor };

            labels.AddRange(lbs);
        }

        void Chore4()
        {
            labels.Clear();
            Label[] lbs = { lblMondayMopFloor, lblTuesdayMopFloor, lblWednesdayMopFloor, lblThursdayMopFloor,
            lblFridayMopFloor, lblSaturdayMopFloor, lblSundayMopFLoor };

            labels.AddRange(lbs);
        }

        void Chore5()
        {
            labels.Clear();
            Label[] lbs = { lblMondayShopMisc, lblTuesdayShopMisc, lblWednesdayShopMisc, lblThursdayShopMisc,
            lblFridayShopMisc, lblSaturdayShopMisc, lblSundayShopMisc };

            labels.AddRange(lbs);
        }

        //Only one at a time because i dont wanna send 5 lists of labels
        void UpdateThird(int id, List<Label> labels)
        {
            List<Account> accounts = db.GetAccountData();
            List<string> names = new List<string>(); //Temp storage of all the account names
            string temp = ""; //Temp storage of substringed name
            foreach (Account a in accounts)
            {
                names.Add(a.Name);
            }

            Dictionary<int, string> b = calendars[id].CheckForNames(names); //Stores 1 week of chores inside a dictionary,
                                                                            //only stores TAKEN chores (with a name)
                                                                            //KEY: <0-6>(0 Monday, 1 Tuesday etc.) | VALUE:<account name>(Aleksandar Todorov)

            for (int i = 0; i < 7; i++) //i < 7, because there are 7 days in a week
            {
                if (b.ContainsKey(i)) //If it contains the week day key (0 monday, 2 tuesday etc)
                {
                    if (b[i].Length > 8) //Just a check to make sure it doesn't go over bounds
                    { 
                        temp = b[i]; 
                        labels[i].Text = temp.Substring(0, 8); //Change this if you want to see more of the name
                    } 
                    else 
                    { 
                        labels[i].Text = b[i]; 
                    } 
                }
            }
            foreach(Label l in labels) //Updates the forecolor of taken chores
            {
                if(l.Text != "EMPTY")
                {
                    l.ForeColor = Color.Blue;
                }
            }
        }
    }
}
