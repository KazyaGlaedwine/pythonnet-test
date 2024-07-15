using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Python.Runtime;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RunScript("mypythonscript");
            Application.Run(new Form1());   
        }

        static void RunScript(string scriptName)
        {
            Runtime.PythonDLL = @"C:\Users\user\AppData\Local\Programs\Python\Python311\python311.dll";
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                //Don't need to put .py
                var pythonScript = Py.Import("mypythonscript");
                var result = pythonScript.InvokeMethod("say_hello");
            }
        }
    }
}
