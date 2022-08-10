"use strict";
exports.__esModule = true;
var bank_module_1 = require("./bank-module");
var a = new bank_module_1.Account(1001);
var b = new bank_module_1.Bank("icici", "mumbai");
var c = new bank_module_1.Customer(1, "deepak");
console.log(a, b, c);
