using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System.IO;
namespace Practica02SIC
{
    public  class VerboseListener : BaseErrorListener
    {
        string fPath = "";
        public VerboseListener(string path)
        {
            fPath = path;
        }

        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {

            try
            {

                string archinter= System.IO.Directory.GetCurrentDirectory() + "/AuxErrores.txt";
                string errorline = File.ReadLines(fPath).Skip(line-1).Take(1).First();
                string path = System.IO.Directory.GetCurrentDirectory() + "/Errores.t";

                StreamWriter sw2;
                sw2 = File.AppendText(archinter);
                sw2.WriteLine(line + " ~ " + errorline);
                sw2.Close();


                //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                string error = "Error in line " + line + " On the character " + charPositionInLine + " " + msg;

                // FileStream stream = new FileStream(System.IO.Directory.GetCurrentDirectory() + "NombreArchivo.txt", FileMode.OpenOrCreate, FileAccess.Read);

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw;
                sw = File.AppendText(path);
                

                //Write a line of text
                
                sw.WriteLine("Error in line " + line + " On the character " + charPositionInLine + " " + msg);
              
                sw.Close();
            }
            catch (Exception ddd)
            {
                Console.WriteLine("Exception: " + ddd.Message);
            }
        
            base.SyntaxError(recognizer, offendingSymbol, line, charPositionInLine, msg, e);
        }

        
        

    }
}
