namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>
    {
        public OperationResult()
        {
        }

        public OperationResult(T value, string message) : this()
        {
            this.Result = value;
            this.Message = message;
        }

        public T Result { get; set; }
        public string Message { get; set; }
    }

}
