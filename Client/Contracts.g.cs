﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v11.17.21.0 (NJsonSchema v9.10.63.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace Example.Api.Client.Contracts
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.17.21.0 (NJsonSchema v9.10.63.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial interface IValuesClient
    {
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> GetAllAsync();
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> GetAllAsync(System.Threading.CancellationToken cancellationToken);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        System.Threading.Tasks.Task PostAsync(string value);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        System.Threading.Tasks.Task PostAsync(string value, System.Threading.CancellationToken cancellationToken);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<string> GetAsync(int id);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        System.Threading.Tasks.Task<string> GetAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        System.Threading.Tasks.Task PutAsync(int id, string value);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        System.Threading.Tasks.Task PutAsync(int id, string value, System.Threading.CancellationToken cancellationToken);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        System.Threading.Tasks.Task DeleteAsync(int id);
    
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        System.Threading.Tasks.Task DeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
    }
    
    

    

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.17.21.0 (NJsonSchema v9.10.63.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class SwaggerException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.17.21.0 (NJsonSchema v9.10.63.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}