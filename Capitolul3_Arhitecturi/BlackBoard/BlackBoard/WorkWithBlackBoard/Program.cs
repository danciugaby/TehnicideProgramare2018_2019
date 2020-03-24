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
            

            ControlData data1 = new ControlData("PrimeNumbers", new object[] { 100 });
            ControlData data2 = new ControlData("SumOfFirst", new object[] { 10 });

            BlackBoardManager.Instance.update("DAT0001", data1);
            BlackBoardManager.Instance.update("DAT0002", data2);

            BlackBoardManager m = new BlackBoardManager();

            PrimeFinder primeFinder = new PrimeFinder();

            SumOfFirst sumoffirst = new SumOfFirst();

            BlackBoardManager.Instance.addKnowledgeWorker(primeFinder);
            BlackBoardManager.Instance.addKnowledgeWorker(sumoffirst);


            ControlData data11 = new ControlData("PrimeNumbers", new object[] { 10 });
            ControlData data22 = new ControlData("SumOfFirst", new object[] { 5 });

            BlackBoardManager.Instance.update("DAT00011", data11);
            BlackBoardManager.Instance.update("DAT00022", data22);

            PrimeFinder primeFinder1 = new PrimeFinder();

            SumOfFirst sumoffirst1 = new SumOfFirst();

            BlackBoardManager.Instance.addKnowledgeWorker(primeFinder1);
            BlackBoardManager.Instance.addKnowledgeWorker(sumoffirst1);

            BlackBoardManager.Instance.print();
            BlackBoardManager.Instance.control.loop();
            BlackBoardManager.Instance.print();
            System.Console.ReadKey();
        }
    }
}
