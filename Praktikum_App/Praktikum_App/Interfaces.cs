using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_App
{
    interface IDictionary
    {
        IElement search(int number);
        void insert(int number);
        void delete(int number);
        void print(); 

    }

    interface IMultiSet : IDictionary { }
    interface ISet : IMultiSet { }
    interface IMultiSetSorted : IDictionary { }
    interface ISetSorted : IDictionary { }

    interface IElement { }
}
