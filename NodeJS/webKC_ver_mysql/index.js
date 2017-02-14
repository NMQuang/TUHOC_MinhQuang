var express = require("express");
var app = express();
app.use(express.static("public"));
app.set("view engine","ejs");
app.set("views","./views");
app.listen(process.env.PORT ||3000);

//Thêm các modules
var mysql = require("mysql");
var config = {
	host: "localhost",
	user: "root",
	password: null,
	database: "giangsnhdb",
};

/*var ckStaticsPath = require('node-ckeditor');

app.use(express.statics(ckStaticsPath));*/

var pool = mysql.createPool(config);

var bodyParser = require("body-parser");

var urlencodedParser = bodyParser.urlencoded({ extended: false });

var multer = require("multer");


var storage = multer.diskStorage({
  destination: function (req, file, cb) {
    cb(null, './public/upload')
  },
  filename: function (req, file, cb) {
    cb(null, file.originalname)
  }
});

var upload = multer({ 
	storage: storage 
}).single("anh");


//GET về trang chủ home.ejs
app.get("/",function(req,res){
	// Viết câu truy vấn sql
	var sql = "SELECT * FROM Video";// Thực hiện câu truy vấn và show dữ liệu
	pool.query(sql, function(error, result){
	if (error) 
	{
		res.end();
		return console.error("Lỗi khi chạy sql",error);
	}
	res.render("home",{data:result});

	});
});

//GET về trang list.ejs
app.get("/video/list",function(req,res){
		// Viết câu truy vấn sql
	var sql = "SELECT * FROM Video";// Thực hiện câu truy vấn và show dữ liệu
	pool.query(sql, function(error, result){
	if (error) 
	{
		res.end();
		return console.error("Lỗi khi chạy sql",error);
	}
	res.render("list",{data:result});

	});
});

//GET về trang delete.ejs với tham số id
app.get("/video/delete/:id",function(req,res){
		// Viết câu truy vấn sql
	var sql = "DELETE FROM Video WHERE id_video =" +req.params.id;// Thực hiện câu truy vấn và show dữ liệu
	pool.query(sql, function(error, result){
	if (error) 
	{
		res.end();
		return console.error("Lỗi khi chạy sql",error);
	}
	res.redirect("../list");

	});
});

//GET về trang add.ejs
app.get("/video/add",function(req,res){
	res.render("add");
});
//POST dữ liệu từ trang add.ejs về CSDL
app.post("/video/add",urlencodedParser,function(req,res){
	upload(req, res, function (err) {
    if (err) {
     	res.send("Loi");
    }else{
    	if(req.file == undefined){
    		res.send("File chưa được chọn");
    	}else{
    		var sql = "INSERT INTO Video(tieude_video,mota_video,key_video,image_video) values('"+req.body.tieude+"','"+req.body.mota+"','"+req.body.key+"','"+req.file.originalname+"') ";// Thực hiện câu truy vấn và show dữ liệu
			pool.query(sql, function(error, result){
			if (error) 
			{
				res.end();
				return console.error("Lỗi khi chạy sql",error);
			}
			res.redirect("./list");

			});
    	}
    }
  });
	
});

//GET về trang edit.ejs
app.get("/video/edit/:id",function(req,res){
		// Viết câu truy vấn sql
		var id = req.params.id;
	var sql = "SELECT * FROM Video WHERE id_video="+id;// Thực hiện câu truy vấn và show dữ liệu
	pool.query(sql, function(error, result){
	if (error) 
	{
		res.end();
		return console.error("Lỗi khi chạy sql",error);
	}
	res.render("edit",{data:result});

	});

});

//POST dữ liệu từ trang .ejs về CSDL
app.post("/video/edit/:id",urlencodedParser,function(req,res){
	var id = req.params.id;
	upload(req, res, function (err) {
    if (err) {
     	res.send("Lỗi trong quá trình upload");
    }else{
    	if(req.file == undefined){
    	
    		var sql = "UPDATE Video SET tieude_video='"+req.body.tieude+"',mota_video='"+req.body.mota+"',key_video='"+req.body.key+"' WHERE id_video ="+id;// Thực hiện câu truy vấn và show dữ liệu
			pool.query(sql, function(error, result){
			if (error) 
			{
				res.end();
				return console.error("Lỗi khi chạy sql",error);
			}
			res.redirect("../list");

			});
    	}
    	else{
    		var sql = "UPDATE Video SET tieude_video='"+req.body.tieude+"',mota_video='"+req.body.mota+"',key_video='"+req.body.key+"',image_video='"+req.file.originalname+"' WHERE id_video ="+id;// Thực hiện câu truy vấn và show dữ liệu
			pool.query(sql, function(error, result){
			if (error) 
			{
				res.end();
				return console.error("Lỗi khi chạy sql",error);
			}
			res.redirect("../list");

			});
    	}
    }
  })
	
});
