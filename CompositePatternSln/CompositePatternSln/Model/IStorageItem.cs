using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSln.Model
{
    public interface IStorageItem
    {
        void ShowDetails(int level);
    }
}
