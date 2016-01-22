// require files in Node.js environment
var $, HelloWorldResponse, ErrorResponse;
if (typeof module === 'object' && module.exports) {
  $ = require('jquery');
  HelloWorldResponse = require('../model/HelloWorldResponse.js');
  ErrorResponse = require('../model/ErrorResponse.js');
}

// export module for AMD
if ( typeof define === "function" && define.amd ) {     
	define(['jquery', 'HelloWorldResponse', 'ErrorResponse'], function($, HelloWorldResponse, ErrorResponse) {
        return DefaultApi;
	 });
}

var DefaultApi = function DefaultApi() {
	var self = this;
  
  
  /**
   * 
   * Returns &#39;Hello&#39; to the caller
   * @param {String}  name The name of the person to whom to say hello
   * @param {function} callback the callback function
   * @return HelloWorldResponse
   */
  self.hello = function(name, callback) {
    var postBody = null;
    var postBinaryBody = null;
    
    // create path and map variables
    var basePath = 'http://localhost:10010/';
    // if basePath ends with a /, remove it as path starts with a leading /
    if (basePath.substring(basePath.length-1, basePath.length)=='/') {
    	basePath = basePath.substring(0, basePath.length-1);
    }
    
    var path = basePath + replaceAll(replaceAll("/hello", "\\{format\\}","json"));

    var queryParams = {};
    var headerParams =  {};
    var formParams =  {};

    
    queryParams.name = name;
    
    
    

    path += createQueryString(queryParams);

    var options = {type: "GET", async: true, contentType: "application/json", dataType: "json", data: postBody};
    var request = $.ajax(path, options);

    request.fail(function(jqXHR, textStatus, errorThrown){
      if (callback) {
        var error = errorThrown || textStatus || jqXHR.statusText || 'error';
        callback(null, textStatus, jqXHR, error);
      }
    });
		
    request.done(function(response, textStatus, jqXHR){
      
      /**
        * @returns HelloWorldResponse
        */
      
      var myResponse = new HelloWorldResponse();
      myResponse.constructFromObject(response);
      if (callback) {
        callback(myResponse, textStatus, jqXHR);
      }
      
    });
 
    return request;
  }
  
  

 	function replaceAll (haystack, needle, replace) {
		var result= haystack;
		if (needle !=null && replace!=null) {
			result= haystack.replace(new RegExp(needle, 'g'), replace);
		}
		return result;
	}

 	function createQueryString (queryParams) {
		var queryString ='';
		var i = 0;
		for (var queryParamName in queryParams) {
			if (i==0) {
				queryString += '?' ;
			} else {
				queryString += '&' ;
			}
			
			queryString +=  queryParamName + '=' + encodeURIComponent(queryParams[queryParamName]);
			i++;
		}
		
		return queryString;
	}
}

// export module for Node.js
if (typeof module === 'object' && module.exports) {
  module.exports = DefaultApi;
}
