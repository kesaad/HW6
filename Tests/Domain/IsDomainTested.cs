﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain
{
    [TestClass]
    public class IsDomainTested : AssemblyTests
    {
        private const string assembly = "Abc.Domain";
        protected override string Namespace(string name) { return $"{assembly}.{name}"; }

        [TestMethod] public void IsCommonTested() { isAllTested(assembly, Namespace("Common")); }
        //[TestMethod] public void IsInventoryTested() { isAllTested(assembly, Namespace("Inventory")); }
        //[TestMethod] public void IsMoneyTested() { isAllTested(assembly, Namespace("Money")); }
        //[TestMethod] public void IsOrderTested() { isAllTested(assembly, Namespace("Order")); }
        //[TestMethod] public void IsPartyTested() { isAllTested(assembly, Namespace("Party")); }
        //[TestMethod] public void IsPartyRelationshipTested() { isAllTested(assembly, Namespace("PartyRelationship")); }
        //[TestMethod] public void IsProcessTested() { isAllTested(assembly, Namespace("Process")); }
        //[TestMethod] public void IsProductTested() { isAllTested(assembly, Namespace("Product")); }
        [TestMethod] public void IsQuantityTested() { isAllTested(assembly, Namespace("Quantity")); }
        //[TestMethod] public void IsRuleTested() { isAllTested(assembly, Namespace("Rule")); }
        [TestMethod] public void IsTested() { isAllTested(base.Namespace("Domain")); }
    }
}
