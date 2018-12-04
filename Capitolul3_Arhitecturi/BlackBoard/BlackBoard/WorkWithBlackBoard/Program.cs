using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackBoard;

namespace WorkWithBlackBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackBoardManager blackBoard = new BlackBoardManager();

            ControlData data1 = new ControlData("PrimeNumbers", new object[] { 100 });
            ControlData data2 = new ControlData("SumOfFirst", new object[] { 10 });

            blackBoard.update("DAT0001", data1);
            blackBoard.update("DAT0002", data2);

            PrimeFinder primeFinder = new PrimeFinder();

            SumOfFirst sumoffirst = new SumOfFirst();

            blackBoard.addKnowledgeWorker(primeFinder);
            blackBoard.addKnowledgeWorker(sumoffirst);

            blackBoard.print();
            blackBoard.control.loop();
            blackBoard.print();
            System.Console.ReadKey();
        }
    }
}
