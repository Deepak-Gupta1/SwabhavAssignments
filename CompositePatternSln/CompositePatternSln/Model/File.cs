using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSln.Model
{
    internal class File:IStorageItem
    {
        private string _name;
        private int _size;
        public File(string name , int size)
        {
            _name = name;
            _size = size;
        }
        public string Name { get { return _name; } }
        public int Size { get { return _size; } }
        public void ShowDetails(int level)
        {
            Console.WriteLine("  "+_name + "|" + _size);
        }
       
    }
}
