using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LexerLibrary;
using System.IO;

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

       

        public bool isNewLexem(Lexer l, List<lexem> lexemsWhithoutRepeate)
        {
            bool isNew = true;

            if(lexemsWhithoutRepeate.Count != 0)
            {
                foreach (lexem y in lexemsWhithoutRepeate)
                {
                    if (l.TokenContents == y.id)
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

       
        public string parser(string inputText)
        {
            lexemsWhithoutRepeate.Clear();
            string outputText = "";
          
            var defs = new TokenDefinition[]
            {
                new TokenDefinition(@"^do$", "OPERATOR LOOP"),
                new TokenDefinition(@"^while$", "OPERATOR LOOP"),
                new TokenDefinition(@"([""'])(?:\\\1|.)*?\1", "QUOTED-STRING"),
                new TokenDefinition(@"[-+]?\d*\.\d+([eE][-+]?\d+)?", "FLOAT"),
                new TokenDefinition(@"[-+]?\d+", "INT"),
                new TokenDefinition(@"#t", "TRUE"),
                new TokenDefinition(@"#f", "FALSE"),
                new TokenDefinition(@"[*<>\?\-+/A-Za-z->!]+", "VARIABLE"),
                new TokenDefinition(@"\.", "DOT"),
                new TokenDefinition(@"\(", "LEFT"),
                new TokenDefinition(@"\)", "RIGHT"),
                new TokenDefinition(@"\s", "SPACE")
            };

            TextReader r = new StringReader(inputText);
            Lexer l = new Lexer(r, defs);
            
            while (l.Next())
            {
                if (isNewLexem(l, lexemsWhithoutRepeate))
                {
                    lexem temp;
                    temp.id = l.TokenContents;
                    temp.type = Convert.ToString(l.Token);
                    lexemsWhithoutRepeate.Add(temp);
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
