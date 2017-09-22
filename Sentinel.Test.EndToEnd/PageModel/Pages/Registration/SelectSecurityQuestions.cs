using System.Collections.Generic;
using System.Linq;
using Sentinel.Test.EndToEnd.PageModel.DataModel.Types;
using Sentinel.WebDriver;

namespace Sentinel.Test.EndToEnd.PageModel.Pages.Registration
{
    public class SelectSecurityQuestions
    {

        internal User User;

        private readonly BrowserDriver driver;
        private readonly RegistrationNavigation navigation;

        private const string QUESTION_ONE_SELECT_ID = "Question1";
        private const string ANSWER_ONE_TEXTBOX_ID = "Answer1";
        private const string QUESTION_TWO_SELECT_ID = "Question2";
        private const string ANSWER_TWO_TEXTBOX_ID = "Answer2";
        private const string QUESTION_THREE_SELECT_ID = "Question3";
        private const string ANSWER_THREE_TEXTBOX_ID = "Answer3";

        private readonly IList<SecurityQuestion> selectedSecurityQuestions;

        public SelectSecurityQuestions(User user, BrowserDriver driver)
        {
            navigation = new RegistrationNavigation(driver, "Next");
            User = user;
            this.driver = driver;
            selectedSecurityQuestions = User.SecurityQuestions;
        }

        public void SelectSecurityQuestionOne()
        {
            var securityQuestion = GetSecurityQuestionAnswer(QUESTION_ONE_SELECT_ID).Question;
            driver.Interactions.SelectOptionTextById(QUESTION_ONE_SELECT_ID, securityQuestion);
        }

        public void SendAnswerOne()
        {
            var securityAnswer = GetSecurityAnswer(QUESTION_ONE_SELECT_ID);
            driver.Interactions.SendTextById(ANSWER_ONE_TEXTBOX_ID, securityAnswer);
        }

        public void SelectSecurityQuestionTwo()
        {
            var securityQuestion = GetSecurityQuestionAnswer(QUESTION_TWO_SELECT_ID).Question;
            driver.Interactions.SelectOptionTextById(QUESTION_ONE_SELECT_ID, securityQuestion);
        }

        public void SendAnswerTwo()
        {
            var securityAnswer = GetSecurityAnswer(QUESTION_TWO_SELECT_ID);
            driver.Interactions.SendTextById(ANSWER_TWO_TEXTBOX_ID, securityAnswer);
        }

        public void SelectSecurityQuestionThree()
        {
            var securityQuestion = GetSecurityQuestionAnswer(QUESTION_THREE_SELECT_ID).Question;
            driver.Interactions.SelectOptionTextById(QUESTION_THREE_SELECT_ID, securityQuestion);
        }

        public void SendAnswerThree()
        {
            var securityAnswer = GetSecurityAnswer(QUESTION_THREE_SELECT_ID);
            driver.Interactions.SendTextById(ANSWER_THREE_TEXTBOX_ID, securityAnswer);
        }

        public void GoToPreviousPage()
        {
            navigation.GoToPreviousPage();
        }

        public void SubmitSecurityAnswersGoToNextPage()
        {
            navigation.GoToNextPage();
        }

        private SecurityQuestion GetSecurityQuestionAnswer(string securityQuestionFieldId)
        {
            var securityQuestionList = driver.Interactions.GetOptionListBySelectId(securityQuestionFieldId);
            var selectedQuestion = securityQuestionList.FirstOrDefault(myQ => myQ.Contains("?") && !selectedSecurityQuestions.Any(existQ => existQ.Question.Contains(myQ)));
            var selectedQuestionAnswer = selectedQuestion.Substring(selectedQuestion.Length - 5);

            var securityQuestion = new SecurityQuestion(selectedQuestion, selectedQuestionAnswer);
            selectedSecurityQuestions.Add(securityQuestion);

            return securityQuestion;
        }

        private string GetSecurityAnswer(string securityQuestionSelectId)
        {
            var securityQuestion = driver.Interactions.GetOptionsSelectedBySelectId(securityQuestionSelectId)[0];
            var securityAnswer =
                selectedSecurityQuestions.FirstOrDefault(sq => sq.Question.ToUpper() == securityQuestion).Answer;

            return securityAnswer;
        }
    }
}
