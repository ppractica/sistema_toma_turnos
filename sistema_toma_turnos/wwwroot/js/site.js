// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//@* VALIDACION PARA EL INPUT DE IDENTIDAD *@
function permite(elEvento, permitidos) {
    // Variables que definen los caracteres permitidos
    var numeros = "0123456789";
    /*var caracteres = " abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";*/
    var caracteres = "-";
    var numeros_caracteres = numeros + caracteres;
    var teclas_especiales = [8, 37, 39, 46];

    switch (permitidos) {
        case 'num':
            permitidos = numeros;
            break;
        case 'car':
            permitidos = caracteres;
            break;
        case 'num_car':
            permitidos = numeros_caracteres;
            break;
    }

    // Obtener la tecla pulsada
    var evento = elEvento || window.event;
    var codigoCaracter = evento.charCode || evento.keyCode;
    var caracter = String.fromCharCode(codigoCaracter);

    // Comprobar si la tecla pulsada es alguna de las teclas especiales
    // (teclas de borrado y flechas horizontales)
    var tecla_especial = false;
    for (var i in teclas_especiales) {
        if (codigoCaracter == teclas_especiales[i]) {
            tecla_especial = true;
            break;
        }
    }
    // Comprobar si la tecla pulsada se encuentra en los caracteres permitidos
    // o si es una tecla especial
    return permitidos.indexOf(caracter) != -1 || tecla_especial;
}

/*FUNCION BOTONES*/


$("#evaluate button").click(function () {


    document.getElementById('identidad').value += ($(this).val());

})

//function mayor() {
//    valor = document.getElementById('identidad').value;
//    if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
//        return false;
//    }
//}




