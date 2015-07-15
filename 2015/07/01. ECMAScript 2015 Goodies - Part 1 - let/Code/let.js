(function declarationTest(){
	let a = 10;
	let b = 20;
	if (a < b) {
	   let c = 30;
	   var d = 40;
	}
	//console.log(c); //error
	console.log(d);
}());

(function blockTest() {
	let numbers = [1, 2, 3, 4, 5];
	for (let i = 0; i < numbers.length; i++) {
		console.log(numbers[i]);
	};
	// console.log(i) //error
}());

(function nestingTest(){
	let x = 30;
	if(true){
	   let x = 40;  // different variable
	   console.log(x); //40
	}
	console.log(x); //30
}());

(function duplicateTest() {
	let x = 10;
	// let x = 20; //error
	console.log(x); 
}());

(function hoistTest() {
	//console.log(foo); // ReferenceError
	let foo = 2;
}());
