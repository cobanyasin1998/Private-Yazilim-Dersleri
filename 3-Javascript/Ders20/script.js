const textInputDOM = document.getElementById("todos");
const addTodo = document.getElementById("addTodo");
const todoListDOM = document.getElementById("todoList");

const temizleBtn = document.getElementById("temizleBtn");

let textInputValue = "";
let todos = [];
textInputDOM.addEventListener("change", function (event) {
    textInputValue = event.target.value;
});

addTodo.addEventListener("click", function (event) {
    event.preventDefault();

    if (textInputValue === "") {
        alert("Lütfen bir todo giriniz");
        return;
    }

    todos.unshift({
        id: todos.length + 1,
        text: textInputValue
    });
    textInputDOM.value = "";
    textInputValue = "";
    displayTodos();

});

function displayTodos() {

    let result = "";

    todos.forEach(function (todo) {
        result += `       
        <li class="flex justify-between border px-4 py-3 flex items-center">
          <span>${todo.text}</span>
          <button onclick="deleteTodo(${todo.id})"  class="text-white-400">Sil</button>
        </li>`;

    });
    todoListDOM.innerHTML = result;
}

temizleBtn.addEventListener("click", function (event) {
    event.preventDefault();
    todos = [];
    displayTodos();
});

deleteTodo = function (id) {
    let deletedId;

    for (let i = 0; i < todos.length; i++) {
        if (todos[i].id === id) {
            deletedId = i;
            break;
        }
    }

    todos.splice(deletedId, 1);
    displayTodos();

}

displayTodos();