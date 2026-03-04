import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import { createFileRoute } from '@tanstack/react-router'
import { useState } from 'react'
import './style.css'
import { deleteFilmek, getFilmek,  type Film } from '@/data/filmek_crud'
import Hozzaadas from '@/components/Hozzaadas'

export const Route = createFileRoute('/')({
    component: App,
})

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
            <button onClick={hozzaadHandler}>
                Hozzáadás
            </button>
            <Hozzaadas/>
            
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