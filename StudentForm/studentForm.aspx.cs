using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace StudentForm
{
    public partial class studentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            }
         /* DataTable employe = fetchdata();
            if(employe != null)
            {
                var filteredEmp = from emp in employee.AsEnumerable()
                                  where emp.Field<string>("JobTitle").Contains("Designer")
                                  select emp;
                string stable = "<Table border=1>";
                foreach(DataRow emp in filteredEmp)
                {
                    stable += "<tr>";
                    for(int i = 0; i < emp.ItemArray.Length; i++) 
                    {
                        stable+= "<td>" + emp.ItemArray[i].ToString + "</td>";
                    } 
                    stable += "</tr>";
                }
                dvPlaceholder.InnerHtml = stable;
                stable += "</table>";
            }
        }
        //SqlConnection scon();
      private static DataTable fetchdata()
        {
            SqlConnection scon;
            SqlDataAdapter dbAdapter;
            DataTable dt = new DataTable("employee");

           string constring = "Data Source=LPCL-PG03415P;Initial Catalog=AdventureWorks2019;Integrated Security=True";
            using (scon = new SqlConnection(constring))
            {
                scon.Open();

               SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select [BusinessEntityID], " +
                    "[NationalIDNumber], [LoginID], [JobTitle], [BirthDate], [MaritalStatus], [Gender], [HireDate], [SalariedFlag], " +
                    "[VacationHours], [SickLeaveHours], [CurrentFlag], [rowguid], [ModifiedDate] " +
                    "from HumanResources.Employee";

               cmd.CommandType = CommandType.Text;
                cmd.Connection = scon;
                dbAdapter = new SqlDataAdapter(cmd);
                //dbAdapter.Fill(dt);
                dbAdapter.Fill(dt);
            }
            return dt;
      }*/
        private DataTable GenerateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student Name");
            dt.Columns.Add("Student Roll.No");
            dt.Columns.Add("Class");
            dt.Columns.Add("Section");
            dt.Columns.Add("Date Of Birth");
            dt.Columns.Add("Mobile NO");
            dt.Columns.Add("Email ID");
            dt.Columns.Add("Address");
            return dt;
        }
        private void SaveandShowGrid()
        {
            DataTable gdt;
            if (ViewState["dt"] == null)
            {
                gdt = GenerateTable();
            }
            else gdt = ((DataTable)ViewState["dt"]);
            object[] row = new object[8];
            row[0] = Convert.ToString(TextBox1.Text);
            row[1] = Convert.ToString(TextBox2.Text);
            row[2] = Convert.ToString(TextBox3.Text);
            row[3] = Convert.ToString(TextBox4.Text);
            row[4] = Convert.ToString(TextBox6.Text);
            row[5] = Convert.ToString(TextBox7.Text);
            row[6] = Convert.ToString(TextBox8.Text);
            row[7] = Convert.ToString(TextBox10.Text);

            gdt.Rows.Add(row);

            ViewState["dt"] = gdt;
            dgrd.DataSource = gdt;
            dgrd.DataBind();
        }


        private void WriteTOFile()
        {
            FileInfo fl = new FileInfo("D:\\Espire\\C#\\StudentForm\\txt.txt");
            FileStream fs = fl.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter s = new StreamWriter(fs);

            object[] obj = new object[8];
            obj[0] = Convert.ToString(TextBox1.Text);
            obj[1] = Convert.ToString(TextBox2.Text);
            obj[2] = Convert.ToString(TextBox3.Text);
            obj[3] = Convert.ToString(TextBox4.Text);
            obj[4] = Convert.ToString(TextBox6.Text);
            obj[5] = Convert.ToString(TextBox7.Text);
            obj[6] = Convert.ToString(TextBox8.Text);
            obj[7] = Convert.ToString(TextBox10.Text);


            s.WriteLine(obj[0] + " " + obj[1] + " " + obj[2] + " " + obj[3] + " " + obj[4] + " " + obj[5] + " " + obj[6] + " " + obj[7]);
            s.Close();
        }

        private void ReadDataFromFile(string Filename)
        {
            FileInfo fl = new FileInfo("D:\\Espire\\C#\\StudentForm\\txt.txt");
            FileStream fs = fl.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                Response.Write(s);
            }
            sr.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteTOFile();
            }
            catch (Exception a)
            {
                Response.Write(a.Message);
                Response.Write("<br />");
            }

        }

        /*{
            TextWriter txt = new StreamWriter("D:\\Espire\\C#\\StudentForm\\form.txt");
            Object[] row = new Object[8];

            txt.Write(TextBox1.Text + " ");
            txt.Write(TextBox2.Text + " ");
            txt.Write(TextBox3.Text + " ");
            txt.Write(TextBox4.Text + " ");
            txt.Write(TextBox6.Text + " ");
            txt.Write(TextBox7.Text + " ");
            txt.Write(TextBox8.Text + " ");
            txt.Write(TextBox10.Text + " ");
            txt.Close();

        }*/

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveandShowGrid();
                //ReadDataFromFile(Filename);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                Response.Write("<br />");
            }
        }
       
    }
      }
    
