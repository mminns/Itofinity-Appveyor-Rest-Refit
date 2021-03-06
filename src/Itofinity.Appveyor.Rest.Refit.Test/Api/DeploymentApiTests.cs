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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Refit;

using Itofinity.Appveyor.Rest.Refit.Client;
using Itofinity.Appveyor.Rest.Refit.Api;
using Itofinity.Appveyor.Rest.Refit.Model;

namespace Itofinity.Appveyor.Rest.Refit.Test
{
    /// <summary>
    ///  Class for testing DeploymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DeploymentApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Appveyor.Rest.Refit.Test.DeploymentApiTests";

        private IDeploymentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<IDeploymentApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeploymentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DeploymentApi
            //Assert.IsInstanceOfType(typeof(DeploymentApi), instance, "instance is a DeploymentApi");
        }

        
        /// <summary>
        /// Test CancelDeployment
        /// </summary>
        [Test]
        public async void CancelDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeploymentCancellation body = null;
            //instance.CancelDeployment(userAgent, body);
            
        }
        
        /// <summary>
        /// Test GetDeployment
        /// </summary>
        [Test]
        public async void GetDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? deploymentId = null;
            //var response = await instance.GetDeployment(userAgent, deploymentId);
            //Assert.IsInstanceOf<ProjectDeployment> (response, "response is ProjectDeployment");
        }
        
        /// <summary>
        /// Test StartDeployment
        /// </summary>
        [Test]
        public async void StartDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeploymentStartRequest body = null;
            //var response = await instance.StartDeployment(userAgent, body);
            //Assert.IsInstanceOf<Deployment> (response, "response is Deployment");
        }
        
    }

}
