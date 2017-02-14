var express = require('express');
var router = express.Router();


//Test get-post method
router.get('/test/:content',function(req,res,next){
  res.render('shop/testgetpost',{output:req.params.content});
});

router.post('/test/input',function(req,res,next){
  var content = req.body.content;
  res.redirect('/test/'+content);
});
//Kết thúc test

//Test validator and session
router.get('/testsession', function(req, res, next) {
  res.render('shop/testsession', { title: 'Validator and Session Test', success:req.session.success ,errors:req.session.errors });
  req.session.errors = null;
});

router.post('/submit',function(req,res,next){
  req.check('email','Invalid email address').isEmail();
  req.check('password','Password is invalid').isLength({min:4}).equals(req.body.confirmPassword);

  var errors = req.validationErrors();
  if(errors){
    req.session.errors = errors;
    req.session.success = false;
  }else{
    req.session.success = true;
  }
  res.redirect('/testsession');
});

//End the test
module.exports = router;
