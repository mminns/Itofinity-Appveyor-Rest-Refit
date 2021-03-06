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
    ///  Class for testing DeploymentEnvironment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DeploymentEnvironmentTests
    {
        // TODO uncomment below to declare an instance variable for DeploymentEnvironment
        //private DeploymentEnvironment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DeploymentEnvironment
            //instance = new DeploymentEnvironment();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeploymentEnvironment
        /// </summary>
        [Test]
        public void DeploymentEnvironmentInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DeploymentEnvironment
            //Assert.IsInstanceOfType<DeploymentEnvironment> (instance, "variable 'instance' is a DeploymentEnvironment");
        }

        /// <summary>
        /// Test the property 'DeploymentEnvironmentId'
        /// </summary>
        [Test]
        public void DeploymentEnvironmentIdTest()
        {
            // TODO unit test for the property 'DeploymentEnvironmentId'
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
        /// Test the property 'Provider'
        /// </summary>
        [Test]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
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
        /// Test the property 'ProjectsMode'
        /// </summary>
        [Test]
        public void ProjectsModeTest()
        {
            // TODO unit test for the property 'ProjectsMode'
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
