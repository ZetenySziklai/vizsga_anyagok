class FilmRepository
{
    // DI = Dependency Injection

    constructor(dbParam)
    {
        this.film = dbParam.film;
    }
    
    async getFilmek()
    {
        return await this.film.findAll();
    }

    async createFilm(filmData)
    {
        return await this.film.create(filmData);
    }

    async updateFilm(filmCim, filmData)
    {
        

        return await this.film.update(
            filmData,                 
            {
              where: { Cim: filmCim } 
            }
          );
    }
    async deleteFilm(filmCim) {
        return await this.film.destroy({
          where: { Cim: filmCim }
        });
    }
    

}

module.exports = FilmRepository;