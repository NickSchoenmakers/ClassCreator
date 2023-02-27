using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClassCreator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            // ---------------------------------------------------------------
            // ---------------------------------------------------------------
            // filing the CMBTType comboboxes
            CMBType1.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType2.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType3.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType4.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType5.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType6.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType7.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType8.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType9.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType10.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType11.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType12.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType13.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType14.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType15.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType16.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType17.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType18.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType19.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType20.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            // ---------------------------------------------------------------
            // ---------------------------------------------------------------
            // filing the CMBTType comboboxes
            CMBFK1.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK2.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            }; 
            CMBFK3.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK4.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK5.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK6.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK7.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK8.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK9.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK10.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK11.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK12.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK13.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK14.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK15.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK16.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK17.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK18.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK19.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            CMBFK20.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "FK" },
            };
            // ---------------------------------------------------------------
            // ---------------------------------------------------------------
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("downloads/createdClasses.cs");
            using (StreamWriter file = new StreamWriter("downloads/createdClasses.cs"))
            {
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {   
                    file.WriteLine("// ---------------------------------------------------------------\r\n// ---------------------------------------------------------------");
                    file.WriteLine("public " + row.Cells["Item1"].Value + " { get; set; }");
                    if (row.Cells["Item2"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item2"].Value + " { get; set; }");
                    if (row.Cells["Item3"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item3"].Value + " { get; set; }");
                    if (row.Cells["Item4"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item4"].Value + " { get; set; }");
                    if (row.Cells["Item5"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item5"].Value + " { get; set; }");
                    if (row.Cells["Item6"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item6"].Value + " { get; set; }");
                    if (row.Cells["Item7"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item7"].Value + " { get; set; }");
                    if (row.Cells["Item8"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item8"].Value + " { get; set; }");
                    if (row.Cells["Item9"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item9"].Value + " { get; set; }");
                    if (row.Cells["Item10"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item10"].Value + " { get; set; }");
                    if (row.Cells["Item11"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item11"].Value + " { get; set; }");
                    if (row.Cells["Item12"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item12"].Value + " { get; set; }");
                    if (row.Cells["Item13"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item13"].Value + " { get; set; }");
                    if (row.Cells["Item14"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item14"].Value + " { get; set; }");
                    if (row.Cells["Item15"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item15"].Value + " { get; set; }");
                    if (row.Cells["Item16"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item16"].Value + " { get; set; }");
                    if (row.Cells["Item17"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item17"].Value + " { get; set; }");
                    if (row.Cells["Item18"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item18"].Value + " { get; set; }");
                    if (row.Cells["Item19"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item19"].Value + " { get; set; }");
                    if (row.Cells["Item20"].Value.ToString() != " ")
                        file.WriteLine("public " + row.Cells["Item20"].Value + " { get; set; }");
                    file.WriteLine("// ---------------------------------------------------------------\r\n// ---------------------------------------------------------------");
                }
            }
        }
        int counter = 1;
        private void ClassCreator_Click(object sender, EventArgs e)
        {
            if (TXBPrimairyKey.Text != "" && CMBType1.Text != "")
            {
                this.dataGridView3.Rows.Add(TXBPrimairyKey.Text,
                    CMBType1.Text + " " + TXB1.Text,
                    CMBType2.Text + " " + TXB2.Text,
                    CMBType3.Text + " " + TXB3.Text,
                    CMBType4.Text + " " + TXB4.Text,
                    CMBType5.Text + " " + TXB5.Text,
                    CMBType6.Text + " " + TXB6.Text,
                    CMBType7.Text + " " + TXB7.Text,
                    CMBType8.Text + " " + TXB8.Text, 
                    CMBType9.Text + " " + TXB9.Text, 
                    CMBType10.Text + " " + TXB10.Text, 
                    CMBType11.Text + " " + TXB11.Text,
                    CMBType12.Text + " " + TXB12.Text, 
                    CMBType13.Text + " " + TXB13.Text, 
                    CMBType14.Text + " " + TXB14.Text, 
                    CMBType15.Text + " " + TXB15.Text, 
                    CMBType16.Text + " " + TXB16.Text, 
                    CMBType17.Text + " " + TXB17.Text, 
                    CMBType18.Text + " " + TXB18.Text, 
                    CMBType19.Text + " " + TXB19.Text,
                    CMBType20.Text + " " + TXB20.Text);
                dataGridView3.Update();
                dataGridView3.Refresh();
                counter++;
            }
            else 
            {
                MessageBox.Show("please give a value to the first and second textboxes");
            }
        }
        public class DataType
        {
            public string Name { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }
        public class ForeignKey
        {
            public string FK { get; set; }
            public override string ToString()
            {
                return "FK";
            }
        }
    }
}
