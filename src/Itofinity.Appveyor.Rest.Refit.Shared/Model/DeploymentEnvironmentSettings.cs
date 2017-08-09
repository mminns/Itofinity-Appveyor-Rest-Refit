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
    /// DeploymentEnvironmentSettings
    /// </summary>
    [DataContract]
    public partial class DeploymentEnvironmentSettings :  IEquatable<DeploymentEnvironmentSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentEnvironmentSettings" /> class.
        /// </summary>
        /// <param name="ProviderSettings">ProviderSettings.</param>
        /// <param name="EnvironmentVariables">EnvironmentVariables.</param>
        /// <param name="Notifications">Notifications.</param>
        public DeploymentEnvironmentSettings(List<StoredNameValue> ProviderSettings = default(List<StoredNameValue>), List<StoredNameValue> EnvironmentVariables = default(List<StoredNameValue>), List<NotificationProviderSettings> Notifications = default(List<NotificationProviderSettings>))
        {
            this.ProviderSettings = ProviderSettings;
            this.EnvironmentVariables = EnvironmentVariables;
            this.Notifications = Notifications;
        }
        
        /// <summary>
        /// Gets or Sets ProviderSettings
        /// </summary>
        [DataMember(Name="providerSettings", EmitDefaultValue=false)]
        public List<StoredNameValue> ProviderSettings { get; set; }
        /// <summary>
        /// Gets or Sets EnvironmentVariables
        /// </summary>
        [DataMember(Name="environmentVariables", EmitDefaultValue=false)]
        public List<StoredNameValue> EnvironmentVariables { get; set; }
        /// <summary>
        /// Gets or Sets Notifications
        /// </summary>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public List<NotificationProviderSettings> Notifications { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentEnvironmentSettings {\n");
            sb.Append("  ProviderSettings: ").Append(ProviderSettings).Append("\n");
            sb.Append("  EnvironmentVariables: ").Append(EnvironmentVariables).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
            return this.Equals(obj as DeploymentEnvironmentSettings);
        }

        /// <summary>
        /// Returns true if DeploymentEnvironmentSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of DeploymentEnvironmentSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentEnvironmentSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProviderSettings == other.ProviderSettings ||
                    this.ProviderSettings != null &&
                    this.ProviderSettings.SequenceEqual(other.ProviderSettings)
                ) && 
                (
                    this.EnvironmentVariables == other.EnvironmentVariables ||
                    this.EnvironmentVariables != null &&
                    this.EnvironmentVariables.SequenceEqual(other.EnvironmentVariables)
                ) && 
                (
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.SequenceEqual(other.Notifications)
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
                if (this.ProviderSettings != null)
                    hash = hash * 59 + this.ProviderSettings.GetHashCode();
                if (this.EnvironmentVariables != null)
                    hash = hash * 59 + this.EnvironmentVariables.GetHashCode();
                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();
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
            yield break;
        }
    }

}