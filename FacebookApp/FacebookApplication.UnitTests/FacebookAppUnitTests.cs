using System;
using FacebookWrapper.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacebookApp.UnitTests
{
    [TestClass]
    public class FacebookAppUnitTests
    {
        [TestMethod]
        public void LoadTab_InsertUnFamilierTab_LoadedTabsIsEmptyList()
        {
            //Arrange
            
            var tabsManager = new TabsManager();
            
            //Act
            tabsManager.LoadTab("jiraf","none");
            //Assert
            Assert.IsTrue(tabsManager.LoadedTabs.Count==0);
        }
    }
}
