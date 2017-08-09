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
    /// ProjectLookupModel
    /// </summary>
    [DataContract]
    public partial class ProjectLookupModel :  IEquatable<ProjectLookupModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLookupModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectLookupModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLookupModel" /> class.
        /// </summary>
        /// <param name="ProjectId">ProjectId (required).</param>
        /// <param name="Name">Name.</param>
        public ProjectLookupModel(int? ProjectId = default(int?), string Name = default(string))
        {
            // to ensure "ProjectId" is required (not null)
            if (ProjectId == null)
            {
                throw new InvalidDataException("ProjectId is a required property for ProjectLookupModel and cannot be null");
            }
            else
            {
                this.ProjectId = ProjectId;
            }
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectLookupModel {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
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
            return this.Equals(obj as ProjectLookupModel);
        }

        /// <summary>
        /// Returns true if ProjectLookupModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectLookupModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectLookupModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProjectId == other.ProjectId ||
                    this.ProjectId != null &&
                    this.ProjectId.Equals(other.ProjectId)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Slug == other.Slug ||
                    this.Slug != null &&
                    this.Slug.Equals(other.Slug)
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
                if (this.ProjectId != null)
                    hash = hash * 59 + this.ProjectId.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Slug != null)
                    hash = hash * 59 + this.Slug.GetHashCode();
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
            // ProjectId (int?) minimum
            if(this.ProjectId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProjectId, must be a value greater than or equal to 0.", new [] { "ProjectId" });
            }

            yield break;
        }
    }

}
