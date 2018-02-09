namespace Sentinel.Web.EndToEnd.DataModel.Types
{
    public class AgentProfile
    { 
        public int Id { get; set; } 

        public string JobTitle { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string MiddleInital { get; set; }
        
        public string Agency { get; set; }
        
        public string Location { get; set; }
        
        public string Department { get; set; }

        public string BadgeNumber { get; set; }
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FaxNumber { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        
        public string ZipCode { get; set; }
        
        public bool HasAcceptedTerms { get; set; }
        
        public string AttentionTo { get; set; }
    }
}
