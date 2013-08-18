(function () {

    WinJS.Namespace.define('MyFactory', {
        id: function (id) {
            return document.getElementById(id);
        },

        Car: WinJS.Class.define(
            // Constructor
            function (color, make) {
                this.color = color;
                this.make = make;
            },
            // Instance Members
            {
                Accelerate: function () {
                    // function definition goes here
                },

                Turn: function () {
                    // function definition goes here
                }
            },
            // Static Members
            {
                numberOfWheels: 4
            }
        ),

        Person: WinJS.Class.define(function (firstName, lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        },
           {
               sayHello: function () {
                   console.log('Hello there good sir');
               }
           }),

        Employee: WinJS.Class.derive(Person, function (firstName, lastName, position) {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }),

        //AutomaticCar : WinJS.Class.derive(Car),

    });


    var app = WinJS.Application;
    app.onactivated = function (args) {
        var myCar = new MyFactory.Car('White', 'Honda');
        var outputDiv = MyFactory.id('OutputDiv');

        var emp = new MyFactory.Employee(1, 2, 3);
        emp.sayHello();
        outputDiv.textContent = 'Your car is ' + myCar.make;

        //new MyFactory.MyClass(outputDiv);
        WinJS.UI.processAll();
    };

    app.start();
})();
