using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.July2021.Domain.Dto
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public string MainErrorMessage { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public static ResponseModel Success => new ResponseModel { IsSuccess = true };
        public static ResponseModel MakeError(string error = "Error encountered") => new ResponseModel { MainErrorMessage = error };
    }

    public class ResponseModel<T> : ResponseModel
    {
        public T Data { get; set; }

        public static new ResponseModel<T> MakeError(string error) => new ResponseModel<T>
        {
            MainErrorMessage = error,
            IsSuccess = false
        };

        public static ResponseModel<T> SuccessWithData(T data) => new ResponseModel<T>
        {
            Data = data,
            IsSuccess = true
        };
    }
}
