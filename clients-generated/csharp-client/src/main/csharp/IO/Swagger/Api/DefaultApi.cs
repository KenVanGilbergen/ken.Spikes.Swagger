using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns &#39;Hello&#39; to the caller
        /// </remarks>
        /// <param name="name">The name of the person to whom to say hello</param>
        /// <returns>HelloWorldResponse</returns>
        HelloWorldResponse Hello (string name = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns &#39;Hello&#39; to the caller
        /// </remarks>
        /// <param name="name">The name of the person to whom to say hello</param>
        /// <returns>ApiResponse of HelloWorldResponse</returns>
        ApiResponse<HelloWorldResponse> HelloWithHttpInfo (string name = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns &#39;Hello&#39; to the caller
        /// </remarks>
        /// <param name="name">The name of the person to whom to say hello</param>
        /// <returns>Task of HelloWorldResponse</returns>
        System.Threading.Tasks.Task<HelloWorldResponse> HelloAsync (string name = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns &#39;Hello&#39; to the caller
        /// </remarks>
        /// <param name="name">The name of the person to whom to say hello</param>
        /// <returns>Task of ApiResponse (HelloWorldResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HelloWorldResponse>> HelloAsyncWithHttpInfo (string name = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        ///  Returns &#39;Hello&#39; to the caller
        /// </summary>
        /// <param name="name">The name of the person to whom to say hello</param> 
        /// <returns>HelloWorldResponse</returns>
        public HelloWorldResponse Hello (string name = null)
        {
             ApiResponse<HelloWorldResponse> response = HelloWithHttpInfo(name);
             return response.Data;
        }

        /// <summary>
        ///  Returns &#39;Hello&#39; to the caller
        /// </summary>
        /// <param name="name">The name of the person to whom to say hello</param> 
        /// <returns>ApiResponse of HelloWorldResponse</returns>
        public ApiResponse< HelloWorldResponse > HelloWithHttpInfo (string name = null)
        {
            
    
            var path_ = "/hello";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Hello: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Hello: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<HelloWorldResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HelloWorldResponse) Configuration.ApiClient.Deserialize(response, typeof(HelloWorldResponse)));
            
        }
    
        /// <summary>
        ///  Returns &#39;Hello&#39; to the caller
        /// </summary>
        /// <param name="name">The name of the person to whom to say hello</param>
        /// <returns>Task of HelloWorldResponse</returns>
        public async System.Threading.Tasks.Task<HelloWorldResponse> HelloAsync (string name = null)
        {
             ApiResponse<HelloWorldResponse> response = await HelloAsyncWithHttpInfo(name);
             return response.Data;

        }

        /// <summary>
        ///  Returns &#39;Hello&#39; to the caller
        /// </summary>
        /// <param name="name">The name of the person to whom to say hello</param>
        /// <returns>Task of ApiResponse (HelloWorldResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HelloWorldResponse>> HelloAsyncWithHttpInfo (string name = null)
        {
            
    
            var path_ = "/hello";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Hello: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Hello: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<HelloWorldResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HelloWorldResponse) Configuration.ApiClient.Deserialize(response, typeof(HelloWorldResponse)));
            
        }
        
    }
    
}
