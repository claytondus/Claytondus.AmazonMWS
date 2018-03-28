using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceWebService.Attributes
{
    using System;
    using System.Reflection;

    // create custom attribute to be assigned to class members
    [AttributeUsage(
       AttributeTargets.Class |
       AttributeTargets.Constructor |
       AttributeTargets.Field |
       AttributeTargets.Method |
       AttributeTargets.Property,
       AllowMultiple = true)]


    public class MarketplaceWebServiceAttribute : System.Attribute
    {

        private RequestType requestType;

        public RequestType RequestType
        {
            get { return this.requestType; }
            set { this.requestType = value; }
        }

        private ResponseType responseType;

        public ResponseType ResponseType
        {
            get { return this.responseType; }
            set { this.responseType = value; }
        }

        private bool isReceiveStream;

        public bool IsReceiveStream
        {
            get { return this.isReceiveStream; }
            set { this.isReceiveStream = value; }
        }

        private bool isRequestStream;

        public bool IsRequestStream
        {
            get { return this.isRequestStream; }
            set { this.isRequestStream = value; }
        }

    }
}
