using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndBaseClassExample.ShareClient
{
    public interface ITwitterClient
    {
        void PublishTweet(string message);
    }
}
