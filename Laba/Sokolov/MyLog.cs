using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokolov
{
    class MyLog : core.LogAbstract<MyLog>, core.LogInterface
    {
        static public void log(string s)
        {
            Instance()._log_(s);
        }
        public void _log_(string s)
        {
            _log.Add(s);
        }
        static public void write()
        {
            Instance()._write();
        }
        override public void _write()
        {
            string path = @"version.txt";
            Directory.CreateDirectory("Log");
            using(StreamReader sr = new StreamReader(path))
            {
                MyLog.log("Версия: " + sr.ReadToEnd().Trim('\n'));
            }
            string date = DateTime.Now.ToString("dd.MM.yyyy_HH_mm_ss");
            for (int i = 0; i < _log.Count; i++)
            {
                Console.WriteLine(_log[i]);
            }
            string datename = @"Log" +Path.DirectorySeparatorChar + date + ".log";
            using (StreamWriter we = new StreamWriter(datename, false, System.Text.Encoding.Default))
            {
                for(int i = 0; i < _log.Count; i++)
                {
                    we.WriteLine(_log[i]);
                }
            }
        }
    }
}
