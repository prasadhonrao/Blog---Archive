// var log = function logMessage(message){
// 	console.log(message);
// }

// log("JavaScript is my favorite language");


var print = function (input) {
    console.log("Print was called with value " + input);
}

print(10);

print = function (input) {
    console.log("Redefining print with value " + input);
}

print(20);