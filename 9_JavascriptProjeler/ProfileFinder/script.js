class UI {
  constructor() {
    this.profile = document.querySelector("#profileContainer");
    this.alert = document.querySelector("#alertMsg");
  }
  showAlert(text) {
    this.alert.innerHTML = `${text} is not found`;
    this.alert.classList.remove("d-none");
  }
  clear() {
    this.profile.innerHTML = "";
    this.alert.innerHTML = "";
    this.alert.classList.add("d-none");
  }
  showProfile(profile) {
    this.profile.innerHTML = `
        <div class="card card-body">
            <div class="row">
                <div class="col-md-3>
                    <a href="https://placeholder.com"><img class="img-thumbnail" src="https://placehold.jp/3d4070/ffffff/150x150.png"></a>
                </div>
                <div class="col-md-9">
                    <h4>Contact</h4>

                    <ul class="list-group">
                        <li class="list-group-item">${profile.name}</li>
                        <li class="list-group-item">${profile.username}</li>
                        <li class="list-group-item">${profile.email}</li>
                        <li class="list-group-item">${profile.phone}</li>
                        <li class="list-group-item">${profile.website}</li>

                    </ul>
                </div
            </div>
        </div>
        
        
        `;
  }
}
class Profile {
  async getProfile(username) {
    const profileResponse = await fetch(
      `https://jsonplaceholder.typicode.com/users?username=${username}`
    );

    const profile = await profileResponse.json();

    return {
      profile,
    };
  }
}

const searchProfile = document.querySelector("#searchForm");
const profile = new Profile();
const ui = new UI();
searchProfile.addEventListener("keyup", (event) => {
  ui.clear();
  let text = event.target.value;
  if (text !== "") {
    profile.getProfile(text).then((res) => {
      if (res.profile.length === 0) {
        ui.showAlert(text);
      } else {
        ui.showProfile(res.profile[0]);
      }
    });
  }
});
