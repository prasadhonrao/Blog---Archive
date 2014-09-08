(function() {
	var payroll = function() {
	    var audit = function(info) {
	        console.log("Auditing information " + info)
	    }

	    var makePayment = function () {
	        console.log("In MakePayment function");
	        audit("success");
	    };

	    var calculcateOverTime = function () {
	        console.log("In CalculateOverTime function");
	        audit("success");
	    };

	    return {
	        MakePayment : makePayment,
	        CalculateOverTime : calculcateOverTime
	    }
	};

	var payrollAdmin = payroll();
	payrollAdmin.MakePayment();
	payrollAdmin.CalculateOverTime();
}());


