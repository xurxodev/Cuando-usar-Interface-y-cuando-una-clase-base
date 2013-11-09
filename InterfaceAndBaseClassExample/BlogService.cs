using InterfaceAndBaseClassExample.ShareClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAndBaseClassExample
{
    public class BlogService
    {
        private ITwitterClient _twitterClient;

        public BlogService(ITwitterClient twitterClient)
        {
            _twitterClient = twitterClient;
        }

        public void PublishPost(string htmlPost)
        {
            //publica post

            //publica en twitter
            _twitterClient.PublishTweet("Nuevo post en...");
        }
    }
}
