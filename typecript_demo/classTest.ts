class Student{
    constructor(public firstName, public lastNmae){
    }
    get FullName(){
        return `${this.firstName}- ${this.lastNmae}` 
    }
}
let s1 =new Student("Deepak","Gupta")
console.log(s1)
s1.firstName="virat"
console.log(s1.FullName)