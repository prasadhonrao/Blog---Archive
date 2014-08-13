
var log = function(message){
	console.log(message);
}
log("This is an anonymous function");

//Anonymous Functions In Object Literal
var person = {
    sayHello: function(){
        console.log("hello");
    }
};
person.sayHello();