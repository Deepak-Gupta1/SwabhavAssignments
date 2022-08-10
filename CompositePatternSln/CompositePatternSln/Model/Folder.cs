using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSln.Model
{
    internal class Folder:IStorageItem
    {
        private string _name;
        private List<IStorageItem> _children=new List<IStorageItem>();
        public Folder(string name)
        {
            _name = name;
        }
        public string Name { get { return _name; } }
        public void AddChild(IStorageItem child)
        {
            _children.Add(child);
        }
        public void ShowDetails(int level)
        {
            Console.WriteLine(" "+_name);

            foreach(var item in _children)
            {
                item.ShowDetails(level);
            }
        }
    }
}
