using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoGenerics
{
    internal class CompareGenerics
    {
        // Agora faça o mesmo que acima criando um método capaz de comparar qualquer objeto utilizando generics

        public static bool Compare<T>(T a, T b)
        {
            return object.Equals(a, b);
        }
    }
}
