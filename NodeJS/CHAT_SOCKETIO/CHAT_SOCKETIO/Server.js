var express = require("express");
var app = express();
app.use(express.static("public"));
app.set("view engine", "ejs");
app.set("views", "./views");
var server = require("http").Server(app);
var io = require("socket.io")(server);
server.listen(3000);
var mangUn = [];

io.on("connection", function(socket){
  console.log("Co nguoi ket noi " + socket.id);

  // lang nghe cliend dang ki tv
  socket.on("client-send-un", function(data){
    console.log("Username: " + data);

    var kq=0;
    if( mangUn.indexOf(data)>=0 ){
      console.log("Co nguoi dang ki roi");
      kq = 0;
    }else{
      kq = 1;
      mangUn.push(data);
      socket.username=data;
      console.log("Dang ki thanh cong");
    }
    socket.emit("server-send-kqdk", kq);

  });

  // lang nghe noi dung chat
  socket.on("client-send-ms", function(data){
    console.log("Noidung: " + data);
    io.sockets.emit("server-send-ms",
      {u:socket.username, d:data});
  });

});

app.get("/", function(req, res){
  res.render("trangchu");
});
