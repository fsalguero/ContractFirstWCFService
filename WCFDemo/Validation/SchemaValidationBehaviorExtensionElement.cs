
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Configuration;
using System.Configuration;
using System.Xml.Schema;
using System.Xml;

namespace Microsoft.ServiceModel.Samples
{
    public class SchemaValidationBehaviorExtensionElement : BehaviorExtensionElement
    {
        public SchemaValidationBehaviorExtensionElement() 
        {
        }

        public override Type BehaviorType 
        { 
            get
            {
                return typeof(SchemaValidationBehavior);
            } 
        }

        protected override object CreateBehavior()
        {
            return new SchemaValidationBehavior(ValidateRequest,ValidateReply);
        }

        [ConfigurationProperty("validateRequest",DefaultValue=false,IsRequired=false)]
        public bool ValidateRequest
        {
            get { return (bool)base["validateRequest"]; }
            set { base["validateRequest"] = value; }
        }

        [ConfigurationProperty("validateReply", DefaultValue = false, IsRequired = false)]
        public bool ValidateReply
        {
            get { return (bool)base["validateReply"]; }
            set { base["validateReply"] = value; }
        }
    }
}