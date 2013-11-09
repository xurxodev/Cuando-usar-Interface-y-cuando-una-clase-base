using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndBaseClassExample.ShareClient
{
    public class TwitterClient:ITwitterClient 
    {
        public void PublishTweet(string message)
        {
            try 
	        {	        
		        //se publica tweet 
	        }
	        catch (Exception)
	        {
		        //se escribe en un log el error y se lanza excepcion
	        }
        }
    }
}
