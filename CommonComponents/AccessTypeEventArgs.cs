using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public enum AccessType
    {
        Read,
        Add,
        Update,
        Delete
    }

    public class AccessTypeEventArgs: IAccessTypeEventArgs
    {
        private AccessType _AccessTypeValue;

        public AccessType AccessTypeValue
        {
            get { return _AccessTypeValue; }
            set { _AccessTypeValue = value; }
        }

        private bool _valuesWereChanged;

        public bool ValuesWereChanged
        {
            get { return _valuesWereChanged; }
            set { _valuesWereChanged = value; }
        }
    }
}
