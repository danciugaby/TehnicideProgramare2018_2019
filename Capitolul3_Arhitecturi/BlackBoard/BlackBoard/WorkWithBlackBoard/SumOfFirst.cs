using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackBoard;

namespace WorkWithBlackBoard
{
    public class SumOfFirst : KnowledgeWorker
    {
        protected int MAX = 1000;
        public SumOfFirst(BlackBoardManager blackboard) : base(blackboard, "SumOfFirst")
        {

        }

        public SumOfFirst() : base("SumOfFirst")
        {

        }
        public override void executeAction()
        {
            if (this.canContribute)
            {
                foreach (KeyValuePair<string, ControlData> value in this.keys)
                {
                    if (this.keys.Contains(value))
                    {
                        int[] sum = new int[1];
                        int maxval = value.Value.input.Cast<int>().ToArray()[0];
                        for (int i = 0; i < maxval; i++)
                        {
                            sum[0] += i;
                        }
                        // update temp results                        
                        value.Value.output = sum.Cast<object>().ToArray();
                    }
                }
            }
        }

        public override bool executeCondition()
        {
            this.keys = new List<KeyValuePair<string, ControlData>>();
            this.canContribute = false;
            foreach (KeyValuePair<string, ControlData> cdata in this.blackboard.inspect())
            {
                if (cdata.Value.problem == "SumOfFirst"
                        && cdata.Value.input != null
                        && cdata.Value.input.Length > 0
                        && valueIsOk(cdata.Value.input[0])
                        && (int)cdata.Value.input[0] < this.MAX)
                {

                    this.canContribute = true;
                    this.keys.Add(cdata);
                    System.Console.WriteLine(string.Format("Worker:{0} can contribute on Problem:{1}", this.Name, cdata.Key));
                }
            }
            return this.canContribute;
        }

        public override void updateBlackboard()
        {
            foreach (KeyValuePair<string, ControlData> value in this.keys)
            {
                this.blackboard.update(value);
            }
        }

        protected bool valueIsOk(object obj)
        {
            if (Equals(obj, null))
            {
                return false;
            }

            Type objType = obj.GetType();
            objType = Nullable.GetUnderlyingType(objType) ?? objType;

            if (objType.IsPrimitive)
            {
                return objType != typeof(bool) &&
                    objType != typeof(char) &&
                    objType != typeof(IntPtr) &&
                    objType != typeof(UIntPtr);
            }

            return objType == typeof(decimal);
        }
    }
}
