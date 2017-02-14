var http = require('http');
var module_1 = require('./module_1');
var module_2 = require('./module_2');

function onRequest(req,res){
  res.writeHead(200,{'Content-Type':'text/plain'});
  res.write(module_2.myVariable);
  module_2.myFunction;
  res.end();
}

http.createServer(onRequest).listen(3000);
