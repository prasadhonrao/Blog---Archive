//Binary
var validBinary = 0b1111;
var invalidBinary = 0BX1111; //SyntaxError
console.log(validBinary); //15

//Octal
var validOctal = 0o1234;
var invalidOctal = 0OAA1234; // SyntaxError
console.log(validOctal); //668