interface ICustomer{
    id:number
    firstName:string
    lastName:string
    location ? :string
}

printDetails([{id:101,firstName:"deepak",lastName:"Gupta"},{id:201,firstName:"virat",lastName:"kohli",location:"Delhi"}])

function printDetails(customer:Array<ICustomer>){
    for(let c of customer){
        console.log(c.id+" "+c.firstName +" "+c.lastName+" "+c.location)
    }
}