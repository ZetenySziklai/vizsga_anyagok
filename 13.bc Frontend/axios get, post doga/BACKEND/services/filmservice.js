const filmRepository = require("../repositories/filmRepository");

class FilmService
{
    constructor(dbParam)
    {
        this.filmRepository = new filmRepository(dbParam);
    }

    async getFilmek()
    {
        return await this.filmRepository.getFilmek();
    }

    async createFilm(filmData)
    {
        if(!filmData) throw new Error("hianyzo adat!");

        return await this.filmRepository.createFilm(filmData);
    }

    async updateFilm(filmCim, filmData)
    {
        if(!filmCim) throw new Error("Missing title!");

        return await this.filmRepository.updateFilm(filmCim, filmData);
    }
    async deleteFilm(filmCim) {
        if (!filmCim) throw new Error("hianyzo adat!");
        return await this.filmRepository.deleteFilm(filmCim);}
        
}

module.exports = FilmService;