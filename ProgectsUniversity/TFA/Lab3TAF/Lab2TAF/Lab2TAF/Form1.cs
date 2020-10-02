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

        List<lexem> lexemsWhithoutRepeate;

        public Form1()
        {
            InitializeComponent();
        }

        public bool isSimbol(char temp)
        {
            bool simbol = false;
            string simbols = "+-*/=<>;^:%&() \t\r\n";

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
        public bool isSpecialSimbol(char temp)
        {
            bool simbol = false;
            string simbols = "=<>:";

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

        public bool isNewLexem(string tempStr, List<lexem> lexemsWhithoutRepeate)
        {
            bool isNew = true;

            if(lexemsWhithoutRepeate.Count != 0)
            {
                foreach (lexem y in lexemsWhithoutRepeate)
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

        public int findLexem(string tempStr, List<lexem> lexemsWhithoutRepeate)
        {
            int number = 0;
            for(int i=0;i<lexemsWhithoutRepeate.Count;i++)
            {
                if(tempStr==lexemsWhithoutRepeate[i].id)
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

            if (tempStr == "do" || tempStr == "while")
            {
                type = "operator of loop";
            }
            else if(tempStr == "<=" || tempStr == "=>" || tempStr == "=" || tempStr == "<" || tempStr == ">")
            {
                type = "operator of comparison";
            }
            else if (tempStr == ":=")
            {
                type = "operator of assignment";
            }
            else if (int.TryParse(tempStr, out intNum))
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
            lexemsWhithoutRepeate.Clear();
            string outputText = "";
            string tempStr = "";
            char temp = ' ';

            for (int i = 0; i < inputText.Length; i++)
            {

                temp = inputText[i];

                //if (temp == ' ')
                //{
                //    tempStr = "";
                //    continue;
                //}

                if ((isSimbol(temp)) || (i + 1 == inputText.Length) || temp == ' ')
                {


                    if (i + 1 == inputText.Length && !isSimbol(temp))
                    {
                        tempStr += temp;
                    }

                    if (tempStr != "" && !isSpecialSimbol(temp))
                    {
                        lexem tempLexem;
                        tempLexem.id = tempStr;
                        tempLexem.type = getType(tempStr);
 
                        if (isNewLexem(tempStr, lexemsWhithoutRepeate))
                        {
                            if (tempLexem.type!="err")
                            {
                                lexemsWhithoutRepeate.Add(tempLexem);
                                if (tempLexem.type != "operator of loop" && tempLexem.type != "operator of assignment" && tempLexem.type != "operator of comparison")
                                    outputText += "<id" + Convert.ToString(lexemsWhithoutRepeate.Count - 1) + ">";
                                else
                                    outputText += tempStr;
                            }
                            else
                            {
                                MessageBox.Show("Invalid input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                outputText = "";
                                lexemsWhithoutRepeate.Clear();
                                tempStr = "";
                                break;
                            }
                        }
                        else
                        {
                            if (tempLexem.type != "operator of loop" && tempLexem.type != "operator of assignment" && tempLexem.type != "operator of comparison")
                                outputText += "<id" + Convert.ToString(findLexem(tempStr, lexemsWhithoutRepeate)) + ">";
                        }
                    }


                    if (isSimbol(temp))
                    {
                        if (isSpecialSimbol(temp))
                        {
                            if (tempStr.Length == 0)
                            {
                                tempStr += temp;
                            }
                            else if (isSpecialSimbol(tempStr[tempStr.Length - 1]))
                            {
                                tempStr += temp;
                                if (isNewLexem(tempStr, lexemsWhithoutRepeate))
                                {
                                    lexem tempLexem;
                                    tempLexem.id = tempStr;
                                    tempLexem.type = getType(tempStr);

                                    if (tempLexem.type != "err")
                                    {
                                        lexemsWhithoutRepeate.Add(tempLexem);
                                        outputText += tempStr;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        outputText = "";
                                        lexemsWhithoutRepeate.Clear();
                                        tempStr = "";
                                        break;
                                    }
                                }
                                else
                                {
                                    outputText += tempStr;
                                }
                            }
                            continue;
                        }
                        else
                        {
                            outputText += temp;
                        }
                    }
                   
                    tempStr = "";

                }
                else
                {
                    if (tempStr.Length!=0)
                        if (isSpecialSimbol(tempStr[tempStr.Length - 1])) 
                            tempStr = "";
                    tempStr += temp;
                }

            }

            return outputText;
        }
        public void setTable()
        {
            if (lexemsWhithoutRepeate.Count != 0)
            {
                bool isDouble = false;
                foreach (lexem y in lexemsWhithoutRepeate)
                {
                    if(y.type == "double")
                    {
                        isDouble = true;
                        break;
                    }
                }

                for (int i = 0; i < lexemsWhithoutRepeate.Count; i++)
                {
                    if (lexemsWhithoutRepeate[i].type == "variable")
                    {
                        if (isDouble) dataGridView1.Rows.Add(i, lexemsWhithoutRepeate[i].id, "double " + lexemsWhithoutRepeate[i].type);
                        else dataGridView1.Rows.Add(i, lexemsWhithoutRepeate[i].id, "int " + lexemsWhithoutRepeate[i].type);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(i, lexemsWhithoutRepeate[i].id, lexemsWhithoutRepeate[i].type);
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
            lexemsWhithoutRepeate = new List<lexem>();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Номер";
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Name = "Идентификатор";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Name = "Значение";
            dataGridView1.Columns[2].Width = 388;

        }
    }
}
