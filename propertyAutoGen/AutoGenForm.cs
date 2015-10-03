using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using propertyAutoGen.DAL;

namespace propertyAutoGen
{
    public partial class AutoGenForm : Form
    {
        public int numOfCols = 0;
        public String concat = "";
        public SqlDataReader reader;
        public String BLLObject;
        public String tableName;
        public String cmdText;


        public AutoGenForm()
        {
            InitializeComponent();
            GetDatabaseNames();          

        }

        private void GetDatabaseNames()
        {
            cmdText = "SELECT [name] FROM master.dbo.sysdatabases WHERE dbid > 4 ";
            reader = SQLUtil.GetDatabases(cmdText);
            while (reader.Read())
            {
                Database_Name.Items.Add(reader["name"].ToString());
            }
        }

       

        private void Database_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameOfTable.Items.Clear();
            cmdText = "SELECT TABLE_NAME from INFORMATION_SCHEMA.TABLES";
            reader = new SQLUtil().GetData(Database_Name.Text,cmdText);

            while (reader.Read())
            {
                nameOfTable.Items.Add(reader["TABLE_NAME"].ToString());
            }
        }
        

        public void getDataTypes()//Get Datatypes of each field
        {
            tableName = nameOfTable.Text.ToString();
            BLLObject = BLLObjectName.Text;
            cmdText = "SELECT * FROM " + tableName;
            reader = new SQLUtil().GetData(Database_Name.Text,cmdText);
            DataTable schemaTable = reader.GetSchemaTable();
            numOfCols = reader.VisibleFieldCount;

            foreach (DataRow row in schemaTable.Rows)
            {
                foreach (DataColumn col in schemaTable.Columns)
                {
                    if (col.ColumnName == ("DataType"))
                    {
                        concat += row[col].ToString().Replace("System.", "") + " ";
                    }
                }
            }
        }


        public String[] setDataTypes()//Sets Datatypes for each field
        {
            String[] data = concat.Split();
            for (int i = 0; i < data.Length; i++)
            {
                int temp = 0;
                if (data[i].Equals("Int32") || data[i].Equals("Int64"))
                {
                    temp = i;
                    data[i] = "int";
                }
                else if (data[i].Equals("String"))
                {
                    temp = i;
                    data[i] = "string";
                }
                else if (data[i].Equals("DateTime"))
                {
                    temp = i;
                    data[i] = "DateFormats";
                }
            }
            return data;
        }


        private void AutoGenForm_Load(object sender, EventArgs e)
        {
        }


        private void GenerateClass_Click(object sender, EventArgs e)
        {
            if (Database_Name.SelectedItem == (null))
            {
                MessageBox.Show("Please select a database to retrieve data from!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameOfTable.SelectedItem == (null))
            {
                MessageBox.Show("Please select a table to retrieve data from!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLLClass();
            }
        }

        private void GenerateMethod_Click(object sender, EventArgs e)
        {
            try
            {
                if (methodType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a method type to generate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Database_Name.SelectedItem == (null))
                {
                    MessageBox.Show("Please select a database to retrieve data from!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nameOfTable.SelectedItem == (null))
                {
                    MessageBox.Show("Please select a table to retrieve data from!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Additional_Method();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error generating method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                x.ToString();
            }
        }

      

        public void BLLClass()
        {
            classCode.Clear();
            getDataTypes();
            String[] data = setDataTypes();
            String[] propertyName = new String[numOfCols];
            classCode.Text += "public class " + BLLObject + "\n{\n";

            for (int i = 0; i < numOfCols; i++)
            {
                String fieldType = data[i];
                propertyName[i] = char.ToUpper(reader.GetName(i)[0]) + reader.GetName(i).Substring(1);
                classCode.Text += ("\tpublic " + fieldType + " " + propertyName[i] + " { get; set ;}") + "\n";
            }

            classCode.Text += "\n\tpublic List <" + BLLObject + "> Get" + BLLObject + "()\n\t{";
            classCode.Text += "\n\t\tString cmdText = \"" + cmdText + "\";";
            classCode.Text += "\n\t\tList <" + BLLObject + "> list = new List <" + BLLObject + ">();";
            classCode.Text += "\n\t\tusing (SqlDataReader dr = SQLUtil.GetData(cmdText))";
            classCode.Text += "\n\t\t{";
            classCode.Text += "\n\t\t\twhile (dr.Read())";
            classCode.Text += "\n\t\t\t{";
            classCode.Text += "\n\t\t\t\t" + BLLObject + " obj = new " + BLLObject + "();";

            for (int i = 0; i < numOfCols; i++)
            {
                if (data[i] == "int")
                {
                    classCode.Text += "\n\t\t\t\tobj." + propertyName[i] + " = Convert.ToInt32(dr[\"" + reader.GetName(i) + "\"].ToString();";
                }
                else
                {
                    classCode.Text += "\n\t\t\t\tobj." + propertyName[i] + " = dr[\"" + reader.GetName(i) + "\"].ToString();";
                }
            }
            classCode.Text += "\n\t\t\t\tlist.Add(obj);";
            classCode.Text += "\n\t\t\t}";
            classCode.Text += "\n\t\t}";
            classCode.Text += "\n\t\treturn list;";
            classCode.Text += "\n\t}";
            classCode.Text += "\n}";
        }

        public void Additional_Method()
        {
            getDataTypes();
            methodCode.Clear();
            methodCode.Text += "public void " + methodType.Text + "_" + BLLObject + ("(PARAMETERS)") + "\n{\n";
            methodCode.Text += "\tString storedProcedure = \"PROCEDURE_NAME\";";
            methodCode.Text += "\n\tusing (SqlCommand cmd = SQLUtil.SetData(storedProcedure))";
            methodCode.Text += "\n\t{";
            methodCode.Text += "\n\t\ttry\n\t\t{";
            methodCode.Text += "\n\t\t\tcmd.CommandType = CommandType.StoredProcedure;";

            for (int i = 0; i < numOfCols; i++)
            {
                methodCode.Text += ("\n\t\t\tcmd.Parameters.AddWithValue(\"@PARAMETER_NAME\", CONTROL_NAME.Text);");
            }

            methodCode.Text += "\n\t\t\tcmd.ExecuteNonQuery();";
            methodCode.Text += "\n\t\t\tcmd.Parameters.Clear();";
            methodCode.Text += "\n\t\t}";
            methodCode.Text += "\n\t\tcatch (Exception e)";
            methodCode.Text += "\n\t\t{";
            methodCode.Text += "\n\t\t\te.ToString();";
            methodCode.Text += "\n\t\t}";
            methodCode.Text += "\n\t}";
            methodCode.Text += "\n}";
        }

       

    }
}
