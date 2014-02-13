
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Description;
using System.Xml.Schema;
using System.Xml.Linq;


namespace Microsoft.ServiceModel.Samples
{
    public class SchemaValidationBehavior : IEndpointBehavior
    {
        bool validateRequest;
        bool validateReply;

        public SchemaValidationBehavior(bool inspectRequest, bool inspectReply)
        {
            this.validateReply = inspectReply;
            this.validateRequest = inspectRequest;
        }

        #region IEndpointBehavior Members

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            //WsdlExporter exporter = new WsdlExporter();
            //exporter.ExportContract(endpoint.Contract);

            XmlSchemaSet sc = new XmlSchemaSet();
            sc.Add(null, "http://localhost:36122/Demo.xsd");

            SchemaValidationMessageInspector inspector = new SchemaValidationMessageInspector(sc, validateRequest, validateReply, true);
            clientRuntime.MessageInspectors.Add(inspector);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
            //WsdlExporter exporter = new WsdlExporter();
            //exporter.ExportContract(endpoint.Contract);

            XmlSchemaSet sc = new XmlSchemaSet();
            sc.Add(null, "http://localhost:36122/Demo.xsd");

            SchemaValidationMessageInspector inspector = new SchemaValidationMessageInspector(sc, validateRequest, validateReply, false);
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(inspector);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        #endregion
    }
}
