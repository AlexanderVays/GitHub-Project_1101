using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Singleton
{
    interface ISingleton
    {
        Dictionary<string, int> GetRead(string fileName);
    }
}
