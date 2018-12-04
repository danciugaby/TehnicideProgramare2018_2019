using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoard
{
    public class ControlData : ICloneable
    {
        public string problem;
        public object[] input;
        public object[] output;
        public string updateby;
        public DateTime updated;

        public ControlData()
        {
            this.problem = null;
            this.input = this.output = null;
        }

        public ControlData(string problem, object[] input)
        {
            this.problem = problem;
            this.input = input;
            this.updated = DateTime.Now;
        }
        public object getResult()
        {
            return this.output;
        }

        public object Clone()
        {
            ControlData clone;
            clone = new ControlData(this.problem, this.input);
            clone.updated = this.updated;
            clone.updateby = this.updateby;
            clone.output = this.output;
            return clone;
        }
    }
}
