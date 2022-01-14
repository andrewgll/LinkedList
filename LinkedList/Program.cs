using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            LinkedList<string> list = new LinkedList<string>();
            list.Add("1sdfgdsfg");
            list.Add("2sdfg1234dsfg");
            list.Add("31sdfgdsfg");
            list.Add("4sd1241fgdsfg");
            list.Add("5sdfgdsfg");
            list.Add("6sdfg123dsfg");
            list.Add("7sdfg123dsfg");
            list.Add("8sdfg123dsfg");
            list.Add("9sdfg123dsfg");
            //list.Insert(new Node<string> { Value = "hi!!!" }, list.Length - 1);

            list.Delete(list.Length -1 );

            list.Print();
        }

    }
}
