using MediatR;
using UniversalChatHistory.Application.Repositories;

namespace UniversalChatHistory.Application.Chats;

public class CreateChatCommandHandler(IChatRepository chatRepository) : IRequestHandler<CreateChatCommand>
{
    private readonly IChatRepository _chatRepository = chatRepository;

    public Task Handle(CreateChatCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}