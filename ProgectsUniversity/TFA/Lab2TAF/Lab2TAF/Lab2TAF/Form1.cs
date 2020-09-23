using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2TAF
{
    public partial class Form1 : Form
    {
        public struct lexem
        {
            public string id;
            public string type;
        }

        List<lexem> lexems;

        public Form1()
        {
            InitializeComponent();
        }

        public bool isSimbol(char temp)
        {
            bool simbol = false;
            string simbols = "+-*/=^:%&()";

            foreach (char y in simbols)
            {
                if (temp == y)
                {
                    simbol = true;
                    break;
                }
            }
            return simbol;
        }

        public bool isNewLexem(string tempStr, List<lexem> lexems)
        {
            bool isNew = true;

            if(lexems.Count != 0)
            {
                foreach (lexem y in lexems)
                {
                    if (tempStr == y.id)
                    {
                        isNew = false;
                        break;
                    }
                }
            }

            return isNew;
        }

        public int findLexem(string tempStr, List<lexem> lexems)
        {
            int number = 0;
            for(int i=0;i<lexems.Count;i++)
            {
                if(tempStr==lexems[i].id)
                {
                    number = i;
                    break;
                }
            }
            return number;
        }

        public bool isVariable(string tempStr)
        {
            foreach(char y in tempStr)
            {
                if (y == '.' || y == ',' || y == '\\' || y == '/') return false;
            }
            return true;
        }

        public string getType(string tempStr)
        {
            string type = "";
            int intNum;
            double doubleNum;

            if (int.TryParse(tempStr, out intNum))
            {
                type = "int";
            }
            else if (double.TryParse(tempStr, out doubleNum))
            {
                type = "double";
            }
            else if (isVariable(tempStr))
            {
                type = "variable";
            }
            else
            {
                type = "err";
            }

            return type;
        }
        public string parser(string inputText)
        {
            lexems.Clear();
            string outputText = "";
            string tempStr = "";
            char temp = ' ';

            for (int i = 0; i < inputText.Length; i++)
            {

                temp = inputText[i];

                if (temp == ' ')
                {
                    continue;
                }

                if ((isSimbol(temp)) || (i + 1 == inputText.Length))
                {


                    if (i + 1 == inputText.Length && !isSimbol(temp))
                    {
                        tempStr += temp;
                    }

                    if (tempStr != "")
                    {
                        if (isNewLexem(tempStr, lexems))
                        {
                            lexem tempLexem;
                            tempLexem.id = tempStr;
                            tempLexem.type = getType(tempStr);

                            if (tempLexem.type!="err")
                            {
                                lexems.Add(tempLexem);
                                outputText += "<id" + Convert.ToString(lexems.Count - 1) + ">";
                            }
                            else
                            {
                                MessageBox.Show("Invalid input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                outputText = "";
                                lexems.Clear();
                                tempStr = "";
                                break;
                            }
                        }
                        else
                        {
                            outputText += "<id" + Convert.ToString(findLexem(tempStr, lexems)) + ">";
                        }
                    }


                    if (isSimbol(temp))
                    {
                        outputText += temp;
                    }
                    tempStr = "";

                }
                else
                {
                    tempStr += temp;
                }

            }

            return outputText;
        }
        public void setTable()
        {
            if (lexems.Count != 0)
            {
                bool isDouble = false;
                foreach (lexem y in lexems)
                {
                    if(y.type == "double")
                    {
                        isDouble = true;
                        break;
                    }
                }

                for (int i = 0; i < lexems.Count; i++)
                {
                    if (lexems[i].type == "variable")
                    {
                        if (isDouble) dataGridView1.Rows.Add(i, lexems[i].id, "double " + lexems[i].type);
                        else dataGridView1.Rows.Add(i, lexems[i].id, "int " + lexems[i].type);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(i, lexems[i].id, lexems[i].type);
                    }    
                }
            }
        }

        private void Analise_Click(object sender, EventArgs e)
        {
            string inputText = Convert.ToString(textInput.Text);

            dataGridView1.Rows.Clear();

            textOutput.Text = parser(inputText);

            setTable();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lexems = new List<lexem>();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Номер";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Идентификатор";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Значение";
            dataGridView1.Columns[2].Width = 185;
        }
    }
}
