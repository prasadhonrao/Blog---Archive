//Anonymous Functions
var log = function(message){
	console.log(message);
}
log("Jack & Jill went up the hill...");

// //Anonymous Functions In Object Literal
// var person = {
//     firstName : "Prasad",
//     lastName : "Honrao",
//     fullName: function(){
//         return this.firstName + " " + this.lastName;
//     }
// };
// console.log(person.fullName());

// // As function object
// setTimeout(function() {
//     console.log('hello');
// }, 1000);


// // In Node.js

// var http = require("http");
// var server = http.createServer(function(request, response) {
//     response.write("Hello World");
//     response.end();

// });
// server.listen(1234);

// // Callback function
// var contest = {
//                 ans: "Red",
//                 askQuestion: function (question, answered) {
//                     console.log(question);
//                     answered(this.ans);
//                }
//             }

// contest.askQuestion("What is your favorite color?" , function (answer) {
//     console.log("Answer is " + answer);
// });
