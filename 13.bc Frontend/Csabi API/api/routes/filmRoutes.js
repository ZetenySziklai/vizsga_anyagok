const express = require("express");

const router = express.Router();

const filmController = require("../controllers/filmController");

router.get("/", filmController.getFilmek);

router.post("/", filmController.createFilm);

router.param("filmCim", (req, res, next, filmCim) => 
{
    req.filmCim = filmCim;

    next();
});

router.patch("/:filmCim", filmController.updateFilm);
router.delete("/:filmCim", filmController.deleteFilm);

module.exports = router;