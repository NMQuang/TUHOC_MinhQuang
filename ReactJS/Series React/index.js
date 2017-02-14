var express = require("express");
var bodyParser = require("body-parser");
var expressHbs = require('express-handlebars');
var parser = bodyParser.urlencoded({extended:false});

var app = express();
app.use(express.static("public"));
app.engine('.hbs', expressHbs({defaultViews: 'home_views', extname: '.hbs'}));
app.set('view engine', '.hbs');
//app.set("view engine","ejs");
//app.set("views","./views");
app.listen(3000);

var Mang = ["HTML5 & CSS3","NodeJS","ReactJS","Java-Spring"];

app.post("/getNode",function(req,res){
	res.send(Mang)
});

app.get("/",function(request,response){
	response.render("home_views");
});

app.post("/add",parser,function(req,res){
	var newNote = req.body.note;
	Mang.push(newNote);
	res.send(Mang);
})

app.post("/delete",parser,function(req,res){
	var id = req.body.idXoa;
	Mang.splice(id,1);
	res.send(Mang);
})

app.post("/update",parser,function(req,res){
	var id = req.body.idSua;
	Mang[id] = req.body.textSua;
	res.send(Mang);
})
