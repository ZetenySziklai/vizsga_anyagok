const FilmService = require("./filmService")

module.exports = (dbParam) =>
{
    const filmService = new FilmService(dbParam);

    return { filmService };
}