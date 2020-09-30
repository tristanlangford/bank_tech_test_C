using System;
using System.Collections.Generic;

namespace Bank_Tech_Test_C
{
    public interface IPrintStatement
    {
        public string Print(List<IInteraction> history);

    }
}
