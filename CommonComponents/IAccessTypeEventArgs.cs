using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public interface IAccessTypeEventArgs
    {
        AccessType AccessTypeValue { get; set; }
        bool ValuesWereChanged { get; set; }
    }
}
