using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitucture.Application.Common
{
    public class Result
    {
        public bool IsSuccess { get; init; }
        public bool IsFailure => !IsSuccess;
        public string Message { get; set; }

        public Result() => IsSuccess = true;
        public Result(string message)
        {
            IsSuccess = false;
            Message = message;
        }


        public static Result Failure(string message) => new(message);
        public static Result Success() => new();
    }
}
