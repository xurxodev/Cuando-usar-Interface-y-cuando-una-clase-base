using InterfaceAndBaseClassExample.ShareClient;
using InterfaceAndBaseClassExample.V2.ShareClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndBaseClassExample.V2
{
    public class BlogService
    {
        private List<IShareClient> _clients;

        public BlogService(List<IShareClient> clients)
        {
            _clients = clients;
        }

        public void PublishPost(string htmlPost)
        {
            //publica post

            //publica en redes sociales
            foreach (IShareClient client in _clients)
            {
                client.Share("Nuevo post en...");
            }
            
        }
    }
}
