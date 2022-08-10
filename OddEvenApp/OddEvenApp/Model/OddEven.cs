using System;
namespace OddEvenApp.Model 
{
    internal class OddEven
    {
        private int _uperBound;
        private int[] _OddAr ;
        private int[] _EvenAr ;
        public OddEven(int num){
            _uperBound = num;
            _OddAr = new int[(num/2)+(num % 2)];
            _EvenAr = new int[num / 2];
             PrintNos();
        }
        public int[] Odds { 
            get { return _OddAr; }
        }
        public int[] Evens { 
            get { return _EvenAr; }
        
        }
        private void PrintNos()
        {
            int o=0;
            int e=0;
            for (int i = 1; i <=_uperBound; i++)
            {
                if (i % 2 == 0)
                {
                    _EvenAr[e] = i;
                    e++;
                }
                else
                {
                    _OddAr[o] = i;
                    o++;
                }

            }

        }
    }
}
