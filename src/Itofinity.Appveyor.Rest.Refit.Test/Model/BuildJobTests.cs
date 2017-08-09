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
    ///  Class for testing BuildJob
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BuildJobTests
    {
        // TODO uncomment below to declare an instance variable for BuildJob
        //private BuildJob instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BuildJob
            //instance = new BuildJob();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BuildJob
        /// </summary>
        [Test]
        public void BuildJobInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BuildJob
            //Assert.IsInstanceOfType<BuildJob> (instance, "variable 'instance' is a BuildJob");
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
        /// Test the property 'JobId'
        /// </summary>
        [Test]
        public void JobIdTest()
        {
            // TODO unit test for the property 'JobId'
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
        /// Test the property 'OsType'
        /// </summary>
        [Test]
        public void OsTypeTest()
        {
            // TODO unit test for the property 'OsType'
        }
        /// <summary>
        /// Test the property 'AllowFailure'
        /// </summary>
        [Test]
        public void AllowFailureTest()
        {
            // TODO unit test for the property 'AllowFailure'
        }
        /// <summary>
        /// Test the property 'MessagesCount'
        /// </summary>
        [Test]
        public void MessagesCountTest()
        {
            // TODO unit test for the property 'MessagesCount'
        }
        /// <summary>
        /// Test the property 'CompilationMessagesCount'
        /// </summary>
        [Test]
        public void CompilationMessagesCountTest()
        {
            // TODO unit test for the property 'CompilationMessagesCount'
        }
        /// <summary>
        /// Test the property 'CompilationErrorsCount'
        /// </summary>
        [Test]
        public void CompilationErrorsCountTest()
        {
            // TODO unit test for the property 'CompilationErrorsCount'
        }
        /// <summary>
        /// Test the property 'CompilationWarningsCount'
        /// </summary>
        [Test]
        public void CompilationWarningsCountTest()
        {
            // TODO unit test for the property 'CompilationWarningsCount'
        }
        /// <summary>
        /// Test the property 'TestsCount'
        /// </summary>
        [Test]
        public void TestsCountTest()
        {
            // TODO unit test for the property 'TestsCount'
        }
        /// <summary>
        /// Test the property 'PassedTestsCount'
        /// </summary>
        [Test]
        public void PassedTestsCountTest()
        {
            // TODO unit test for the property 'PassedTestsCount'
        }
        /// <summary>
        /// Test the property 'FailedTestsCount'
        /// </summary>
        [Test]
        public void FailedTestsCountTest()
        {
            // TODO unit test for the property 'FailedTestsCount'
        }
        /// <summary>
        /// Test the property 'ArtifactsCount'
        /// </summary>
        [Test]
        public void ArtifactsCountTest()
        {
            // TODO unit test for the property 'ArtifactsCount'
        }

    }

}