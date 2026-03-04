require("dotenv").config({ quiet: true });

const app = require("./app");

const PORT = process.env.PORT 

const db = require("./api/db");

app.listen(PORT, () => 
{
    console.log(`http://localhost:${PORT}`);
});