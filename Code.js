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
    } else if (actualMonth === birthMonth){
        if (actualDay < birthDay) {
            age--;
        }
    }

    return age;
}

window.addEventListener('load',function(){
    document.getElementById("birthDate").addEventListener('change',function(){
        if (this.value){
            document.getElementById("age").value=getAge(this.value);
        }
    })    
});

document.getElementById("btn-submit").addEventListener('click',()=>{
    if (document.getElementById('fname').value == null || document.getElementById('fname').value =="") {
        alert("El campo Nombre no puede estar vacío.");
        document.getElementById('fname').focus();
        return false;
    }
    if (document.getElementById('lname').value == null || document.getElementById('lname').value =="") {
        alert("El campo Apellido no puede estar vacío.");
        document.getElementById('lname').focus();
        return false;
    }
    if (document.getElementById('age').value == null || document.getElementById('age').value =="") {
        alert("Debes introducir la Fecha de Nacimiento.");
        document.getElementById('birthDate').focus();
        return false;
    }
    return true;    
});

document.getElementById("btn-clean").addEventListener('click',()=>{
    document.getElementById("form").reset();
});
