using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSlnApp.Model
{
    public interface IWorker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
