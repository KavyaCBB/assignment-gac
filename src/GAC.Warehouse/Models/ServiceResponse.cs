using System.Runtime.Serialization;

namespace IO.Swagger.Models
{
    [DataContract]
    public class ServiceResponse<T>
    {

        public ServiceResponse()
        {
            Status = ServiceResponseStatus.Error;
            IsSuccess = false;
        }

        public ServiceResponse(ServiceResponseStatus status)
        {
            Status = status;
        }

        [DataMember(Name = "Data")]
        public T Data { get; set; }

        [DataMember(Name = "Error")]
        public ErrorResponse Error { get; set; }

        [DataMember(Name = "Status")]
        public ServiceResponseStatus Status { get; set; }

        [DataMember(Name = "IsSuccess")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Set Error Message
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"></param>
        /// <param name="stackTrace"></param>
        /// <returns></returns>
        public ServiceResponse<T> SetError(string methodName, ServiceResponseStatus errorCode, string errorType,string errorMessage, string stackTrace = "")
        {
            this.IsSuccess = false;
            this.Status = errorCode;
            this.Error = new ErrorResponse
            {
                Error = errorMessage,
                ErrorType = errorType
            };

            return this;
        }

        /// <summary>
        /// 204 - No Content
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public ServiceResponse<T> SetNoDataFound(string methodName)
        {
            this.IsSuccess = true;
            this.Status = ServiceResponseStatus.NoContent;
            this.Error = new ErrorResponse
            {
                ErrorCode = 204,
                ErrorType = "No Content"
            };

            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public ServiceResponse<T> SetSuccess(T data)
        {
            this.Data = data;
            this.IsSuccess = true;
            this.Status = ServiceResponseStatus.Success;

            return this;
        }
    }

    public enum ServiceResponseStatus
    {
        Success = 200,
        NoContent = 204,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        Error = 500,
        Fail = 400,
        BadRequest = 400
    }
}
