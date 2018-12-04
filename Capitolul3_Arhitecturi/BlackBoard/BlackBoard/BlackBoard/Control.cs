using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoard
{

    public class Control
    {
        BlackBoardManager blackBoard = null;

        public Control(BlackBoardManager blackBoard)
        {
            this.blackBoard = blackBoard;
        }

        public void loop()
        {
            System.Console.WriteLine("Starting loop");
            if (blackBoard == null)
                throw new InvalidOperationException("blackboard is null");
            this.nextSource();
            System.Console.WriteLine("Loop ended");

        }

        void nextSource()
        {
            // observers the blackboard
            foreach (KeyValuePair<string, ControlData> value in this.blackBoard.inspect())
            {
                foreach (KnowledgeWorker worker in this.blackBoard.knowledgeWorkers)
                {
                    if (worker.executeCondition())
                    {
                        Console.WriteLine(string.Format("{0} Can Contribute", worker.getName()));
                        worker.executeAction();
                        worker.updateBlackboard();
                    }
                }
            }
        }
    }

}
