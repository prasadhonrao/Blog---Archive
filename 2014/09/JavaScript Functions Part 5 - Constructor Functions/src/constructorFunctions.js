var Customer = function (fname, lname, age) {
	this.FirstName  = fname;
	this.LastName = lname;
	this.Age = age;
}

var bob = new Customer("Bob","Hart", 50);
var mili = new Customer("Mili");

console.log(bob instanceof Customer);
console.log(mili instanceof Customer);

Customer.prototype.city = "London";
console.log(mili.city);
