var Person = function() {
	this.name = "";
	this.age = 0;
	this.city = "";

	this.setName = function(name){
		this.name = name;
		return this;
	};

	this.setAge = function(age){
		this.age = age;
		return this;
	};

	this.setCity = function(city) {
		this.city = city;
		return this;
	};

	this.save = function() {
		console.log("Saving Person ["
			        + "Name : " + this.name + ", "
			        + "Age : " + this.age + ", "
			        + "City : " + this.city + "]...");
		return this;
	};
};

new Person().setName("Colin")
 	 		.setAge(35)
     		.setCity("London")
     		.save();


// var Person = function() {
// 	this.name = "";
// 	this.age = 0;
// 	this.city = "";
// };

// Person.prototype.setName = function(name) {
// 	this.name = name;
// 	return this;
// };

// Person.prototype.setAge = function(age) {
// 	this.age = age;
// 	return this;
// };

// Person.prototype.setCity = function(city) {
// 	this.city = city;
// 	return this;
// };

// Person.prototype.save = function() {
// 	console.log("Saving Person [" + "Name : " + this.name + ", Age : " + this.age + ", City : " + this.city + "]...");
// 	return this;
// };

// new Person().setName("Colin")
//  	 		.setAge(35)
//      		.setCity("London")
//      		.save();