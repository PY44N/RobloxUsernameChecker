const fs = require("fs");
const axios = require("axios");

let names = fs
  .readFileSync("usernames.txt", "utf8")
  .split("\n")
  .map((name) => name.replace("\r", "")); //Removes the windows line break char

fs.writeFileSync("available.txt", "");

let count = 0;
let total = names.length;
for (let name of names) {
  axios
    .get(`https://api.roblox.com/users/get-by-username?username=${name}`)
    .then((res) => {
      if (res.data.success == false) {
        console.log(`${name} is available`);
        fs.appendFileSync("available.txt", name + "\n");
      } else {
        console.log(`${name} is not available`);
      }
      count++;
    })
    .catch((err) => {
      console.log("Failed to check username: " + name);
      count++;
    });
}

let loop = setInterval(() => {
  if (count == total) {
    console.log("Completed, closing in 3 secconds...");
    setTimeout(() => {}, 3000); // Waits 3 secconds (3000 ms) to keep the window open
    clearInterval(loop);
  }
}, 100);
