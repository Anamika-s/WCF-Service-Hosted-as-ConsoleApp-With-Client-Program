using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    interface IFunctions
    {
        [OperationContract]
        string Combine(string s1, string s2);
            
    }
}
