/// <reference path="../jquery-1.10.2.js" />

//Remove button function
var remove = document.getElementsByClassName("remove");
var i;
for (i = 0; i < remove.length; i++) {
  remove[i].onclick = function () {
    var e = this.parentElement;
    $(e).fadeOut();
  }
}

//Add a checked line to cross out line
var list = document.querySelector("ul");
list.addEventListener("click", function (e) {
  if (e.target.tagName == "INPUT") {
    e.target.classList.toggle("checked");
  }
}, false);

//Add new line
function AddTask(){

  //Checkbox
  var list = document.getElementById("taskList");
  var newTaskTxt = document.getElementById("newTask").value;

  var item = document.createElement("li");
  item.className = "list-group-item"

  var input = document.createElement("input");
  input.type = "checkbox";
  input.className = "isChecked";
  input.addEventListener("click", function (e) {
    if (e.target.tagName == "INPUT") {
      e.target.classList.toggle("checked");
    }
  }, false)

  var label = document.createElement("label");
  label.textContent = newTaskTxt

  item.appendChild(input);
  item.appendChild(label);  
  
  //Remove button
  var remove = document.createElement("span")
  var removeTxt = document.createTextNode("remove");
  remove.className = "btn btn-warning remove";
  remove.appendChild(removeTxt);
  remove.onclick = function () {
    var e = this.parentElement
    $(e).fadeOut();
  }
  item.appendChild(remove);

  //Disallow blank tasks
  if( newTaskTxt == ""){
    alert("You cannot enter a blank task!");
  }else{
    list.appendChild(item);
  }

  //Reset input
  document.getElementById("newTask").value = "";  
}


