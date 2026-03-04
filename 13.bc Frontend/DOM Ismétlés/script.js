// function boxGeneration(){
//     let db = parseInt(document.getElementById("dbInput").value);
//     const boxes = document.getElementById("boxes");
//     boxes.innerHTML = "";
//     for(let i = 0; i<db; i++){
//         const box = document.createElement("div");
//         box.innerHTML = i+1;
//         boxes.appendChild(box);
//     }
// }


let a = 0;
function boxGeneration(){
    const boxes = document.getElementById("boxes");
    let akt = parseInt(document.getElementById("dbInput").value);
    if(akt > a){
        const ujbox = document.createElement("div");
        ujbox.innerHTML = akt;
        boxes.appendChild(ujbox);
        a++;
    }
    else{
        boxes.removeChild(boxes.lastChild);
        a--;
    }
}