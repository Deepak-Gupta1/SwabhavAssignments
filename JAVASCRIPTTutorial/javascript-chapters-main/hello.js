function youSayGoodBye(){
    alert("goodbye")
    function iSayHello(){
        alert("hello")
    }
    return iSayHello;
}
var something = youSayGoodBye();
something();