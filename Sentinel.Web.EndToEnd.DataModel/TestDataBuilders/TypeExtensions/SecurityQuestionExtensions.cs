using Sentinel.Web.EndToEnd.DataModel.Types;

namespace Sentinel.Web.EndToEnd.DataModel.TestDataBuilders.TypeExtensions
{
    public static class SecurityQuestionExtensions
    {
        public static SecurityQuestions WithSecurityQuestionAndAnswer(this SecurityQuestions securityQuestions, string securityQuestion)
        {
            return SecurityQuestionsBuilder.OpenSecurityQuestions(securityQuestions).WithSecurityQuestion(securityQuestion).Create();
        }
    }
}
