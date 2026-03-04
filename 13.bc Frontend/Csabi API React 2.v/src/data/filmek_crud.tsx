import axios from "axios";
import z from 'zod';

export const filmSchema = z.object({
    Cim: z.string()
        .min(1,"A cím nem lehet üres!") //minimum 1 hosszú karakter
        .max(100, "A cím nem lehet 100 karakternél hosszabb")
        .trim(),
    Hossz: z.number()
        .int("A hossz értéke csak egész szám lehet")
        .positive("A hossz értéke csak pozitív szám lehet")
        .max(600, "600 percnél hosszabb nem lehet egy film."),
    Ertekeles: z.number()
        .min(1,"Az értéklés legalább 1!")
        .max(10, "Az rétékelés legfeljebb 10")
});

export type Film = z.infer<typeof filmSchema>;
// type Film = {
//     Cim: string,
//     Hossz: number,
//     Ertekeles: number
// }

export const getFilmek = () => {
    return axios.get<Film[]>("http://localhost:4000/filmek");
}

export const postFilmek = (data: Film) => {
    return axios.post("http://localhost:4000/filmek", data);
}

export const deleteFilmek = (cim: string) =>{
    return axios.delete(`http://localhost:4000/filmek/${cim}`);
}

export const putFilmek = (cim:string, adat:z.infer<typeof filmSchema>) =>{
    return axios.put(`http://localhost:4000/filmek/${cim}`,adat);
}
