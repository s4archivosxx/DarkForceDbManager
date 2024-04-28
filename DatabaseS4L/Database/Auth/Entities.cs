using DatabaseS4L.Attributes;

namespace DatabaseS4L.Auth
{
    [AliceTable("accounts")]
    public class AccountEntity
    {
        [AliceColumn("Id")]
        public int Id { get; set; }

        [AliceColumn("Username")]
        public string Username { get; set; }

        [AliceColumn("Nickname")]
        public string Nickname { get; set; }

        [AliceColumn("Password")]
        public string Password { get; set; }

        [AliceColumn("Salt")]
        public string Salt { get; set; }

        [AliceColumn("SecurityLevel")]
        public byte SecurityLevel { get; set; }

        [AliceColumn("Token")]
        public string Token { get; set; }

        [AliceColumn("AccessToken")]
        public string AccessToken { get; set; }

        [AliceColumn("RefreshToken")]
        public string RefreshToken { get; set; }

        [AliceColumn("ExpireDate")]
        public string ExpireDate { get; set; }
    }

    [AliceTable("bans")]
    public class BanEntity
    {
        [AliceColumn("Id")]
        public int Id { get; set; }

        [AliceColumn("AccountId")]
        public int AccountId { get; set; }

        [AliceColumn("Date")]
        public long Date { get; set; }

        [AliceColumn("Duration")]
        public long? Duration { get; set; }

        [AliceColumn("Reason")]
        public string Reason { get; set; }
    }

    [AliceTable("login_history")]
    public class LoginHistoryEntity
    {
        [AliceColumn("Id")]
        public int Id { get; set; }

        [AliceColumn("AccountId")]
        public int AccountId { get; set; }

        [AliceColumn("Date")]
        public long Date { get; set; }

        [AliceColumn("IP")]
        public string IP { get; set; }
    }

    [AliceTable("nickname_history")]
    public class NicknameHistoryEntity
    {
        [AliceColumn("Id")]
        public int Id { get; set; }

        [AliceColumn("AccountId")]
        public int AccountId { get; set; }

        [AliceColumn("Nickname")]
        public string Nickname { get; set; }

        [AliceColumn("ExpireDate")]
        public long? ExpireDate { get; set; }
    }
}
