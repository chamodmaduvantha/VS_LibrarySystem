using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Home : Form
    {
        function fn = new function();
        String query;
        public Home()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Clear Student
        public void StudentClearAll()
        {
            comboNcourse.SelectedIndex = -1;
            comboNfaculity.SelectedIndex = -1;
            txtNname.Clear();
            txtNstuid.Clear();
            txtNaddress.Clear();
            txtNtpno.Clear();
            txtNnic.Clear();

        }



        private void label28_Click(object sender, EventArgs e)
        {

        }

        //New Student
        private void button10_Click(object sender, EventArgs e)
        {
            if (txtNstuid.Text == "" || txtNname.Text == "" || txtNaddress.Text == "")
            {
                MessageBox.Show("Invalied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    query = "insert into student(Student_ID,Student_Name,Address,TP_NO,Course_Name,Faculity_Name,NIC_NO) values('" + txtNstuid.Text + "','" + txtNname.Text + "','" + txtNaddress.Text + "','" + txtNtpno.Text + "','" + comboNcourse.Text + "','" + comboNfaculity.Text + "','" + txtNnic.Text + "')";
                    fn.setData(query);
                    StudentClearAll();
                    MessageBox.Show("Successfully Data Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Student ID allready exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Clear Book
        public void BookClearAll()
        {
            comboBcategoy.SelectedIndex = -1;
            txtBbookid.Clear();
            txtBname.Clear();
            txtBauother.Clear();
            txtBprice.Clear();
            txtByear.Clear();

        }


        //New Book
        private void button12_Click(object sender, EventArgs e)
        {

            if (txtBbookid.Text == "" || txtBname.Text == "" || txtBauother.Text == "")
            {
                MessageBox.Show("Book ID allready exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    query = "insert into book(Book_ID,Book_Name,Category,Auother,Price,Publish_Year) values('" + txtBbookid.Text + "','" + txtBname.Text + "','" + comboBcategoy.Text + "','" + txtBauother.Text + "','" + txtBprice.Text + "','" + txtByear.Text + "')";
                    fn.setData(query);
                    BookClearAll();
                    MessageBox.Show("Successfully Data Add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Book ID allready exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Issue Book
        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-PO4QOF1;Initial Catalog=LibrarySystem;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlCommand cmd_bookid = new SqlCommand("select Book_ID from book where Book_ID ='" + txtIbookid.Text + "'", con);
            SqlCommand cmd_studentid = new SqlCommand("select Student_ID from student where Student_ID ='" + txtIstudentid.Text + "'", con);
            SqlCommand cmd_bookname = new SqlCommand("select Book_Name from book where Book_ID ='" + txtIbookid.Text + "'", con);
            SqlCommand cmd_studentname = new SqlCommand("select Student_Name from student where Student_ID ='" + txtIstudentid.Text + "'", con);
            con.Open();
            string value = cmd_bookid.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value1 = cmd_studentid.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value3 = cmd_bookname.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value4 = cmd_studentname.ExecuteScalar() as string;
            con.Close();

            // Set the bookname and student name for lable
            lblIbookname.Text = value3;
            lblIstudentname.Text = value4;

            if (txtIbookid.Text.Equals(value) && txtIstudentid.Text.Equals(value1))
            {
                if (MessageBox.Show("Are you suer?", "Important message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Date Picker

                    String issueDate = dtpIissue.Value.ToShortDateString();
                    String dueDate = dtpIdue.Value.ToShortDateString();

                    query = "insert into issue (Student_ID,Student_Name,Book_ID,Book_Name,Issue_Date,Due_Date) values ('" + txtIstudentid.Text + "','" + value4 + "','" + txtIbookid.Text + "','" + value3 + "','" + issueDate + "','" + dueDate + "')";
                    fn.setData(query);

                }


            }
            else
            {
                MessageBox.Show("Invalied details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Return Book
        private void button16_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-PO4QOF1;Initial Catalog=LibrarySystem;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlCommand cmd_bookid = new SqlCommand("select Book_ID from issue where Book_ID ='" + txtRbookid.Text + "'", con);
            SqlCommand cmd_studentid = new SqlCommand("select Student_ID from issue where Student_ID ='" + txtRstudentid.Text + "'", con);
            SqlCommand cmd_issuedate = new SqlCommand("select Issue_Date from issue where Book_ID ='" + txtRbookid.Text + "'", con);
            SqlCommand cmd_duedate = new SqlCommand("select Due_Date from issue where Student_ID ='" + txtRstudentid.Text + "'", con);
            SqlCommand cmd_studentname = new SqlCommand("select Student_Name from student where Student_ID ='" + txtRstudentid.Text + "'", con);
            SqlCommand cmd_bookname = new SqlCommand("select Book_Name from book where Book_ID ='" + txtRbookid.Text + "'", con);
            con.Open();
            string value = cmd_bookid.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value1 = cmd_studentid.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value3 = cmd_issuedate.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value4 = cmd_duedate.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value5 = cmd_studentname.ExecuteScalar() as string;
            con.Close();

            con.Open();
            string value6 = cmd_bookname.ExecuteScalar() as string;
            con.Close();


            if (txtRbookid.Text.Equals(value) && txtRstudentid.Text.Equals(value1))
            {

                //Issue date and due date

                lblRissuedate.Text = value3;
                lblRduedate.Text = value4;

                //Issue student name and book name

                lblRstudentname.Text = value5;
                lblRbookname.Text = value6;

                if (MessageBox.Show("Are you suer?", "Important message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    query = "Delete from issue where Book_ID='" + txtRbookid.Text + "' and Student_ID='" + txtRstudentid.Text + "'";
                    fn.setData(query);

                    MessageBox.Show("Successfully Book Returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    String date = DateTime.Now.ToString("yyyy-MM-dd");
                    
                    query = "insert into retbook (Student_ID,Student_Name,Book_ID,Book_Name,Issue_Date,Due_Date,Return_Date) values ('" + txtRstudentid.Text + "','" + value5 + "','" + txtRbookid.Text + "','" + value6 + "','" + lblRissuedate.Text + "','" + lblRduedate.Text + "','" + date + "')";
                    fn.setData(query);

                    
                }

            }
            else
            {
                MessageBox.Show("Invalied details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblRstudentname_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Pnewstudent.Visible = false;
            Pnewbook.Visible = false;
            Pissuebook.Visible = false;
            Preturnbook.Visible = false;

            String date = DateTime.Now.ToString("yyyy-MM-dd");
            lbldate.Text = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pnewstudent.Visible = true;
            Pnewstudent.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pnewbook.Visible = true;
            Pnewbook.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pissuebook.Visible = true;
            Pissuebook.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Preturnbook.Visible = true;
            Preturnbook.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Edit update = new Edit();
            update.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
