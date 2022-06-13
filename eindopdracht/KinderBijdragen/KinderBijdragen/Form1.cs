/*
 * Naam: Steffan van der Werf
 * Datum : 10-06-2022
 * Korte beschrijving : maken ouderbijdragen programma voor een school
 * Opdracht: 2 
 * Bijgeleidende docent: Rob Loves
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderBijdragen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread thread = new Thread(new ThreadStart(startLoading));
            thread.Start();
            Thread.Sleep(1000);
            thread.Abort();
            InitializeComponent();
            LoadSchoolInfo();
        }

        private void startLoading()
        {
            Application.Run(new LoadingScreen());
        }
        private School CreateSchool()
        {
            //get and make School
            DataSet dsSchool = Database.SelectDataFromDatabase("SELECT Name, Id FROM School WHERE Id = 1");
            School school = new School(dsSchool.Tables[0].Rows[0]["Name"].ToString(), (int)dsSchool.Tables[0].Rows[0]["Id"]);

            //get and make Childern
            DataSet dsChild = Database.SelectDataFromDatabase("SELECT Name, BirthDate, Id, SchoolId FROM Child WHERE SchoolId = 1");
            
            foreach (DataRow child in dsChild.Tables[0].Rows)
            {
                Child curChild = new Child(child[0].ToString(), Convert.ToDateTime(child[1].ToString()), (int)child[2], (int)child[3]);
                ParentContribution pc = new ParentContribution(curChild);
                
                // Add childeren and ParentContribution to school
                school.AddChild(curChild);
                school.AddPc(pc);
            }

            return school;
        }

        private void LoadSchoolInfo()
        {
            School school = CreateSchool();

            // Fill the fields with Data
            label3.Text = school.Name;
            label5.Text = "€ " + school.GetTotalProfit().ToString();
            label7.Text = school.GetYoungestChild().ToString() + " Jaar";
            label12.Text = school.GetCountChildPerCat(0, 6).ToString();
            label11.Text = school.GetCountChildPerCat(6, 10).ToString();
            label13.Text = school.GetCountChildPerCat(10, 99999).ToString();
        }

        private void LoadChildernList()
        {
            School school = CreateSchool();

            label17.Text = "";
            label18.Text = "";
            label19.Text = "";

            foreach (ParentContribution pc in school.Pcs)
            {
                label17.Text += pc.Child.Name + "\n";
                label18.Text += pc.Child.GetAge().ToString() + "\n";
                label19.Text += "€ " + pc.CalcContribution().ToString() + "\n";
            }
        }

        //Load the data according to which page is selected
        private void Pane_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(e.TabPage.Name);
            switch (e.TabPage.Name)
            {
                case "SchoolInfoPane":
                    LoadSchoolInfo();
                    break;
                case "ChildernListPane":
                    LoadChildernList();
                    break;
                default:
                    break;
            }
        }

        //Events to Add en click buttons
        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Child(SchoolId, Name, BirthDate) VALUES(1, @Name, @BirthDate)";
            SqlCommand cmd = new SqlCommand(query, Database.OpenSqlConnection());

            string dateString = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string name = textBox1.Text;
            if (!name.Equals(string.Empty)) {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@BirthDate", dateString);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesvol Toegevoegd");
            }
            else
            {
                MessageBox.Show("Voer alle velden in");
            }
        }

        private void showApp()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void hideApp(object sender, EventArgs e)
        {
            Hide();
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            showApp();
        }

        private void openAbout(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
        private void openSchoolPane(object sender, EventArgs e) 
        {
            showApp();
            tabControl1.SelectedTab = tabControl1.TabPages["SchoolInfoPane"];
        }

        private void openChildListPane(object sender, EventArgs e)
        {
            showApp();
            tabControl1.SelectedTab = tabControl1.TabPages["ChildernListPane"];
        } 
        private void openAddChildPane(object sender, EventArgs e)
        {
            showApp();
            tabControl1.SelectedTab = tabControl1.TabPages["AddChildernPane"];
        }
    }
}
