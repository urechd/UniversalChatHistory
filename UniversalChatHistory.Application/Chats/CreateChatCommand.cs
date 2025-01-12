using MediatR;

namespace UniversalChatHistory.Application.Chats;

public record CreateChatCommand(string Username, string Message) : IRequest;