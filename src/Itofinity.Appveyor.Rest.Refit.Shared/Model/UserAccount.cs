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
    /// UserAccount
    /// </summary>
    [DataContract]
    public partial class UserAccount :  IEquatable<UserAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccount" /> class.
        /// </summary>
        /// <param name="SuccessfulBuildNotification">SuccessfulBuildNotification (required).</param>
        /// <param name="FailedBuildNotification">FailedBuildNotification (required).</param>
        /// <param name="NotifyWhenBuildStatusChangedOnly">Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update.  (default to false).</param>
        /// <param name="SuccessfulDeploymentNotification">SuccessfulDeploymentNotification (required).</param>
        /// <param name="FailedDeploymentNotification">FailedDeploymentNotification (required).</param>
        /// <param name="NotifyWhenDeploymentStatusChangedOnly">Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update.  (default to false).</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="FullName">FullName (required).</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="Password">Password.</param>
        /// <param name="RoleId">RoleId.</param>
        public UserAccount(BuildNotificationFrequency SuccessfulBuildNotification = default(BuildNotificationFrequency), BuildNotificationFrequency FailedBuildNotification = default(BuildNotificationFrequency), bool? NotifyWhenBuildStatusChangedOnly = false, DeploymentNotificationFrequency SuccessfulDeploymentNotification = default(DeploymentNotificationFrequency), DeploymentNotificationFrequency FailedDeploymentNotification = default(DeploymentNotificationFrequency), bool? NotifyWhenDeploymentStatusChangedOnly = false, int? UserId = default(int?), string FullName = default(string), string Email = default(string), string Password = default(string), int? RoleId = default(int?))
        {
            // to ensure "SuccessfulBuildNotification" is required (not null)
            if (SuccessfulBuildNotification == null)
            {
                throw new InvalidDataException("SuccessfulBuildNotification is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.SuccessfulBuildNotification = SuccessfulBuildNotification;
            }
            // to ensure "FailedBuildNotification" is required (not null)
            if (FailedBuildNotification == null)
            {
                throw new InvalidDataException("FailedBuildNotification is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.FailedBuildNotification = FailedBuildNotification;
            }
            // to ensure "SuccessfulDeploymentNotification" is required (not null)
            if (SuccessfulDeploymentNotification == null)
            {
                throw new InvalidDataException("SuccessfulDeploymentNotification is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.SuccessfulDeploymentNotification = SuccessfulDeploymentNotification;
            }
            // to ensure "FailedDeploymentNotification" is required (not null)
            if (FailedDeploymentNotification == null)
            {
                throw new InvalidDataException("FailedDeploymentNotification is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.FailedDeploymentNotification = FailedDeploymentNotification;
            }
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // use default value if no "NotifyWhenBuildStatusChangedOnly" provided
            if (NotifyWhenBuildStatusChangedOnly == null)
            {
                this.NotifyWhenBuildStatusChangedOnly = false;
            }
            else
            {
                this.NotifyWhenBuildStatusChangedOnly = NotifyWhenBuildStatusChangedOnly;
            }
            // use default value if no "NotifyWhenDeploymentStatusChangedOnly" provided
            if (NotifyWhenDeploymentStatusChangedOnly == null)
            {
                this.NotifyWhenDeploymentStatusChangedOnly = false;
            }
            else
            {
                this.NotifyWhenDeploymentStatusChangedOnly = NotifyWhenDeploymentStatusChangedOnly;
            }
            this.UserId = UserId;
            this.Password = Password;
            this.RoleId = RoleId;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; private set; }
        /// <summary>
        /// Gets or Sets SuccessfulBuildNotification
        /// </summary>
        [DataMember(Name="successfulBuildNotification", EmitDefaultValue=false)]
        public BuildNotificationFrequency SuccessfulBuildNotification { get; set; }
        /// <summary>
        /// Gets or Sets FailedBuildNotification
        /// </summary>
        [DataMember(Name="failedBuildNotification", EmitDefaultValue=false)]
        public BuildNotificationFrequency FailedBuildNotification { get; set; }
        /// <summary>
        /// Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update. 
        /// </summary>
        /// <value>Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update. </value>
        [DataMember(Name="notifyWhenBuildStatusChangedOnly", EmitDefaultValue=false)]
        public bool? NotifyWhenBuildStatusChangedOnly { get; set; }
        /// <summary>
        /// Gets or Sets SuccessfulDeploymentNotification
        /// </summary>
        [DataMember(Name="successfulDeploymentNotification", EmitDefaultValue=false)]
        public DeploymentNotificationFrequency SuccessfulDeploymentNotification { get; set; }
        /// <summary>
        /// Gets or Sets FailedDeploymentNotification
        /// </summary>
        [DataMember(Name="failedDeploymentNotification", EmitDefaultValue=false)]
        public DeploymentNotificationFrequency FailedDeploymentNotification { get; set; }
        /// <summary>
        /// Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update. 
        /// </summary>
        /// <value>Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update. </value>
        [DataMember(Name="notifyWhenDeploymentStatusChangedOnly", EmitDefaultValue=false)]
        public bool? NotifyWhenDeploymentStatusChangedOnly { get; set; }
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; private set; }
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; private set; }
        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name="isOwner", EmitDefaultValue=false)]
        public bool? IsOwner { get; private set; }
        /// <summary>
        /// Gets or Sets IsCollaborator
        /// </summary>
        [DataMember(Name="isCollaborator", EmitDefaultValue=false)]
        public bool? IsCollaborator { get; private set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public int? RoleId { get; set; }
        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; private set; }
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccount {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  SuccessfulBuildNotification: ").Append(SuccessfulBuildNotification).Append("\n");
            sb.Append("  FailedBuildNotification: ").Append(FailedBuildNotification).Append("\n");
            sb.Append("  NotifyWhenBuildStatusChangedOnly: ").Append(NotifyWhenBuildStatusChangedOnly).Append("\n");
            sb.Append("  SuccessfulDeploymentNotification: ").Append(SuccessfulDeploymentNotification).Append("\n");
            sb.Append("  FailedDeploymentNotification: ").Append(FailedDeploymentNotification).Append("\n");
            sb.Append("  NotifyWhenDeploymentStatusChangedOnly: ").Append(NotifyWhenDeploymentStatusChangedOnly).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  IsCollaborator: ").Append(IsCollaborator).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(obj as UserAccount);
        }

        /// <summary>
        /// Returns true if UserAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.SuccessfulBuildNotification == other.SuccessfulBuildNotification ||
                    this.SuccessfulBuildNotification != null &&
                    this.SuccessfulBuildNotification.Equals(other.SuccessfulBuildNotification)
                ) && 
                (
                    this.FailedBuildNotification == other.FailedBuildNotification ||
                    this.FailedBuildNotification != null &&
                    this.FailedBuildNotification.Equals(other.FailedBuildNotification)
                ) && 
                (
                    this.NotifyWhenBuildStatusChangedOnly == other.NotifyWhenBuildStatusChangedOnly ||
                    this.NotifyWhenBuildStatusChangedOnly != null &&
                    this.NotifyWhenBuildStatusChangedOnly.Equals(other.NotifyWhenBuildStatusChangedOnly)
                ) && 
                (
                    this.SuccessfulDeploymentNotification == other.SuccessfulDeploymentNotification ||
                    this.SuccessfulDeploymentNotification != null &&
                    this.SuccessfulDeploymentNotification.Equals(other.SuccessfulDeploymentNotification)
                ) && 
                (
                    this.FailedDeploymentNotification == other.FailedDeploymentNotification ||
                    this.FailedDeploymentNotification != null &&
                    this.FailedDeploymentNotification.Equals(other.FailedDeploymentNotification)
                ) && 
                (
                    this.NotifyWhenDeploymentStatusChangedOnly == other.NotifyWhenDeploymentStatusChangedOnly ||
                    this.NotifyWhenDeploymentStatusChangedOnly != null &&
                    this.NotifyWhenDeploymentStatusChangedOnly.Equals(other.NotifyWhenDeploymentStatusChangedOnly)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.IsOwner == other.IsOwner ||
                    this.IsOwner != null &&
                    this.IsOwner.Equals(other.IsOwner)
                ) && 
                (
                    this.IsCollaborator == other.IsCollaborator ||
                    this.IsCollaborator != null &&
                    this.IsCollaborator.Equals(other.IsCollaborator)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.SuccessfulBuildNotification != null)
                    hash = hash * 59 + this.SuccessfulBuildNotification.GetHashCode();
                if (this.FailedBuildNotification != null)
                    hash = hash * 59 + this.FailedBuildNotification.GetHashCode();
                if (this.NotifyWhenBuildStatusChangedOnly != null)
                    hash = hash * 59 + this.NotifyWhenBuildStatusChangedOnly.GetHashCode();
                if (this.SuccessfulDeploymentNotification != null)
                    hash = hash * 59 + this.SuccessfulDeploymentNotification.GetHashCode();
                if (this.FailedDeploymentNotification != null)
                    hash = hash * 59 + this.FailedDeploymentNotification.GetHashCode();
                if (this.NotifyWhenDeploymentStatusChangedOnly != null)
                    hash = hash * 59 + this.NotifyWhenDeploymentStatusChangedOnly.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.IsOwner != null)
                    hash = hash * 59 + this.IsOwner.GetHashCode();
                if (this.IsCollaborator != null)
                    hash = hash * 59 + this.IsCollaborator.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null)
                    hash = hash * 59 + this.RoleName.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
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
            // AccountId (int?) minimum
            if(this.AccountId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, must be a value greater than or equal to 0.", new [] { "AccountId" });
            }

            // UserId (int?) minimum
            if(this.UserId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserId, must be a value greater than or equal to 0.", new [] { "UserId" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 1.", new [] { "Password" });
            }

            // RoleId (int?) minimum
            if(this.RoleId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoleId, must be a value greater than or equal to 0.", new [] { "RoleId" });
            }

            // PageSize (int?) minimum
            if(this.PageSize < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value greater than or equal to 0.", new [] { "PageSize" });
            }

            yield break;
        }
    }

}
