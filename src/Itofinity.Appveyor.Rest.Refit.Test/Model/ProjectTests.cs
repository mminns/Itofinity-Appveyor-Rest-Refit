/* 
 * AppVeyor REST API
 *
 * AppVeyor is a hosted continuous integration service which runs on Microsoft Windows.  The AppVeyor REST API provides a RESTful way to interact with the AppVeyor service.  This includes managing projects, builds, deployments, and the teams that build them.  Additional help and discussion of the AppVeyor REST API is available at http://help.appveyor.com/discussions  This Swagger definition is an **unofficial** description of the AppVeyor REST API maintained at https://github.com/kevinoid/appveyor-swagger Please report any issues or suggestions for this Swagger definition at https://github.com/kevinoid/appveyor-swagger/issues/new  #### API Conventions  Fields which are missing from update operations (`PUT` requests) are typically reset to their default values.  So although most fields are not technically required, they should usually be specified in practice. 
 *
 * OpenAPI spec version: 0.20170106.0
 * Contact: team@appveyor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Itofinity.Appveyor.Rest.Refit.Api;
using Itofinity.Appveyor.Rest.Refit.Model;
using Itofinity.Appveyor.Rest.Refit.Client;
using System.Reflection;

namespace Itofinity.Appveyor.Rest.Refit.Test
{
    /// <summary>
    ///  Class for testing Project
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProjectTests
    {
        // TODO uncomment below to declare an instance variable for Project
        //private Project instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Project
            //instance = new Project();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Project
        /// </summary>
        [Test]
        public void ProjectInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Project
            //Assert.IsInstanceOfType<Project> (instance, "variable 'instance' is a Project");
        }

        /// <summary>
        /// Test the property 'ProjectId'
        /// </summary>
        [Test]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'AccountName'
        /// </summary>
        [Test]
        public void AccountNameTest()
        {
            // TODO unit test for the property 'AccountName'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Slug'
        /// </summary>
        [Test]
        public void SlugTest()
        {
            // TODO unit test for the property 'Slug'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Test]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Test]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'Builds'
        /// </summary>
        [Test]
        public void BuildsTest()
        {
            // TODO unit test for the property 'Builds'
        }
        /// <summary>
        /// Test the property 'RepositoryType'
        /// </summary>
        [Test]
        public void RepositoryTypeTest()
        {
            // TODO unit test for the property 'RepositoryType'
        }
        /// <summary>
        /// Test the property 'RepositoryScm'
        /// </summary>
        [Test]
        public void RepositoryScmTest()
        {
            // TODO unit test for the property 'RepositoryScm'
        }
        /// <summary>
        /// Test the property 'RepositoryName'
        /// </summary>
        [Test]
        public void RepositoryNameTest()
        {
            // TODO unit test for the property 'RepositoryName'
        }
        /// <summary>
        /// Test the property 'RepositoryBranch'
        /// </summary>
        [Test]
        public void RepositoryBranchTest()
        {
            // TODO unit test for the property 'RepositoryBranch'
        }
        /// <summary>
        /// Test the property 'IsPrivate'
        /// </summary>
        [Test]
        public void IsPrivateTest()
        {
            // TODO unit test for the property 'IsPrivate'
        }
        /// <summary>
        /// Test the property 'SkipBranchesWithoutAppveyorYml'
        /// </summary>
        [Test]
        public void SkipBranchesWithoutAppveyorYmlTest()
        {
            // TODO unit test for the property 'SkipBranchesWithoutAppveyorYml'
        }
        /// <summary>
        /// Test the property 'EnableSecureVariablesInPullRequests'
        /// </summary>
        [Test]
        public void EnableSecureVariablesInPullRequestsTest()
        {
            // TODO unit test for the property 'EnableSecureVariablesInPullRequests'
        }
        /// <summary>
        /// Test the property 'EnableSecureVariablesInPullRequestsFromSameRepo'
        /// </summary>
        [Test]
        public void EnableSecureVariablesInPullRequestsFromSameRepoTest()
        {
            // TODO unit test for the property 'EnableSecureVariablesInPullRequestsFromSameRepo'
        }
        /// <summary>
        /// Test the property 'EnableDeploymentInPullRequests'
        /// </summary>
        [Test]
        public void EnableDeploymentInPullRequestsTest()
        {
            // TODO unit test for the property 'EnableDeploymentInPullRequests'
        }
        /// <summary>
        /// Test the property 'RollingBuilds'
        /// </summary>
        [Test]
        public void RollingBuildsTest()
        {
            // TODO unit test for the property 'RollingBuilds'
        }
        /// <summary>
        /// Test the property 'RollingBuildsDoNotCancelRunningBuilds'
        /// </summary>
        [Test]
        public void RollingBuildsDoNotCancelRunningBuildsTest()
        {
            // TODO unit test for the property 'RollingBuildsDoNotCancelRunningBuilds'
        }
        /// <summary>
        /// Test the property 'AlwaysBuildClosedPullRequests'
        /// </summary>
        [Test]
        public void AlwaysBuildClosedPullRequestsTest()
        {
            // TODO unit test for the property 'AlwaysBuildClosedPullRequests'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'NuGetFeed'
        /// </summary>
        [Test]
        public void NuGetFeedTest()
        {
            // TODO unit test for the property 'NuGetFeed'
        }
        /// <summary>
        /// Test the property 'SecurityDescriptor'
        /// </summary>
        [Test]
        public void SecurityDescriptorTest()
        {
            // TODO unit test for the property 'SecurityDescriptor'
        }

    }

}
