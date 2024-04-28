using DatabaseS4L.Attributes;

namespace DatabaseS4L.Web
{
    [AliceTable("web_accounts")]
    public class WebAccountEntity
    {
        [AliceColumn("AccountId")]
        public int AccountId { get; set; }

        [AliceColumn("Password")]
        public string Password { get; set; }

        [AliceColumn("NPassword")]
        public string NPassword { get; set; }

        [AliceColumn("Mail")]
        public string Mail { get; set; }

        [AliceColumn("NMail")]
        public string NMail { get; set; }

        [AliceColumn("DateBirthday")]
        public string DateBirthday { get; set; }

        [AliceColumn("Country")]
        public string Country { get; set; }

        [AliceColumn("DateRegister")]
        public string DateRegister { get; set; }

        [AliceColumn("LastLogin")]
        public string LastLogin { get; set; }

        [AliceColumn("IsVip")]
        public bool IsVip { get; set; }

        public WebAccountEntity()
        {
            Password = string.Empty;
            NPassword = string.Empty;
            Mail = string.Empty;
            NMail = string.Empty;
            DateBirthday = string.Empty;
            Country = string.Empty;
            DateRegister = string.Empty;
            LastLogin = string.Empty;
        }
    }
}
