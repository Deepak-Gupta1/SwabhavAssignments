using System;
using System.Collections.Generic;
namespace CollectionPocApp.Model
{
    internal class ListCollection
    {
        List<int> list = new List<int>();
        public void AddData(int data) { list.Add(data); }
        public void RemoveData(int data) { list.Remove(data); }
        public void RemoveAt(int position) { list.RemoveAt(position); }
        public void GetCount() { Console.WriteLine(list.Count); }
        public void ClearList(){ list.Clear(); }
        public void PrintList() {
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        
        }  
    }

}
