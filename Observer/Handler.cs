using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)

        {

            this.successor = successor;

        }

        public abstract void HandleRequest(int request);


    }
}
