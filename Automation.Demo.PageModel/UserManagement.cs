﻿using System;
using Automation.Demo.DataModel;
using Automation.Demo.TestTools.APIModel.Account.DataObjects;
using Automation.Demo.TestTools.APIModel.Account.DataObjects.DataBuilders;
using Automation.Demo.TestTools.APIModel.Account.DataObjects.ResourceModels;
using Automation.Demo.TestTools.APIModel.Identity.DataObjects;
using Automation.Demo.TestTools.APIModel.Identity.DataObjects.DataBuilders;

namespace Automation.Demo.PageModel
{
    public class UserManagement : IDisposable
    {
        private TestData testData;
        public UserData UserData;
        private readonly Automation.Demo.TestTools.APIModel.TestData identityData;

        public UserManagement(TestData testData)
        {
            UserData = new UserData();
            this.testData = testData;
            identityData = new Automation.Demo.TestTools.APIModel.TestData();
        }

        public void SetUser(UserData userData)
        {
            UserData.AgentProfile = userData.AgentProfile;
            UserData.Credential = userData.Credential;
            UserData.SecurityQuestions = userData.SecurityQuestions;
        }

        public void CreateBasicUser()
        {
            var user = identityData.UserManagement.GenerateNewUserWithCredential(1);
            var userData = new UserData(user.EMail, user.Password);
            CreateAgent(user);
            SetUser(userData);
        }

        public void CreateAdminUser()
        {
            var user = identityData.UserManagement.CreateUserWithCredential(UserBuilder.NewRandomUser().WithIsAdmin(true), 1);
            var userData = new UserData(user.EMail, user.Password);
            CreateAgent(user);
            SetUser(userData);
        }

        private void CreateAgent(User user)
        {
            var agent = AgentBuilder.OpenAgent(user).Create().WithEmail(user.EMail);
            var agentCreateRequest = AgentRequests.AgentCreate(agent, 1);
            var response = identityData.ExecuteRequest(agentCreateRequest);
        }

        public void Dispose()
        {
            testData = null;
            UserData = null;
            identityData.TearDown();
        }
    }
}