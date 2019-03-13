using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteHandler1 : Handler

    {
        public override void HandleRequest(int request)

        {

            if (request >= 0 && request < 10)

            {

                Console.WriteLine($"{this.GetType().Name} Obsłużony request {request}");

            }

            else if (successor != null)

            {

                successor.HandleRequest(request);

            }

        }

    }
}
