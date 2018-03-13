using System.Data.Entity;
using LiteBot.Models;
using Configuration = LiteBot.Migrations.Configuration;

namespace LiteBot
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("name=connString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Fanpage> Fanpages { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Giftcode> Giftcodes { get; set; }
        public DbSet<GroupGiftcode> GroupGiftcodes { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuButton> MenuButtons { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Sequence> Sequences { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<ShortLink> ShortLinks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}