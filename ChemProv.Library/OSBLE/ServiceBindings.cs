﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ChemProV.Library.OSBLE
{
    public class ServiceBindings
    {
        public static EndpointAddress AuthenticationServiceEndpoint
        {
            get
            {
                return RemoteAuthenticationEndpoint;
            }
        }

        public static EndpointAddress LocalAuthenticationEndpoint
        {
            get
            {
                EndpointAddress endpoint = new EndpointAddress("https://localhost:17532/Services/AuthenticationService.svc");
                return endpoint;
            }
        }

        public static EndpointAddress RemoteAuthenticationEndpoint
        {
            get
            {
                EndpointAddress endpoint = new EndpointAddress("https://osble.org/Services/AuthenticationService.svc");
                return endpoint;
            }
        }

        public static Binding AuthenticationServiceBinding
        {
            get
            {
                BasicHttpBinding binding = new BasicHttpBinding()
                {
                    Name = "BasicHttpBinding_AuthenticationService",
                    MaxBufferSize = 2147483647,
                    MaxReceivedMessageSize = 2147483647,
                    SendTimeout = new TimeSpan(0, 0, 15, 0, 0),
                    ReceiveTimeout = new TimeSpan(0, 0, 15, 0, 0),
                };

#if false
                binding.Security.Mode = BasicHttpSecurityMode.None;
#else
                binding.Security.Mode = BasicHttpSecurityMode.Transport;
#endif
                return binding;
            }
        }
    }
}
