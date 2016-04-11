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
    /// [TODO] Graph Parameters
    /// </summary>
    public partial class GraphParameter
    {
        /// <summary>
        /// Initializes a new instance of the GraphParameter class.
        /// </summary>
        public GraphParameter() { }

        /// <summary>
        /// Initializes a new instance of the GraphParameter class.
        /// </summary>
        public GraphParameter(string description = default(string), ParameterType? type = default(ParameterType?), IList<GraphParameterLink> links = default(IList<GraphParameterLink>))
        {
            Description = description;
            Type = type;
            Links = links;
        }

        /// <summary>
        /// Description for this graph parameter.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Graph parameter's type. Possible values include: 'String', 'Int',
        /// 'Float', 'Enumerated', 'Script', 'Mode', 'Credential', 'Boolean',
        /// 'Double', 'ColumnPicker', 'ParameterRange', 'DataGatewayName'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ParameterType? Type { get; set; }

        /// <summary>
        /// [TODO] Links of this parameter
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<GraphParameterLink> Links { get; set; }

    }
}
