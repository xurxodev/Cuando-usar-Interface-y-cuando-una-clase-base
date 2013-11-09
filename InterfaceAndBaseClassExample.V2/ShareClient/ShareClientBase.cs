using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndBaseClassExample.V2.ShareClient
{
    public abstract class ShareClientBase:IShareClient
    {
        public void Share(string message)
        {
            try
            {
                //se comparte 
                ShareText(message);
            }
            catch (Exception)
            {
                //se escribe en un log el error y se lanza excepcion
            }
        }

        protected abstract void ShareText(string message);
    }
}
