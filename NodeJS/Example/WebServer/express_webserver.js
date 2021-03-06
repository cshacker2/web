var express = require('express'), http = require('http');

var app = express();

app.use(function(req, res, next) {
    console.log('first middle ware');
    req.user = 'mike';
    //res.send({name:'girls generation', age:20});
    next();
});

app.use('/', function(req, res, next) {
    console.log('second middle ware');

    res.writeHead('200', {'Content-Type':'text/html;charset=utf8'});
    res.end('<h1>Express Server ' + req.user + ' response.</h1>');
});

app.set('port', process.env.PORT || 3000);

http.createServer(app).listen(app.get('port'), function() {
    console.log('express server started : ' + app.get('port'));
});