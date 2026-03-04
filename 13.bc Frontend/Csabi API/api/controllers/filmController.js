const db = require("../db");


const { filmService } = require("../services")(db);

exports.getFilmek = async (req, res, next) =>
{   
    res.status(200).json(await filmService.getFilmek());
}

exports.createFilm = async (req, res, next) =>
{
    const { Cim, Hossz, Ertekeles } = req.body;

    res.status(201).json(await filmService.createFilm({ Cim, Hossz, Ertekeles }));
}

exports.updateFilm = async (req, res, next) =>
{
    const filmCim  = req.filmCim;

    const { Hossz, Ertekeles } = req.body;

    res.status(200).json(await filmService.updateFilm(filmCim, {Hossz,Ertekeles}));
}
exports.deleteFilm = async (req, res, next) => {
    const filmCim = req.filmCim;
    res.status(200).json(await filmService.deleteFilm(filmCim));
  };