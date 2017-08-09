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
    /// ProjectWithConfiguration
    /// </summary>
    [DataContract]
    public partial class ProjectWithConfiguration :  IEquatable<ProjectWithConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWithConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectWithConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWithConfiguration" /> class.
        /// </summary>
        /// <param name="ProjectId">ProjectId (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="Builds">Only non-empty for response from getProjects..</param>
        /// <param name="RepositoryType">RepositoryType.</param>
        /// <param name="RepositoryScm">RepositoryScm.</param>
        /// <param name="RepositoryName">RepositoryName (required).</param>
        /// <param name="RepositoryBranch">Not present in response from addProject..</param>
        /// <param name="IsPrivate">IsPrivate.</param>
        /// <param name="SkipBranchesWithoutAppveyorYml">SkipBranchesWithoutAppveyorYml.</param>
        /// <param name="EnableSecureVariablesInPullRequests">EnableSecureVariablesInPullRequests.</param>
        /// <param name="EnableSecureVariablesInPullRequestsFromSameRepo">EnableSecureVariablesInPullRequestsFromSameRepo.</param>
        /// <param name="EnableDeploymentInPullRequests">EnableDeploymentInPullRequests.</param>
        /// <param name="RollingBuilds">RollingBuilds.</param>
        /// <param name="RollingBuildsDoNotCancelRunningBuilds">RollingBuildsDoNotCancelRunningBuilds.</param>
        /// <param name="AlwaysBuildClosedPullRequests">AlwaysBuildClosedPullRequests.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="NuGetFeed">Not present in response from addProject..</param>
        /// <param name="SecurityDescriptor">Not present in response from addProject. Not always present in response from getProjects (only after updateProject or startBuild?)..</param>
        /// <param name="VersionFormat">VersionFormat (required).</param>
        /// <param name="NextBuildNumber">NextBuildNumber.</param>
        /// <param name="ScheduleCrontabExpression">Build schedule as an NCrontab Expression.  See https://github.com/atifaziz/NCrontab/wiki/Crontab-Expression.</param>
        /// <param name="RepositoryAuthentication">RepositoryAuthentication.</param>
        /// <param name="RepositoryUsername">RepositoryUsername.</param>
        /// <param name="SshPublicKey">SshPublicKey.</param>
        /// <param name="WebhookId">WebhookId.</param>
        /// <param name="WebhookUrl">WebhookUrl.</param>
        /// <param name="StatusBadgeId">StatusBadgeId.</param>
        /// <param name="BuildPriority">BuildPriority.</param>
        /// <param name="IgnoreAppveyorYml">IgnoreAppveyorYml.</param>
        /// <param name="CustomYmlName">CustomYmlName.</param>
        /// <param name="Configuration">Configuration (required).</param>
        public ProjectWithConfiguration(int? ProjectId = default(int?), string Name = default(string), List<Build> Builds = default(List<Build>), RepositoryProvider RepositoryType = default(RepositoryProvider), RepositoryScm RepositoryScm = default(RepositoryScm), string RepositoryName = default(string), string RepositoryBranch = default(string), bool? IsPrivate = default(bool?), bool? SkipBranchesWithoutAppveyorYml = default(bool?), bool? EnableSecureVariablesInPullRequests = default(bool?), bool? EnableSecureVariablesInPullRequestsFromSameRepo = default(bool?), bool? EnableDeploymentInPullRequests = default(bool?), bool? RollingBuilds = default(bool?), bool? RollingBuildsDoNotCancelRunningBuilds = default(bool?), bool? AlwaysBuildClosedPullRequests = default(bool?), string Tags = default(string), NuGetFeed NuGetFeed = default(NuGetFeed), SecurityDescriptor SecurityDescriptor = default(SecurityDescriptor), string VersionFormat = default(string), int? NextBuildNumber = default(int?), string ScheduleCrontabExpression = default(string), RepositoryAuthenticationType RepositoryAuthentication = default(RepositoryAuthenticationType), string RepositoryUsername = default(string), string SshPublicKey = default(string), string WebhookId = default(string), string WebhookUrl = default(string), string StatusBadgeId = default(string), int? BuildPriority = default(int?), bool? IgnoreAppveyorYml = default(bool?), string CustomYmlName = default(string), ProjectConfiguration Configuration = default(ProjectConfiguration))
        {
            // to ensure "ProjectId" is required (not null)
            if (ProjectId == null)
            {
                throw new InvalidDataException("ProjectId is a required property for ProjectWithConfiguration and cannot be null");
            }
            else
            {
                this.ProjectId = ProjectId;
            }
            // to ensure "RepositoryName" is required (not null)
            if (RepositoryName == null)
            {
                throw new InvalidDataException("RepositoryName is a required property for ProjectWithConfiguration and cannot be null");
            }
            else
            {
                this.RepositoryName = RepositoryName;
            }
            // to ensure "VersionFormat" is required (not null)
            if (VersionFormat == null)
            {
                throw new InvalidDataException("VersionFormat is a required property for ProjectWithConfiguration and cannot be null");
            }
            else
            {
                this.VersionFormat = VersionFormat;
            }
            // to ensure "Configuration" is required (not null)
            if (Configuration == null)
            {
                throw new InvalidDataException("Configuration is a required property for ProjectWithConfiguration and cannot be null");
            }
            else
            {
                this.Configuration = Configuration;
            }
            this.Name = Name;
            this.Builds = Builds;
            this.RepositoryType = RepositoryType;
            this.RepositoryScm = RepositoryScm;
            this.RepositoryBranch = RepositoryBranch;
            this.IsPrivate = IsPrivate;
            this.SkipBranchesWithoutAppveyorYml = SkipBranchesWithoutAppveyorYml;
            this.EnableSecureVariablesInPullRequests = EnableSecureVariablesInPullRequests;
            this.EnableSecureVariablesInPullRequestsFromSameRepo = EnableSecureVariablesInPullRequestsFromSameRepo;
            this.EnableDeploymentInPullRequests = EnableDeploymentInPullRequests;
            this.RollingBuilds = RollingBuilds;
            this.RollingBuildsDoNotCancelRunningBuilds = RollingBuildsDoNotCancelRunningBuilds;
            this.AlwaysBuildClosedPullRequests = AlwaysBuildClosedPullRequests;
            this.Tags = Tags;
            this.NuGetFeed = NuGetFeed;
            this.SecurityDescriptor = SecurityDescriptor;
            this.NextBuildNumber = NextBuildNumber;
            this.ScheduleCrontabExpression = ScheduleCrontabExpression;
            this.RepositoryAuthentication = RepositoryAuthentication;
            this.RepositoryUsername = RepositoryUsername;
            this.SshPublicKey = SshPublicKey;
            this.WebhookId = WebhookId;
            this.WebhookUrl = WebhookUrl;
            this.StatusBadgeId = StatusBadgeId;
            this.BuildPriority = BuildPriority;
            this.IgnoreAppveyorYml = IgnoreAppveyorYml;
            this.CustomYmlName = CustomYmlName;
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
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; private set; }
        /// <summary>
        /// Only non-empty for response from getProjects.
        /// </summary>
        /// <value>Only non-empty for response from getProjects.</value>
        [DataMember(Name="builds", EmitDefaultValue=false)]
        public List<Build> Builds { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryType
        /// </summary>
        [DataMember(Name="repositoryType", EmitDefaultValue=false)]
        public RepositoryProvider RepositoryType { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryScm
        /// </summary>
        [DataMember(Name="repositoryScm", EmitDefaultValue=false)]
        public RepositoryScm RepositoryScm { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryName
        /// </summary>
        [DataMember(Name="repositoryName", EmitDefaultValue=false)]
        public string RepositoryName { get; set; }
        /// <summary>
        /// Not present in response from addProject.
        /// </summary>
        /// <value>Not present in response from addProject.</value>
        [DataMember(Name="repositoryBranch", EmitDefaultValue=false)]
        public string RepositoryBranch { get; set; }
        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name="isPrivate", EmitDefaultValue=false)]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// Gets or Sets SkipBranchesWithoutAppveyorYml
        /// </summary>
        [DataMember(Name="skipBranchesWithoutAppveyorYml", EmitDefaultValue=false)]
        public bool? SkipBranchesWithoutAppveyorYml { get; set; }
        /// <summary>
        /// Gets or Sets EnableSecureVariablesInPullRequests
        /// </summary>
        [DataMember(Name="enableSecureVariablesInPullRequests", EmitDefaultValue=false)]
        public bool? EnableSecureVariablesInPullRequests { get; set; }
        /// <summary>
        /// Gets or Sets EnableSecureVariablesInPullRequestsFromSameRepo
        /// </summary>
        [DataMember(Name="enableSecureVariablesInPullRequestsFromSameRepo", EmitDefaultValue=false)]
        public bool? EnableSecureVariablesInPullRequestsFromSameRepo { get; set; }
        /// <summary>
        /// Gets or Sets EnableDeploymentInPullRequests
        /// </summary>
        [DataMember(Name="enableDeploymentInPullRequests", EmitDefaultValue=false)]
        public bool? EnableDeploymentInPullRequests { get; set; }
        /// <summary>
        /// Gets or Sets RollingBuilds
        /// </summary>
        [DataMember(Name="rollingBuilds", EmitDefaultValue=false)]
        public bool? RollingBuilds { get; set; }
        /// <summary>
        /// Gets or Sets RollingBuildsDoNotCancelRunningBuilds
        /// </summary>
        [DataMember(Name="rollingBuildsDoNotCancelRunningBuilds", EmitDefaultValue=false)]
        public bool? RollingBuildsDoNotCancelRunningBuilds { get; set; }
        /// <summary>
        /// Gets or Sets AlwaysBuildClosedPullRequests
        /// </summary>
        [DataMember(Name="alwaysBuildClosedPullRequests", EmitDefaultValue=false)]
        public bool? AlwaysBuildClosedPullRequests { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }
        /// <summary>
        /// Not present in response from addProject.
        /// </summary>
        /// <value>Not present in response from addProject.</value>
        [DataMember(Name="nuGetFeed", EmitDefaultValue=false)]
        public NuGetFeed NuGetFeed { get; set; }
        /// <summary>
        /// Not present in response from addProject. Not always present in response from getProjects (only after updateProject or startBuild?).
        /// </summary>
        /// <value>Not present in response from addProject. Not always present in response from getProjects (only after updateProject or startBuild?).</value>
        [DataMember(Name="securityDescriptor", EmitDefaultValue=false)]
        public SecurityDescriptor SecurityDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets VersionFormat
        /// </summary>
        [DataMember(Name="versionFormat", EmitDefaultValue=false)]
        public string VersionFormat { get; set; }
        /// <summary>
        /// Gets or Sets NextBuildNumber
        /// </summary>
        [DataMember(Name="nextBuildNumber", EmitDefaultValue=false)]
        public int? NextBuildNumber { get; set; }
        /// <summary>
        /// Build schedule as an NCrontab Expression.  See https://github.com/atifaziz/NCrontab/wiki/Crontab-Expression
        /// </summary>
        /// <value>Build schedule as an NCrontab Expression.  See https://github.com/atifaziz/NCrontab/wiki/Crontab-Expression</value>
        [DataMember(Name="scheduleCrontabExpression", EmitDefaultValue=false)]
        public string ScheduleCrontabExpression { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryAuthentication
        /// </summary>
        [DataMember(Name="repositoryAuthentication", EmitDefaultValue=false)]
        public RepositoryAuthenticationType RepositoryAuthentication { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryUsername
        /// </summary>
        [DataMember(Name="repositoryUsername", EmitDefaultValue=false)]
        public string RepositoryUsername { get; set; }
        /// <summary>
        /// Gets or Sets SshPublicKey
        /// </summary>
        [DataMember(Name="sshPublicKey", EmitDefaultValue=false)]
        public string SshPublicKey { get; set; }
        /// <summary>
        /// Gets or Sets WebhookId
        /// </summary>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public string WebhookId { get; set; }
        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name="webhookUrl", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }
        /// <summary>
        /// Gets or Sets StatusBadgeId
        /// </summary>
        [DataMember(Name="statusBadgeId", EmitDefaultValue=false)]
        public string StatusBadgeId { get; set; }
        /// <summary>
        /// Gets or Sets BuildPriority
        /// </summary>
        [DataMember(Name="buildPriority", EmitDefaultValue=false)]
        public int? BuildPriority { get; set; }
        /// <summary>
        /// Gets or Sets IgnoreAppveyorYml
        /// </summary>
        [DataMember(Name="ignoreAppveyorYml", EmitDefaultValue=false)]
        public bool? IgnoreAppveyorYml { get; set; }
        /// <summary>
        /// Gets or Sets CustomYmlName
        /// </summary>
        [DataMember(Name="customYmlName", EmitDefaultValue=false)]
        public string CustomYmlName { get; set; }
        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public ProjectConfiguration Configuration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectWithConfiguration {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Builds: ").Append(Builds).Append("\n");
            sb.Append("  RepositoryType: ").Append(RepositoryType).Append("\n");
            sb.Append("  RepositoryScm: ").Append(RepositoryScm).Append("\n");
            sb.Append("  RepositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  RepositoryBranch: ").Append(RepositoryBranch).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  SkipBranchesWithoutAppveyorYml: ").Append(SkipBranchesWithoutAppveyorYml).Append("\n");
            sb.Append("  EnableSecureVariablesInPullRequests: ").Append(EnableSecureVariablesInPullRequests).Append("\n");
            sb.Append("  EnableSecureVariablesInPullRequestsFromSameRepo: ").Append(EnableSecureVariablesInPullRequestsFromSameRepo).Append("\n");
            sb.Append("  EnableDeploymentInPullRequests: ").Append(EnableDeploymentInPullRequests).Append("\n");
            sb.Append("  RollingBuilds: ").Append(RollingBuilds).Append("\n");
            sb.Append("  RollingBuildsDoNotCancelRunningBuilds: ").Append(RollingBuildsDoNotCancelRunningBuilds).Append("\n");
            sb.Append("  AlwaysBuildClosedPullRequests: ").Append(AlwaysBuildClosedPullRequests).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  NuGetFeed: ").Append(NuGetFeed).Append("\n");
            sb.Append("  SecurityDescriptor: ").Append(SecurityDescriptor).Append("\n");
            sb.Append("  VersionFormat: ").Append(VersionFormat).Append("\n");
            sb.Append("  NextBuildNumber: ").Append(NextBuildNumber).Append("\n");
            sb.Append("  ScheduleCrontabExpression: ").Append(ScheduleCrontabExpression).Append("\n");
            sb.Append("  RepositoryAuthentication: ").Append(RepositoryAuthentication).Append("\n");
            sb.Append("  RepositoryUsername: ").Append(RepositoryUsername).Append("\n");
            sb.Append("  SshPublicKey: ").Append(SshPublicKey).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  StatusBadgeId: ").Append(StatusBadgeId).Append("\n");
            sb.Append("  BuildPriority: ").Append(BuildPriority).Append("\n");
            sb.Append("  IgnoreAppveyorYml: ").Append(IgnoreAppveyorYml).Append("\n");
            sb.Append("  CustomYmlName: ").Append(CustomYmlName).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
            return this.Equals(obj as ProjectWithConfiguration);
        }

        /// <summary>
        /// Returns true if ProjectWithConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectWithConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectWithConfiguration other)
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
                ) && 
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Builds == other.Builds ||
                    this.Builds != null &&
                    this.Builds.SequenceEqual(other.Builds)
                ) && 
                (
                    this.RepositoryType == other.RepositoryType ||
                    this.RepositoryType != null &&
                    this.RepositoryType.Equals(other.RepositoryType)
                ) && 
                (
                    this.RepositoryScm == other.RepositoryScm ||
                    this.RepositoryScm != null &&
                    this.RepositoryScm.Equals(other.RepositoryScm)
                ) && 
                (
                    this.RepositoryName == other.RepositoryName ||
                    this.RepositoryName != null &&
                    this.RepositoryName.Equals(other.RepositoryName)
                ) && 
                (
                    this.RepositoryBranch == other.RepositoryBranch ||
                    this.RepositoryBranch != null &&
                    this.RepositoryBranch.Equals(other.RepositoryBranch)
                ) && 
                (
                    this.IsPrivate == other.IsPrivate ||
                    this.IsPrivate != null &&
                    this.IsPrivate.Equals(other.IsPrivate)
                ) && 
                (
                    this.SkipBranchesWithoutAppveyorYml == other.SkipBranchesWithoutAppveyorYml ||
                    this.SkipBranchesWithoutAppveyorYml != null &&
                    this.SkipBranchesWithoutAppveyorYml.Equals(other.SkipBranchesWithoutAppveyorYml)
                ) && 
                (
                    this.EnableSecureVariablesInPullRequests == other.EnableSecureVariablesInPullRequests ||
                    this.EnableSecureVariablesInPullRequests != null &&
                    this.EnableSecureVariablesInPullRequests.Equals(other.EnableSecureVariablesInPullRequests)
                ) && 
                (
                    this.EnableSecureVariablesInPullRequestsFromSameRepo == other.EnableSecureVariablesInPullRequestsFromSameRepo ||
                    this.EnableSecureVariablesInPullRequestsFromSameRepo != null &&
                    this.EnableSecureVariablesInPullRequestsFromSameRepo.Equals(other.EnableSecureVariablesInPullRequestsFromSameRepo)
                ) && 
                (
                    this.EnableDeploymentInPullRequests == other.EnableDeploymentInPullRequests ||
                    this.EnableDeploymentInPullRequests != null &&
                    this.EnableDeploymentInPullRequests.Equals(other.EnableDeploymentInPullRequests)
                ) && 
                (
                    this.RollingBuilds == other.RollingBuilds ||
                    this.RollingBuilds != null &&
                    this.RollingBuilds.Equals(other.RollingBuilds)
                ) && 
                (
                    this.RollingBuildsDoNotCancelRunningBuilds == other.RollingBuildsDoNotCancelRunningBuilds ||
                    this.RollingBuildsDoNotCancelRunningBuilds != null &&
                    this.RollingBuildsDoNotCancelRunningBuilds.Equals(other.RollingBuildsDoNotCancelRunningBuilds)
                ) && 
                (
                    this.AlwaysBuildClosedPullRequests == other.AlwaysBuildClosedPullRequests ||
                    this.AlwaysBuildClosedPullRequests != null &&
                    this.AlwaysBuildClosedPullRequests.Equals(other.AlwaysBuildClosedPullRequests)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.NuGetFeed == other.NuGetFeed ||
                    this.NuGetFeed != null &&
                    this.NuGetFeed.Equals(other.NuGetFeed)
                ) && 
                (
                    this.SecurityDescriptor == other.SecurityDescriptor ||
                    this.SecurityDescriptor != null &&
                    this.SecurityDescriptor.Equals(other.SecurityDescriptor)
                ) && 
                (
                    this.VersionFormat == other.VersionFormat ||
                    this.VersionFormat != null &&
                    this.VersionFormat.Equals(other.VersionFormat)
                ) && 
                (
                    this.NextBuildNumber == other.NextBuildNumber ||
                    this.NextBuildNumber != null &&
                    this.NextBuildNumber.Equals(other.NextBuildNumber)
                ) && 
                (
                    this.ScheduleCrontabExpression == other.ScheduleCrontabExpression ||
                    this.ScheduleCrontabExpression != null &&
                    this.ScheduleCrontabExpression.Equals(other.ScheduleCrontabExpression)
                ) && 
                (
                    this.RepositoryAuthentication == other.RepositoryAuthentication ||
                    this.RepositoryAuthentication != null &&
                    this.RepositoryAuthentication.Equals(other.RepositoryAuthentication)
                ) && 
                (
                    this.RepositoryUsername == other.RepositoryUsername ||
                    this.RepositoryUsername != null &&
                    this.RepositoryUsername.Equals(other.RepositoryUsername)
                ) && 
                (
                    this.SshPublicKey == other.SshPublicKey ||
                    this.SshPublicKey != null &&
                    this.SshPublicKey.Equals(other.SshPublicKey)
                ) && 
                (
                    this.WebhookId == other.WebhookId ||
                    this.WebhookId != null &&
                    this.WebhookId.Equals(other.WebhookId)
                ) && 
                (
                    this.WebhookUrl == other.WebhookUrl ||
                    this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(other.WebhookUrl)
                ) && 
                (
                    this.StatusBadgeId == other.StatusBadgeId ||
                    this.StatusBadgeId != null &&
                    this.StatusBadgeId.Equals(other.StatusBadgeId)
                ) && 
                (
                    this.BuildPriority == other.BuildPriority ||
                    this.BuildPriority != null &&
                    this.BuildPriority.Equals(other.BuildPriority)
                ) && 
                (
                    this.IgnoreAppveyorYml == other.IgnoreAppveyorYml ||
                    this.IgnoreAppveyorYml != null &&
                    this.IgnoreAppveyorYml.Equals(other.IgnoreAppveyorYml)
                ) && 
                (
                    this.CustomYmlName == other.CustomYmlName ||
                    this.CustomYmlName != null &&
                    this.CustomYmlName.Equals(other.CustomYmlName)
                ) && 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.Equals(other.Configuration)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Builds != null)
                    hash = hash * 59 + this.Builds.GetHashCode();
                if (this.RepositoryType != null)
                    hash = hash * 59 + this.RepositoryType.GetHashCode();
                if (this.RepositoryScm != null)
                    hash = hash * 59 + this.RepositoryScm.GetHashCode();
                if (this.RepositoryName != null)
                    hash = hash * 59 + this.RepositoryName.GetHashCode();
                if (this.RepositoryBranch != null)
                    hash = hash * 59 + this.RepositoryBranch.GetHashCode();
                if (this.IsPrivate != null)
                    hash = hash * 59 + this.IsPrivate.GetHashCode();
                if (this.SkipBranchesWithoutAppveyorYml != null)
                    hash = hash * 59 + this.SkipBranchesWithoutAppveyorYml.GetHashCode();
                if (this.EnableSecureVariablesInPullRequests != null)
                    hash = hash * 59 + this.EnableSecureVariablesInPullRequests.GetHashCode();
                if (this.EnableSecureVariablesInPullRequestsFromSameRepo != null)
                    hash = hash * 59 + this.EnableSecureVariablesInPullRequestsFromSameRepo.GetHashCode();
                if (this.EnableDeploymentInPullRequests != null)
                    hash = hash * 59 + this.EnableDeploymentInPullRequests.GetHashCode();
                if (this.RollingBuilds != null)
                    hash = hash * 59 + this.RollingBuilds.GetHashCode();
                if (this.RollingBuildsDoNotCancelRunningBuilds != null)
                    hash = hash * 59 + this.RollingBuildsDoNotCancelRunningBuilds.GetHashCode();
                if (this.AlwaysBuildClosedPullRequests != null)
                    hash = hash * 59 + this.AlwaysBuildClosedPullRequests.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.NuGetFeed != null)
                    hash = hash * 59 + this.NuGetFeed.GetHashCode();
                if (this.SecurityDescriptor != null)
                    hash = hash * 59 + this.SecurityDescriptor.GetHashCode();
                if (this.VersionFormat != null)
                    hash = hash * 59 + this.VersionFormat.GetHashCode();
                if (this.NextBuildNumber != null)
                    hash = hash * 59 + this.NextBuildNumber.GetHashCode();
                if (this.ScheduleCrontabExpression != null)
                    hash = hash * 59 + this.ScheduleCrontabExpression.GetHashCode();
                if (this.RepositoryAuthentication != null)
                    hash = hash * 59 + this.RepositoryAuthentication.GetHashCode();
                if (this.RepositoryUsername != null)
                    hash = hash * 59 + this.RepositoryUsername.GetHashCode();
                if (this.SshPublicKey != null)
                    hash = hash * 59 + this.SshPublicKey.GetHashCode();
                if (this.WebhookId != null)
                    hash = hash * 59 + this.WebhookId.GetHashCode();
                if (this.WebhookUrl != null)
                    hash = hash * 59 + this.WebhookUrl.GetHashCode();
                if (this.StatusBadgeId != null)
                    hash = hash * 59 + this.StatusBadgeId.GetHashCode();
                if (this.BuildPriority != null)
                    hash = hash * 59 + this.BuildPriority.GetHashCode();
                if (this.IgnoreAppveyorYml != null)
                    hash = hash * 59 + this.IgnoreAppveyorYml.GetHashCode();
                if (this.CustomYmlName != null)
                    hash = hash * 59 + this.CustomYmlName.GetHashCode();
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
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

            // AccountId (int?) minimum
            if(this.AccountId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, must be a value greater than or equal to 0.", new [] { "AccountId" });
            }

            // VersionFormat (string) minLength
            if(this.VersionFormat != null && this.VersionFormat.Length < 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VersionFormat, length must be greater than 7.", new [] { "VersionFormat" });
            }

            // VersionFormat (string) pattern
            Regex regexVersionFormat = new Regex(@"[{]build[}]", RegexOptions.CultureInvariant);
            if (false == regexVersionFormat.Match(this.VersionFormat).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VersionFormat, must match a pattern of /[{]build[}]/.", new [] { "VersionFormat" });
            }

            // BuildPriority (int?) minimum
            if(this.BuildPriority < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildPriority, must be a value greater than or equal to 1.", new [] { "BuildPriority" });
            }

            yield break;
        }
    }

}
