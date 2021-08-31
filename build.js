const fs = require("fs");

if (!fs.existsSync("builds")) fs.mkdirSync("builds");

if (!fs.existsSync("builds/win")) fs.mkdirSync("builds/win");
if (!fs.existsSync("builds/mac")) fs.mkdirSync("builds/mac");
if (!fs.existsSync("builds/linux")) fs.mkdirSync("builds/linux");

fs.renameSync("index-win.exe", "./builds/win/RobloxUsernameCheckerWin.exe");
fs.renameSync("index-macos", "./builds/mac/RobloxUsernameCheckerMac");
fs.renameSync("index-linux", "./builds/linux/RobloxUsernameCheckerLinux");

fs.writeFileSync("./builds/win/usernames.txt", "");
fs.writeFileSync("./builds/mac/usernames.txt", "");
fs.writeFileSync("./builds/linux/usernames.txt", "");
