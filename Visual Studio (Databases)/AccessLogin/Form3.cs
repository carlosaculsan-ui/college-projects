using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessLogin
{
    public partial class Form3 : Form
    {
        private string firstName;
        private string lastName;
        public Form3(string firstName, string lastName)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            lblFullName.Text = $"Welcome, {firstName} {lastName}";
        }
        public Form3()
        {
            InitializeComponent();
           

        }
        private bool reset = false;

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void ShowCourseSelectionMessage()
        {
            if (!reset)
            {
                MessageBox.Show("You must select a course first.", "Course Selection",

                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void HandleSelectionChanged()
        {
            if (reset) return;

            if (string.IsNullOrEmpty(cbCourse.Text))
            {
                ShowCourseSelectionMessage();
                return;
            }

           
            cbSemester.Enabled = true;
            cbCode.Enabled = true;
            cbCode.Visible = true;
            txtSubject.Text = "";
            txtUnit.Text = "";
        }
        private void cbCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HandleSelectionChanged();
        }

        private void cbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSelectionChanged();
            PopulateSections();

        }
        private void PopulateSections()
        {
            cbSection.Items.Clear(); 

            if (cbYearLevel.SelectedItem == null) return; 

            string selectedYearLevel = cbYearLevel.SelectedItem.ToString();

            
            switch (selectedYearLevel)
            {
                case "1st year":
                    cbSection.Items.Add("1A");
                    cbSection.Items.Add("1B");
                    cbSection.Items.Add("1C");
                    cbSection.Items.Add("1D");
                    break;
                case "2nd year":
                    cbSection.Items.Add("2A");
                    cbSection.Items.Add("2B");
                    cbSection.Items.Add("2C");
                    cbSection.Items.Add("2D");
                    break;
                case "3rd year":
                    cbSection.Items.Add("3A");
                    cbSection.Items.Add("3B");
                    cbSection.Items.Add("3C");
                    cbSection.Items.Add("3D");
                    break;
                case "4th year":
                    cbSection.Items.Add("4A");
                    cbSection.Items.Add("4B");
                    cbSection.Items.Add("4C");
                    cbSection.Items.Add("4D");
                    break;
                default:
                    break;
            }
        }
        private void cbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSelectionChanged();
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (reset) return;

                if (string.IsNullOrEmpty(cbCourse.Text) || string.IsNullOrEmpty(cbYearLevel.Text))
                {
                    ShowCourseSelectionMessage();
                    return;
                }

                cbCode.Items.Clear();
                cbCode.Visible = true;
                cbCode.Enabled = true;

            }

            if (cbCourse.Text == "BSCS")
            {
                if (cbYearLevel.Text == "1st year" && cbSemester.Text == "1st sem")

                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("CC101");
                    cbCode.Items.Add("CC102");
                    cbCode.Items.Add("GE1");
                    cbCode.Items.Add("GE2");
                    cbCode.Items.Add("GE3");
                    cbCode.Items.Add("NSTP1");
                    cbCode.Items.Add("PE1");
                    cbCode.Items.Add("PDP1");
                }
                else if (cbYearLevel.Text == "1st year" && cbSemester.Text == "2nd sem")
                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("CC103");
                    cbCode.Items.Add("GE4");
                    cbCode.Items.Add("GE5");
                    cbCode.Items.Add("GE6");
                    cbCode.Items.Add("DS101");

                    cbCode.Items.Add("NSTP2");
                    cbCode.Items.Add("PE2");
                    cbCode.Items.Add("PDP2");
                }
                else if (cbYearLevel.Text == "2nd year" && cbSemester.Text == "1st sem")
                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("GE7");
                    cbCode.Items.Add("GE8");

                    cbCode.Items.Add("CC104");
                    cbCode.Items.Add("DS102");
                    cbCode.Items.Add("SDF104");
                    cbCode.Items.Add("PE3");
                    cbCode.Items.Add("PDP3");
                }
                else if (cbYearLevel.Text == "2nd year" && cbSemester.Text == "2nd sem")
                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("GE9");
                    cbCode.Items.Add("GE10");
                    cbCode.Items.Add("CC105");
                    cbCode.Items.Add("AL101");
                    cbCode.Items.Add("MATH ELE");
                    cbCode.Items.Add("PE4");
                    cbCode.Items.Add("PDP4");
                }
                else if (cbYearLevel.Text == "3rd year" && cbSemester.Text == "1st sem")
                {
                    cbCode.Items.Clear();

                    cbCode.Items.Add("GE11");
                    cbCode.Items.Add("GE12");
                    cbCode.Items.Add("CC106");
                    cbCode.Items.Add("AL102");
                    cbCode.Items.Add("AR101");
                    cbCode.Items.Add("IAS101");
                    cbCode.Items.Add("GV101");
                }

                else if (cbYearLevel.Text == "3rd year" && cbSemester.Text == "2nd sem")
                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("GE13");
                    cbCode.Items.Add("GE14");
                    cbCode.Items.Add("PL101");
                    cbCode.Items.Add("SE101");
                    cbCode.Items.Add("SP101");
                    cbCode.Items.Add("IS101");
                    cbCode.Items.Add("CN101");
                }
                else if (cbYearLevel.Text == "4th year" && cbSemester.Text == "1st sem")
                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("GE15");
                    cbCode.Items.Add("GE16");
                    cbCode.Items.Add("OS101");
                    cbCode.Items.Add("SE102");
                    cbCode.Items.Add("SF101");
                    cbCode.Items.Add("HCI101");
                    cbCode.Items.Add("THS101");

                }
                else if (cbYearLevel.Text == "4th year" && cbSemester.Text == "2nd sem")
                {
                    cbCode.Items.Clear();
                    cbCode.Items.Add("GE17");
                    cbCode.Items.Add("GE18");
                    cbCode.Items.Add("NC101");

                    cbCode.Items.Add("PD101");
                    cbCode.Items.Add("THS102");
                }
                else
                {

                    txtSubject.Text = "";
                    txtUnit.Text = "";
                }
            }
            else
            {
                ShowCourseSelectionMessage();
            }
        }

        private void cbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reset) return;

            if (cbCourse.Text == "BSCS")

            {
                if (cbYearLevel.Text == "1st year" && cbSemester.Text == "1st sem")
                {

                    if (cbCode.Text == "CC101")
                    {

                        txtSubject.Text = "Introduction to Computing";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "CC102")
                    {
                        txtSubject.Text = "Fundamental Programming";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE1")
                    {
                        txtSubject.Text = "Communication Skills 1";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE2")
                    {
                        txtSubject.Text = "Komunikasyon sa Akademikong Pilipino";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE3")
                    {
                        txtSubject.Text = "College Algebra";
                        txtUnit.Text = "3";
                    }

                    else if (cbCode.Text == "NSTP1")
                    {
                        txtSubject.Text = "National Service Training Program 1";
                        txtUnit.Text = "3";
                    }

                    else if (cbCode.Text == "PE1")
                    {
                        txtSubject.Text = "Physical Fitness";
                        txtUnit.Text = "2";
                    }
                    else if (cbCode.Text == "PDP1")
                    {
                        txtSubject.Text = "Professional Development Program 1";
                        txtUnit.Text = "2";
                    }
                    else
                    {
                        txtSubject.Text = "";
                        txtUnit.Text = "";
                    }
                }
                else if (cbYearLevel.Text == "1st year" && cbSemester.Text == "2nd sem")
                {
                    if (cbCode.Text == "CC103")
                    {
                        txtSubject.Text = "Intermediate Programming";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE4")

                    {
                        txtSubject.Text = "Communication Skills";
                        txtUnit.Text = "3";
                    }

                    else if (cbCode.Text == "GE5")
                    {
                        txtSubject.Text = "Pagbasa at Pagsulat Tungo sa Pananaliksik";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE6")
                    {
                        txtSubject.Text = "Art Appreciation";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "DS101")
                    {
                        txtSubject.Text = "Discrete Structure 1";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "NSTP2")
                    {
                        txtSubject.Text = "National Service Program 2";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "PE2")
                    {
                        txtSubject.Text = "Rhythmic Activities";
                        txtUnit.Text = "2";
                    }

                    else if (cbCode.Text == "PDP2")
                    {
                        txtSubject.Text = "Professional Development Program 2";

                        txtUnit.Text = "2";
                    }
                    else
                    {
                        txtSubject.Text = "";
                        txtUnit.Text = "";
                    }
                }
                else if (cbYearLevel.Text == "2nd year" && cbSemester.Text == "1st sem")
                {
                    if (cbCode.Text == "GE7")
                    {
                        txtSubject.Text = "Speech and Oral Communication";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE8")
                    {
                        txtSubject.Text = "Probabilities and Statistics";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "CC104")
                    {
                        txtSubject.Text = "Data Structures and Algorithms";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "DS102")

                    {
                        txtSubject.Text = "Discrete Structures 2";

                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "SDF104")
                    {
                        txtSubject.Text = "Object Oriented Programming";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "PE3")
                    {
                        txtSubject.Text = "Individual & Sports";
                        txtUnit.Text = "2";
                    }
                    else if (cbCode.Text == "PDP3")
                    {
                        txtSubject.Text = "Professional Development Programs 3";
                        txtUnit.Text = "2";
                    }

                    else
                    {
                        txtSubject.Text = "";
                        txtUnit.Text = "";
                    }
                }
                else if (cbYearLevel.Text == "2nd year" && cbSemester.Text == "2nd sem")
                {
                    if (cbCode.Text == "GE9")

                    {

                        txtSubject.Text = "College Physics";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE10")
                    {
                        txtSubject.Text = "Introduction to Literature";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "CC105")
                    {
                        txtSubject.Text = "Information Management";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "AL101")
                    {
                        txtSubject.Text = "Algorithms and Complexity";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "MATH ELE")
                    {
                        txtSubject.Text = "Discrete Mathematics";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "PE4")
                    {
                        txtSubject.Text = "Team Sports";
                        txtUnit.Text = "2";
                    }

                    else if (cbCode.Text == "PDP4")
                    {
                        txtSubject.Text = "Professional Development Programs 4";
                        txtUnit.Text = "2";
                    }
                }
                else if (cbYearLevel.Text == "3rd year" && cbSemester.Text == "1st sem")
                {
                    if (cbCode.Text == "GE11")
                    {
                        txtSubject.Text = "Trigonometry";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE12")
                    {
                        txtSubject.Text = "Philosophy of Man and Ethics";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "CC106")
                    {
                        txtSubject.Text = "Applications Development and Engineering Technologies";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "AL102")
                    {
                        txtSubject.Text = "Automata Theory and Formal Language";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "AR101")

                    {
                        txtSubject.Text = "Architecture and Organization";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "IAS101")
                    {
                        txtSubject.Text = "Information Assurance and Security";
                        txtUnit.Text = "2";
                    }
                    else if (cbCode.Text == "GV101")
                    {
                        txtSubject.Text = "Graphics and Visual Computing";
                        txtUnit.Text = "2";
                    }
                }
                else if (cbYearLevel.Text == "3rd year" && cbSemester.Text == "2nd sem")
                {
                    if (cbCode.Text == "GE13")
                    {
                        txtSubject.Text = "Electricity and Electromagnetism";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE14")
                    {
                        txtSubject.Text = "Life & Works of Rizal";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "PL101")

                    {

                        txtSubject.Text = "Programming Languages";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "SE101")
                    {
                        txtSubject.Text = "Software Engineering 1";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "SP101")
                    {
                        txtSubject.Text = "Social Issues and Professional Practices";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "IS101")
                    {
                        txtSubject.Text = "Intelligent Systems";
                        txtUnit.Text = "2";
                    }
                    else if (cbCode.Text == "CN101")
                    {
                        txtSubject.Text = "Computational Science";
                        txtUnit.Text = "2";
                    }
                }
                else if (cbYearLevel.Text == "4th year" && cbSemester.Text == "1st sem")
                {
                    if (cbCode.Text == "GE15")

                    {
                        txtSubject.Text = "Philippine History and Culture";

                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE16")
                    {
                        txtSubject.Text = "Politics and Governance (w/ Philippine Constitution";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "PL101")
                    {
                        txtSubject.Text = "Operating Systems";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "SE102")
                    {
                        txtSubject.Text = "Software Engineering 2";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "SF101")
                    {
                        txtSubject.Text = "System Fundamentals 1";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "HCI101")
                    {
                        txtSubject.Text = "Human Computer Interation";
                        txtUnit.Text = "2";

                    }
                    else if (cbCode.Text == "THS101")
                    {

                        txtSubject.Text = "CS Thesis Writing 1";
                        txtUnit.Text = "2";
                    }
                }
                else if (cbYearLevel.Text == "4th year" && cbSemester.Text == "2nd sem")
                {
                    if (cbCode.Text == "GE17")
                    {
                        txtSubject.Text = "Economics (w/ Taxation & Agrarian Reform Integrated";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "GE18")
                    {
                        txtSubject.Text = "Asian/Western Civilization";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "NC101")
                    {
                        txtSubject.Text = "Networks and Communications";
                        txtUnit.Text = "3";
                    }
                    else if (cbCode.Text == "PD101")
                    {
                        txtSubject.Text = "Parallel and Distributed Computing";
                        txtUnit.Text = "3";

                    }
                    else if (cbCode.Text == "THS102")
                    {
                        txtSubject.Text = "CS Thesis Writing 2";

                        txtUnit.Text = "3";
                    }

                }
                else
                {
                    txtSubject.Text = "";
                    txtUnit.Text = "";
                }
            }
            else
            {
                ShowCourseSelectionMessage();
            }
            this.Refresh();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset = true;

            txtSubject.Text = "";
            txtUnit.Text = "";

            cbCourse.SelectedIndex = -1;
            cbSection.SelectedIndex = -1;

            cbYearLevel.SelectedIndex = -1;
            cbSemester.SelectedIndex = -1;
            cbSchoolYear.SelectedIndex = -1;
            cbCode.SelectedIndex = -1;

            reset = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

    
