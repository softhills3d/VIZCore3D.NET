using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.EncryptDecrypt
{
    public class FileItem
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public string Name { get; set; }

        public long Length { get; set; }

        public long OutputLength { get; set; }

        public double Ratio { get; set; }

        public FileItem() { }

        public FileItem(string input)
        {
            Input = input;

            string path = System.IO.Path.GetDirectoryName(Input);
            Name = System.IO.Path.GetFileName(Input);

            string dir = string.Format("{0}\\Output", path);
            if (System.IO.Directory.Exists(dir) == false)
                System.IO.Directory.CreateDirectory(dir);

            Length = new System.IO.FileInfo(input).Length;

            Output = string.Format("{0}\\{1}", dir, Name);
        }

        public FileItem(string input, string output) { Input = input; Output = output; }

        public bool UpdateOutput()
        {
            if (System.IO.File.Exists(Output) == false) return false;

            OutputLength = new System.IO.FileInfo(Output).Length;

            Ratio = OutputLength * 100 / Length;

            return true;
        }
    }
}
