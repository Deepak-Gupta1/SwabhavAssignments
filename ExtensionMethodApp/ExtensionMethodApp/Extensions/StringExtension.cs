using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.Extensions
{
    public static class StringExtension
    {
        public static string Foo(this String actual)
        {
            return "Foo" + actual.ToString();

        }
    }
}
