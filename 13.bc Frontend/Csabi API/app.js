const express = require("express");
const cors = require("cors");


const app = express();
app.use(cors({
  origin: "http://localhost:3000"
}));
app.use(express.json());




app.use(express.urlencoded({ extended: true }));

app.disable("x-powered-by");

const filmRoutes = require("./api/routes/filmRoutes");

app.use("/filmek", filmRoutes);

const errorHandler = require("./api/middlewares/errorHandler");

app.use(errorHandler);

module.exports = app;