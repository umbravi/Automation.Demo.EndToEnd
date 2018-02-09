using System.IO;
using Microsoft.Extensions.Configuration;

namespace Sentinel.Web.EndToEnd.TestCases
{
    internal static class AppSettings
    {
        internal static string TargetBrowser;
        internal static string ApplicationUnderTestUrl;

        //Identity API
        internal static string IdentityApiUrl;
        internal static string BaseIdentityUri;
        internal static string AuthenticationResource;
        internal static string UsersResource;
        internal static string UsersWithCredentialsResource;

        //Account API
        internal static string AccountApiUrl;
        internal static string BaseAccountUri;
        internal static string AgencyResource;
        internal static string AgentResource;
        internal static string AgentProgressResource;
        internal static string AgentStatusResource;
        internal static string CabinetResource;
        internal static string DepartmentResource;
        internal static string JurisdictionResource;
        internal static string LocationResource;
        internal static string StateResource;
        internal static string TermsAndConditionsResource;
        internal static string UserAgreementResource;

        public static IConfigurationRoot Configuration { get; set; }

        static AppSettings()
        {
            Configuration = GetConfiguration();
            TargetBrowser = Configuration["targetBrowser"];
            ApplicationUnderTestUrl = Configuration["applicationUnderTestUrl"];
            IdentityApiUrl = Configuration["identityApiUri"];
            BaseIdentityUri = Configuration["baseIdentityUri"];
            AuthenticationResource = Configuration["authenticationResource"];
            UsersResource = Configuration["usersResource"];
            UsersWithCredentialsResource = Configuration["usersWithCredentialsResource"];
            AccountApiUrl = Configuration["accountApiUrl"];
            BaseAccountUri = Configuration["baseAccountUri"];
            AgencyResource = Configuration["agencyResource"];
            AgentResource = Configuration["agentResource"];
            AgentProgressResource = Configuration["agentProgressResource"];
            AgentStatusResource = Configuration["agentStatusResource"];
            CabinetResource = Configuration["cabinetResource"];
            DepartmentResource = Configuration["departmentResource"];
            JurisdictionResource = Configuration["jurisdictionResource"];
            LocationResource = Configuration["locationResource"];
            StateResource = Configuration["stateResource"];
            TermsAndConditionsResource = Configuration["termsAndConditionsResource"];
            UserAgreementResource = Configuration["userAgreementResource"];
        }
        
        internal static IConfigurationRoot GetConfiguration()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            return settings.Build();
        }
    }
}