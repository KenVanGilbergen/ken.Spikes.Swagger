if (typeof module === 'object' && module.exports) {
  var HelloWorldApp = {};
  
  HelloWorldApp.HelloWorldResponse = require('./model/HelloWorldResponse.js');
  
  HelloWorldApp.ErrorResponse = require('./model/ErrorResponse.js');
  
  
  HelloWorldApp.DefaultApi = require('./api/DefaultApi.js');
  
  module.exports = HelloWorldApp;
}