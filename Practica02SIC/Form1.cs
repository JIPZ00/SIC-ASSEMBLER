using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
namespace Practica02SIC
{
    public partial class Form1 : Form
    {
        string version = "";
        string fileContent = string.Empty;
        string filePath = string.Empty;
        List<List<String>> TabOp = new List<List<string>>();
        List<ValorArchIntermedio> listaArchinter = new List<ValorArchIntermedio>();
        List<List<string>> TabSim = new List<List<string>>();
        List<String> Registros = new List<string>();
        string tamProg;
        bool entroform = false;
        private int caractere;
        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string basediv = "@HOLA";
            string[] divide = basediv.Split('@');
            textBoxEditor.Enabled = false;
            buttonAnalizar.Enabled = false;
            //textBoxEditor.ScrollBars = ScrollBars.Vertical;
           // textBoxEditor.accepts
            //textBoxEditor.AcceptsReturn = true;
            textBoxEditor.AcceptsTab = true;
            dataGridTablaS.RowHeadersVisible = false;
            dataGridArchInter.RowHeadersVisible = false;
            guardarToolStripMenuItem.Enabled = false;
            guardarComoToolStripMenuItem.Enabled = false;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    char[] ext = filePath.ToArray();
                    string extension = ext[ext.Length - 1].ToString();
                    if (extension == "x")
                    {
                        version = "ext";
                    }
                    else if (extension == "s")
                    {
                        version = "est";
                    }
                    else
                    {
                        return;
                    }
                }
            }
            textBoxEditor.Text = fileContent;
            textBoxEditor.Enabled = true;
            buttonAnalizar.Enabled = true;
            guardarComoToolStripMenuItem.Enabled = true;
            for (int i = 0; i < dataGridTablaS.Rows.Count; i++)
            {
                dataGridTablaS.Rows.RemoveAt(i);
                i--;

            }
            for (int i = 0; i < dataGridArchInter.Rows.Count; i++)
            {
                dataGridArchInter.Rows.RemoveAt(i);
                i--;
            }
            guardarToolStripMenuItem.Enabled = true;


            label7.Text = "";
            textBoCodigoObj.Clear();
            textBoxErrores.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";
            string path2 = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
            string path3 = System.IO.Directory.GetCurrentDirectory() + "/ArchInter.txt";
            string path4 = System.IO.Directory.GetCurrentDirectory() + "/AuxErrores.txt";
            string path5 = System.IO.Directory.GetCurrentDirectory() + "/ArchRegistros.obj";
            File.Delete(path);
            File.Delete(path2);
            File.Delete(path3);
            File.Delete(path4);
            File.Delete(path5);



            if (version == "est")
            {
                AntlrInputStream ant = new AntlrInputStream(textBoxEditor.Text);

                sicestLexer sices = new sicestLexer(ant);
                CommonTokenStream tkn = new CommonTokenStream(sices);
                sicestParser prs = new sicestParser(tkn);
                //prs.RemoveErrorListeners();
                prs.AddErrorListener(new VerboseListener(filePath));
                // IParseTree tree = prs.programa(); //le pones la primera produccion

                sicestvisitor sicvst = new sicestvisitor();
                // sicvst.Visit(tree);
                sicvst.Visit(prs.programa());
                TabOp = sicvst.TabOp;
                listaArchinter = sicvst.listaArchinter;
                TabSim = sicvst.TabSim;
                tamProg = sicvst.tamprog;

                if (File.Exists(path))
                {

                    MessageBox.Show("Hay errores en el programa, verificar en el archivo Errores creado en la carpeta /bin/Debug");
                }
                else
                {
                    MessageBox.Show("No hay errores en el código");
                }
                File.Delete(path4);
                llenatextErrores();
            }


            //Se Ensambla
            _2dopasovisitor segundopaso = new _2dopasovisitor(TabSim, TabOp, listaArchinter);
            Registros = segundopaso.Registros;
            listaArchinter = segundopaso.listaArchinter;
            llenadataArchInter(listaArchinter);
            llenadataTabSim(TabSim);
            llenatextCodObj(Registros);
            label7.Text = tamProg;

        }

        private void escribeArchivoIntermedio()
        {
            string archinter = System.IO.Directory.GetCurrentDirectory() + "/ArchInter.txt";
            StreamWriter sw;
            sw = File.AppendText(archinter);
            for (int i = 0; i < listaArchinter.Count; i++)
            {
                if (listaArchinter[i].error == "")
                {
                    sw.WriteLine(listaArchinter[i].numl + "\t" + listaArchinter[i].direccion + "\t" + listaArchinter[i].etiqueta + "\t" + listaArchinter[i].instruccion + "\t" + listaArchinter[i].operando + "\t" + listaArchinter[i].codigoobjeto);

                }
                else
                {
                    if (listaArchinter[i].instruccion == "~")
                    {
                        sw.WriteLine(listaArchinter[i].numl + "\t" + listaArchinter[i].direccion + "\t" + listaArchinter[i].etiqueta + "\t" + listaArchinter[i].error);
                    }
                    else
                    {
                        sw.WriteLine(listaArchinter[i].numl + "\t" + listaArchinter[i].direccion + "\t" + listaArchinter[i].etiqueta + "\t" + listaArchinter[i].instruccion + "\t" + listaArchinter[i].operando + "\t" + listaArchinter[i].codigoobjeto + "\t" + listaArchinter[i].error);
                    }
                }

            }
            sw.Close();
        }

        private void llenatextErrores()
        {
            //Read the contents of the file into a stream
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";
                var fileStream = File.Open(path, FileMode.Open);
                var fErrores = string.Empty;
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fErrores = reader.ReadToEnd();
                }
                textBoxErrores.Text = fErrores;
            }
            catch
            {

            }
        }

        private void llenatextCodObj(List<String> Regs)
        {
            List<String> Registros = Regs;
            for(int i = 0; i < Registros.Count; i++)
            {
                textBoCodigoObj.Text = textBoCodigoObj.Text + Registros[i] + "\r\n";
            }
        }

        private void llenadataTabSim(List<List<string>> TabS)
        {
            List<List<string>> TabSim = TabS;
            object[] buffer = new object[3];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (List<string> item in TabSim)
            {
                buffer[0] = item[0];
                buffer[1] = item[1];
                buffer[2] = "RELATIVO";
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dataGridTablaS, buffer);
            }
            dataGridTablaS.Rows.AddRange(rows.ToArray());
        }

        private void llenadataArchInter(List<ValorArchIntermedio> listaArch)
        {
            for (int i = 0; i < dataGridArchInter.Rows.Count; i++)
            {
                dataGridArchInter.Rows.RemoveAt(i);
                i--;
            }
            List<ValorArchIntermedio> listaArchinter = listaArch;
            object[] buffer = new object[7];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (ValorArchIntermedio item in listaArchinter)
            {
                buffer[0] = item.numl;
                buffer[1] = item.direccion;
                buffer[2] = item.etiqueta;
                buffer[3] = item.instruccion;
                buffer[4] = item.operando;
                buffer[5] = item.codigoobjeto;
                buffer[6] = item.error;
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dataGridArchInter, buffer);
            }
            dataGridArchInter.Rows.AddRange(rows.ToArray());
        }

        private void textBoxEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (version == "est")
            {
                _2dopasovisitor segundopaso = new _2dopasovisitor(TabSim, TabOp, listaArchinter);
                Registros = segundopaso.Registros;
                listaArchinter = segundopaso.listaArchinter;
                llenadataArchInter(listaArchinter);
                llenadataTabSim(TabSim);
                llenatextCodObj(Registros);
                label7.Text = tamProg;
            }
           
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEditor.Enabled = true;
            buttonAnalizar.Enabled = true ;
            guardarComoToolStripMenuItem.Enabled = true;
            textBoxEditor.Clear();
            for (int i = 0; i < dataGridTablaS.Rows.Count; i++) {
                dataGridTablaS.Rows.RemoveAt(i);
                i--;

            }
            for (int i = 0; i < dataGridArchInter.Rows.Count; i++) {
                dataGridArchInter.Rows.RemoveAt(i);
                i--;
            }
            textBoCodigoObj.Clear();
            textBoxErrores.Clear();
            label7.Text = "";
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter newTask = new StreamWriter(filePath, false))
            {
                newTask.Write(textBoxEditor.Text);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.DefaultExt = ".s";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    using (StreamWriter newTask = new StreamWriter(filePath, false))
                    {
                        newTask.Write(textBoxEditor.Text);
                    }
                }
                guardarToolStripMenuItem.Enabled = true;
            }
        }

        
        private void dataGridArchInter_MouseEnter(object sender, EventArgs e)
        {
            pbLineas.Invalidate();
        }

        private void dataGridArchInter_MouseLeave(object sender, EventArgs e)
        {
            pbLineas.Invalidate();
        }

        public void AddLines(PaintEventArgs e)
        {
            int altura = textBoxEditor.GetPositionFromCharIndex(0).Y;

            if (textBoxEditor.Lines.Length > 0)
            {
                for (int i = 0; i < textBoxEditor.Lines.Length - 1; i++)
                {
                    e.Graphics.DrawString(i + 1 + "", textBoxEditor.Font, Brushes.Blue, pbLineas.Width - (e.Graphics.MeasureString(i + 1 + "", textBoxEditor.Font).Width + 10), altura);
                    caractere += textBoxEditor.Lines[i].Length + 1;
                    altura = textBoxEditor.GetPositionFromCharIndex(caractere).Y;
                }
                e.Graphics.DrawString(textBoxEditor.Lines.Length + "", textBoxEditor.Font, Brushes.Blue, pbLineas.Width - (e.Graphics.MeasureString(textBoxEditor.Lines.Length + "", textBoxEditor.Font).Width + 10), altura);
            }
            else
            {
                e.Graphics.DrawString(1 + "", textBoxEditor.Font, Brushes.Blue, pbLineas.Width - (e.Graphics.MeasureString(1 + "", textBoxEditor.Font).Width + 10), altura);
            }
        }

        private void pbLineas_Paint(object sender, PaintEventArgs e)
        {
            caractere = 0;
            AddLines(e);
        }

        private void textBoxEditor_VScroll(object sender, EventArgs e)
        {
            pbLineas.Invalidate();
        }

        private void textBoxEditor_TextChanged_1(object sender, EventArgs e)
        {
            pbLineas.Invalidate();
        }

        private void textBoxEditor_MouseDown(object sender, MouseEventArgs e)
        {
            pbLineas.Invalidate();
        }

        private void textBoxEditor_SelectionChanged(object sender, EventArgs e)
        {
            pbLineas.Invalidate();
        }
    }
}
