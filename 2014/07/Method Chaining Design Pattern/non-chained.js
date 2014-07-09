var Person = function() {
	this.name = "";
	this.age = 0;
	this.city = "";

	this.setName = function(name){
		this.name = name;
	};
};

// Person.prototype.setName = function(name) {
// 	this.name = name;
// };

Person.prototype.setAge = function(age) {
	this.age = age;
};

Person.prototype.setCity = function(city) {
	this.city = city;
};

Person.prototype.save = function() {
	console.log("Saving Person [" + "Name : " + this.name + ", Age : " + this.age + ", City : " + this.city + "]...");
};

var colin = new Person();
colin.setName("Colin");
colin.setAge(35);
colin.setCity("London");

colin.save();


// var Person = function() {
// 	this.name = "";
// 	this.age = 0;
// 	this.city = "";

// 	this.setName = function(name){
// 		this.name = name;
// 	};
// };

// // Person.prototype.setName = function(name) {
// // 	this.name = name;
// // };

// Person.prototype.setAge = function(age) {
// 	this.age = age;
// };

// Person.prototype.setCity = function(city) {
// 	this.city = city;
// };

// Person.prototype.save = function() {
// 	console.log("Saving Person [" + "Name : " + this.name + ", Age : " + this.age + ", City : " + this.city + "]...");
// };

// var colin = new Person();
// colin.setName("Colin");
// colin.setAge(35);
// colin.setCity("London");

// colin.save();