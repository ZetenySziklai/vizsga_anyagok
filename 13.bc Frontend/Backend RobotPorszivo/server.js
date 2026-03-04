const app = require("./app");

app.listen(process.env.PORT, () => {
  console.log(`Szerver fut: http://localhost:${process.env.PORT}`);
});
