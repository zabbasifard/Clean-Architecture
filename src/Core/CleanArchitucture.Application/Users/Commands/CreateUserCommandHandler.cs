using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitucture.Application.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new CreateUserCommand
            {
                UserName = request.UserName,
                Email = request.Email,
                FistName = request.FistName,
                LastName = request.LastName,
            };


        }
    }
}
