﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace ZebraRFIDIoTConnector_GPIOSample.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RAWMQTTCommand
    {
        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name = "command", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// Gets or Sets CommandId
        /// </summary>
        [DataMember(Name = "command_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "command_id")]
        public string CommandId { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payload")]
        public dynamic Payload { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RAWMQTTCommands {\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }

    }
}
