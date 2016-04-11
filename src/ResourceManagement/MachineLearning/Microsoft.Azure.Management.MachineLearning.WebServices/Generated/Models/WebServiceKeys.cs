// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// web service Keys
    /// </summary>
    public partial class WebServiceKeys
    {
        /// <summary>
        /// Initializes a new instance of the WebServiceKeys class.
        /// </summary>
        public WebServiceKeys() { }

        /// <summary>
        /// Initializes a new instance of the WebServiceKeys class.
        /// </summary>
        public WebServiceKeys(string primary = default(string), string secondary = default(string))
        {
            Primary = primary;
            Secondary = secondary;
        }

        /// <summary>
        /// The Primary Key
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public string Primary { get; set; }

        /// <summary>
        /// The Secondary Key
        /// </summary>
        [JsonProperty(PropertyName = "secondary")]
        public string Secondary { get; set; }

    }
}
