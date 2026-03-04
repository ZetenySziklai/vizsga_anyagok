import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import { createFileRoute, useNavigate } from '@tanstack/react-router'
import axios from 'axios'
import React, { useState } from 'react'
import './style.css'

import z from "zod";


export const Route = createFileRoute('/')({
    component: App,
})


const filmSchema = z.object({
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

type Film = z.infer<typeof filmSchema>;
// type Film = {
//     Cim: string,
//     Hossz: number,
//     Ertekeles: number
// }

const getFilmek = () => {
    return axios.get<Film[]>("http://localhost:4000/filmek");
}

const postFilmek = (data: Film) => {
    return axios.post("http://localhost:4000/filmek", data);
}

const deleteFilmek = (cim: string) =>{
    return axios.delete(`http://localhost:4000/filmek/${cim}`);
}

const putFilmek = (cim:string, adat:z.infer<typeof filmSchema>) =>{
    return axios.put(`http://localhost:4000/filmek/${cim}`,adat);
}

function App() {

    const [kivalasztott, setKivalasztott] = useState<Film | null>(null);

    const [cim, setCim] = useState("");
    const [hossz, setHossz] = useState(0);
    const [ertekeles, setErtekeles] = useState(5);

    const [hibak, setHibak] = useState<{[key: string]:string}>({});
    const [modositas, setModositas] = useState<boolean>(false);


    const { data, isLoading } = useQuery(
        {
            queryKey: ["filmek"],
            queryFn: getFilmek
        }
    );

    const queryClient = useQueryClient();
     const {mutate: filmTorlese} = useMutation({
        mutationFn: (cim:string)=> deleteFilmek(cim),
        onSuccess(){
            alert("Sikeres adat törlés!");
            queryClient.invalidateQueries({
                queryKey:["filmek"]
            })
        }
    });

     const {mutate: filmFeltoltese} = useMutation({
        mutationFn: (data:Film)=> postFilmek(data),
        onSuccess(){
            alert("Sikeresen feltöltötte az adatot!");
            queryClient.invalidateQueries({
                queryKey:["filmek"]
            })
        }
    });

    const {mutate: filmModositas} = useMutation({
        mutationFn: ({cim, data} : {cim: string, data:Film})=> putFilmek(cim, data),
        onSuccess(){
            alert("Sikeres adat módosítás!");
            queryClient.invalidateQueries({
                queryKey:["filmek"]
            })
        }
    });

    //const filmCimKivalasztHandler = (event:React.ChangeEvent<HTMLSelectElement>)=>{ 
    const filmCimKivalasztHandler = (event: any) => {
        const cim = event.target.value;
        //console.log(cim);
        const film = data?.data.find(c => c.Cim == cim);
        setKivalasztott(film || null);
    }

    const hozzaadHandler = ()=>{
        console.log("Kattintás");       
    }

    const elemKeszitesEsEllenorzes = ()=>{
        const ujElem = {
            Cim: cim,
            Hossz: hossz,
            Ertekeles: ertekeles
        }
        const ellenorzes = filmSchema.safeParse(ujElem);
        if(!ellenorzes.success){
            const ujHibak :{ [key:string]:string} = {};
            ellenorzes.error.issues.forEach((issue)=>{
                ujHibak[String(issue.path[0])] = issue.message
            });
            setHibak(ujHibak);
            return;
        }
        return ujElem;
    }

    const ujFilmHozzaadasa =()=>{
        const ujElem = elemKeszitesEsEllenorzes();
        if(!ujElem) return; //Ha az új elem nem jött létre, megállítom.
        setHibak({});
        setCim("");
        setHossz(0);
        setErtekeles(5);
        filmFeltoltese(ujElem);
    }


    const meglevoFilmModositasa = ()=>{
        const regicim = kivalasztott?.Cim;
        const elem = elemKeszitesEsEllenorzes();       
        if(!elem || !regicim) return;
        setHibak({});
        setCim("");
        setHossz(0);
        setKivalasztott(null);
        setErtekeles(5);
        setModositas(!modositas);
        filmModositas({cim: regicim, data: elem});
    }

    const torlesHandler = ()=>{
        const cim = kivalasztott?.Cim;
        filmTorlese(cim || "");
        setKivalasztott(null);
        setCim("");
        setHossz(0);
        setErtekeles(5);
    }

    const modositHandler = () =>{
        const film = kivalasztott;
        setCim(String(film?.Cim));
        setHossz(Number(film?.Hossz));
        setErtekeles(Number(film?.Ertekeles))
        setModositas(!modositas);
    }

    //console.log(data);
    if (isLoading) {
        return <div>Adatok betöltése</div>
    }
    return (
        <>
            {/* {
                data?.data.map((ertek)=>(
                    <div key={ertek.Cim}>
                        { <div>Cím: {ertek.Cim}</div>
                        <div>Hossz: {ertek.Hossz}</div>
                        <div>Ertekeles: {ertek.Ertekeles}</div> }                        
                ))
                </div>
            } */}
            <button onClick={hozzaadHandler}>
                Hozzáadás
            </button>
            <div className='hozzaadas_blokk'>
                <div>
                    <div>
                        <label htmlFor="">Cím: </label>
                        <input onChange={(e)=>setCim(e.target.value)} type="text" name="" id="" placeholder='Cim'
                            className={`border p-2 rounded w-full ${hibak.Cim ? 'border-red-500 bg-red-50' : 'border-gray-300'}`} value={cim}/>
                        {hibak.Cim && <p className="text-red-500 text-xs mt-1">{hibak.Cim}</p>}
                    </div>
                    <div>
                        <label htmlFor="">Hossz: </label>
                        <input onChange={(e)=>setHossz(Number(e.target.value))} type="number" 
                            className={`border p-2 rounded w-full ${hibak.Hossz ? 'border-red-500 bg-red-50' : 'border-gray-300'}`} value={hossz}/>
                        {hibak.Hossz && <p className="text-red-500 text-xs mt-1">{hibak.Hossz}</p>}
                    </div>
                    <div>
                        <label htmlFor="">Értékelés </label>
                        <input onChange={(e)=>setErtekeles(parseFloat(e.target.value))} type="range" min="1" max={10} step={0.05} value={ertekeles} />
                        <label htmlFor="">({ertekeles})</label>

                    </div>
                    <div>
                        {
                        !modositas ?
                            <button onClick={()=> ujFilmHozzaadasa()}>
                                Új film hozzáadása
                            </button> :
                            <button onClick={()=> meglevoFilmModositasa()}>
                                Módosítás
                            </button>
                        } 
                    </div>
                </div>
            </div>

            <select onChange={filmCimKivalasztHandler}>
                <option value=""> -- Válassz! -- </option>
                {
                    data?.data.map((ertek) => (
                        <option key={ertek.Cim} value={ertek.Cim}>
                            {ertek.Cim} ({ertek.Ertekeles})
                        </option>
                    ))
                }
            </select>
            {
                !kivalasztott ?
                    <div>Válasszon a filmek közül</div> :
                    <div>
                        <p>{kivalasztott.Hossz} perc</p>
                        <div>
                            <button onClick={torlesHandler}>Törlés</button>
                            <button onClick={modositHandler}>Módosítás</button>
                        </div>
                    </div>
            }
        </>
    )
};