var raport_bg = document.getElementById("raport_bg");
raport_bg.style.display = 'none';
const raportButton = document.getElementById("raportButton");
raportButton.addEventListener("click", showmoney);

function showmoney(){
    raport_bg.style.display = 'inline';

}
function hidemoney(){
    
raport_bg.style.display = 'none';
}
function prevent(event){
    event.stopPropagation();
}