using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoard
{
    abstract public class KnowledgeWorker
    {
        protected Boolean canContribute;
        protected string Name;
        public BlackBoardManager blackboard = null;
        protected List<KeyValuePair<string, ControlData>> keys;
        public KnowledgeWorker(BlackBoardManager blackboard, String Name)
        {
            this.blackboard = blackboard;
            this.Name = Name;
        }

        public KnowledgeWorker(String Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return this.Name;
        }

        abstract public void executeAction();

        abstract public bool executeCondition();

        abstract public void updateBlackboard();

    }
}
