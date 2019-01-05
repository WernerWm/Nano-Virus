using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class FileHandler
    {
        StreamWriter writer;

        public FileHandler()
        {
            writer = new StreamWriter(@"C:\Documents");
        }

        public void FileWriter(Session session)
        {
            string line = String.Format("Cycle Number: {1}{0}" +
                "Number of Red Blood Cells {2}{0}" +
                "Number of White Blood Cells: {3}{0}" +
                "Number of Tumor Cells: {4}{0}" +
                "Number of Nano virus cells: {5}{0}" +
                "--------------------------------------",
                Environment.NewLine, session.LifeCycle, session.RBCLeft, session.WBCLeft, session.TCPresent, session.NVPresent);

            writer.WriteLine(line);
        }
    }
}
