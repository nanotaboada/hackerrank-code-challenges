var button = document.getElementById("btn");
var label = 0;

button.addEventListener("click", function() {
    label++;  
    button.innerHTML = label;
});
