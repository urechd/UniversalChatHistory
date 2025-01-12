namespace UniversalChatHistory.Domain.Chats;

public class Chat
{
    public Guid Id { get; init; }
    public string UserName { get; init; }
    public string Message { get; init; }

    public Chat(
        string userName,
        string message,
        Guid? id)
    {
        Id = id ?? Guid.NewGuid();
        UserName = userName;
        Message = message;
    }
}