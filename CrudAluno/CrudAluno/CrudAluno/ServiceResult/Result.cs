using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAluno.ServiceResult
{
    public class Result
    {
        public ResultType ResultType { get; set; }

        public string Error { get; set; }

        public string Alert { get; set; }

        public Result()
        {
            SuccessResult();
        }

        public Result(Result result)
        {
            ResultType = result.ResultType;
            Error = result.Error;
        }

        public Result InvalidResult(string error)
        {
            ResultType = ResultType.Invalid;
            Error = error;

            return this;
        }

        public Result InvalidResult(Result resultError)
        {
            ResultType = ResultType.Invalid;
            Error = resultError.Error;
            Alert = resultError.Alert;

            return this;
        }

        public Result SuccessResult()
        {
            ResultType = ResultType.Ok;
            Error = string.Empty;

            return this;
        }

        public bool IsNotOkResult()
        {
            return (ResultType == ResultType.Ok || ResultType == ResultType.OkWithReset) == false;
        }
    }

    public class Result<T> : Result
    {
        public Result()
        {
            SuccessResult();
        }

        public Result(Result result) : base(result)
        {
            ResultType = result.ResultType;
            Error = result.Error;
        }

        public Result<T> InvalidResult(string error, T data)
        {
            base.InvalidResult(error);
            Data = data;

            return this;
        }

        public Result<T> InvalidResult(string error)
        {
            base.InvalidResult(error);

            return this;
        }

        public Result<T> InvalidResult(Result error)
        {
            base.InvalidResult(error);

            return this;
        }

        public Result<T> SuccessResult()
        {
            base.SuccessResult();

            return this;
        }

        public Result<T> SuccessResult(T data)
        {
            base.SuccessResult();
            Data = data;

            return this;
        }

        public T Data { get; set; }
    }

    public enum ResultType
    {
        Ok,
        OkWithReset,
        Invalid,
        ServeOffLine,
        TimeOut,
        UpdateClient,
        ResetClient,
        LogOffClient
    }
}
