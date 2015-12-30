/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMenu
{
    public class ThreadedMenu : Menu
    {
        private static Helpers.TaskPool sPool = new Helpers.TaskPool();

        public void HandleResponseParallel(string FailMessage = "Invalid command", bool ClearInputLine = true)
        {
            sPool.AddAndRun(new Action(() => HandleResponse(FailMessage, ClearInputLine)));
        }
    }
}
*/
