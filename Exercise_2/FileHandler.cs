using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Exercise_2
{
    class FileHandler
    {
        DataHandler handler = new DataHandler();
        public string file = @" C:\PRG282\Exercises\Exercise_1\bin\newfile.txt";

        public List<string> read()
        {
            List<string> list = new List<string>();
            list = File.ReadAllLines(file).ToList();
            return handler.Format(list);
        } 
        public void write(List<String> employees)
        {
            string outpath = @" C:\PRG282\Exercises\Exercise_1\bin\newfile2.txt";
            File.WriteAllLines(file, employees);
            MessageBox.Show("Written formated data to newfile.txt");
        }
    }
}
