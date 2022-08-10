let attent=4;
const randNo = Math.round(Math.random(100) * 100);
console.log("Random No "+randNo);
const input = document.querySelector('input');
const printSlideValue= document.getElementById('showslidevalue');
const attentValue= document.getElementById('attent');
const btn = document.getElementById('btn');
const ipslide = document.getElementById('ipslide');
const hint = document.getElementById('hint');
document.getElementById('gamepage').style.display='none';
input.addEventListener('click', (e) => { 
    let slideNo = printSlideValue.textContent = e.target.value; 
    document.getElementById('h'+attent).style.display='none';
    attent--;
    AttentValidation();
    Validation(slideNo);
 })
function Validation(slideNo) {
    if (slideNo == randNo) {
        hint.innerHTML="YOU WIN";
        const Clickbtn = document.getElementById(slideNo);
        Clickbtn.style.background = "blue";
        ipslide.disabled = true;
    }
    if (slideNo > randNo) {
        hint.innerHTML="Go for small number";
        const Clickbtn = document.getElementById(slideNo);
        Clickbtn.style.background = "red";
    }
    if (slideNo < randNo) {
        hint.innerHTML="Go for Big number";
        const Clickbtn = document.getElementById(slideNo);
        Clickbtn.style.background = "Yellow";
    }
}
function BtnValue(num) {
    document.getElementById('h'+attent).style.display='none';
    attent--;
    console.log(num);
    AttentValidation();
    Validation(num);
}
function GameOver(){
    document.getElementById('gamepage').innerHTML=`<img id="myImage" src='Images/gameover.gif'
    style="padding-left: 32%;">`;
    ipslide.disabled = true;
    btn.style.display='none';
}
function AttentValidation(){
    console.log(attent);
    if(attent==0){
        GameOver();
    }
}
function GamePage(){
    document.getElementById('strbtn').style.display='none';
    document.getElementById('gamepage').style.display='block';
}