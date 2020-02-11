const list = document.querySelector('#list')
const form = document.querySelector('#form')
const input = document.querySelector('#input')
const submit = document.querySelector('#submit')
const alert = document.querySelector('#alert')
const clearBtn = document.querySelector('#clearBtn')

loadEventListeners();

function loadEventListeners() {
    form.addEventListener('submit', addTodo)
    /*Event Delegation*/
    list.addEventListener('click', deleteItem)
    clearBtn.addEventListener('click', clearTodos)
}

function hideClear() {
    clearBtn.style.display = 'none'
}

function clearTodos(e) {
  const items = document.querySelectorAll('.list-item')
  /* we do querySelectorAll instead of list.Children becuase it gives us access to array methods like. 
    forEach, map, etc... querySelectorAll gives us a node list... 
    list.Children gives us an HTML collection (cannot be used with array methods)*/
  items.forEach(item => {
      item.remove();
  })
  hideClear()
}

/* If what I click on is a list item, delete/remove the list item I just clicked on*/
function deleteItem(e) {
    if (e.target.className === 'list-item') {
        e.target.remove();
    if (list.children.length === 1) {
        hideClear();
    }
  }
}

function showClear() {
    clearBtn.style.display = "inline-block";
}

function addTodo(e) {
const text = input.value

if (text === "") {
    showAlert();
} else {
    
    const li = document.createElement('li')
    li.className = 'list-item'
    li.textContent = text
    
    
    list.appendChild(li)
    input.value = "";
    if (list.children.length > 1) {
        showClear()
    }
}

e.preventDefault()
}

function showAlert() {
  alert.style.display = "block"
  
  setTimeout (() => {
    alert.style.display = "none"

}, 2000)

}
