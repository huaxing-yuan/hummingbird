// This class is generated by Hummingbird Test Framework
// Hummingbird.TestFramework, A product of Hummingbird ALM tool set
// Hummingbird.TestManager, A product of Hummingbird ALM tool set
// Copyright (c) 2014-2018 Huaxing YUAN, All rights reserved
// Template created at: 2017-8-22  21:05 by Huaxing YUAN
using Hummingbird.TestFramework.Extensibility;
using Hummingbird.TestFramework.ExtensionProject;
using Hummingbird.TestFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Hummingbird.MS.Bot
{
    public class MyWebServiceExtension : WebServiceExtension
    {

        public override SoapClientService[] ClientServices
        {
            get
            {
                return new SoapClientService[]{

                };
            }
        }

        public override SoapServerService[] ServerServices
        {
            get
            {

                return new SoapServerService[]{

                };
            }
        }
    }

}
