using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaceApp.Model
{
    internal interface Icrudable
    {
        void Create();
        void Read();
        void Update();  
        void Delete();
    }
}
