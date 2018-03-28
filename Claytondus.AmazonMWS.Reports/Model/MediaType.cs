using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MarketplaceWebService.Model
{
    /// <summary>
    /// Enumeration of valid media types for the ContentType object.  The description attribute
    /// of each enumeration value is used to define the value output to the http stream.
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// Indicates the content is sent as an octet-stream ("application/octet-stream").
        /// Currently, this is the only supported content type.
        /// </summary>
        [Description("application/octet-stream")]
        OctetStream
    }
}
