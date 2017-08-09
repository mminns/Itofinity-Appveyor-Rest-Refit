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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using Itofinity.Appveyor.Rest.Refit.Client;
using Itofinity.Appveyor.Rest.Refit.Model;

namespace Itofinity.Appveyor.Rest.Refit.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoleApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Add role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Rest.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of RoleWithGroups</returns>
        [Post("/roles")]
        System.Threading.Tasks.Task<RoleWithGroups> AddRole([Header("UserAgent")] string userAgent, [Body]RoleAddition body);

        /// <summary>
        /// Delete role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Rest.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of void</returns>
        [Delete("/roles/{roleId}")]
        System.Threading.Tasks.Task DeleteRole([Header("UserAgent")] string userAgent, [AliasAs("roleId")]int? roleId);

        /// <summary>
        /// Get role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Rest.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role ID</param>
        /// <returns>Task of RoleWithGroups</returns>
        [Get("/roles/{roleId}")]
        System.Threading.Tasks.Task<RoleWithGroups> GetRole([Header("UserAgent")] string userAgent, [AliasAs("roleId")]int? roleId);

        /// <summary>
        /// Get roles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Rest.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Role&gt;</returns>
        [Get("/roles")]
        System.Threading.Tasks.Task<List<Role>> GetRoles([Header("UserAgent")] string userAgent);

        /// <summary>
        /// Update role
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Appveyor.Rest.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of RoleWithGroups</returns>
        [Put("/roles")]
        System.Threading.Tasks.Task<RoleWithGroups> UpdateRole([Header("UserAgent")] string userAgent, [Body]RoleWithGroups body);
        #endregion Asynchronous Operations
    }
}
