var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/',function(req,res,next){
  res.render('shop/index');
});

//Test get-post method
router.get('/test/:id',function(req,res,next){
  res.render('shop/test_get',{output:req.params.id});
});

router.post('/test/input',function(req,res,next){
  var id = req.body.id;
  res.redirect('/test/'+id);
});
//Kết thúc test

//Test validator and session
router.get('/testsession', function(req, res, next) {
  res.render('shop/test_get', { title: 'Validator and Session Test', success:req.session.success ,errors:req.session.errors });
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
