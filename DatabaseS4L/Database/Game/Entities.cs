using DatabaseS4L.Attributes;

namespace DatabaseS4L.Game
{
    [AliceTable("players")]
    public class PlayerEntity
    {
        [AliceColumn("Id")]
        public int Id { get; set; }

        [AliceColumn]
        public int EventCoupon { get; set; }

        [AliceColumn("OnGame")]
        public byte OnGame { get; set; }

        [AliceColumn("GameTime")]
        public string GameTime { get; set; }

        [AliceColumn("TutorialState")]
        public byte TutorialState { get; set; }

        [AliceColumn("Level")]
        public byte Level { get; set; }

        [AliceColumn("TotalExperience")]
        public uint TotalExperience { get; set; }

        [AliceColumn("PEN")]
        public int PEN { get; set; }

        [AliceColumn("AP")]
        public int AP { get; set; }

        [AliceColumn("Coins1")]
        public int Coins1 { get; set; }

        [AliceColumn("Coins2")]
        public int Coins2 { get; set; }

        [AliceColumn("CurrentCharacterSlot")]
        public byte CurrentCharacterSlot { get; set; }

        [AliceColumn("TotalWins")]
        public int TotalWins { get; set; }

        [AliceColumn("TotalLosses")]
        public int TotalLosses { get; set; }

        public PlayerEntity()
        {
            GameTime = "0.00:00:00";
        }

        //public IList<PlayerCharacterDto> Characters { get; set; } = new List<PlayerCharacterDto>();
        //public IList<PlayerDenyDto> Ignores { get; set; } = new List<PlayerDenyDto>();
        //public IList<PlayerFriendDto> Friends { get; set; } = new List<PlayerFriendDto>();
        //public IList<PlayerItemDto> Items { get; set; } = new List<PlayerItemDto>();
        //public IList<PlayerMailDto> Inbox { get; set; } = new List<PlayerMailDto>();
        //public IList<PlayerSettingDto> Settings { get; set; } = new List<PlayerSettingDto>();

        //public IList<PlayerDeathMatchDto> DeathMatchInfo { get; set; } = new List<PlayerDeathMatchDto>();
        //public IList<PlayerTouchDownDto> TouchDownInfo { get; set; } = new List<PlayerTouchDownDto>();
        //public IList<PlayerChaserDto> ChaserInfo { get; set; } = new List<PlayerChaserDto>();
        //public IList<PlayerBattleRoyalDto> BattleRoyalInfo { get; set; } = new List<PlayerBattleRoyalDto>();
        //public IList<PlayerCaptainDto> CaptainInfo { get; set; } = new List<PlayerCaptainDto>();
    }

    [AliceTable("")]
    public class PlayerDeathMatchDto
    {
        public int PlayerId { get; set; }

        public ulong Matchs { get; set; }
        public ulong Won { get; set; }
        public ulong Loss { get; set; }
        public ulong Kills { get; set; }
        public ulong KillAssists { get; set; }
        public ulong Deaths { get; set; }
    }

    [AliceTable("")]
    public class PlayerTouchDownDto
    {
        public int PlayerId { get; set; }

        public ulong Matchs { get; set; }
        public ulong Won { get; set; }
        public ulong Loss { get; set; }
        public ulong TD { get; set; }
        public ulong TDAssist { get; set; }
        public ulong Offense { get; set; }
        public ulong OffenseAssist { get; set; }
        public ulong Defense { get; set; }
        public ulong DefenseAssist { get; set; }
        public ulong Kill { get; set; }
        public ulong KillAssist { get; set; }
        public ulong OffenseRebound { get; set; }
        public ulong Heal { get; set; }
    }

    [AliceTable("")]
    public class PlayerChaserDto
    {
        public int PlayerId { get; set; }

        public ulong Matchs { get; set; }
        public ulong ChasedWon { get; set; }
        public ulong ChasedRounds { get; set; }
        public ulong ChaserWon { get; set; }
        public ulong ChaserRounds { get; set; }
    }

    [AliceTable("")]
    public class PlayerBattleRoyalDto
    {
        public int PlayerId { get; set; }

        public ulong Matchs { get; set; }
        public ulong Won { get; set; }
        public ulong Loss { get; set; }
        public ulong Kills { get; set; }
        public ulong KillAssists { get; set; }
        public ulong FirstKilled { get; set; }
        public ulong FirstPlace { get; set; }
    }

    [AliceTable("")]
    public class PlayerCaptainDto
    {
        public int PlayerId { get; set; }

        public ulong Matchs { get; set; }
        public ulong Won { get; set; }
        public ulong Loss { get; set; }
        public ulong CPTKilled { get; set; }
        public ulong CPTCount { get; set; }
    }

    [AliceTable("")]
    public class PlayerCharacterDto
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }

        public byte Slot { get; set; }
        public byte Gender { get; set; }
        public byte BasicHair { get; set; }
        public byte BasicFace { get; set; }
        public byte BasicShirt { get; set; }
        public byte BasicPants { get; set; }
        public int? Weapon1Id { get; set; }
        public int? Weapon2Id { get; set; }
        public int? Weapon3Id { get; set; }
        public int? SkillId { get; set; }
        public int? HairId { get; set; }
        public int? FaceId { get; set; }
        public int? ShirtId { get; set; }
        public int? PantsId { get; set; }
        public int? GlovesId { get; set; }
        public int? ShoesId { get; set; }
        public int? AccessoryId { get; set; }
        public int? PetId { get; set; }
    }

    [AliceTable("")]
    public class PlayerDenyEntity
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }

        public PlayerEntity Player { get; set; }

        public int DenyPlayerId { get; set; }
    }

    [AliceTable("")]
    public class PlayerFriendEntity
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public int FriendId { get; set; }
        public uint State { get; set; }
    }

    [AliceTable("")]
    public class PlayerItemEntity
    {
        public long Id { get; set; }

        public int PlayerId { get; set; }

        // public PlayerEntity Player { get; set; }

        public int ShopItemInfoId { get; set; }
        public int ShopPriceId { get; set; }
        public byte Color { get; set; }
        public long PurchaseDate { get; set; }
        public int Durability { get; set; }
        public uint MP { get; set; }
        public uint MPLevel { get; set; }
        public string Effects { get; set; }
    }

    [AliceTable("")]
    public class PlayerMailEntity
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public PlayerEntity Player { get; set; }

        public int SenderPlayerId { get; set; }
        public long SentDate { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsMailNew { get; set; }
        public bool IsMailDeleted { get; set; }
    }

    [AliceTable("")]
    public class PlayerSettingEntity
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public PlayerEntity Player { get; set; }

        public string Setting { get; set; }
        public string Value { get; set; }
    }

    [AliceTable("")]
    public class ShopEffectGroupEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public uint PreviewEffect { get; set; }
        // public IList<ShopEffectDto> ShopEffects { get; set; }
    }

    [AliceTable("")]
    public class ShopEffectEntity
    {
        public int Id { get; set; }

        public int EffectGroupId { get; set; }

        // public ShopEffectGroupDto EffectGroup { get; set; }

        public uint Effect { get; set; }
    }

    [AliceTable("")]
    public class ShopPriceGroupEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public byte PriceType { get; set; }

        //public IList<ShopPriceDto> ShopPrices { get; set; } = new List<ShopPriceDto>();
    }

    [AliceTable("")]
    public class ShopPriceEntity
    {
        public int Id { get; set; }
        public int PriceGroupId { get; set; }

        public byte PeriodType { get; set; }
        public int Period { get; set; }
        public int Price { get; set; }
        public bool IsRefundable { get; set; }
        public int Durability { get; set; }
        public bool IsEnabled { get; set; }
    }

    [AliceTable("")]
    public class ShopItemEntity
    {
        public uint Id { get; set; }

        public byte RequiredGender { get; set; }
        public byte RequiredLicense { get; set; }
        public byte Colors { get; set; }
        public byte UniqueColors { get; set; }
        public byte RequiredLevel { get; set; }
        public byte LevelLimit { get; set; }
        public byte RequiredMasterLevel { get; set; }
        public bool IsOneTimeUse { get; set; }
        public bool IsDestroyable { get; set; }
        public byte MainTab { get; set; }
        public byte SubTab { get; set; }

        // public IList<ShopItemInfoDto> ItemInfos { get; set; } = new List<ShopItemInfoDto>();
    }

    [AliceTable("")]
    public class ShopItemInfoEntity
    {
        public int Id { get; set; }

        public uint ShopItemId { get; set; }

        public int PriceGroupId { get; set; }
        public int EffectGroupId { get; set; }
        public byte DiscountPercentage { get; set; }
        public bool IsEnabled { get; set; }
    }

    [AliceTable("")]
    public class ShopVersionEntity
    {
        public byte Id { get; set; }

        public string Version { get; set; }
    }

    [AliceTable("")]
    public class StartItemEntity
    {
        public int Id { get; set; }

        public int ShopItemInfoId { get; set; }
        public int ShopPriceId { get; set; }
        public int ShopEffectId { get; set; }
        public byte Color { get; set; }
        public int Count { get; set; }
        public byte RequiredSecurityLevel { get; set; }
    }

    [AliceTable("")]
    public class ChannelEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int PlayerLimit { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public uint Color { get; set; }
        public uint TooltipColor { get; set; }
    }

    [AliceTable("")]
    public class ClubEntity
    {
        public uint Id { get; set; }

        public string MasterName { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string CreationDate { get; set; }
    }

    [AliceTable("")]
    public class ClubPlayerEntity
    {
        public int PlayerId { get; set; }
        public int ClubId { get; set; }
        public int State { get; set; }
        public int Rank { get; set; }
        public string JoinDate { get; set; }
    }
}
