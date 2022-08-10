var Student = /** @class */ (function () {
    function Student(firstName, lastNmae) {
        this.firstName = firstName;
        this.lastNmae = lastNmae;
    }
    Object.defineProperty(Student.prototype, "FullName", {
        get: function () {
            return "".concat(this.firstName, "- ").concat(this.lastNmae);
        },
        enumerable: false,
        configurable: true
    });
    return Student;
}());
var s1 = new Student("Deepak", "Gupta");
console.log(s1);
s1.firstName = "virat";
console.log(s1.FullName);
