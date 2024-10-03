var result_bg = document.getElementById("result_bg");
result_bg.style.display = 'none';

function showmoney(){
  result_bg.style.display = 'inline';

}

function hidemoney(){
  result_bg.style.display = 'none';
}

function prevent(event){
  event.stopPropagation();
}

const filterInput = document.getElementById("filterInput");
filterInput.addEventListener("change", () => {
  const index = categoriesAndSums.indexOf(filterInput.options[filterInput.selectedIndex].value);
  document.getElementById("categoriesSum").innerText = `: ${categoriesAndSums[index + 1]}`;
});