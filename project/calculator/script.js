var buttons = document.getElementsByClassName("button");
var display = document.getElementById("display");


var operand1 = 0;
var operand2 = null;
var operator = null;
var evaluated = false;
var a=0;
var b=0;
var Lastsign="";


//evaluate check any string value and convert into number 
function evaluate(value) {

     
    console.log("dvnvivfvmvimfivmfivmvivf");
    if (Number.isInteger(+value)) {


        display.textContent = "";

    }
    evaluated = false;
}
//thi function holds all the event 
function eventHandler(value) {
    if (
        value === "+" ||
        value === "-" ||
        value === "*" ||
        value === "/" ||
        value === "%" ||
        Number.isInteger(+value) ||
        value === "."
    ) {
        if( Lastsign=="+"|| Lastsign=="-" || Lastsign=="*" || Lastsign=="%" || Lastsign=="+"  ||Lastsign=="="  )
        {
            if( Number.isInteger(+value)) 
            {
                display.textContent += value;
                Lastsign="";
                
            }  

        }  
        
        
        
        else{
                  
            if( Number.isInteger(+value)) 
            {
                display.textContent += value;
                Lastsign="";
                
            }else
            {
                display.textContent = eval(display.textContent);
                 display.textContent += value;
                 Lastsign=value;

            }  
              
        }  
        
    }


    if (value === "=" || value === "Enter") {
        display.textContent = eval(display.textContent);
       // evaluated = true;
    }



    if (value === "^") {
        display.textContent += '**';
    }



    if (value === "Backspace") {
        display.textContent = display.textContent.slice(0, -1);
    }



    if (value === "AC") {
       
        display.textContent = "";
        Lastsign="";
        evaluate = false;
      
    }


}
//add event listener for all the buttons
for (var i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener("click", function () {
        console.log("this is my code");
        var value = this.getAttribute("data-value");
        if (evaluated) {
            evaluate(value);
        }
        eventHandler(value);
    });
}
//using addeventListener to keyboard key event
document.addEventListener("keydown", function (event) {
    var value = event.key;
    console.log(value);
    if (evaluated) {
        evaluate(value);
    }
    eventHandler(value);
});

function result()
{



}