using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class FactoryDataItem
    {
        private object _dataItem;

        public FactoryDataItem(object dataItem)
        {
            _dataItem = dataItem;
        }

        public object DataItem { get { return _dataItem; } }
    }
}
