using System;
using System.Linq;
using FizzWare.NBuilder;
using Sentinel.Web.EndToEnd.DataModel.Types;

namespace Sentinel.Web.EndToEnd.DataModel.TestDataBuilders
{
    public class SecurityQuestionsBuilder
    {
        private readonly ISingleObjectBuilder<SecurityQuestions> securityQuestionBuilder;

        public SecurityQuestionsBuilder()
        {
            securityQuestionBuilder = Builder<SecurityQuestions>.CreateNew();
        }

        public SecurityQuestionsBuilder(SecurityQuestions securityQuestions)
        {
            var oldQuestions = securityQuestions.SecurityQuestionList.ToList();
            securityQuestionBuilder = Builder<SecurityQuestions>.CreateNew()
                .Do(newSq => oldQuestions.ForEach(oldSq => newSq.SecurityQuestionList.Add(oldSq)));
        }

        public static SecurityQuestionsBuilder OpenSecurityQuestions()
        {
            return new SecurityQuestionsBuilder();
        }

        public static SecurityQuestionsBuilder OpenSecurityQuestions(SecurityQuestions securityQuestions)
        {
            return new SecurityQuestionsBuilder(securityQuestions);
        }

        public SecurityQuestionsBuilder WithSecurityQuestion(string question)
        {
            securityQuestionBuilder.Do(sq => sq.SecurityQuestionList.Add(GetQuestionAnswer(question)));
            return this;
        }

        public SecurityQuestions Create()
        {
            return securityQuestionBuilder.Build();
        }

        private static (string Question, string Answer) GetQuestionAnswer(string question)
        {
            return (question, string.Join(String.Empty, Faker.Lorem.Words(2)));
        }

    }
}