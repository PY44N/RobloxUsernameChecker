const fs = require("fs");
const zip = require("zip-a-folder").zip;

if (!fs.existsSync("builds")) fs.mkdirSync("builds");

if (!fs.existsSync("builds/win")) fs.mkdirSync("builds/win");
if (!fs.existsSync("builds/mac")) fs.mkdirSync("builds/mac");
if (!fs.existsSync("builds/linux")) fs.mkdirSync("builds/linux");

fs.renameSync("index-win.exe", "./builds/win/RobloxUsernameCheckerWin.exe");
fs.renameSync("index-macos", "./builds/mac/RobloxUsernameCheckerMac");
fs.renameSync("index-linux", "./builds/linux/RobloxUsernameCheckerLinux");

for (let os of ["win", "mac", "linux"]) {
  fs.writeFileSync(`./builds/${os}/usernames.txt`, "");
  zip(`./builds/${os}/`, `./builds/${os}.zip`);
  fs.rmdirSync(`./builds/${os}/`, { recursive: true });
}
