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
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType2.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType3.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType4.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType5.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType6.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType7.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType8.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType9.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType10.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType11.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType12.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType13.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType14.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType15.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType16.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType17.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType18.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType19.DataSource = new DataType[] {
                new DataType{ Name = "string" },
                new DataType{ Name = "int" },
                new DataType{ Name = "bool" },
                new DataType{ Name = "double" },
                new DataType{ Name = "decimal" },
                new DataType{ Name = "float" },
                new DataType{ Name = "dateTime" }
            };
            CMBType20.DataSource = new DataType[] {
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
            File.Delete("downloads/"+ TXBPrimairyKey.Text + ".cs");
            using (StreamWriter file = new StreamWriter("downloads/" + TXBPrimairyKey.Text + ".cs"))
            {
                file.WriteLine("public " + CMBType1.Text + " " + TXB1.Text + " { get; set; }");
                if (TXB2.Text != "")
                {
                    file.WriteLine("public " + CMBType2.Text + " " + TXB2.Text + " { get; set; }");
                }
                if (TXB3.Text != "")
                {
                    file.WriteLine("public " + CMBType3.Text + " " + TXB3.Text + " { get; set; }");
                }
                if (TXB4.Text != "")
                {
                    file.WriteLine("public " + CMBType4.Text + " " + TXB4.Text + " { get; set; }");
                }
                if (TXB5.Text != "")
                {
                    file.WriteLine("public " + CMBType5.Text + " " + TXB5.Text + " { get; set; }");
                }
                if (TXB6.Text != "")
                {
                    file.WriteLine("public " + CMBType6.Text + " " + TXB6.Text + " { get; set; }");
                }
                if (TXB7.Text != "")
                {
                    file.WriteLine("public " + CMBType7.Text + " " + TXB7.Text + " { get; set; }");
                }
                if (TXB8.Text != "")
                {
                    file.WriteLine("public " + CMBType8.Text + " " + TXB8.Text + " { get; set; }");
                }
                if (TXB9.Text != "")
                {
                    file.WriteLine("public " + CMBType9.Text + " " + TXB9.Text + " { get; set; }");
                }
                if (TXB10.Text != "")
                {
                    file.WriteLine("public " + CMBType10.Text + " " + TXB10.Text + " { get; set; }");
                }
                if (TXB11.Text != "")
                {
                    file.WriteLine("public " + CMBType11.Text + " " + TXB11.Text + " { get; set; }");
                }
                if (TXB12.Text != "")
                {
                    file.WriteLine("public " + CMBType12.Text + " " + TXB12.Text + " { get; set; }");
                }
                if (TXB13.Text != "")
                {
                    file.WriteLine("public " + CMBType13.Text + " " + TXB13.Text + " { get; set; }");
                }
                if (TXB14.Text != "")
                {
                    file.WriteLine("public " + CMBType14.Text + " " + TXB14.Text + " { get; set; }");
                }
                if (TXB15.Text != "")
                {
                    file.WriteLine("public " + CMBType15.Text + " " + TXB15.Text + " { get; set; }");
                }
                if (TXB16.Text != "")
                {
                    file.WriteLine("public " + CMBType16.Text + " " + TXB16.Text + " { get; set; }");
                }
                if (TXB17.Text != "")
                {
                    file.WriteLine("public " + CMBType17.Text + " " + TXB17.Text + " { get; set; }");
                }
                if (TXB18.Text != "")
                {
                    file.WriteLine("public " + CMBType18.Text + " " + TXB18.Text + " { get; set; }");
                }
                if (TXB19.Text != "")
                {
                    file.WriteLine("public " + CMBType19.Text + " " + TXB19.Text + " { get; set; }");
                }
                if (TXB20.Text != "")
                {
                    file.WriteLine("public " + CMBType20.Text + " " + TXB20.Text + " { get; set; }");
                }
            }
        }
        private void ClassCreator_Click(object sender, EventArgs e)
        {
            if (TXBPrimairyKey.Text != "" && CMBType1.Text != "")
            {
                List<Classes> Classes = new List<Classes>();
                Classes data = new Classes();
                data.Name = TXBPrimairyKey.Text;
                data.Item1 = CMBType1.Text + "_" + TXB1.Text;
                data.Item2 = CMBType2.Text + "_" + TXB2.Text;
                data.Item3 = CMBType3.Text + "_" + TXB3.Text;
                Classes.Add(data);
                dataGridView3.DataSource = Classes;
            }
            else 
            {
                MessageBox.Show("please give a value to the first and second textboxes");
            }

        }
        public class Classes
        {
            public string Name { get; set; }
            public string Item1 { get; set; } = null;
            public string Item2 { get; set; } = null;
            public string Item3 { get; set; } = null;
            public string Item4 { get; set; } = null;
            public string Item5 { get; set; } = null;
            public string Item6 { get; set; } = null;
            public string Item7 { get; set; } = null; 
            public string Item8 { get; set; } = null;
            public string Item9 { get; set; } = null;
            public string Item10 { get; set; } = null;
            public string Item11 { get; set; } = null;
            public string Item12 { get; set; } = null;
            public string Item13 { get; set; } = null;
            public string Item14 { get; set; } = null;
            public string Item15 { get; set; } = null;
            public string Item16 { get; set; } = null;
            public string Item17 { get; set; } = null;
            public string Item18 { get; set; } = null; 
            public string Item19 { get; set; } = null;
            public string Item20 { get; set; } = null;
            public override string ToString()
            {
                return Name;
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
