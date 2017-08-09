/* 
 * AppVeyor REST API
 *
 * AppVeyor is a hosted continuous integration service which runs on Microsoft Windows.  The AppVeyor REST API provides a RESTful way to interact with the AppVeyor service.  This includes managing projects, builds, deployments, and the teams that build them.  Additional help and discussion of the AppVeyor REST API is available at http://help.appveyor.com/discussions  This Swagger definition is an **unofficial** description of the AppVeyor REST API maintained at https://github.com/kevinoid/appveyor-swagger Please report any issues or suggestions for this Swagger definition at https://github.com/kevinoid/appveyor-swagger/issues/new  #### API Conventions  Fields which are missing from update operations (`PUT` requests) are typically reset to their default values.  So although most fields are not technically required, they should usually be specified in practice. 
 *
 * OpenAPI spec version: 0.20170106.0
 * Contact: team@appveyor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Itofinity.Appveyor.Rest.Refit.Model
{
    /// <summary>
    /// HostEntry
    /// </summary>
    [DataContract]
    public partial class HostEntry :  IEquatable<HostEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HostEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostEntry" /> class.
        /// </summary>
        /// <param name="Host">Host (required).</param>
        /// <param name="Ip">Ip (required).</param>
        public HostEntry(string Host = default(string), string Ip = default(string))
        {
            // to ensure "Host" is required (not null)
            if (Host == null)
            {
                throw new InvalidDataException("Host is a required property for HostEntry and cannot be null");
            }
            else
            {
                this.Host = Host;
            }
            // to ensure "Ip" is required (not null)
            if (Ip == null)
            {
                throw new InvalidDataException("Ip is a required property for HostEntry and cannot be null");
            }
            else
            {
                this.Ip = Ip;
            }
        }
        
        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }
        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostEntry {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as HostEntry);
        }

        /// <summary>
        /// Returns true if HostEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of HostEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) && 
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Host (string) minLength
            if(this.Host != null && this.Host.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Host, length must be greater than 1.", new [] { "Host" });
            }

            // Ip (string) minLength
            if(this.Ip != null && this.Ip.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ip, length must be greater than 1.", new [] { "Ip" });
            }

            yield break;
        }
    }

}