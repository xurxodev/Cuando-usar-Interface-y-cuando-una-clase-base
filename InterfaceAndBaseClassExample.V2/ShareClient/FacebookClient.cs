using InterfaceAndBaseClassExample.V2.ShareClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndBaseClassExample.ShareClient
{
    public class TwitterClient :ShareClientBase
    {
        protected override void ShareText(string message)
        {
            //se comparte
        }
    }
}
