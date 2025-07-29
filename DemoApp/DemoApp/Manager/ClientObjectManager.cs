using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Objects;
using DemoApp.Objects;

namespace DemoApp
{
    public class ClientObjectManager : ObjectManager
    {
        private static ClientObjectManager instance = null;

        public ClientObjectManager(SimpleObjectModelDiscovery modelDiscovery)
            : base(modelDiscovery)
        {
            if (instance == null)
                instance = this;
        }

        public static ClientObjectManager Instance
        {
            get { return instance; }
        }
    }
}
