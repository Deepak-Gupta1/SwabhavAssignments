printDetails([{ id: 101, firstName: "deepak", lastName: "Gupta" }]);
function printDetails(customer) {
    for (var _i = 0, customer_1 = customer; _i < customer_1.length; _i++) {
        var c = customer_1[_i];
        console.log(c.id + " " + c.firstName + " " + c.lastName + " " + c.location);
    }
}
