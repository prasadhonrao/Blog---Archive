(function () {

    var Person = WinJS.Class.define(function (firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    },
    {
        sayHello: function () {
            console.log('Hello there good sir');
        }
    });

    var Employee = WinJS.Class.derive(Person, function (firstName, lastName, position) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.position = position;
    });

})();
