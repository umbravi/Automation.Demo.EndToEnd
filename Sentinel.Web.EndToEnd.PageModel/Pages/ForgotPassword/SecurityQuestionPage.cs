using System;
using System.Linq;
using Sentinel.WebDriver;
using Sentinel.Web.EndToEnd.DataModel;
using Sentinel.Web.EndToEnd.DataModel.Types;

namespace Sentinel.Web.EndToEnd.PageModel.Pages.ForgotPassword
{
    public class SecurityQuestionPage
    {
        private readonly SecurityQuestions userSecurityQuestions;
        private readonly BrowserDriver driver;

        private const string SECURITY_ANSWER_FIELD_ID = "SecurityAnswer";
        private const string SECURITY_QUESTION_LABEL_TEXT = "Security Question";
        private const string NEXT_BUTTON_TEXT = "Next";

        public SecurityQuestionPage(UserData userData, BrowserDriver driver)
        {
            userSecurityQuestions = userData.SecurityQuestions;
            this.driver = driver;
        }

        public void SendSecurityAnswer()
        {
            var question = driver.Interactions.GetElementTextByLabelText(SECURITY_QUESTION_LABEL_TEXT);
            var answer = userSecurityQuestions.SecurityQuestionList.FirstOrDefault(sq => string.Equals(sq.Question, question, StringComparison.CurrentCultureIgnoreCase)).Answer;
            driver.Interactions.SendTextById(SECURITY_ANSWER_FIELD_ID, answer);
        }

        public void ClickNextButton()
        {
            driver.Interactions.ClickButtonByText(NEXT_BUTTON_TEXT);
        }
    }
}
