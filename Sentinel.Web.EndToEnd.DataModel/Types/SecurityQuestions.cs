using System.Collections.Generic;

namespace Sentinel.Web.EndToEnd.DataModel.Types
{
    public class SecurityQuestions
    {
        public IList<(string Question, string Answer)> SecurityQuestionList { get; set; }

        public SecurityQuestions()
        {
            SecurityQuestionList = new List<(string Question, string Answer)>();
        }

        public SecurityQuestions(IList<(string Question, string Answer)> securityQuestionList)
        {
            SecurityQuestionList = securityQuestionList;
        }
    }
}
