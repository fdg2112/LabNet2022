const birthDate = document.getElementById("birthDate");
const age = document.getElementById("age");

const getAge = (birthDate) =>{
    const actualDate = new Date();
    const actualYear = parseInt(actualDate.getFullYear());
    const actualMonth = parseInt(actualDate.getMonth()+1);
    const actualDay = parseInt(actualDate.getDay());
    
    const birthYear = parseInt(String(birthDate).substring(0,4));
    const birthMonth = parseInt(String(birthDate).substring(5,7));
    const birthDay = parseInt(String(birthDate).substring(8,10));
    
    let age = actualYear - birthYear;
    if (actualMonth < birthMonth) {
        age--;
    } else if (actualMonth == birthMonth){
        if (actualDay < birthDay) {
            edad--;
        }
    }

    return age;
}

window.addEventListener('load',function(){
    birthDate.addEventListener('change',function(){
        if (this.value){
            age.innerText=`Tu edad es: ${this.value} años`
        }
    })    
});