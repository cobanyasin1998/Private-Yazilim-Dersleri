const result = document.getElementById("list");
const filter = document.getElementById("filterText");
const listItems = [];

getData();

filter.addEventListener("input", (e) => {
  filterData(e.target.value);
});

function getData() {
  fetch("https://randomuser.me/api/?results=50")
    .then((res) => res.json())
    .then((data) => {
      // clear
      result.innerHTML = "";

      data.results.forEach((user) => {
        const li = document.createElement("li");

        // store for filter
        listItems.push(li);

        li.innerHTML = `
				<img  class="imgPhoto"  width="75px" src="${user.picture.large}" alt="${user.name.first}">
				<div class="user-info">
					<h4>${user.name.first} ${user.name.last}</h4>
					<p>${user.location.city}, ${user.location.country}</p>
				</div>
			`;

        result.appendChild(li);
      });
    });
}

function filterData(searchTerm) {
  listItems.forEach((item) => {
    if (item.innerText.toLowerCase().includes(searchTerm.toLowerCase())) {
      item.classList.remove("hide");
    } else {
      item.classList.add("hide");
    }
  });
}
