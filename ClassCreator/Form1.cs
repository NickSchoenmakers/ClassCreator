using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ClassCreator
{
    public partial class Form1 : Form
    {
        int charCounter = 0;
        string item1 = "";
        string item2 = "";
        string item3 = "";
        string item4 = "";
        string item5 = "";
        string item6 = "";
        string item7 = "";
        string item8 = "";
        string item9 = "";
        string item10 = "";
        string item11 = "";
        string item12 = "";
        string item13 = "";
        string item14 = "";
        string item15 = "";
        string item16 = "";
        string item17 = "";
        string item18 = "";
        string item19 = "";
        string item20 = "";

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
            CMBFK1.Items.Add("");
            CMBFK2.Items.Add("");
            CMBFK3.Items.Add("");
            CMBFK4.Items.Add("");
            CMBFK5.Items.Add("");
            CMBFK6.Items.Add("");
            CMBFK7.Items.Add("");
            CMBFK8.Items.Add("");
            CMBFK9.Items.Add("");
            CMBFK10.Items.Add("");
            CMBFK11.Items.Add("");
            CMBFK12.Items.Add("");
            CMBFK13.Items.Add("");
            CMBFK14.Items.Add("");
            CMBFK15.Items.Add("");
            CMBFK16.Items.Add("");
            CMBFK17.Items.Add("");
            CMBFK18.Items.Add("");
            CMBFK19.Items.Add("");
            CMBFK20.Items.Add("");
            // ---------------------------------------------------------------
            // ---------------------------------------------------------------
            // filing the CMBTType comboboxes
            CMBNullable1.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable2.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable3.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable4.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable5.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable6.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable7.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable8.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable9.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable10.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable11.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable12.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable13.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable14.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable15.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable16.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable17.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable18.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable19.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            CMBNullable20.DataSource = new DataType[] {
                new DataType{ Name = "" },
                new DataType{ Name = "Null" },
            };
            // ---------------------------------------------------------------
            // ---------------------------------------------------------------  
        }
        private void AddItem(object item, StreamWriter file)
        {
            // idea for a method came from Adam Grygoruk
            // https://www.linkedin.com/in/adam-grygoruk-b60030265/
            if (item.ToString().Contains("FK"))
            {
                file.WriteLine("public " + item.ToString().Remove(item.ToString().Length - 4) + " { get; set; }");
            }
            else if (item.ToString().Contains("Null"))
            {
                file.WriteLine("public " + item.ToString().Remove(item.ToString().Length - 4) + " { get; set; } = null;");
            }
            else if(item.ToString() != "  ")
            {
                file.WriteLine("public " + item + " { get; set; }");
            }
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("downloads/createdClasses.cs");
            {
                charCounter = 0;
                using (StreamWriter file = new StreamWriter("downloads/createdClasses.cs"))
                foreach (DataGridViewRow row in DGVClasses.Rows)
                {
                    file.WriteLine("// ---------------------------------------------------------------\r\n// ---------------------------------------------------------------");
                    file.WriteLine("public int Id { get; set; }");
                    
                    AddItem(row.Cells["Item001"].Value, file);
                    AddItem(row.Cells["Item002"].Value, file);
                    AddItem(row.Cells["Item003"].Value, file);
                    AddItem(row.Cells["Item004"].Value, file);
                    AddItem(row.Cells["Item005"].Value, file);
                    AddItem(row.Cells["Item006"].Value, file);
                    AddItem(row.Cells["Item007"].Value, file);
                    AddItem(row.Cells["Item008"].Value, file);
                    AddItem(row.Cells["Item009"].Value, file);
                    AddItem(row.Cells["Item010"].Value, file);
                    AddItem(row.Cells["Item011"].Value, file);
                    AddItem(row.Cells["Item012"].Value, file);
                    AddItem(row.Cells["Item013"].Value, file);
                    AddItem(row.Cells["Item014"].Value, file);
                    AddItem(row.Cells["Item015"].Value, file);
                    AddItem(row.Cells["Item016"].Value, file);
                    AddItem(row.Cells["Item017"].Value, file);
                    AddItem(row.Cells["Item018"].Value, file);
                    AddItem(row.Cells["Item019"].Value, file);
                    AddItem(row.Cells["Item020"].Value, file);

                    file.WriteLine("// ---------------------------------------------------------------\r\n// ---------------------------------------------------------------");
                }
            }
        }
        private void ClassCreator_Click(object sender, EventArgs e)
        {
            if (TXBPrimairyKey.Text != "" && CMBType1.Text != "")
            {
                Console.WriteLine(CMBType1.Text + " " + TXB1.Text + " " + CMBNullable1.Text);
                this.DGVClasses.Rows.Add(TXBPrimairyKey.Text,
                    CMBType1.Text + " " + TXB1.Text + " " + CMBNullable1.Text,
                    CMBType2.Text + " " + TXB2.Text + " " + CMBNullable2.Text,
                    CMBType3.Text + " " + TXB3.Text + " " + CMBNullable3.Text,
                    CMBType4.Text + " " + TXB4.Text + " " + CMBNullable4.Text,
                    CMBType5.Text + " " + TXB5.Text + " " + CMBNullable5.Text,
                    CMBType6.Text + " " + TXB6.Text + " " + CMBNullable6.Text,
                    CMBType7.Text + " " + TXB7.Text + " " + CMBNullable7.Text,
                    CMBType8.Text + " " + TXB8.Text + " " + CMBNullable8.Text, 
                    CMBType9.Text + " " + TXB9.Text + " " + CMBNullable9.Text, 
                    CMBType10.Text + " " + TXB10.Text + " " + CMBNullable10.Text, 
                    CMBType11.Text + " " + TXB11.Text + " " + CMBNullable11.Text,
                    CMBType12.Text + " " + TXB12.Text + " " + CMBNullable12.Text, 
                    CMBType13.Text + " " + TXB13.Text + " " + CMBNullable13.Text, 
                    CMBType14.Text + " " + TXB14.Text + " " + CMBNullable14.Text, 
                    CMBType15.Text + " " + TXB15.Text + " " + CMBNullable15.Text, 
                    CMBType16.Text + " " + TXB16.Text + " " + CMBNullable16.Text, 
                    CMBType17.Text + " " + TXB17.Text + " " + CMBNullable17.Text, 
                    CMBType18.Text + " " + TXB18.Text + " " + CMBNullable18.Text, 
                    CMBType19.Text + " " + TXB19.Text + " " + CMBNullable19.Text,
                    CMBType20.Text + " " + TXB20.Text + " " + CMBNullable20.Text);
                CMBFK1.Items.Add(TXBPrimairyKey.Text);
                CMBFK2.Items.Add(TXBPrimairyKey.Text);
                CMBFK3.Items.Add(TXBPrimairyKey.Text);
                CMBFK4.Items.Add(TXBPrimairyKey.Text);
                CMBFK5.Items.Add(TXBPrimairyKey.Text);
                CMBFK6.Items.Add(TXBPrimairyKey.Text);
                CMBFK7.Items.Add(TXBPrimairyKey.Text);
                CMBFK8.Items.Add(TXBPrimairyKey.Text);
                CMBFK9.Items.Add(TXBPrimairyKey.Text);
                CMBFK10.Items.Add(TXBPrimairyKey.Text);
                CMBFK11.Items.Add(TXBPrimairyKey.Text);
                CMBFK12.Items.Add(TXBPrimairyKey.Text);
                CMBFK13.Items.Add(TXBPrimairyKey.Text);
                CMBFK14.Items.Add(TXBPrimairyKey.Text);
                CMBFK15.Items.Add(TXBPrimairyKey.Text);
                CMBFK16.Items.Add(TXBPrimairyKey.Text);
                CMBFK17.Items.Add(TXBPrimairyKey.Text);
                CMBFK18.Items.Add(TXBPrimairyKey.Text);
                CMBFK19.Items.Add(TXBPrimairyKey.Text);
                CMBFK20.Items.Add(TXBPrimairyKey.Text);
                DGVClasses.Update();
                DGVClasses.Refresh();
            }
            else 
            {
                MessageBox.Show("please give a value to the first and second textbox");
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
