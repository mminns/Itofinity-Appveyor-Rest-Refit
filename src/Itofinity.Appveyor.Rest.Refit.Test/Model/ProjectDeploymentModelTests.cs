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
    ///  Class for testing ProjectDeploymentModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProjectDeploymentModelTests
    {
        // TODO uncomment below to declare an instance variable for ProjectDeploymentModel
        //private ProjectDeploymentModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProjectDeploymentModel
            //instance = new ProjectDeploymentModel();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectDeploymentModel
        /// </summary>
        [Test]
        public void ProjectDeploymentModelInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProjectDeploymentModel
            //Assert.IsInstanceOfType<ProjectDeploymentModel> (instance, "variable 'instance' is a ProjectDeploymentModel");
        }

        /// <summary>
        /// Test the property 'DeploymentId'
        /// </summary>
        [Test]
        public void DeploymentIdTest()
        {
            // TODO unit test for the property 'DeploymentId'
        }
        /// <summary>
        /// Test the property 'Build'
        /// </summary>
        [Test]
        public void BuildTest()
        {
            // TODO unit test for the property 'Build'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Started'
        /// </summary>
        [Test]
        public void StartedTest()
        {
            // TODO unit test for the property 'Started'
        }
        /// <summary>
        /// Test the property 'Finished'
        /// </summary>
        [Test]
        public void FinishedTest()
        {
            // TODO unit test for the property 'Finished'
        }
        /// <summary>
        /// Test the property 'Environment'
        /// </summary>
        [Test]
        public void EnvironmentTest()
        {
            // TODO unit test for the property 'Environment'
        }

    }

}