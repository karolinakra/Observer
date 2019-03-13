using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)

        {

            if (request >= 20 && request < 30)

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
