require("dotenv").config();
const express = require("express");
const cors = require("cors");


const app = express();
app.use(cors({
  origin: "http://localhost:3000"
}));

app.use(express.json());

app.use("/api/robotporszivo", require("./routes/robotporszivo.routes"));

module.exports = app;
