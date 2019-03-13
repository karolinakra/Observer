using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteSubject : Subject
    {
        public ConcreteSubject(string subjectstate)
        {
            SubjectState = subjectstate;
        }
        public string SubjectState { get; set; }

    }
}
