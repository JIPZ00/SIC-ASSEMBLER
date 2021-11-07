using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using System.IO;
using Antlr4.Runtime.Tree;
namespace Practica02SIC
{
    class sicestvisitor: sicestBaseVisitor<String>
    {
        String dirinicial;
        String CONTLOC;
        Boolean badline = false;
        public string tamprog;
        List<string> errors = new List<string>();
       public  List<List<string>> TabSim = new List<List<string>>();
       public List<List<String>> TabOp = new List<List<string>>();
        public List<ValorArchIntermedio> listaArchinter = new List<ValorArchIntermedio>();
        Boolean onlyonce = false;
        public override string VisitInicioPrograma([NotNull] sicestParser.InicioProgramaContext context)
        {
            List<string> aux;
            aux = new List<string>();
            aux.Add("ADD");
            aux.Add("18");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("AND");
            aux.Add("40");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("COMP");
            aux.Add("28");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("DIV");
            aux.Add("24");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("J");
            aux.Add("3C");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("JEQ");
            aux.Add("30");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("JGT");
            aux.Add("34");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("JLT");
            aux.Add("38");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("JSUB");
            aux.Add("48");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("LDA");
            aux.Add("00");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("LDCH");
            aux.Add("50");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("LDL");
            aux.Add("08");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("LDX");
            aux.Add("04");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("MUL");
            aux.Add("20");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("OR");
            aux.Add("44");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("RD");
            aux.Add("D8");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("RSUB");
            aux.Add("4C");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("STA");
            aux.Add("0C");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("STCH");
            aux.Add("54");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("STL");
            aux.Add("14");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("STSW");
            aux.Add("E8");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("STX");
            aux.Add("10");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("SUB");
            aux.Add("1C");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("TD");
            aux.Add("E0");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("TIX");
            aux.Add("2C");
            TabOp.Add(aux);
            aux = new List<string>();
            aux.Add("WD");
            aux.Add("DC");
            TabOp.Add(aux);
            return base.VisitInicioPrograma(context);
        }
        public override string VisitEtiqini([NotNull] sicestParser.EtiqiniContext context)
        {
            string num = "";
            dirinicial = Visit(context.num());
            string[] aux = dirinicial.Split('H');
            aux = aux[0].Split('h');
            CONTLOC = aux[0];
            dirinicial = aux[0];
            Console.WriteLine(CONTLOC + " " + context.START().GetText());
            if (onlyonce == false)
            {
                string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                StreamWriter sw;
                sw = File.AppendText(path);
                sw.WriteLine("SIMBOLO" + "\t" + "DIRECCION");
                sw.Close();
                onlyonce = true;
            }

            /*if(tipoDirectiva == "EQU")
            {
                if(tipoDirectiva = '*')
                {
                    TabSim.CP = this.CP;
                }
                else
                {
                    TabSim.CP = tipoDirectiva.result;
                }
            }*/

            /*if (tipoDirectiva == "ORG")
            {
                CogFuente.CP = tipoDirectiva.result;
            }*/
            string etiq = Visit(context.etiqueta());

            ValorArchIntermedio auxarch = new ValorArchIntermedio();
            auxarch.numl = 1;
            auxarch.direccion = CONTLOC;
            auxarch.etiqueta = etiq;
            auxarch.instruccion = "START";
            auxarch.operando = dirinicial;
            listaArchinter.Add(auxarch);


            return num;
        }

        public override string VisitFin([NotNull] sicestParser.FinContext context)
        {
            try
            {
                int op1 = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                int op2 = Int32.Parse(dirinicial, System.Globalization.NumberStyles.HexNumber);
                op1 = op1 - op2;
                string hexValue = op1.ToString("X");
                string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                StreamWriter sw;
                sw = File.AppendText(path);
                sw.WriteLine("TAMAÑO DEL PROGRAMA: " + hexValue + "H");
                tamprog = hexValue;
                sw.Close();

                string salida = Visit(context.entrada());

                int iCOunt = listaArchinter.Count + 1;

                ValorArchIntermedio auxarch = new ValorArchIntermedio();
                auxarch.numl = iCOunt;
                auxarch.direccion = CONTLOC;
                auxarch.etiqueta = "";
                auxarch.instruccion = "END";
                auxarch.operando = salida;
                listaArchinter.Add(auxarch);
            }
            catch (Exception e)
            {

            }

            return base.VisitFin(context);
        }

        public override string VisitNumhex([NotNull] sicestParser.NumhexContext context)
        {
            return context.NUMHEX().GetText();
        }

        public override string VisitNumnormal([NotNull] sicestParser.NumnormalContext context)
        {
            return context.NUM().GetText();
        }

        public override string VisitNumhexmin([NotNull] sicestParser.NumhexminContext context)
        {
            return context.NUMHEXMIN().GetText();
        }

        public override string VisitInstrrsub([NotNull] sicestParser.InstrrsubContext context)
        {
            string res = Visit(context.etiqueta());

            bool simbduplicado = false;
            bool existeetiqueta = false;
            if (res != "")
            {
                for (int i = 0; i < TabSim.Count; i++)
                {
                    if (TabSim[i][0] == res)
                    {
                        existeetiqueta = true;
                    }
                }
                if (existeetiqueta == true)
                {
                    simbduplicado = true;
                    //Error simbolo duplicado
                }
                else
                {
                    List<string> tablaaux = new List<string>();
                    tablaaux.Add(res);
                    tablaaux.Add(CONTLOC);
                    TabSim.Add(tablaaux);
                    string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                    StreamWriter sw;
                    sw = File.AppendText(path);
                    sw.WriteLine(res + "\t" + CONTLOC);
                    sw.Close();
                }
            }
            for (int i = 0; i < TabOp.Count; i++)
            {
                if (context.RSUB().GetText() == TabOp[i][0])
                {

                    int iCOunt = listaArchinter.Count + 1;

                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = context.RSUB().GetText();
                    auxarch.operando = "";
                    

                    if (simbduplicado == true)
                    {
                        auxarch.error = "ERROR SIMBOLO DUPLICADO";

                    }
                    else
                    {

                    }
                    listaArchinter.Add(auxarch);
                    int aux = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                    aux += 3;
                    string hexValue = aux.ToString("X");
                    CONTLOC = hexValue;


                }
            }
            return "";
        }

        public override string VisitInstrnormal([NotNull] sicestParser.InstrnormalContext context)
        {

            if (badline == false)
            {
                bool simboloduplicado = false;
                string res = Visit(context.etiqueta());
                string op = Visit(context.opinstruccion());
                string prueba = context.CODOP().GetText();
                bool existeetiqueta = false;
                if (res != "")
                {
                    for (int i = 0; i < TabOp.Count; i++)
                    {
                        if (res == TabOp[i][0])
                        {
                            //La etiqueta o el operador no pueden ser un codop
                            return "";
                        }
                        if (op == TabOp[i][0] || op == null)
                        {
                            badline = true;
                            return "";
                        }
                    }
                    List<List<string>> TabSim2 = new List<List<string>>();
                    TabSim2 = TabSim;
                    for (int i = 0; i < TabSim.Count; i++)
                    {
                        if (TabSim[i][0] == res)
                        {
                            existeetiqueta = true;
                        }
                    }
                    if (existeetiqueta == true)
                    {
                        simboloduplicado = true;
                        //Error simbolo duplicado
                    }
                    else
                    {
                        List<string> tablaaux = new List<string>();
                        tablaaux.Add(res);
                        tablaaux.Add(CONTLOC);
                        TabSim.Add(tablaaux);
                        string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                        StreamWriter sw;
                        sw = File.AppendText(path);
                        sw.WriteLine(res + "\t" + CONTLOC);
                        sw.Close();
                    }
                }
                for (int i = 0; i < TabOp.Count; i++)
                {
                    if (res == TabOp[i][0])
                    {
                        //La etiqueta o el operador no pueden ser un codop
                        return "";
                    }
                    if (op == TabOp[i][0] || op == null)
                    {
                        badline = true;
                        return "";
                    }
                }
                for (int i = 0; i < TabOp.Count; i++)
                {
                    if (context.CODOP().GetText() == TabOp[i][0])
                    {

                        int iCOunt = listaArchinter.Count + 1;

                        ValorArchIntermedio auxarch = new ValorArchIntermedio();
                        auxarch.numl = iCOunt;
                        auxarch.direccion = CONTLOC;
                        auxarch.etiqueta = res;
                        auxarch.instruccion = context.CODOP().GetText();
                        auxarch.operando = op;

                        if (simboloduplicado == true)
                        {

                            auxarch.error = "ERROR SIMBOLO DUPLICADO";
                        }
                        listaArchinter.Add(auxarch);

                        int aux = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        aux += 3;
                        string hexValue = aux.ToString("X");
                        CONTLOC = hexValue;
                        break;

                    }
                }
                Console.WriteLine(CONTLOC + " " + context.CODOP().GetText());
            }
            else
            {
                badline = false;
            }


          
             return base.VisitInstrnormal(context);
        }

        public override string VisitEsDirectiva([NotNull] sicestParser.EsDirectivaContext context)
        {
            string tipodir = Visit(context.tipodirectiva());
            string etiq = Visit(context.etiqueta());
            bool simboloduplicado = false;
            if (tipodir == "ORG")
            {
                
            }

                if (tipodir == "WORD")
                {
                    string opinst = Visit(context.opdirectiva());
                    string res = Visit(context.etiqueta());
                    if (res != "")
                    {
                        bool existeetiqueta = false;
                        for (int i = 0; i < TabSim.Count; i++)
                        {
                            if (TabSim[i][0] == res)
                            {
                                existeetiqueta = true;
                            }
                        }
                        if (existeetiqueta == true)
                        {
                        simboloduplicado = true;
                            //Error simbolo duplicado
                        }
                        else
                        {
                            List<string> tablaaux = new List<string>();
                            tablaaux.Add(res);
                            tablaaux.Add(CONTLOC);
                            TabSim.Add(tablaaux);
                            string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                            StreamWriter sw;
                            sw = File.AppendText(path);
                            sw.WriteLine(res + "\t" + CONTLOC);
                            sw.Close();
                        }
                    }


                int iCOunt = listaArchinter.Count + 1;
                ValorArchIntermedio auxarch = new ValorArchIntermedio();
                auxarch.numl = iCOunt;
                auxarch.direccion = CONTLOC;
                auxarch.etiqueta = res;
                auxarch.instruccion = "WORD";
                auxarch.operando = opinst;
                


                if (simboloduplicado == true)
                {

                    auxarch.error = "ERROR SIMBOLO DUPLICADO";
                }

                listaArchinter.Add(auxarch);

                    int aux = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                    aux += 3;
                    string hexValue = aux.ToString("X");
                    CONTLOC = hexValue;
                }
                if (tipodir == "RESB")
                {
                    string res = Visit(context.etiqueta());
                    if (res != "")
                    {
                        bool existeetiqueta = false;
                        for (int i = 0; i < TabSim.Count; i++)
                        {
                            if (TabSim[i][0] == res)
                            {
                                existeetiqueta = true;
                            }
                        }
                        if (existeetiqueta == true)
                        {
                        simboloduplicado = true;
                            //Error simbolo duplicado
                        }
                        else
                        {
                            List<string> tablaaux = new List<string>();
                            tablaaux.Add(res);
                            tablaaux.Add(CONTLOC);
                            TabSim.Add(tablaaux);
                            string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                            StreamWriter sw;
                            sw = File.AppendText(path);
                            sw.WriteLine(res + "\t" + CONTLOC);
                            sw.Close();
                        }
                    }
                    String[] eshexa;
                    string opinst = Visit(context.opdirectiva());
                    eshexa = opinst.Split('h');
                    if (eshexa.Count() > 1)
                    {

                    }
                    else
                    {
                        eshexa = opinst.Split('H');
                    }
                    if (eshexa.Count() > 1)
                    {

                    int iCOunt = listaArchinter.Count + 1;
                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = "RESB";
                    auxarch.operando = opinst;


                    if (simboloduplicado == true)
                    {
                        auxarch.error = "ERROR SIMBOLO DUPLICADO";
                    }

                    listaArchinter.Add(auxarch);
                        int op1 = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        int op2 = Int32.Parse(eshexa[0], System.Globalization.NumberStyles.HexNumber);
                        op1 = op1 + op2;
                        string hexValueRes = op1.ToString("X");
                        CONTLOC = hexValueRes;
                    }
                    else
                    {

                    int iCOunt = listaArchinter.Count + 1;

                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = "RESB";
                    auxarch.operando = opinst;
                    if (simboloduplicado == true)
                    {
                        auxarch.error = "ERROR SIMBOLO DUPLICADO";
                    }
                    listaArchinter.Add(auxarch);
                        int aux = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        aux += Convert.ToInt32(eshexa[0]);
                        string hexValue = aux.ToString("X");
                        CONTLOC = hexValue;

                    }
                }
                if (tipodir == "RESW")
                {
                    String[] eshexa;
                    string opinst = Visit(context.opdirectiva());
                    eshexa = opinst.Split('h');
                    string res = Visit(context.etiqueta());
                    if (res != "")
                    {
                        bool existeetiqueta = false;
                        for (int i = 0; i < TabSim.Count; i++)
                        {
                            if (TabSim[i][0] == res)
                            {
                                existeetiqueta = true;
                            }
                        }
                        if (existeetiqueta == true)
                        {
                        simboloduplicado = true;
                            //Error simbolo duplicado
                        }
                        else
                        {
                            List<string> tablaaux = new List<string>();
                            tablaaux.Add(res);
                            tablaaux.Add(CONTLOC);
                            TabSim.Add(tablaaux);
                            string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                            StreamWriter sw;
                            sw = File.AppendText(path);
                            sw.WriteLine(res + "\t" + CONTLOC);
                            sw.Close();
                        }
                    }

                    if (eshexa.Count() > 1)
                    {

                    }
                    else
                    {
                        eshexa = opinst.Split('H');
                    }
                    if (eshexa.Count() > 1)
                    {

                    int iCOunt = listaArchinter.Count + 1;
                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = "RESW";
                    auxarch.operando = opinst;


                    if (simboloduplicado == true)
                    {

                        auxarch.error = "ERROR SIMBOLO DUPLICADO";
                    }

                    listaArchinter.Add(auxarch);
                        int op1 = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        int op2 = Int32.Parse(eshexa[0], System.Globalization.NumberStyles.HexNumber);
                        op2 = op2 * 3;
                        op1 = op1 + op2;
                        string hexValueRes = op1.ToString("X");
                        CONTLOC = hexValueRes;
                    }
                    else
                    {

                    int iCOunt = listaArchinter.Count + 1;
                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = "RESW";
                    auxarch.operando = opinst;

                    if (simboloduplicado == true)
                    {

                        auxarch.error = "ERROR SIMBOLO DUPLICADO";
                    }

                    listaArchinter.Add(auxarch);


                        int aux = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        int op2 = Convert.ToInt32(eshexa[0]) * 3;
                        aux += op2;
                        string hexValue = aux.ToString("X");
                        CONTLOC = hexValue;

                    }


                }

            

            Console.WriteLine(CONTLOC + " " + tipodir);
            return base.VisitEsDirectiva(context);
        }

        public override string VisitEsBYTE([NotNull] sicestParser.EsBYTEContext context)
        {
            string tipo = Visit(context.@byte());
            string res = Visit(context.etiqueta());
            string prueba = Visit(context.@byte());
            bool simboloduplicado = false;
                string[] words;
                if (tipo != null && tipo != "")
                {
                    words = tipo.Split('\'');
                    if (words[0] == "C")
                    {
                        if (res != "")
                        {
                            bool existeetiqueta = false;
                            for (int i = 0; i < TabSim.Count; i++)
                            {
                                if (TabSim[i][0] == res)
                                {
                                    existeetiqueta = true;
                                }
                            }
                            if (existeetiqueta == true)
                            {
                            simboloduplicado = true;
                                //Error simbolo duplicado
                            }
                            else
                            {
                                List<string> tablaaux = new List<string>();
                                tablaaux.Add(res);
                                tablaaux.Add(CONTLOC);
                                TabSim.Add(tablaaux);
                                string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                                StreamWriter sw;
                                sw = File.AppendText(path);
                                sw.WriteLine(res + "\t" + CONTLOC);
                                sw.Close();
                            }
                        }

                    int iCOunt = listaArchinter.Count + 1;
                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = "BYTE";
                    auxarch.operando = tipo;


                    if (simboloduplicado == true)
                    {

                        auxarch.error = "SIMBOLO DUPLICADO";
                    }

                    listaArchinter.Add(auxarch);
                        int numwords = words[1].Length;
                        int aux = Int32.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        aux = aux + numwords;
                        string hexValue = aux.ToString("X");
                        CONTLOC = hexValue;

                    }
                    else if (words[0] == "X")
                    {
                        if (res != "")
                        {
                            bool existeetiqueta = false;
                            for (int i = 0; i < TabSim.Count; i++)
                            {
                                if (TabSim[i][0] == res)
                                {
                                    existeetiqueta = true;
                                }
                            }
                            if (existeetiqueta == true)
                            {
                            simboloduplicado = true;
                                //Error simbolo duplicado
                            }
                            else
                            {
                                List<string> tablaaux = new List<string>();
                                tablaaux.Add(res);
                                tablaaux.Add(CONTLOC);
                                TabSim.Add(tablaaux);
                                string path = System.IO.Directory.GetCurrentDirectory() + "/TabSim.txt";
                                StreamWriter sw;
                                sw = File.AppendText(path);
                                sw.WriteLine(res + "\t" + CONTLOC);
                                sw.Close();
                            }
                        }

                    int iCOunt = listaArchinter.Count + 1;
                    ValorArchIntermedio auxarch = new ValorArchIntermedio();
                    auxarch.numl = iCOunt;
                    auxarch.direccion = CONTLOC;
                    auxarch.etiqueta = res;
                    auxarch.instruccion = "BYTE";
                    auxarch.operando = tipo;


                    if (simboloduplicado == true)
                    {
                        auxarch.error = "ERROR SIMBOLO DUPLICADO";

                    }

                    listaArchinter.Add(auxarch);
                        int numwords = words[1].Length;
                        
                        int aux = int.Parse(CONTLOC, System.Globalization.NumberStyles.HexNumber);
                        double res2 = numwords / (double)2;
                        res2 = Math.Ceiling(res2);
                        aux = aux + (int)res2;
                        string hexValue = aux.ToString("X");
                        CONTLOC = hexValue;
                    }
                }
                Console.WriteLine(CONTLOC + " " + "BYTE");

            
           

            return base.VisitEsBYTE(context);
        }
        public override string VisitExisteID([NotNull] sicestParser.ExisteIDContext context)
        {
            return context.ID().GetText();
        }

        public override string VisitNoExisteID([NotNull] sicestParser.NoExisteIDContext context)
        {
            return "";
        }

        public override string VisitExisteOpInstruccion([NotNull] sicestParser.ExisteOpInstruccionContext context)
        {
            string esindexado = Visit(context.indexado());
            if (esindexado == "")
            {
                return context.ID().GetText();
            }
            else
            {
                string res = context.ID().GetText() + esindexado;
                return res;
            }
        }

        public override string VisitNoexisteOpInstruccion([NotNull] sicestParser.NoexisteOpInstruccionContext context)
        {
            return "";
        }
        public override string VisitNoEsIndexado([NotNull] sicestParser.NoEsIndexadoContext context)
        {
            return "";
        }

        public override string VisitEsIndexado([NotNull] sicestParser.EsIndexadoContext context)
        {
            string res = context.COMA().GetText() + context.INDICE().GetText();
            return res;
        }

        public override string VisitDirNum([NotNull] sicestParser.DirNumContext context)
        {
            return context.NUM().GetText();
        }
        public override string VisitDirConstCad([NotNull] sicestParser.DirConstCadContext context)
        {
            return context.ID().GetText();
        }
        public override string VisitDirNumHex([NotNull] sicestParser.DirNumHexContext context)
        {
            return context.NUMHEX().GetText();
        }
        public override string VisitDirNumHexMin([NotNull] sicestParser.DirNumHexMinContext context)
        {
            return context.NUMHEXMIN().GetText();
        }
        public override string VisitDIRRESB([NotNull] sicestParser.DIRRESBContext context)
        {
            return context.RESB().GetText();
        }
        public override string VisitDIRRESW([NotNull] sicestParser.DIRRESWContext context)
        {
            return context.RESW().GetText();
        }
        public override string VisitDIRWORD([NotNull] sicestParser.DIRWORDContext context)
        {
            return context.TIPOWORD().GetText();
        }
        public override string VisitBYTECBYTE([NotNull] sicestParser.BYTECBYTEContext context)
        {
            return context.CBYTE().GetText();
        }
        public override string VisitBYTEXBYTE([NotNull] sicestParser.BYTEXBYTEContext context)
        {
            return context.XBYTE().GetText();
        }
        public override string VisitEndID([NotNull] sicestParser.EndIDContext context)
        {
            return context.ID().GetText();
        }
        public override string VisitNoEndID([NotNull] sicestParser.NoEndIDContext context)
        {
            return "";
        }

     

        public override string VisitProposicion([NotNull] sicestParser.ProposicionContext context)
        {


            int iCOunt = listaArchinter.Count + 1;

            string[] values;
            string archaux = System.IO.Directory.GetCurrentDirectory() + "/AuxErrores.txt";
            try
            {
                StreamReader sr2 = new StreamReader(archaux);
                while (sr2.Peek() != -1)
                {
                    string aux = sr2.ReadLine();
                    values = aux.Split('~');
                    if (Convert.ToInt32(values[0]) == iCOunt)
                    {
                        char[] tienetab = values[1].ToArray();
                        string tab = tienetab[1].ToString();
                        ValorArchIntermedio auxarch = new ValorArchIntermedio();
                        auxarch.numl = iCOunt;
                        auxarch.direccion = CONTLOC;
                        auxarch.etiqueta = values[1];
                        auxarch.instruccion = "~";
                        auxarch.error = "ERROR DE SINTAXIS";
                        listaArchinter.Add(auxarch);

                    }
                }
                sr2.Close();
            }
            catch
            {

            }
           





    
            return base.VisitProposicion(context);
        }

        public override string VisitErrorDobleByte([NotNull] sicestParser.ErrorDobleByteContext context)
        {

            int iCOunt = listaArchinter.Count + 1;
            string res = Visit(context.@byte());

            ValorArchIntermedio auxarch = new ValorArchIntermedio();
            auxarch.numl = iCOunt;
            auxarch.direccion = CONTLOC;
            auxarch.etiqueta = "BYTE";
            auxarch.instruccion = "BYTE";
            auxarch.operando = res;
            auxarch.error = "ERROR DE SINTAXIS";
            listaArchinter.Add(auxarch);


            string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";
            StreamWriter sw2;
            sw2 = File.AppendText(path);

            sw2.WriteLine("Error in line " + iCOunt + " BYTE can't be a label ");
            sw2.Close();
            return base.VisitErrorDobleByte(context);
        }

        public override string VisitErrorDobleDirectiva([NotNull] sicestParser.ErrorDobleDirectivaContext context)
        {

            int iCOunt = listaArchinter.Count + 1;
            string res = Visit(context.opdirectiva());
            string tipo = Visit(context.tipodirectiva()[0]);
            string tipo2 = Visit(context.tipodirectiva()[1]);

            ValorArchIntermedio auxarch = new ValorArchIntermedio();
            auxarch.numl = iCOunt;
            auxarch.direccion = CONTLOC;
            auxarch.etiqueta = tipo;
            auxarch.instruccion = tipo2;
            auxarch.operando = res;
            auxarch.error = "ERROR DE SINTAXIS";
            listaArchinter.Add(auxarch);


            string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";
            StreamWriter sw2;
            sw2 = File.AppendText(path);

            sw2.WriteLine("Error in line " + iCOunt + " " + tipo +" can't be a label ");
            sw2.Close();

            return base.VisitErrorDobleDirectiva(context);
        }

        public override string VisitErrorCodOp([NotNull] sicestParser.ErrorCodOpContext context)
        {

            int iCOunt = listaArchinter.Count + 1;
            ITerminalNode trm;
            ITerminalNode trm2;
            string res = Visit(context.opinstruccion());
            trm = context.CODOP(0);
            trm2 = context.CODOP(1);
            string tipo = trm.GetText();
            string tipo2 = trm2.GetText();
            ValorArchIntermedio auxarch = new ValorArchIntermedio();
            auxarch.numl = iCOunt;
            auxarch.direccion = CONTLOC;
            auxarch.etiqueta = tipo;
            auxarch.instruccion = tipo2;
            auxarch.operando = res;
            auxarch.error = "ERROR DE SINTAXIS";
            listaArchinter.Add(auxarch);

            string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";
            StreamWriter sw2;
            sw2 = File.AppendText(path);

            sw2.WriteLine("Error in line " + iCOunt +" " + tipo + " can't be a label ");
            sw2.Close();
            return base.VisitErrorCodOp(context);
        }

        public override string VisitErrorRsub([NotNull] sicestParser.ErrorRsubContext context)
        {

            int iCOunt = listaArchinter.Count + 1;

            ValorArchIntermedio auxarch = new ValorArchIntermedio();
            auxarch.numl = iCOunt;
            auxarch.direccion = CONTLOC;
            auxarch.etiqueta = "RSUB";
            auxarch.instruccion = "RSUB";
            auxarch.error = "ERROR DE SINTAXIS";
            listaArchinter.Add(auxarch);


            string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";
            StreamWriter sw2;
            sw2 = File.AppendText(path);

            sw2.WriteLine("Error in line " + iCOunt + " RSUB" + " can't be a label ");
            sw2.Close();
            return base.VisitErrorRsub(context);
        }
    }
}
