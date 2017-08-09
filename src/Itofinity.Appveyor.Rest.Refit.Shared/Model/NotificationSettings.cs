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
    /// This type is the union of the settings types for each of the various notification types supported by the API.  The properties correspond to the following notification types:  #### All Types - onBuildSuccess - onBuildFailure - onBuildStatusChanged  #### Campfire - account - authToken - room - template  #### Email - subjectTemplate - bodyTemplate - recipients - recipientsValue  #### GitHubPullRequest - authToken - template  #### HipChat - authToken - from - room - template - serverUrl  #### Slack - incomingWebhookUrl - authToken - channel - template  #### Webhook - method - url - headers - headersValue - addCustomRequestBody - customRequestBodyContentType - customRequestBody  #### VSOTeamRoom - vsoAccount - username - password - room - template 
    /// </summary>
    [DataContract]
    public partial class NotificationSettings :  IEquatable<NotificationSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSettings" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="OnBuildSuccess">OnBuildSuccess.</param>
        /// <param name="OnBuildFailure">OnBuildFailure.</param>
        /// <param name="OnBuildStatusChanged">OnBuildStatusChanged.</param>
        /// <param name="Account">Account.</param>
        /// <param name="AuthToken">AuthToken.</param>
        /// <param name="Room">Room.</param>
        /// <param name="Template">Template.</param>
        /// <param name="SubjectTemplate">SubjectTemplate.</param>
        /// <param name="BodyTemplate">BodyTemplate.</param>
        /// <param name="Recipients">Recipients.</param>
        /// <param name="RecipientsValue">RecipientsValue.</param>
        /// <param name="From">From.</param>
        /// <param name="ServerUrl">ServerUrl.</param>
        /// <param name="IncomingWebhookUrl">IncomingWebhookUrl.</param>
        /// <param name="Channel">Channel.</param>
        /// <param name="Method">Method.</param>
        /// <param name="Url">Url.</param>
        /// <param name="Headers">Headers.</param>
        /// <param name="HeadersValue">HeadersValue.</param>
        /// <param name="AddCustomRequestBody">AddCustomRequestBody.</param>
        /// <param name="CustomRequestBodyContentType">CustomRequestBodyContentType.</param>
        /// <param name="CustomRequestBody">CustomRequestBody.</param>
        /// <param name="VsoAccount">VsoAccount.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Password">Password.</param>
        public NotificationSettings(NotificationSettingsType Type = default(NotificationSettingsType), bool? OnBuildSuccess = default(bool?), bool? OnBuildFailure = default(bool?), bool? OnBuildStatusChanged = default(bool?), string Account = default(string), StoredValue AuthToken = default(StoredValue), string Room = default(string), string Template = default(string), string SubjectTemplate = default(string), string BodyTemplate = default(string), List<StringValueObject> Recipients = default(List<StringValueObject>), string RecipientsValue = default(string), string From = default(string), string ServerUrl = default(string), string IncomingWebhookUrl = default(string), string Channel = default(string), HttpMethodRestricted Method = default(HttpMethodRestricted), string Url = default(string), List<StoredNameValue> Headers = default(List<StoredNameValue>), string HeadersValue = default(string), bool? AddCustomRequestBody = default(bool?), string CustomRequestBodyContentType = default(string), string CustomRequestBody = default(string), string VsoAccount = default(string), string Username = default(string), StoredValue Password = default(StoredValue))
        {
            this.Type = Type;
            this.OnBuildSuccess = OnBuildSuccess;
            this.OnBuildFailure = OnBuildFailure;
            this.OnBuildStatusChanged = OnBuildStatusChanged;
            this.Account = Account;
            this.AuthToken = AuthToken;
            this.Room = Room;
            this.Template = Template;
            this.SubjectTemplate = SubjectTemplate;
            this.BodyTemplate = BodyTemplate;
            this.Recipients = Recipients;
            this.RecipientsValue = RecipientsValue;
            this.From = From;
            this.ServerUrl = ServerUrl;
            this.IncomingWebhookUrl = IncomingWebhookUrl;
            this.Channel = Channel;
            this.Method = Method;
            this.Url = Url;
            this.Headers = Headers;
            this.HeadersValue = HeadersValue;
            this.AddCustomRequestBody = AddCustomRequestBody;
            this.CustomRequestBodyContentType = CustomRequestBodyContentType;
            this.CustomRequestBody = CustomRequestBody;
            this.VsoAccount = VsoAccount;
            this.Username = Username;
            this.Password = Password;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="$type", EmitDefaultValue=false)]
        public NotificationSettingsType Type { get; set; }
        /// <summary>
        /// Gets or Sets OnBuildSuccess
        /// </summary>
        [DataMember(Name="onBuildSuccess", EmitDefaultValue=false)]
        public bool? OnBuildSuccess { get; set; }
        /// <summary>
        /// Gets or Sets OnBuildFailure
        /// </summary>
        [DataMember(Name="onBuildFailure", EmitDefaultValue=false)]
        public bool? OnBuildFailure { get; set; }
        /// <summary>
        /// Gets or Sets OnBuildStatusChanged
        /// </summary>
        [DataMember(Name="onBuildStatusChanged", EmitDefaultValue=false)]
        public bool? OnBuildStatusChanged { get; set; }
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }
        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name="authToken", EmitDefaultValue=false)]
        public StoredValue AuthToken { get; set; }
        /// <summary>
        /// Gets or Sets Room
        /// </summary>
        [DataMember(Name="room", EmitDefaultValue=false)]
        public string Room { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }
        /// <summary>
        /// Gets or Sets SubjectTemplate
        /// </summary>
        [DataMember(Name="subjectTemplate", EmitDefaultValue=false)]
        public string SubjectTemplate { get; set; }
        /// <summary>
        /// Gets or Sets BodyTemplate
        /// </summary>
        [DataMember(Name="bodyTemplate", EmitDefaultValue=false)]
        public string BodyTemplate { get; set; }
        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<StringValueObject> Recipients { get; set; }
        /// <summary>
        /// Gets or Sets RecipientsValue
        /// </summary>
        [DataMember(Name="recipientsValue", EmitDefaultValue=false)]
        public string RecipientsValue { get; set; }
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }
        /// <summary>
        /// Gets or Sets ServerUrl
        /// </summary>
        [DataMember(Name="serverUrl", EmitDefaultValue=false)]
        public string ServerUrl { get; set; }
        /// <summary>
        /// Gets or Sets IncomingWebhookUrl
        /// </summary>
        [DataMember(Name="incomingWebhookUrl", EmitDefaultValue=false)]
        public string IncomingWebhookUrl { get; set; }
        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public string Channel { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public HttpMethodRestricted Method { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<StoredNameValue> Headers { get; set; }
        /// <summary>
        /// Gets or Sets HeadersValue
        /// </summary>
        [DataMember(Name="headersValue", EmitDefaultValue=false)]
        public string HeadersValue { get; set; }
        /// <summary>
        /// Gets or Sets AddCustomRequestBody
        /// </summary>
        [DataMember(Name="addCustomRequestBody", EmitDefaultValue=false)]
        public bool? AddCustomRequestBody { get; set; }
        /// <summary>
        /// Gets or Sets CustomRequestBodyContentType
        /// </summary>
        [DataMember(Name="customRequestBodyContentType", EmitDefaultValue=false)]
        public string CustomRequestBodyContentType { get; set; }
        /// <summary>
        /// Gets or Sets CustomRequestBody
        /// </summary>
        [DataMember(Name="customRequestBody", EmitDefaultValue=false)]
        public string CustomRequestBody { get; set; }
        /// <summary>
        /// Gets or Sets VsoAccount
        /// </summary>
        [DataMember(Name="vsoAccount", EmitDefaultValue=false)]
        public string VsoAccount { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public StoredValue Password { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSettings {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OnBuildSuccess: ").Append(OnBuildSuccess).Append("\n");
            sb.Append("  OnBuildFailure: ").Append(OnBuildFailure).Append("\n");
            sb.Append("  OnBuildStatusChanged: ").Append(OnBuildStatusChanged).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            sb.Append("  Room: ").Append(Room).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  SubjectTemplate: ").Append(SubjectTemplate).Append("\n");
            sb.Append("  BodyTemplate: ").Append(BodyTemplate).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  RecipientsValue: ").Append(RecipientsValue).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ServerUrl: ").Append(ServerUrl).Append("\n");
            sb.Append("  IncomingWebhookUrl: ").Append(IncomingWebhookUrl).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  HeadersValue: ").Append(HeadersValue).Append("\n");
            sb.Append("  AddCustomRequestBody: ").Append(AddCustomRequestBody).Append("\n");
            sb.Append("  CustomRequestBodyContentType: ").Append(CustomRequestBodyContentType).Append("\n");
            sb.Append("  CustomRequestBody: ").Append(CustomRequestBody).Append("\n");
            sb.Append("  VsoAccount: ").Append(VsoAccount).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(obj as NotificationSettings);
        }

        /// <summary>
        /// Returns true if NotificationSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.OnBuildSuccess == other.OnBuildSuccess ||
                    this.OnBuildSuccess != null &&
                    this.OnBuildSuccess.Equals(other.OnBuildSuccess)
                ) && 
                (
                    this.OnBuildFailure == other.OnBuildFailure ||
                    this.OnBuildFailure != null &&
                    this.OnBuildFailure.Equals(other.OnBuildFailure)
                ) && 
                (
                    this.OnBuildStatusChanged == other.OnBuildStatusChanged ||
                    this.OnBuildStatusChanged != null &&
                    this.OnBuildStatusChanged.Equals(other.OnBuildStatusChanged)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.AuthToken == other.AuthToken ||
                    this.AuthToken != null &&
                    this.AuthToken.Equals(other.AuthToken)
                ) && 
                (
                    this.Room == other.Room ||
                    this.Room != null &&
                    this.Room.Equals(other.Room)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.SubjectTemplate == other.SubjectTemplate ||
                    this.SubjectTemplate != null &&
                    this.SubjectTemplate.Equals(other.SubjectTemplate)
                ) && 
                (
                    this.BodyTemplate == other.BodyTemplate ||
                    this.BodyTemplate != null &&
                    this.BodyTemplate.Equals(other.BodyTemplate)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
                ) && 
                (
                    this.RecipientsValue == other.RecipientsValue ||
                    this.RecipientsValue != null &&
                    this.RecipientsValue.Equals(other.RecipientsValue)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.ServerUrl == other.ServerUrl ||
                    this.ServerUrl != null &&
                    this.ServerUrl.Equals(other.ServerUrl)
                ) && 
                (
                    this.IncomingWebhookUrl == other.IncomingWebhookUrl ||
                    this.IncomingWebhookUrl != null &&
                    this.IncomingWebhookUrl.Equals(other.IncomingWebhookUrl)
                ) && 
                (
                    this.Channel == other.Channel ||
                    this.Channel != null &&
                    this.Channel.Equals(other.Channel)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) && 
                (
                    this.HeadersValue == other.HeadersValue ||
                    this.HeadersValue != null &&
                    this.HeadersValue.Equals(other.HeadersValue)
                ) && 
                (
                    this.AddCustomRequestBody == other.AddCustomRequestBody ||
                    this.AddCustomRequestBody != null &&
                    this.AddCustomRequestBody.Equals(other.AddCustomRequestBody)
                ) && 
                (
                    this.CustomRequestBodyContentType == other.CustomRequestBodyContentType ||
                    this.CustomRequestBodyContentType != null &&
                    this.CustomRequestBodyContentType.Equals(other.CustomRequestBodyContentType)
                ) && 
                (
                    this.CustomRequestBody == other.CustomRequestBody ||
                    this.CustomRequestBody != null &&
                    this.CustomRequestBody.Equals(other.CustomRequestBody)
                ) && 
                (
                    this.VsoAccount == other.VsoAccount ||
                    this.VsoAccount != null &&
                    this.VsoAccount.Equals(other.VsoAccount)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.OnBuildSuccess != null)
                    hash = hash * 59 + this.OnBuildSuccess.GetHashCode();
                if (this.OnBuildFailure != null)
                    hash = hash * 59 + this.OnBuildFailure.GetHashCode();
                if (this.OnBuildStatusChanged != null)
                    hash = hash * 59 + this.OnBuildStatusChanged.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.AuthToken != null)
                    hash = hash * 59 + this.AuthToken.GetHashCode();
                if (this.Room != null)
                    hash = hash * 59 + this.Room.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.SubjectTemplate != null)
                    hash = hash * 59 + this.SubjectTemplate.GetHashCode();
                if (this.BodyTemplate != null)
                    hash = hash * 59 + this.BodyTemplate.GetHashCode();
                if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                if (this.RecipientsValue != null)
                    hash = hash * 59 + this.RecipientsValue.GetHashCode();
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                if (this.ServerUrl != null)
                    hash = hash * 59 + this.ServerUrl.GetHashCode();
                if (this.IncomingWebhookUrl != null)
                    hash = hash * 59 + this.IncomingWebhookUrl.GetHashCode();
                if (this.Channel != null)
                    hash = hash * 59 + this.Channel.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                if (this.HeadersValue != null)
                    hash = hash * 59 + this.HeadersValue.GetHashCode();
                if (this.AddCustomRequestBody != null)
                    hash = hash * 59 + this.AddCustomRequestBody.GetHashCode();
                if (this.CustomRequestBodyContentType != null)
                    hash = hash * 59 + this.CustomRequestBodyContentType.GetHashCode();
                if (this.CustomRequestBody != null)
                    hash = hash * 59 + this.CustomRequestBody.GetHashCode();
                if (this.VsoAccount != null)
                    hash = hash * 59 + this.VsoAccount.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
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
