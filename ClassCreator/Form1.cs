using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
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
            string[] words = item.ToString().Split(' ');
            if (words[3].Length != 0)
            {
                file.WriteLine("public ObservableCollectionListSource<" + words[1] + "> " + words[1] + " { get; } = new ObservableCollectionListSource<" + words[1] + ">();");
            }
            else if (item.ToString().Contains("Null"))
            {
                Console.WriteLine("gadihjasgbgewbg");
                file.WriteLine("public " + item.ToString().Remove(item.ToString().Length - 5) + " { get; set; } = null;");
            }
            else if (item.ToString() != "   ")
            {
                file.WriteLine("public " + item.ToString().Remove(item.ToString().Length - 2) + " { get; set; }");
            }
        }
        int FKLengthv2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("Downloads\\createdClasses.cs");
            {
                charCounter = 0;
                using (StreamWriter file = new StreamWriter("Downloads\\createdClasses.cs"))
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
                Process.Start("Downloads\\createdClasses.cs");
            }
        }
        private void ClassCreator_Click(object sender, EventArgs e)
        {
            if (TXBPrimairyKey.Text != "" && TXB1.Text != "")
            {
                this.DGVClasses.Rows.Add(TXBPrimairyKey.Text,
                    CMBType1.Text + " " + TXB1.Text + " " + CMBNullable1.Text + " " + CMBFK1.Text,
                    CMBType2.Text + " " + TXB2.Text + " " + CMBNullable2.Text + " " + CMBFK2.Text,
                    CMBType3.Text + " " + TXB3.Text + " " + CMBNullable3.Text + " " + CMBFK3.Text,
                    CMBType4.Text + " " + TXB4.Text + " " + CMBNullable4.Text + " " + CMBFK4.Text,
                    CMBType5.Text + " " + TXB5.Text + " " + CMBNullable5.Text + " " + CMBFK5.Text,
                    CMBType6.Text + " " + TXB6.Text + " " + CMBNullable6.Text + " " + CMBFK6.Text,
                    CMBType7.Text + " " + TXB7.Text + " " + CMBNullable7.Text + " " + CMBFK7.Text,
                    CMBType8.Text + " " + TXB8.Text + " " + CMBNullable8.Text + " " + CMBFK8.Text,
                    CMBType9.Text + " " + TXB9.Text + " " + CMBNullable9.Text + " " + CMBFK9.Text,
                    CMBType10.Text + " " + TXB10.Text + " " + CMBNullable10.Text + " " + CMBFK10.Text,
                    CMBType11.Text + " " + TXB11.Text + " " + CMBNullable11.Text + " " + CMBFK11.Text,
                    CMBType12.Text + " " + TXB12.Text + " " + CMBNullable12.Text + " " + CMBFK12.Text,
                    CMBType13.Text + " " + TXB13.Text + " " + CMBNullable13.Text + " " + CMBFK13.Text,
                    CMBType14.Text + " " + TXB14.Text + " " + CMBNullable14.Text + " " + CMBFK14.Text,
                    CMBType15.Text + " " + TXB15.Text + " " + CMBNullable15.Text + " " + CMBFK15.Text,
                    CMBType16.Text + " " + TXB16.Text + " " + CMBNullable16.Text + " " + CMBFK16.Text,
                    CMBType17.Text + " " + TXB17.Text + " " + CMBNullable17.Text + " " + CMBFK17.Text,
                    CMBType18.Text + " " + TXB18.Text + " " + CMBNullable18.Text + " " + CMBFK18.Text,
                    CMBType19.Text + " " + TXB19.Text + " " + CMBNullable19.Text + " " + CMBFK19.Text,
                    CMBType20.Text + " " + TXB20.Text + " " + CMBNullable20.Text + " " + CMBFK20.Text);
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

        private void CMBFK1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK1.Text == "")
            {
                CMBType1.Text = "";
                TXB1.ReadOnly = false;
                CMBNullable1.Enabled = true;
                CMBType1.Enabled = true;
            }
            else
            {
                CMBType1.Text = "FK";
                TXB1.Text = CMBFK1.Text;
                CMBNullable1.Text = "";
                TXB1.ReadOnly = true;
                CMBNullable1.Enabled = false;
                CMBType1.Enabled = false;
            }
        }

        private void CMBFK2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK2.Text == "")
            {
                CMBType2.Text = "";
                TXB2.ReadOnly = false;
                CMBNullable2.Enabled = true;
                CMBType2.Enabled = true;
            }
            else
            {
                CMBType2.Text = "FK";
                TXB2.Text = CMBFK2.Text;
                CMBNullable2.Text = "";
                TXB2.ReadOnly = true;
                CMBNullable2.Enabled = false;
                CMBType2.Enabled = false;
            }
        }

        private void CMBFK3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK3.Text == "")
            {
                CMBType3.Text = "";
                TXB3.ReadOnly = false;
                CMBNullable3.Enabled = true;
                CMBType3.Enabled = true;
            }
            else
            {
                CMBType3.Text = "FK";
                TXB3.Text = CMBFK3.Text;
                CMBNullable3.Text = "";
                TXB3.ReadOnly = true;
                CMBNullable3.Enabled = false;
                CMBType3.Enabled = false;
            }
        }

        private void CMBFK4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK4.Text == "")
            {
                CMBType4.Text = "";
                TXB4.ReadOnly = false;
                CMBNullable4.Enabled = true;
                CMBType4.Enabled = true;
            }
            else
            {
                CMBType4.Text = "FK";
                TXB4.Text = CMBFK4.Text;
                CMBNullable4.Text = "";
                TXB4.ReadOnly = true;
                CMBNullable4.Enabled = false;
                CMBType4.Enabled = false;
            }
        }

        private void CMBFK5_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK5.Text == "")
            {
                CMBType5.Text = "";
                TXB5.ReadOnly = false;
                CMBNullable5.Enabled = true;
                CMBType5.Enabled = true;
            }
            else
            {
                CMBType5.Text = "FK";
                TXB5.Text = CMBFK5.Text;
                CMBNullable5.Text = "";
                TXB5.ReadOnly = true;
                CMBNullable5.Enabled = false;
                CMBType5.Enabled = false;
            }
        }

        private void CMBFK6_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK6.Text == "")
            {
                CMBType6.Text = "";
                TXB6.ReadOnly = false;
                CMBNullable6.Enabled = true;
                CMBType6.Enabled = true;
            }
            else
            {
                CMBType6.Text = "FK";
                TXB6.Text = CMBFK6.Text;
                CMBNullable6.Text = "";
                TXB6.ReadOnly = true;
                CMBNullable6.Enabled = false;
                CMBType6.Enabled = false;
            }
        }

        private void CMBFK7_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK7.Text == "")
            {
                CMBType7.Text = "";
                TXB7.ReadOnly = false;
                CMBNullable7.Enabled = true;
                CMBType7.Enabled = true;
            }
            else
            {
                CMBType7.Text = "FK";
                TXB7.Text = CMBFK7.Text;
                CMBNullable7.Text = "";
                TXB7.ReadOnly = true;
                CMBNullable7.Enabled = false;
                CMBType7.Enabled = false;
            }
        }

        private void CMBFK8_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK8.Text == "")
            {
                CMBType8.Text = "";
                TXB8.ReadOnly = false;
                CMBNullable8.Enabled = true;
                CMBType8.Enabled = true;
            }
            else
            {
                CMBType8.Text = "FK";
                TXB8.Text = CMBFK8.Text;
                CMBNullable8.Text = "";
                TXB8.ReadOnly = true;
                CMBNullable8.Enabled = false;
                CMBType8.Enabled = false;
            }
        }

        private void CMBFK9_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK9.Text == "")
            {
                CMBType9.Text = "";
                TXB9.ReadOnly = false;
                CMBNullable9.Enabled = true;
                CMBType9.Enabled = true;
            }
            else
            {
                CMBType9.Text = "FK";
                TXB9.Text = CMBFK9.Text;
                CMBNullable9.Text = "";
                TXB9.ReadOnly = true;
                CMBNullable9.Enabled = false;
                CMBType9.Enabled = false;
            }
        }

        private void CMBFK10_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK10.Text == "")
            {
                CMBType10.Text = "";
                TXB10.ReadOnly = false;
                CMBNullable10.Enabled = true;
                CMBType10.Enabled = true;
            }
            else
            {
                CMBType10.Text = "FK";
                TXB10.Text = CMBFK10.Text;
                CMBNullable10.Text = "";
                TXB10.ReadOnly = true;
                CMBNullable10.Enabled = false;
                CMBType10.Enabled = false;
            }
        }

        private void CMBFK11_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK11.Text == "")
            {
                CMBType11.Text = "";
                TXB11.ReadOnly = false;
                CMBNullable11.Enabled = true;
                CMBType11.Enabled = true;
            }
            else
            {
                CMBType11.Text = "FK";
                TXB11.Text = CMBFK11.Text;
                CMBNullable11.Text = "";
                TXB11.ReadOnly = true;
                CMBNullable11.Enabled = false;
                CMBType11.Enabled = false;
            }
        }

        private void CMBFK12_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK12.Text == "")
            {
                CMBType12.Text = "";
                TXB12.ReadOnly = false;
                CMBNullable12.Enabled = true;
                CMBType12.Enabled = true;
            }
            else
            {
                CMBType12.Text = "FK";
                TXB12.Text = CMBFK12.Text;
                CMBNullable12.Text = "";
                TXB12.ReadOnly = true;
                CMBNullable12.Enabled = false;
                CMBType12.Enabled = false;
            }
        }

        private void CMBFK13_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK13.Text == "")
            {
                CMBType13.Text = "";
                TXB13.ReadOnly = false;
                CMBNullable13.Enabled = true;
                CMBType13.Enabled = true;
            }
            else
            {
                CMBType13.Text = "FK";
                TXB13.Text = CMBFK13.Text;
                CMBNullable13.Text = "";
                TXB13.ReadOnly = true;
                CMBNullable13.Enabled = false;
                CMBType13.Enabled = false;
            }
        }

        private void CMBFK14_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK14.Text == "")
            {
                CMBType14.Text = "";
                TXB14.ReadOnly = false;
                CMBNullable14.Enabled = true;
                CMBType14.Enabled = true;
            }
            else
            {
                CMBType14.Text = "FK";
                TXB14.Text = CMBFK14.Text;
                CMBNullable14.Text = "";
                TXB14.ReadOnly = true;
                CMBNullable14.Enabled = false;
                CMBType14.Enabled = false;
            }
        }

        private void CMBFK15_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK15.Text == "")
            {
                CMBType15.Text = "";
                TXB15.ReadOnly = false;
                CMBNullable15.Enabled = true;
                CMBType15.Enabled = true;
            }
            else
            {
                CMBType15.Text = "FK";
                TXB15.Text = CMBFK15.Text;
                CMBNullable15.Text = "";
                TXB15.ReadOnly = true;
                CMBNullable15.Enabled = false;
                CMBType15.Enabled = false;
            }
        }

        private void CMBFK16_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK16.Text == "")
            {
                CMBType16.Text = "";
                TXB16.ReadOnly = false;
                CMBNullable16.Enabled = true;
                CMBType16.Enabled = true;
            }
            else
            {
                CMBType16.Text = "FK";
                TXB16.Text = CMBFK16.Text;
                CMBNullable16.Text = "";
                TXB16.ReadOnly = true;
                CMBNullable16.Enabled = false;
                CMBType16.Enabled = false;
            }
        }

        private void CMBFK17_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK17.Text == "")
            {
                CMBType17.Text = "";
                TXB17.ReadOnly = false;
                CMBNullable17.Enabled = true;
                CMBType17.Enabled = true;
            }
            else
            {
                CMBType17.Text = "FK";
                TXB17.Text = CMBFK17.Text;
                CMBNullable17.Text = "";
                TXB17.ReadOnly = true;
                CMBNullable17.Enabled = false;
                CMBType17.Enabled = false;
            }
        }

        private void CMBFK18_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK18.Text == "")
            {
                CMBType18.Text = "";
                TXB18.ReadOnly = false;
                CMBNullable18.Enabled = true;
                CMBType18.Enabled = true;
            }
            else
            {
                CMBType18.Text = "FK";
                TXB18.Text = CMBFK18.Text;
                CMBNullable18.Text = "";
                TXB18.ReadOnly = true;
                CMBNullable18.Enabled = false;
                CMBType18.Enabled = false;
            }
        }

        private void CMBFK19_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK19.Text == "")
            {
                CMBType19.Text = "";
                TXB19.ReadOnly = false;
                CMBNullable19.Enabled = true;
                CMBType19.Enabled = true;
            }
            else
            {
                CMBType19.Text = "FK";
                TXB19.Text = CMBFK19.Text;
                CMBNullable19.Text = "";
                TXB19.ReadOnly = true;
                CMBNullable19.Enabled = false;
                CMBType19.Enabled = false;
            }
        }

        private void CMBFK20_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMBFK20.Text == "")
            {
                CMBType20.Text = "";
                TXB20.ReadOnly = false;
                CMBNullable20.Enabled = true;
                CMBType20.Enabled = true;
            }
            else
            {
                CMBType20.Text = "FK";
                TXB20.Text = CMBFK20.Text;
                CMBNullable20.Text = "";
                TXB20.ReadOnly = true;
                CMBNullable20.Enabled = false;
                CMBType20.Enabled = false;
            }
        }
    }
}
