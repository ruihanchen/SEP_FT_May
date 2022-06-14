let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

var Sum = salaries.John + salaries.Ann + salaries.Pete;
console.log(Sum);





let menu = { width: 200, height: 300, title: "My menu"};

function multiplyNumeric(obj) {
    for(i=0; i<obj.length; i++){
        if(typeof obj[i] == 'string'){
            return obj[i];
        }else{
            return obj[i]* 2;
        }      
    }
}

console.log(multiplyNumeric(menu));





var str = "asdgsdg@gsidni.com";

function checkEmailId(str){
    var mailFormat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (str.value.match(mailFormat)) {
      alert("Valid email address!");
      document.myForm.Email.focus();
      return true;
    }
    else {
      alert("You have entered an invalid email address!");
      document.myForm.Email.focus();
      return false;
    }
}





function truncate(str, maxlength) {
    return str.substring(0,maxlength-1);

}





let names = {James, Brennie}

names.push("Robert");

names[1]=Calvin;

names.shift();

names.splice(0,0,Rose, Regal);
