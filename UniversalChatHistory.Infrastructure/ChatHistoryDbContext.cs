using Microsoft.EntityFrameworkCore;
using UniversalChatHistory.Domain.Chats;

namespace UniversalChatHistory.Infrastructure;

public class ChatHistoryDbContext : DbContext
{
    public DbSet<Chat> Chats { get; set; }
    
    public string DbPath { get; set; }

    public ChatHistoryDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Combine(path, "ChatHistory.db");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");
}