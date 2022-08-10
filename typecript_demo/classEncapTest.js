var Account = /** @class */ (function () {
    function Account(_accno, _name, _balance) {
        this._accno = _accno;
        this._name = _name;
        this._balance = _balance;
    }
    Account.prototype.deposite = function (amount) {
        this._balance += amount;
    };
    Object.defineProperty(Account.prototype, "Balance", {
        get: function () {
            return this._balance;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Account.prototype, "Accno", {
        get: function () {
            return this._accno;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Account.prototype, "Name", {
        get: function () {
            return this._name;
        },
        enumerable: false,
        configurable: true
    });
    return Account;
}());
var acc1 = new Account(101, "deepak", 1000);
console.log(acc1);
console.log(acc1.Accno);
acc1.deposite(1000);
console.log(acc1.Balance);
