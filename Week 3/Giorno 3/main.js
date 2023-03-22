const tagOp = document.getElementById("operazioni");
const tagSel = document.getElementsByTagName("option");

const metodo = (dato) => {
    tagOp.value += dato;
}

const operazione = () => {
    tagOp.value = eval(tagOp.value);
}

const cancella = () => {
    tagOp.value = "";
}

// const binario(da) {

// }

// const cambioNot = () => {
//     if (tagSel.value === "ottale") {

//     }
// }