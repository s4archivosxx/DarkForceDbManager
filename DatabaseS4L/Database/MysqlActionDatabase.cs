using DatabaseS4L.Auth;
using DatabaseS4L.Game;
using DatabaseS4L.Web;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseS4L
{
    public class MysqlActionDatabase : MysqlDatabase
    {
        public static MysqlActionDatabase This { get; set; }

        public MysqlActionDatabase()
        {
            This = this;
            MysqlConnection = string.Empty;
        }

        public MysqlActionDatabase(string mysqlConnection)
        {
            This = this;
            MysqlConnection = mysqlConnection;
        }

        public bool CheckConnection()
        {
            return IsValidConnection();
        }

        public MysqlActionDatabase AddConnetionString(string connectionString)
        {
            MysqlConnection = connectionString;
            return This;
        }

        public Task<long> AddAccountEntity(object entity)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Insert("accounts")
                          .IntoValues()
                          .ExecuteGetId();
                return Task.FromResult(_);
            }
        }

        public Task AddWebAccountEntity(object entity)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Insert("web_accounts")
                          .IntoValues()
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }

        public Task AddPlayerItemEntity(object entity)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Insert("player_items")
                          .IntoValues()
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }

        public Task<List<AccountEntity>> GetAccountEntities()
        {
            using (var connection = Open())
            {
                var entity = new AccountEntity();
                var result = new List<AccountEntity>();
                var _ = CreateCommand(mysql: connection)
                            .Select("accounts")
                            .OrderBy("Id")
                            .Limit(0, 1000)
                            .ExecuteReader();

                if (!_.HasRows)
                    return Task.FromResult(result);

                while (_.Read())
                {
                    entity.Id = _.GetInt32(0);
                    entity.Username = _.GetString(1);
                    try { entity.Nickname = _.GetString(2); }
                    catch { entity.Nickname = string.Empty; }
                    try { entity.Password = _.GetString(3); }
                    catch { entity.Password = string.Empty; }
                    entity.Salt = _.GetString(4);
                    entity.SecurityLevel = _.GetByte(5);
                    entity.Token = _.GetString(6);
                    entity.AccessToken = _.GetString(7);
                    entity.RefreshToken = _.GetString(8);
                    entity.ExpireDate = _.GetString(9);
                    result.Add(entity);
                }

                return Task.FromResult(result);
            }
        }

        public Task<PlayerEntity> GetPlayerEntity(object entity)
        {
            try
            {
                using (var connection = Open())
                {
                    var result = new PlayerEntity();
                    var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                              .Select("players")
                              .Where()
                              .ExecuteReader();

                    if (!_.Read())
                        return Task.FromResult(default(PlayerEntity));

                    result = new PlayerEntity
                    {
                        Id = _.GetInt32(0),
                        EventCoupon = _.GetInt32(1),
                        OnGame = _.GetByte(2),
                        GameTime = _.GetString(3),
                        TutorialState = _.GetByte(4),
                        Level = _.GetByte(5),
                        TotalExperience = _.GetUInt32(6),
                        PEN = _.GetInt32(7),
                        AP = _.GetInt32(8),
                        Coins1 = _.GetInt32(9),
                        Coins2 = _.GetInt32(10),
                        CurrentCharacterSlot = _.GetByte(11),
                        TotalWins = _.GetInt32(12),
                        TotalLosses = _.GetInt32(13)
                    };

                    return Task.FromResult(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.FromResult(default(PlayerEntity));
            }
        }

        public Task<List<PlayerEntity>> GetPlayerEntities()
        {
            using (var connection = Open())
            {
                var result = new List<PlayerEntity>();
                var _ = CreateCommand(mysql: connection)
                            .Select("players")
                            .OrderBy("Id")
                            .Limit(0, 1000)
                            .ExecuteReader();

                if (!_.HasRows)
                    return Task.FromResult(result);

                while (_.Read())
                {
                    result.Add(new PlayerEntity
                    {
                        Id = _.GetInt32(0),
                        EventCoupon = _.GetInt32(1),
                        OnGame = _.GetByte(2),
                        GameTime = _.GetString(3),
                        TutorialState = _.GetByte(4),
                        Level = _.GetByte(5),
                        TotalExperience = _.GetUInt32(6),
                        PEN = _.GetInt32(7),
                        AP = _.GetInt32(8),
                        Coins1 = _.GetInt32(9),
                        Coins2 = _.GetInt32(10),
                        CurrentCharacterSlot = _.GetByte(11),
                        TotalWins = _.GetInt32(12),
                        TotalLosses = _.GetInt32(13)
                    });
                }
                return Task.FromResult(result);
            }
        }

        public Task<List<PlayerItemEntity>> GetPlayerItemEntities()
        {
            using (var connection = Open())
            {
                var result = new List<PlayerItemEntity>();
                var _ = CreateCommand(mysql: connection)
                            .Select("player_items")
                            .OrderBy("Id")
                            .ExecuteReader();

                if (!_.HasRows)
                    return Task.FromResult(result);

                while (_.Read())
                {
                    result.Add(new PlayerItemEntity
                    {
                        Id = _.GetInt64(0),
                        PlayerId = _.GetInt32(1),
                        ShopItemInfoId = _.GetInt32(2),
                        ShopPriceId = _.GetInt32(3),
                        Color = _.GetByte(4),
                        PurchaseDate = _.GetInt64(5),
                        Durability = _.GetInt32(6),
                        MP = _.GetUInt32(7),
                        MPLevel = _.GetUInt32(8),
                        Effects = _.GetString(9),
                    });
                }
                return Task.FromResult(result);
            }
        }

        public Task<List<PlayerItemEntity>> GetPlayerItemEntities(object entity, params string[] columns)
        {
            using (var connection = Open())
            {
                var result = new List<PlayerItemEntity>();
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                            .Select("player_items")
                            .Where(columns)
                            .ExecuteReader();

                if (!_.HasRows)
                    return Task.FromResult(result);

                while (_.Read())
                {
                    result.Add(new PlayerItemEntity
                    {
                        Id = _.GetInt64(0),
                        PlayerId = _.GetInt32(1),
                        ShopItemInfoId = _.GetInt32(2),
                        ShopPriceId = _.GetInt32(3),
                        Color = _.GetByte(4),
                        PurchaseDate = _.GetInt64(5),
                        Durability = _.GetInt32(6),
                        MP = _.GetUInt32(7),
                        MPLevel = _.GetUInt32(8),
                        Effects = _.GetString(9),
                    });
                }
                return Task.FromResult(result);
            }
        }

        public Task AddLoginHistory(object entity)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Insert("login_history")
                          .IntoValues()
                          .ExecuteNonQuery();
            }
            return Task.CompletedTask;
        }

        public Task<LoginHistoryEntity> GetLoginHistory(object entity)
        {
            try
            {
                using (var connection = Open())
                {
                    var result = new LoginHistoryEntity();
                    var reader = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                                 .Select(
                                    table: "login_history")
                                 .Where()
                                 .ExecuteReader();

                    if (!reader.Read())
                        return Task.FromResult(default(LoginHistoryEntity));

                    result.Id = reader.GetInt32(0);
                    result.AccountId = reader.GetInt32(1);
                    result.Date = reader.GetInt64(2);
                    result.IP = reader.GetString(3);
                    return Task.FromResult(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.FromResult(default(LoginHistoryEntity));
            }
        }

        public Task<AccountEntity> GetAccount(object entity)
        {
            try
            {
                using (var connection = Open())
                {
                    var result = new AccountEntity();
                    var reader = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                                .Select(
                                    table: "accounts")
                                .Where()
                                .ExecuteReader();

                    if (!reader.Read())
                        return Task.FromResult(default(AccountEntity));

                    result.Id = reader.GetInt32(0);
                    result.Username = reader.GetString(1);
                    try { result.Nickname = reader.GetString(2); }
                    catch { result.Nickname = string.Empty; }
                    try { result.Password = reader.GetString(3); }
                    catch { result.Password = string.Empty; }
                    result.Salt = reader.GetString(4);
                    result.SecurityLevel = reader.GetByte(5);
                    result.Token = reader.GetString(6);
                    result.AccessToken = reader.GetString(7);
                    result.RefreshToken = reader.GetString(8);
                    result.ExpireDate = reader.GetString(9);

                    return Task.FromResult(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.FromResult(default(AccountEntity));
            }
        }

        public Task<WebAccountEntity> GetWebAccountById(object entity)
        {
            try
            {
                using (var connection = Open())
                {
                    var result = new WebAccountEntity();
                    var reader = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                                .Select(
                                    table: "web_accounts")
                                .Where()
                                .ExecuteReader();

                    if (!reader.Read())
                        return Task.FromResult(default(WebAccountEntity));

                    result.AccountId = reader.GetInt32(0);
                    result.Password = reader.GetString(1);
                    result.NPassword = reader.GetString(2);
                    result.Mail = reader.GetString(3);
                    result.NMail = reader.GetString(4);
                    result.DateBirthday = reader.GetString(5);
                    result.Country = reader.GetString(6);
                    result.DateRegister = reader.GetString(7);
                    result.LastLogin = reader.GetString(8);
                    result.IsVip = reader.GetBoolean(9);

                    return Task.FromResult(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.FromResult(default(WebAccountEntity));
            }
        }

        public Task<WebAccountEntity> GetWebAccountByMail(string mail)
        {
            using (var connection = Open())
            {
                var result = new WebAccountEntity();
                var reader = CreateCommand(
                                mysql: connection,
                                instance: new { NMail = mail })
                            .Select(
                                table: "web_accounts")
                            .Where()
                            .ExecuteReader();

                if (!reader.Read())
                {
                    reader = CreateCommand(
                                mysql: connection,
                                instance: new { Mail = mail })
                            .Select(
                                table: "web_accounts")
                            .Where()
                            .ExecuteReader();
                }

                if (!reader.Read())
                    return Task.FromResult(default(WebAccountEntity));

                result.AccountId = reader.GetInt32(0);
                result.Password = reader.GetString(1);
                result.NPassword = reader.GetString(2);
                result.Mail = reader.GetString(3);
                result.NMail = reader.GetString(4);
                result.DateBirthday = reader.GetString(5);
                result.Country = reader.GetString(6);
                result.DateRegister = reader.GetString(7);
                result.LastLogin = reader.GetString(8);
                result.IsVip = reader.GetBoolean(9);

                return Task.FromResult(result);
            }
        }

        public Task UpdateAccountEntity(object entity)
        {
            try
            {
                using (var connection = Open())
                {
                    var _ = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                              .Update(
                                    table: "accounts")
                              .Set(skip: 6)
                              .Where()
                              .ExecuteNonQuery();
                    return Task.CompletedTask;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.CompletedTask;
            }
        }

        public Task UpdateAccountEntity(object entity, int skip, int limit, bool blocked)
        {
            try
            {
                using (var connection = Open())
                {
                    var _ = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                              .Update(
                                    table: "accounts")
                              .Set(skip, limit, blocked)
                              .Where()
                              .ExecuteNonQuery();
                    return Task.CompletedTask;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.CompletedTask;
            }
        }

        public Task UpdateAccountEntity(object entity, params string[] columns)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Update(
                                table: "accounts")
                          .Set(columns)
                          .Where()
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }

        public Task UpdatePlayerEntity(object entity, int skip, int limit, bool blocked)
        {
            try
            {
                using (var connection = Open())
                {
                    var _ = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                              .Update(
                                    table: "players")
                              .Set(skip, limit, blocked)
                              .Where()
                              .ExecuteNonQuery();
                    return Task.CompletedTask;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.CompletedTask;
            }
        }

        public Task UpdatePlayerEntity(object entity, string column)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Update(
                                table: "players")
                          .Set(column)
                          .Where()
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }

        public Task UpdatePlayerItemEntity(object entity, string column, long value)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Update(
                                table: "player_items")
                          .Set(column, value)
                          .Where("Id", "PlayerId")
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }

        public Task UpdateLoginHistory(object entity)
        {
            try
            {
                using (var connection = Open())
                {
                    var _ = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                                .Update(
                                    table: "login_history")
                                .Set(skip: 2)
                                .Where()
                                .ExecuteNonQuery();
                    return Task.CompletedTask;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Task.CompletedTask;
            }
        }

        public Task UpdateShopItemEntity(object entity)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                    mysql: connection,
                                    instance: entity)
                          .Update(
                                  table: "shop_items")
                          .Set()
                          .Where()
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }

        public Task UpdateWebAccountEntity(object entity)
        {
            using (var connection = Open())
            {
                var _ = CreateCommand(
                                mysql: connection,
                                instance: entity)
                          .Update(
                                table: "web_accounts")
                          .Set()
                          .Where()
                          .ExecuteNonQuery();
                return Task.CompletedTask;
            }
        }
    }
}
