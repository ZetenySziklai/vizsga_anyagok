import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query';
import { createFileRoute, useNavigate } from '@tanstack/react-router'
import axios from 'axios';
import type { Robotporszivo } from '.';

export const Route = createFileRoute('/ertekeles')({
    component: RouteComponent,
    validateSearch: (search: Robotporszivo) => {
        return search
    }
})

type Ertekeles = {
    id: number,
    robot_id: number,
    felhasznalonev: string,
    csillagszam: number,
    szoveg: string,
    marka: string,
    tipus: string
}

const getErtekeles = () => {
    return axios.get<Ertekeles[]>("http://localhost:3001/api/ertekelesek");
}

function RouteComponent() {

    const robotproszivo = Route.useSearch();

    const navigation = useNavigate();

    const { data: ertekelesek, isLoading: ertekelesekIsLoading } = useQuery(
        {
            queryKey: ["ertekeles"],
            queryFn: getErtekeles
        }
    );


    const navUrl = (url: string) => {
        navigation({ to: url });
    }

    if (ertekelesekIsLoading)
        return <> Adatok betöltése ....</>
    else
        return (
            <div>
                <button
                    className="back-button btn "
                    onClick={() => navUrl('/')}
                    aria-label="Vissza a főoldalra"
                >
                    ← Vissza a főoldalra
                </button>
                <div className="title">
                    <h1 >{robotproszivo.marka}</h1>
                    <h2>{robotproszivo.tipus}</h2>
                </div>
                <div className="grid">
                    {
                        ertekelesek?.data.map((item) => (
                            robotproszivo.id === item.robot_id &&
                            <div key={item.id} className="card" >
                                <div className="card-content">
                                    <p className="card-title">{item.felhasznalonev} Pascal</p>
                                    <p>{item.szoveg} Ft</p>
                                    <p>{item.csillagszam}</p>
                                    <div className="card-actions">
                                        <button className="btn edit-btn" >🗑</button>
                                    </div>
                                </div>
                            </div>
                        ))}
                </div>
            </div>
        );
}