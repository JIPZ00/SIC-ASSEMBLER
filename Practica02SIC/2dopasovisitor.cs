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
    class _2dopasovisitor : sicestBaseVisitor<String>
    {
        public List<List<string>> TabSim = new List<List<string>>();
        public List<List<String>> TabOp = new List<List<string>>();
        public List<ValorArchIntermedio> listaArchinter = new List<ValorArchIntermedio>();
        public List<string> Registros = new List<string>();
        public _2dopasovisitor(List<List<string>> TabS, List<List<String>> TabO,List<ValorArchIntermedio> listaArchi)
        {
            TabSim = TabS;
            TabOp = TabO;
            listaArchinter = listaArchi;
            calculaCodigoObjeto();
            escribeArchivoIntermedio();
            creaRegistros();
        }

        private void creaRegistros()
        {
            creaRegistroH();
            creaRegistrosT();
            creaRegistroE();
            escribeArchivoRegistros();
        }

        private void escribeArchivoRegistros()
        {
            string archinter = System.IO.Directory.GetCurrentDirectory() + "/ArchRegistros.obj";
            StreamWriter sw;
            sw = File.AppendText(archinter);
            for(int i = 0; i < Registros.Count; i++)
            {
                sw.WriteLine(Registros[i]);
            }
            sw.Close();
        }

        private void creaRegistroE()
        {
            string Registro = "E";
            string dirfin = "";
            for (int i = 0; i < listaArchinter.Count; i++)
            {
                if (listaArchinter[i].instruccion == "END" && listaArchinter[i].error == "")
                {
                    dirfin = listaArchinter[i].direccion;
                    if (listaArchinter[i].operando == "")
                    {
                        for (int x = 0; x < listaArchinter.Count; x++)
                        {
                            if (listaArchinter[x].instruccion != "START" && listaArchinter[x].instruccion != "END" && listaArchinter[x].instruccion != "RESB" && listaArchinter[x].instruccion != "RESW")
                            {
                                char[] num = listaArchinter[x].direccion.ToArray();
                                string aux3 = "";
                                switch (num.Length)
                                {
                                    case 1:
                                        aux3 = "00000" + listaArchinter[x].direccion;
                                        break;
                                    case 2:
                                        aux3 = "0000" + listaArchinter[x].direccion;
                                        break;

                                    case 3:
                                        aux3 = "000" + listaArchinter[x].direccion;
                                        break;

                                    case 4:
                                        aux3 = "00" + listaArchinter[x].direccion;
                                        break;

                                    case 5:
                                        aux3 = "0" + listaArchinter[x].direccion;
                                        break;

                                    case 6:
                                        break;
                                }
                                Registro = Registro + aux3;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int x = 0; x < TabSim.Count; x++)
                        {
                            if (TabSim[x][0] == listaArchinter[i].operando)
                            {
                                char[] num = TabSim[x][1].ToArray();
                                string aux4 = "";
                                switch (num.Length)
                                {
                                    case 1:
                                        aux4 = "00000" + TabSim[x][1];
                                        break;
                                    case 2:
                                        aux4 = "0000" + TabSim[x][1];
                                        break;

                                    case 3:
                                        aux4 = "000" + TabSim[x][1];
                                        break;

                                    case 4:
                                        aux4 = "00" + TabSim[x][1];
                                        break;

                                    case 5:
                                        aux4 = "0" + TabSim[x][1];
                                        break;

                                    case 6:
                                        break;
                                }
                                Registro = Registro + aux4;
                                break;
                            }
                        }
                    }
                }
            }
            Registros.Add(Registro);
        }

        private void creaRegistrosT()
        {
            string Registro = "";
            bool inicia = true;
            for(int i = 0; i < listaArchinter.Count; i++)
            {
                if(listaArchinter[i].error!= "ERROR DE SINTAXIS")
                {
                    if(listaArchinter[i].codigoobjeto== "---------")
                    {
                        if (Registro != "")
                        {
                            char[] numdatos = Registro.ToArray();
                            int n = numdatos.Length - 9;
                            n = n / 2;
                            string hexValue = n.ToString("X");
                            char[] spara = hexValue.ToArray();
                            if (spara.Length == 2)
                            {
                                Registro = Registro.Replace('~', spara[0]);
                                Registro = Registro.Replace('¿', spara[1]);
                            }
                            else
                            {
                                Registro = Registro.Replace('~', '0');
                                Registro = Registro.Replace('¿', spara[0]);
                            }
                            
                            Registros.Add(Registro);
                            Registro = "";
                            inicia = true;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (inicia == true)
                    {
                        char[] num = listaArchinter[i].direccion.ToArray();
                        string aux3 = "";
                        switch (num.Length)
                        {
                            case 1:
                                aux3 = "00000" + listaArchinter[i].direccion;
                                break;
                            case 2:
                                aux3 = "0000" + listaArchinter[i].direccion;
                                break;

                            case 3:
                                aux3 = "000" + listaArchinter[i].direccion;
                                break;

                            case 4:
                                aux3 = "00" + listaArchinter[i].direccion;
                                break;

                            case 5:
                                aux3 = "0" + listaArchinter[i].direccion;
                                break;

                            case 6:
                                break;
                        }
                        Registro = "T" + aux3 + "~" + "¿";
                        inicia = false;
                    }
                    if(listaArchinter[i].codigoobjeto != "---------")
                    {
                        char[] numdatos = Registro.ToArray();
                        char[] numdatosinst = listaArchinter[i].codigoobjeto.ToArray();
                        if((numdatos.Length + numdatosinst.Length)> 69)
                        {
                            char[] numdatos2 = Registro.ToArray();
                            int n = numdatos2.Length - 9;
                            n = n / 2;
                            string hexValue = n.ToString("X");
                            char[] spara = hexValue.ToArray();
                            if (spara.Length == 2)
                            {
                                Registro = Registro.Replace('~', spara[0]);
                                Registro = Registro.Replace('¿', spara[1]);
                            }
                            else
                            {
                                Registro = Registro.Replace('~', '0');
                                Registro = Registro.Replace('¿', spara[0]);
                            }
                            Registros.Add(Registro);
                            Registro = "";
                            inicia = true;
                            i--;
                            
                        }
                        else
                        {
                            Registro = Registro + listaArchinter[i].codigoobjeto;
                        }
                       
                    }
                }
            }
        }

        private void creaRegistroH()
        {
            string Registro = "";
            string dirinicio = "";
            string dirfin = "";
            for (int i = 0; i < listaArchinter.Count; i++)
            {
                if (listaArchinter[i].instruccion == "START" && listaArchinter[i].error=="")
                {
                    char[] nprg = listaArchinter[i].etiqueta.ToArray();
                    string aux2 = "";
                    dirinicio = listaArchinter[i].direccion;
                    if (nprg.Length >= 6)
                    {
                        Registro = "H" + nprg[0] + nprg[1] + nprg[2] + nprg[3] + nprg[4] + nprg[5];
                    }
                    else
                    {
                        switch (nprg.Length)
                        {
                            case 1:
                                aux2 = listaArchinter[i].etiqueta + "     ";
                                break;
                            case 2:
                                aux2 = listaArchinter[i].etiqueta + "    ";
                                break;

                            case 3:
                                aux2 = listaArchinter[i].etiqueta + "   ";
                                break;

                            case 4:
                                aux2 = listaArchinter[i].etiqueta + "  ";
                                break;

                            case 5:
                                aux2 = listaArchinter[i].etiqueta + " ";
                                break;
                        }
                        Registro = "H" + aux2;
                    }
                    break;
                }
            }
            for (int i = 0; i < listaArchinter.Count; i++)
            {
                if(listaArchinter[i].error!="ERROR DE SINTAXIS")
                {
                    if (listaArchinter[i].instruccion != "START" && listaArchinter[i].instruccion != "RESW" && listaArchinter[i].instruccion != "END" && listaArchinter[i].instruccion != "RESB")
                    {
                        string hexValue2 = listaArchinter[i].direccion;
                        char[] numdir2 = hexValue2.ToArray();
                        string aux8 = "";
                        switch (numdir2.Length)
                        {
                            case 1:
                                aux8 = "00000" + hexValue2;
                                break;
                            case 2:
                                aux8 = "0000" + hexValue2;
                                break;

                            case 3:
                                aux8 = "000" + hexValue2;
                                break;

                            case 4:
                                aux8 = "00" + hexValue2;
                                break;

                            case 5:
                                aux8 = "0" + hexValue2;
                                break;

                            case 6:
                                break;
                        }
                        Registro = Registro + aux8;
                        break;
                    }
                }
                
            }
            for(int i = 0; i < listaArchinter.Count; i++)
            {
                if(listaArchinter[i].instruccion=="END" && listaArchinter[i].error!="ERROR DE SINTAXIS")
                {
                    dirfin = listaArchinter[i].direccion;
                    break;
                }
            }
            int op1 = Int32.Parse(dirinicio, System.Globalization.NumberStyles.HexNumber);
            int op2 = Int32.Parse(dirfin, System.Globalization.NumberStyles.HexNumber);
            int res = op2 - op1;
            string hexValue = res.ToString("X");
            char[] numdir = hexValue.ToArray();
            string aux = "";
            switch (numdir.Length)
            {
                case 1:
                    aux = "00000" + hexValue;
                    break;
                case 2:
                    aux = "0000" + hexValue;
                    break;

                case 3:
                    aux = "000" + hexValue;
                    break;

                case 4:
                    aux = "00" + hexValue;
                    break;

                case 5:
                    aux = "0" + hexValue;
                    break;

                case 6:
                    break;
            }
            Registro = Registro + aux;
            Registros.Add(Registro);
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
                    if(listaArchinter[i].instruccion== "~")
                    {
                        sw.WriteLine(listaArchinter[i].numl + "\t" + listaArchinter[i].direccion + "\t" + listaArchinter[i].etiqueta + "\t" + listaArchinter[i].error);
                    }
                    else
                    {
                        sw.WriteLine(listaArchinter[i].numl + "\t" + listaArchinter[i].direccion + "\t" + listaArchinter[i].etiqueta + "\t" + listaArchinter[i].instruccion + "\t"+ listaArchinter[i].operando  + "\t" + listaArchinter[i].codigoobjeto + "\t" + listaArchinter[i].error);
                    }
                }

            }
            sw.Close();
        }

        private void calculaCodigoObjeto()
        {
            for(int i = 0; i < listaArchinter.Count; i++)
            {
                if(listaArchinter[i].error=="ERROR DE SINTAXIS")
                {

                }
                else
                {
                    if (listaArchinter[i].instruccion == "START" || listaArchinter[i].instruccion == "RESW" || listaArchinter[i].instruccion == "END" || listaArchinter[i].instruccion == "RESB" || listaArchinter[i].instruccion == "ORG" || listaArchinter[i].instruccion == "EQU")
                    {
                        listaArchinter[i].codigoobjeto = "---------";
                    }
                    else if (listaArchinter[i].instruccion == "BYTE" || listaArchinter[i].instruccion == "WORD")
                    {
                        if (listaArchinter[i].instruccion == "WORD")
                        {
                            string[] eshexa = listaArchinter[i].operando.Split('h');


                            if (eshexa.Count() > 1)
                            {

                            }
                            else
                            {
                                eshexa = listaArchinter[i].operando.Split('H');
                            }

                            if (eshexa.Count() > 1)
                            {
                                string hexValueRes = eshexa[0];
                                char[] num = eshexa[0].ToArray();
                                switch (num.Length)
                                {
                                    case 1:
                                        hexValueRes = "00000" + hexValueRes;
                                        break;
                                    case 2:
                                        hexValueRes = "0000" + hexValueRes;
                                        break;

                                    case 3:
                                        hexValueRes = "000" + hexValueRes;
                                        break;

                                    case 4:
                                        hexValueRes = "00" + hexValueRes;
                                        break;

                                    case 5:
                                        hexValueRes = "0" + hexValueRes;
                                        break;

                                    case 6:
                                        break;
                                }

                                listaArchinter[i].codigoobjeto = hexValueRes;
                            }
                            else
                            {
                                int op1 = Convert.ToInt32(listaArchinter[i].operando);
                                string hexValueRes = op1.ToString("X");
                                char[] num = hexValueRes.ToArray();
                                switch (num.Length)
                                {
                                    case 1:
                                        hexValueRes = "00000" + hexValueRes;
                                        break;
                                    case 2:
                                        hexValueRes = "0000" + hexValueRes;
                                        break;

                                    case 3:
                                        hexValueRes = "000" + hexValueRes;
                                        break;

                                    case 4:
                                        hexValueRes = "00" + hexValueRes;
                                        break;

                                    case 5:
                                        hexValueRes = "0" + hexValueRes;
                                        break;

                                    case 6:
                                        break;
                                }

                                listaArchinter[i].codigoobjeto = hexValueRes;
                            }
                        }
                        else if (listaArchinter[i].instruccion == "BYTE")
                        {
                            string[] words = listaArchinter[i].operando.Split('\'');
                            if (words[0] == "C")
                            {
                                char[] num = words[1].ToArray();
                                for (int x = 0; x < num.Length; x++)
                                {
                                    byte b = Convert.ToByte(num[x]);
                                    string hexValue = b.ToString("X");
                                    listaArchinter[i].codigoobjeto = listaArchinter[i].codigoobjeto + hexValue;
                                }
                            }
                            else if (words[0] == "X")
                            {
                                char[] num = words[1].ToArray();
                                if ((num.Length % 2) == 0)
                                {
                                    listaArchinter[i].codigoobjeto = words[1]; //Es par
                                }
                                else
                                {
                                    listaArchinter[i].codigoobjeto = "0" + words[1]; //Es impar
                                }
                            }
                        }

                    }
                    else
                    {
                        for (int k = 0; k < TabOp.Count; k++)
                        {
                            if (TabOp[k][0] == listaArchinter[i].instruccion)
                            {
                                string[] sep = listaArchinter[i].operando.Split(',');
                                if (sep.Length > 1)
                                {
                                    for (int z = 0; z < TabSim.Count; z++)
                                    {
                                        if (TabSim[z][0] == sep[0])
                                        {
                                            int op1 = Int32.Parse(TabSim[z][1], System.Globalization.NumberStyles.HexNumber);
                                            int op2 = 32768;
                                            op2 = op1 + op2;
                                            string hexValueRes = op2.ToString("X");
                                            listaArchinter[i].codigoobjeto = TabOp[k][1] + hexValueRes;
                                            //32768
                                        }
                                    }
                                }
                                else
                                {
                                    for (int z = 0; z < TabSim.Count; z++)
                                    {
                                        if (TabSim[z][0] == sep[0])
                                        {
                                            listaArchinter[i].codigoobjeto = TabOp[k][1] + TabSim[z][1];
                                            string kk = listaArchinter[i].codigoobjeto;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(listaArchinter[i].instruccion == "RSUB")
                    {
                        listaArchinter[i].codigoobjeto = "4C0000";
                    }

                }

            }
        }
       
    }
}
