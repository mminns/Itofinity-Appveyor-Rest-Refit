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
    ///  Class for testing HostEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HostEntryTests
    {
        // TODO uncomment below to declare an instance variable for HostEntry
        //private HostEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HostEntry
            //instance = new HostEntry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HostEntry
        /// </summary>
        [Test]
        public void HostEntryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HostEntry
            //Assert.IsInstanceOfType<HostEntry> (instance, "variable 'instance' is a HostEntry");
        }

        /// <summary>
        /// Test the property 'Host'
        /// </summary>
        [Test]
        public void HostTest()
        {
            // TODO unit test for the property 'Host'
        }
        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Test]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }

    }

}
