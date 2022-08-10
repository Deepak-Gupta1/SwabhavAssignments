// import {Account,Bank,Customer} from './bank-module'
import Bank,{Account,Customer} from './bank-module'  //when defualt use in export class

let a=new Account(1001)
let b=new Bank("icici","mumbai")
let c=new Customer(1,"deepak")

console.log(a,b,c)