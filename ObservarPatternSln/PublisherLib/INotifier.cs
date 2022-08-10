using PublisherLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherLib
{
    public interface INotifier
    {
        void notify(Account acc,string transactionType);
    }
}
