/*
A const cannot be re-assigned
*/
const language = "JavaScript";
language = "JS"; // Error
console.log(language);

/*
A const cannot share its name with variable or function in same scope
*/
const tool = "Sublime";
var tool = "SublimeText";


/*
Similar to let, a const is a block scoped and does not hoist
*/
(function foo() {

  { // Explicit Block
  	const company = "Microsoft";
  	console.log(company);
  }
  console.log(company); // Error

  console.log(pi); // Error
  const pi = 3.14;
  console.log(pi);

}());

/*
Can be define using object literal as well
*/

const env = {
  "language": "JavaScript",
  "tool": "SublimeText"
};
console.log(env.language);