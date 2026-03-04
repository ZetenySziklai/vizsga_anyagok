import { filmSchema, postFilmek, putFilmek, type Film } from "@/data/filmek_crud";
import { useMutation, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";

const Hozzaadas = () => {

    const [kivalasztott, setKivalasztott] = useState<Film | null>(null);

    const [cim, setCim] = useState("");
    const [hossz, setHossz] = useState(0);
    const [ertekeles, setErtekeles] = useState(5);

    const [hibak, setHibak] = useState<{ [key: string]: string }>({});
    const [modositas, setModositas] = useState<boolean>(false);

    const queryClient = useQueryClient();

    const { mutate: filmFeltoltese } = useMutation({
        mutationFn: (data: Film) => postFilmek(data),
        onSuccess() {
            alert("Sikeresen feltöltötte az adatot!");
            queryClient.invalidateQueries({
                queryKey: ["filmek"]
            })
        }
    });

    const { mutate: filmModositas } = useMutation({
        mutationFn: ({ cim, data }: { cim: string, data: Film }) => putFilmek(cim, data),
        onSuccess() {
            alert("Sikeres adat módosítás!");
            queryClient.invalidateQueries({
                queryKey: ["filmek"]
            })
        }
    });


    const elemKeszitesEsEllenorzes = () => {
        const ujElem = {
            Cim: cim,
            Hossz: hossz,
            Ertekeles: ertekeles
        }
        const ellenorzes = filmSchema.safeParse(ujElem);
        if (!ellenorzes.success) {
            const ujHibak: { [key: string]: string } = {};
            ellenorzes.error.issues.forEach((issue) => {
                ujHibak[String(issue.path[0])] = issue.message
            });
            setHibak(ujHibak);
            return;
        }
        return ujElem;
    }

    const ujFilmHozzaadasa = () => {
        const ujElem = elemKeszitesEsEllenorzes();
        if (!ujElem) return; //Ha az új elem nem jött létre, megállítom.
        setHibak({});
        setCim("");
        setHossz(0);
        setErtekeles(5);
        filmFeltoltese(ujElem);
    }


    const meglevoFilmModositasa = () => {
        const regicim = kivalasztott?.Cim;
        const elem = elemKeszitesEsEllenorzes();
        if (!elem || !regicim) return;
        setHibak({});
        setCim("");
        setHossz(0);
        setKivalasztott(null);
        setErtekeles(5);
        setModositas(!modositas);
        filmModositas({ cim: regicim, data: elem });
    }

    return (
        <div className='hozzaadas_blokk'>
            <div>
                <div>
                    <label htmlFor="">Cím: </label>
                    <input onChange={(e) => setCim(e.target.value)} type="text" name="" id="" placeholder='Cim'
                        className={`border p-2 rounded w-full ${hibak.Cim ? 'border-red-500 bg-red-50' : 'border-gray-300'}`} value={cim} />
                    {hibak.Cim && <p className="text-red-500 text-xs mt-1">{hibak.Cim}</p>}
                </div>
                <div>
                    <label htmlFor="">Hossz: </label>
                    <input onChange={(e) => setHossz(Number(e.target.value))} type="number"
                        className={`border p-2 rounded w-full ${hibak.Hossz ? 'border-red-500 bg-red-50' : 'border-gray-300'}`} value={hossz} />
                    {hibak.Hossz && <p className="text-red-500 text-xs mt-1">{hibak.Hossz}</p>}
                </div>
                <div>
                    <label htmlFor="">Értékelés </label>
                    <input onChange={(e) => setErtekeles(parseFloat(e.target.value))} type="range" min="1" max={10} step={0.05} value={ertekeles} />
                    <label htmlFor="">({ertekeles})</label>

                </div>
                <div>
                    {
                        !modositas ?
                            <button onClick={() => ujFilmHozzaadasa()}>
                                Új film hozzáadása
                            </button> :
                            <button onClick={() => meglevoFilmModositasa()}>
                                Módosítás
                            </button>
                    }
                </div>
            </div>
        </div>
    );
}

export default Hozzaadas;