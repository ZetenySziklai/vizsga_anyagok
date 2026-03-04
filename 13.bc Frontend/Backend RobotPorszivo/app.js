require("dotenv").config();
const express = require("express");
const cors = require("cors");

const robotRoutes = require("./routes/robotRoutes");
const ertekelesRoutes = require("./routes/ertekelesRoutes");

const app = express();

app.use(cors({
  origin: "http://localhost:3000"
}));

app.use(express.json());

app.use("/api/robotporszivo", robotRoutes);
app.use("/api/ertekelesek", ertekelesRoutes);

module.exports = app;
