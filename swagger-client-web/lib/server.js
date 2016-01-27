var express = require('express');
var app = express();

app.use(require('connect-livereload')({
    port: 8000
}));
app.use(express.static('_site'));

app.listen(3000, function () {
  console.log('Listening on port 3000!');
});