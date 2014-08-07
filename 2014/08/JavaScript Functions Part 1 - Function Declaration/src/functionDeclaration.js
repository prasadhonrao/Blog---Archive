function logMessage(message){
	console.log(message);
}
logMessage("This is a function statement");


function print(input) {
    console.log("Print was called with value " + input);
}
print(10);

function print(input) {
    console.log("Redefining print with value " + input);
}
print(20);