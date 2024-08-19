using MediatR;

namespace CleanArchitucture.Application.Users.Commands
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string UserName { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
