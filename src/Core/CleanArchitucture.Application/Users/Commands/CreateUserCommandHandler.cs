using CleanArchitecture.Domain.Entities;
using CleanArchitucture.Application.Common;
using MediatR;

namespace CleanArchitucture.Application.Users.Commands
{
    public class CreateUserCommandHandler(IApplicationUnitOfWork unitOfWork) : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IApplicationUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                UserName = request.UserName,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
            };

            _unitOfWork.Users.Add(user);
            await _unitOfWork.SaveChangeAsync(cancellationToken);
            return user.Id;
        }
    }
}
