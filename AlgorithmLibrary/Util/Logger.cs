using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Util
{
    public static class Logger
    {
        private static string SEPARATOR = "***************************************************************************";

        private static object locker = new object();

        #region Methods

        #region Write string methods

        public static void WriteLine(string data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt";

            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);
                }
            }
        }

        public static void WriteLine(string data, string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);
                }
            }
        }

        public static void Write(string data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt";

            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.Write(data);
                }
            }
        }

        public static void Write(string data, string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.Write(data);
                }
            }
        }

        #endregion

        #region Write object methods

        public static void WriteLine(object data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt";

            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);
                }
            }
        }

        public static void WriteLine(object data, string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);
                }
            }
        }

        public static void Write(object data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt";

            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.Write(data);
                }
            }
        }

        public static void Write(object data, string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.Write(data);
                }
            }
        }

        #endregion

        #region Write prepared string methods

        public static void WriteNewLine()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt";

            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
        }

        public static void WriteNewLine(string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
        }

        public static void WriteSeparator()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt";

            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                    file.Write(SEPARATOR);
                    file.WriteLine();
                }
            }
        }

        public static void WriteSeparator(string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                    file.Write(SEPARATOR);
                    file.WriteLine();
                }
            }
        }

        #endregion

        #endregion

    }
}
