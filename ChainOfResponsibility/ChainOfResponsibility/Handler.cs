using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler Next;
        public Handler(Handler next)
        {
            this.Next = next;
        }
        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;

            if (Next != null)
                this.Next.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
