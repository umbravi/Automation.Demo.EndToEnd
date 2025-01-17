﻿using System;
using Automation.Demo.PageModel.Features;
using Automation.Demo.PageModel.Pages;
using Automation.Demo.WebDriver;

namespace Automation.Demo.PageModel
{
    public class TestData : IDisposable
    {
        public LoginPage Login;
        public DashboardPage Dashboard;
        public ForgotPasswordFeature ForgotPasswordFeature;
        public PreRegistrationFeature PreRegistrationFeature;
        public RegistrationFeature RegistrationFeature;

        public UserManagement UserManagement;

        private readonly BrowserDriver driver;

        public TestData(string targetBrowser, string applicationUnderTestUrl)
        {

            driver = new BrowserDriver(targetBrowser);

            UserManagement = new UserManagement(this);
            Login = new LoginPage(driver, UserManagement.UserData, applicationUnderTestUrl);
            Dashboard = new DashboardPage(driver, UserManagement.UserData);
            ForgotPasswordFeature = new ForgotPasswordFeature(driver, UserManagement.UserData);
            PreRegistrationFeature = new PreRegistrationFeature(driver, UserManagement.UserData);
            RegistrationFeature = new RegistrationFeature(driver, UserManagement.UserData);
        }

        public void Dispose()
        {
            UserManagement.Dispose();
            driver.KillDrivers();
        }
    }
}
