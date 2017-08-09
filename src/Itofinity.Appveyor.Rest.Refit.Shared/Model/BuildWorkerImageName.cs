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
    /// Defines BuildWorkerImageName
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuildWorkerImageName
    {
        
        /// <summary>
        /// Enum PreviousVisualStudio2013 for "Previous Visual Studio 2013"
        /// </summary>
        [EnumMember(Value = "Previous Visual Studio 2013")]
        PreviousVisualStudio2013,
        
        /// <summary>
        /// Enum PreviousVisualStudio2015 for "Previous Visual Studio 2015"
        /// </summary>
        [EnumMember(Value = "Previous Visual Studio 2015")]
        PreviousVisualStudio2015,
        
        /// <summary>
        /// Enum PreviousVisualStudio2017 for "Previous Visual Studio 2017"
        /// </summary>
        [EnumMember(Value = "Previous Visual Studio 2017")]
        PreviousVisualStudio2017,
        
        /// <summary>
        /// Enum Ubuntu for "Ubuntu"
        /// </summary>
        [EnumMember(Value = "Ubuntu")]
        Ubuntu,
        
        /// <summary>
        /// Enum VisualStudio2013 for "Visual Studio 2013"
        /// </summary>
        [EnumMember(Value = "Visual Studio 2013")]
        VisualStudio2013,
        
        /// <summary>
        /// Enum VisualStudio2015 for "Visual Studio 2015"
        /// </summary>
        [EnumMember(Value = "Visual Studio 2015")]
        VisualStudio2015,
        
        /// <summary>
        /// Enum VisualStudio2017 for "Visual Studio 2017"
        /// </summary>
        [EnumMember(Value = "Visual Studio 2017")]
        VisualStudio2017,
        
        /// <summary>
        /// Enum VisualStudio2017Preview for "Visual Studio 2017 Preview"
        /// </summary>
        [EnumMember(Value = "Visual Studio 2017 Preview")]
        VisualStudio2017Preview,
        
        /// <summary>
        /// Enum WMF5 for "WMF 5"
        /// </summary>
        [EnumMember(Value = "WMF 5")]
        WMF5
    }

}