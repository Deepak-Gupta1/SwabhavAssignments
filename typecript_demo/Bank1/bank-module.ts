export default class Bank{
    constructor(public name: string ,public location :string) {
      
    }
}

export class Customer{
constructor(public cid:number ,public firstName) {
  
}
}

export class Account{
  constructor(public balance:number){
  }

}