﻿using Automation.Demo.DataModel.Types;
using FizzWare.NBuilder;

namespace Automation.Demo.DataModel.TestDataBuilders
{
    public class CredentialBuilder
    {
        private readonly ISingleObjectBuilder<Credential> credentialBuilder;

        public CredentialBuilder()
        {
            credentialBuilder = Builder<Credential>.CreateNew();
        }

        public CredentialBuilder(Credential credential)
        {
            credentialBuilder = Builder<Credential>.CreateNew()
                .With(c => c.Email = credential.Email)
                .With(c => c.Password = credential.Password);
        }

        public static CredentialBuilder OpenCredential()
        {
            return new CredentialBuilder();
        }

        public static CredentialBuilder OpenCredential(Credential credential)
        {
            return new CredentialBuilder(credential);
        }

        public CredentialBuilder WithEmail(string email)
        {
            credentialBuilder.With(c => c.Email = email);
            return this;
        }

        public CredentialBuilder WithPassword(string password)
        {
            credentialBuilder.With(c => c.Password = password);
            return this;
        }

        public Credential Create()
        {
            return credentialBuilder.Build();
        }
    }
}
