class Course {
  constructor(title, instructor, image) {
    this.title = title;
    this.instructor = instructor;
    this.image = image;
  }
}

class UI {
  addCourseToList(course) {
    const list = document.getElementById("course-list");
    var html = `
      <tr>
          <td><img style="width:100px;" src="img/${course.image}"/></td>    
          <td>${course.title}</td>    
          <td>${course.instructor}</td>    
          <td><a href="#" class="btn btn-danger btn-sm">Delete</a></td>   
      </tr>
      `;
    list.innerHTML = html;
  }
  clearControls() {
    const title = (document.getElementById("title").value = "");
    const instructor = (document.getElementById("instructor").value = "");
    const image = (document.getElementById("image").value = "");
  }
  deleteCourse(element) {
    if (element.classList.contains("delete")) {
      element.parentElement.parentElement.remove();
    }
  }
  showAlert(message, className) {
    var alert = `
  <div class="alert alert-${className}">${message}</div>
  `;

    const row = document.querySelector(".row");

    row.insertAdjacentHTML("beforebegin", alert);

    setTimeout(() => {
      document.querySelector("alert").remove();
    });
  }
}
document.querySelector("#new-course").addEventListener("submit", function (e) {
  const title = document.getElementById("title").value;
  const instructor = document.getElementById("instructor").value;
  const image = document.getElementById("image").value;

  const course = new Course(title, instructor, image);

  const ui = new UI();

  if (title === "" || instructor === "" || image === "") {
    ui.ShowAlert("Please complete the form", "warning");
  } else {
    ui.addCourseToList(course);
    ui.clearControls();
    ui.ShowAlert("The course has been added", "success");
  }

  e.preventDefault();
});

document.getElementById("course-list").addEventListener("click", function (e) {
  const ui = new UI();
  ui.deleteCourse(e.target);
  ui.ShowAlert("The course has been deleted", "danger");
});
