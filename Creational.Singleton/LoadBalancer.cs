using System;
using System.Collections.Generic;

namespace Creational.Singleton
{
    class LoadBalancer : ILoadBalancer
    {
        private static LoadBalancer _instance;
        private readonly List<string> _servers = new List<string>();
        private readonly Random _random = new Random();

        private static readonly object syncLock = new object();

        public LoadBalancer()
        {
            _servers.Add("Server1");
            _servers.Add("Server2");
            _servers.Add("Server3");
            _servers.Add("Server4");
            _servers.Add("Server5");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}