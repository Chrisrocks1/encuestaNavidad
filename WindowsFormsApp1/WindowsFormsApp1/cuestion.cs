using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class cuestion
    {
        public string concepto { get; set; }
        public string resp1 { get; set; }

        public int valor1 { get; set; }
        public string resp2 { get; set; }
        public int valor2 { get; set; }
        public string resp3 { get; set; }
        public int valor3 { get; set; }
        public string resp4 { get; set; }
        public int valor4 { get; set; }

        public static implicit operator cuestion(List<cuestion> v)
        {
            throw new NotImplementedException();
        }
    }

    public class dato
    {
        static public string valor;
    }
}