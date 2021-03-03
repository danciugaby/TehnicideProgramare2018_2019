using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCustomRoutedEvent
{
    public delegate string MyDelegate(string str);

    class EventProgram
    {
        event MyDelegate MyEvent;
        string composer = "";
        public EventProgram()
        {
            this.MyEvent += new MyDelegate(this.Welcome);
            this.MyEvent += new MyDelegate(this.ReadFile);
        }

        public string callEvent(String s)
        {
            composer = "";
            MyEvent(s);

            return composer;
        }


        private string Welcome(string user)
        {
            composer += "Welcome " + user 
                + Environment.NewLine;
            return "Welcome " + user;
        }

        private string ReadFile(string filepath)
        {
            StringBuilder strb = new StringBuilder();
            StreamReader reader = new StreamReader(filepath);
            String s;
            while ((s = reader.ReadLine()) != null)
            {
                strb.Append(s);
            }
            composer += strb;
            return strb.ToString();
        }
    }
}
