using System;
using System.IO;

namespace AlgorithmLibrary.Util
{
    public static class Logger
    {
        private static string SEPARATOR = "***************************************************************************";

        private static object locker = new object();

        #region Methods

        #region Write string methods

        public static void AppendLine(string data)
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

        public static void AppendLine(string data, string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);
                }
            }
        }

        public static void Append(string data)
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

        public static void Append(string data, string path)
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

        public static void AppendLine(object data)
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

        public static void AppendLine(object data, string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);
                }
            }
        }

        public static void Append(object data)
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

        public static void Append(object data, string path)
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

        public static void AppendNewLine()
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

        public static void AppendNewLine(string path)
        {
            lock (locker)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine();
                }
            }
        }

        public static void AppendSeparator()
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

        public static void AppendSeparator(string path)
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
