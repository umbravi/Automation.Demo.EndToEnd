using FizzWare.NBuilder;
using Sentinel.Web.EndToEnd.DataModel.Types;

namespace Sentinel.Web.EndToEnd.DataModel.TestDataBuilders
{
    public class AgentProfileBuilder
    {
        private readonly ISingleObjectBuilder<AgentProfile> agentProfileBuilder;

        public AgentProfileBuilder()
        {
            agentProfileBuilder = Builder<AgentProfile>.CreateNew();
        }

        public AgentProfileBuilder(AgentProfile agentProfile)
        {
            agentProfileBuilder = Builder<AgentProfile>.CreateNew()
                .With(u => u.JobTitle = agentProfile.JobTitle)
                .With(u => u.FirstName = agentProfile.FirstName)
                .With(u => u.LastName = agentProfile.LastName)
                .With(u => u.MiddleInital = agentProfile.MiddleInital)
                .With(u => u.Agency = agentProfile.Agency)
                .With(u => u.Location = agentProfile.Location)
                .With(u => u.Department = agentProfile.Department)
                .With(u => u.BadgeNumber = agentProfile.BadgeNumber)
                .With(u => u.Email = agentProfile.Email)
                .With(u => u.PhoneNumber = agentProfile.PhoneNumber)
                .With(u => u.FaxNumber = agentProfile.FaxNumber)
                .With(u => u.Street1 = agentProfile.Street1)
                .With(u => u.Street2 = agentProfile.Street2)
                .With(u => u.City = agentProfile.City)
                .With(u => u.State = agentProfile.State)
                .With(u => u.ZipCode = agentProfile.ZipCode)
                .With(u => u.HasAcceptedTerms = agentProfile.HasAcceptedTerms)
                .With(u => u.AttentionTo = agentProfile.AttentionTo);
        }

        public static AgentProfileBuilder OpenUser()
        {
            return new AgentProfileBuilder();
        }

        public static AgentProfileBuilder OpenUser(AgentProfile agentProfile)
        {
            return new AgentProfileBuilder(agentProfile);
        }

        public AgentProfileBuilder WithCompleteProfile()
        {
            return this.WithJobTitle()
                .WithFirstName()
                .WithLastName()
                .WithMiddleInital()
                .WithAgency()
                .WithLocation()
                .WithDepartment()
                .WithBadgeNumber()
                .WithEmail()
                .WithPhoneNumber()
                .WithFaxNumber()
                .WithStreet1()
                .WithStreet2()
                .WithCity()
                .WithState()
                .WithZipCode()
                .HasAcceptedTerms()
                .WithAttentionTo();
        }

        public AgentProfileBuilder WithJobTitle()
        {
            agentProfileBuilder.With(u => u.JobTitle = Faker.Lorem.GetFirstWord());
            return this;
        }

        public AgentProfileBuilder WithOutJobTitle()
        {
            agentProfileBuilder.With(u => u.JobTitle = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithFirstName()
        {
            agentProfileBuilder.With(u => u.FirstName = Faker.Name.First());
            return this;
        }

        public AgentProfileBuilder WithOutFirstName()
        {
            agentProfileBuilder.With(u => u.FirstName = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithLastName()
        {
            agentProfileBuilder.With(u => u.LastName = Faker.Name.First());
            return this;
        }

        public AgentProfileBuilder WithOutLastName()
        {
            agentProfileBuilder.With(u => u.LastName = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithMiddleInital()
        {
            agentProfileBuilder.With(u => u.MiddleInital = Faker.Name.First());
            return this;
        }

        public AgentProfileBuilder WithOutMiddleInital()
        {
            agentProfileBuilder.With(u => u.MiddleInital = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithAgency()
        {
            agentProfileBuilder.With(u => u.Agency = "ATF");
            return this;
        }

        public AgentProfileBuilder WithOutAgency()
        {
            agentProfileBuilder.With(u => u.Agency = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithLocation()
        {
            agentProfileBuilder.With(u => u.Location = "precinct 10");
            return this;
        }

        public AgentProfileBuilder WithOutLocation()
        {
            agentProfileBuilder.With(u => u.Location = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithDepartment()
        {
            agentProfileBuilder.With(u => u.Department = "14th Judicial District");
            return this;
        }

        public AgentProfileBuilder WithOutDepartment()
        {
            agentProfileBuilder.With(u => u.Department = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithBadgeNumber()
        {
            agentProfileBuilder.With(u => u.BadgeNumber = Faker.Lorem.GetFirstWord());
            return this;
        }

        public AgentProfileBuilder WithOutBadgeNumber()
        {
            agentProfileBuilder.With(u => u.BadgeNumber = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithEmail()
        {
            agentProfileBuilder.With(u => u.Email = Faker.Internet.Email());
            return this;
        }

        public AgentProfileBuilder WithOutEmail()
        {
            agentProfileBuilder.With(u => u.Email = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithPhoneNumber()
        {
            agentProfileBuilder.With(u => u.PhoneNumber = Faker.Phone.Number());
            return this;
        }

        public AgentProfileBuilder WithOutPhoneNumber()
        {
            agentProfileBuilder.With(u => u.PhoneNumber = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithFaxNumber()
        {
            agentProfileBuilder.With(u => u.FaxNumber = Faker.Phone.Number());
            return this;
        }

        public AgentProfileBuilder WithOutFaxNumber()
        {
            agentProfileBuilder.With(u => u.FaxNumber = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithStreet1()
        {
            agentProfileBuilder.With(u => u.Street1 = Faker.Address.StreetAddress());
            return this;
        }

        public AgentProfileBuilder WithOutStreet1()
        {
            agentProfileBuilder.With(u => u.Street1 = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithStreet2()
        {
            agentProfileBuilder.With(u => u.Street2 = Faker.Address.SecondaryAddress());
            return this;
        }

        public AgentProfileBuilder WithOutStreet2()
        {
            agentProfileBuilder.With(u => u.Street2 = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithCity()
        {
            agentProfileBuilder.With(u => u.City = Faker.Address.City());
            return this;
        }

        public AgentProfileBuilder WithOutCity()
        {
            agentProfileBuilder.With(u => u.City = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithState()
        {
            agentProfileBuilder.With(u => u.State = Faker.Address.UsState());
            return this;
        }

        public AgentProfileBuilder WithOutState()
        {
            agentProfileBuilder.With(u => u.State = string.Empty);
            return this;
        }
        public AgentProfileBuilder WithZipCode()
        {
            agentProfileBuilder.With(u => u.ZipCode = Faker.Address.ZipCode());
            return this;
        }

        public AgentProfileBuilder WithOutZipCode()
        {
            agentProfileBuilder.With(u => u.ZipCode = string.Empty);
            return this;
        }
        public AgentProfileBuilder HasAcceptedTerms()
        {
            agentProfileBuilder.With(u => u.HasAcceptedTerms = true);
            return this;
        }

        public AgentProfileBuilder HasNotAcceptedTerms()
        {
            agentProfileBuilder.With(u => u.HasAcceptedTerms = false);
            return this;
        }
        public AgentProfileBuilder WithAttentionTo()
        {
            agentProfileBuilder.With(u => u.AttentionTo = Faker.Lorem.GetFirstWord());
            return this;
        }

        public AgentProfileBuilder WithOutAttentionTo()
        {
            agentProfileBuilder.With(u => u.AttentionTo = string.Empty);
            return this;
        }

        public AgentProfile Create()
        {
            return agentProfileBuilder.Build();
        }
    }
}
