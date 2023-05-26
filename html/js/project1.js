function passwordcontrol(){
    const loginForm = document.getElementById("login-form");    
    const gebruikersnaam = loginForm.gebruikersnaam.value;
    const wachtwoord = loginForm.wachtwoord.value;
    

    if (gebruikersnaam == "admin" && wachtwoord == "admin") {
        alert("U bent succesvol ingelogd");
        
        
    } else {
        alert("Ongeldig gebruikersnaam of wachtwoord");
    } 
}


function berekenPrijsPizza(){

    var totaal = 0;
    for(var counter = 1; counter <= 8; counter++){

        var prijs1 = parseFloat(document.getElementById("prijs1_" + counter).value);
        var nodig1 = parseFloat(document.getElementById("nodig1_" + counter).value);
        var ingredient1 = document.getElementById("ingredient1_" + counter).value;

    
        
        if(!isNaN(prijs1) && !isNaN(nodig1) && ingredient1!=""){

            var result25 = prijs1 / 1000 * nodig1;
            var result35 = prijs1 / 1000 * nodig1 * 1.96;
            totaal+= result25;

            document.getElementById("m25_"+ counter).value = result25.toFixed(2);
            document.getElementById("m35_"+ counter).value = result35.toFixed(2);
            document.getElementById("prijs25").value = totaal.toFixed(2);
            var ttotaal = totaal * 1.96;
            document.getElementById("prijs35").value = ttotaal.toFixed(2);
        }
        if(!isNaN(prijs1) && !isNaN(nodig1) && ingredient1==""){
            alert("Vul iets in bij ingredient")
            break;
        }
    }

}

function berekenPrijsPasta(){

    var totaal = 0;
    for(var counter = 1; counter <= 8; counter++){

        var ppk1 = parseFloat(document.getElementById("ppk1_" + counter).value);
        var nodig1 = parseFloat(document.getElementById("nodig1_" + counter).value);
        var ingredient1 = document.getElementById("ingredient1_" + counter).value;

    
        
        if(!isNaN(ppk1) && !isNaN(nodig1) && ingredient1!=""){

            var result = ppk1 / 1000 * nodig1;
            
            totaal+= result;

            document.getElementById("p25_"+ counter).value = result.toFixed(2);
            document.getElementById("kp25").value = totaal.toFixed(2);
           
        }
        if(!isNaN(ppk1) && !isNaN(nodig1) && ingredient1==""){
            alert("Vul iets in bij ingredient")
            break;
        }
    }

}
