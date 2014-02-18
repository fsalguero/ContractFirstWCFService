ContractFirstWCFService
=======================

This is a sample project that serves as a base for *contract first* WCF webservices, also can be useful for testing and getting the hang of wcf services

It includes:

* A behavior that validates the request and response against the defined schema.
* A hostFactory to validate authentication certificates, configurable by web.config on the service
* The client uses the certificates through *classic* web.config definition, so you will need to install the client .pfx and the service .cer as trusted people

Notes:

* The password used for the certificates is 'test'

TODO:
* Behavior to log requests and responses
