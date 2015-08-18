//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Common;
//using System.Configuration;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.Data.Schema.UnitTesting;

////namespace GUI_Task.PrintDataSets
//namespace GUI_Task
//{
//    [TestClass()]
//    public class DatabaseSetup
//    {

//        [AssemblyInitialize()]
//        public static void InitializeAssembly(TestContext ctx)
//        {
//            //   Setup the test database based on setting in the
//            // configuration file
//            //DatabaseTestClass.TestService.DeployDatabaseProject();
//            //DatabaseTestClass.TestService.GenerateData();
//        }

//    }
//}


//<?xml version="1.0"?>
//<configuration>
//<configSections>
//    <section name="DatabaseUnitTesting" type="Microsoft.Data.Schema.UnitTesting.Configuration.DatabaseUnitTestingSection, Microsoft.Data.Schema.UnitTesting, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
//</configSections>

//<connectionStrings>
//    <add name="GUI_Task.Properties.Settings.GUI_TaskConnectionString"
//        connectionString="Data Source=WIN2K8SVR;Initial Catalog=GUI_Task;Persist Security Info=True;User ID=appsuser;Password=abcbook"
//        providerName="System.Data.SqlClient" />
//    <add name="GUI_Task.Properties.Settings.GUI_TaskConnectionString1"
//        connectionString="Data Source=WIN2K8SVR;Initial Catalog=GUI_Task;User ID=appsuser;Password=abcbook"
//        providerName="System.Data.SqlClient" />
//    <add name="GUI_Task.Properties.Settings.GUI_TaskConnectionString"
//        connectionString="Data Source=WIN2K8SVR;Initial Catalog=GUI_Task;User ID=appsuser"
//        providerName="System.Data.SqlClient" />
//    <add name="GUI_Task.Properties.Settings.GUI_TaskConnectionString1"
//        connectionString="Data Source=SHOAIBPC;Initial Catalog=GUI_Task;Persist Security Info=True;User ID=appsuser;Password=abcbook"
//        providerName="System.Data.SqlClient" />
//    <add name="GUI_Task.Properties.Settings.GUI_TaskConnectionString2"
//        connectionString="Data Source=(Local);Initial Catalog=GUI_Task;Persist Security Info=True;User ID=sa;Password=smc786"
//        providerName="System.Data.SqlClient" />
//</connectionStrings>
//<!--<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/></startup>-->
//    <!-- Start: added by baba -->
//    <startup useLegacyV2RuntimeActivationPolicy="true">
//        <supportedRuntime version="v4.0"/>
//    </startup>
//    <!-- End: added by baba -->

//</configuration>
