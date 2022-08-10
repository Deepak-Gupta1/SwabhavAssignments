class Account{
    constructor(private _accno ,private _name ,private _balance) {
  
    }
    deposite(amount){
        this._balance+=amount;
    }
    get Balance(){
        return this._balance
    }
    get Accno(){
        return this._accno
    }
    get Name(){
        return this._name 
    }
}

let acc1 =new Account(101,"deepak",1000)
console.log(acc1)
console.log(acc1.Accno)
acc1.deposite(1000);
console.log(acc1.Balance)

