﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Management.Automation.Runspaces;

namespace OfficeDevPnP.PowerShell.Tests
{
    [TestClass]
    public class GetTenantSiteTests
    {
        [TestMethod]
        public void GetTenantSiteTest()
        {
            using (var scope = new PSTestScope(true))
            {
                var results = scope.ExecuteCommand("Get-SPOTenantSite");

                Assert.IsTrue(results.Count > 0);
            }
        }

        [TestMethod]
        public void GetTimeZoneIdTest1()
        {
            using (var scope = new PSTestScope(false))
            {
                var results = scope.ExecuteCommand("Get-SPOTimeZoneId");
                Assert.IsTrue(results.Count > 0);
            }
        }

        [TestMethod]
        public void GetTimeZoneIdTest2()
        {
            using (var scope = new PSTestScope(false))
            {
                var results = scope.ExecuteCommand("Get-SPOTimeZoneId", new CommandParameter("Match", "Stockholm"));

                Assert.IsTrue(results.Count == 1);
            }
        }

        [TestMethod]
        public void GetWebTemplatesTest()
        {
            using (var scope = new PSTestScope(true))
            {
                var results = scope.ExecuteCommand("Get-SPOWebTemplates");

                Assert.IsTrue(results.Count > 0);
                Assert.IsTrue(results[0].BaseObject.GetType().Equals(typeof(Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplate)));
            }
        }
    }
}
