import { getRobotp, type Robotporszivo } from '@/data/robotporszivokData'
import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import { createFileRoute, useNavigate } from '@tanstack/react-router'
import axios from 'axios'
import { useState } from 'react'


export const Route = createFileRoute('/')({
    component: App,
})

function App() {

    const [kivalasztott, setKivalaszt] = useState<Robotporszivo>();
    const [marka, setMarka] = useState("");
    const [tipus, setTipus] = useState("");
    const [teljesitmeny, setTeljesitmeny] = useState(0);
    const [ar, setAr] = useState(0);


    const navigate = useNavigate();

    const { data: robotporszivok, isLoading: robotporszivokIsLoading } = useQuery(
        {
            queryKey: ["robot"],
            queryFn: getRobotp
        }
    );

    if (robotporszivokIsLoading)
        return <> Adatok betöltése ....</>
    else
        return (
            <div className="container">
                <h1 className="title">Robotporszívók</h1>
                    <div className="form-section">
                        <div className="form-fields">
                            <label>Márka</label>
                            <input type="text" placeholder='Marka'  className="input" />
                            <label>Típus</label>
                            <input type="text" placeholder='Tipus'  className="input" />
                            <label>Teljesítmény</label>
                            <input type="number" placeholder='Teljesitmeny' className="input" />
                            <label>Ár</label>
                            <input type="number" placeholder='Ar'  className="input" />
                        </div>
                        <div className="form-actions">
                            <button className="btn" >Módosítás</button>
                        </div>
                    </div>
                <div className="grid">
                    {
                        robotporszivok?.data.map((item) => (
                            <div key={item.id} className="card">
                                <div className="card-content" onClick={() => {
                                    navigate({
                                        to: '/ertekeles',
                                        search: item
                                    })
                                }}>
                                    <h2 className="card-title">{item.marka}</h2>
                                    <p>{item.tipus}</p>
                                    <p>{item.teljesitmeny} Pascal</p>
                                    <p>{item.ar} Ft</p>
                                </div>
                                <div className="card-actions">
                                    <button className="btn edit-btn">✏️</button>
                                </div>
                            </div>
                        ))
                    }
                </div>
            </div>
        )
};