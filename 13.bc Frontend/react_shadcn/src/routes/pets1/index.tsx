import { createFileRoute, useNavigate } from '@tanstack/react-router'
import { Button } from "@/components/ui/button"
import { Table, TableBody, TableCaption, TableCell, TableHead, TableHeader, TableRow } from "@/components/ui/table"
import { useState } from 'react'

export const Route = createFileRoute('/pets1/')({
    component: RouteComponent,
})

// const tombfeltoltes = () => {
//     let t = [];
//     for (let i = 1; i <= 10; i++)
//         t.push(i);
//     return t;
// }

const random = (a:number,b:number)=>{
    return Math.floor(Math.random()*(b-a+1)+a);
}

const kodgeneralas =()=>{
    return random(100,999) + String.fromCharCode(random(97,122)) + String.fromCharCode(random(97,122));
}

const adatok = [
    {
        id: kodgeneralas(),
        nev: "Nagy János",
        szido: "1978.03.12",
        fiz: random(100,500)*1000
    },    
    {
        id: kodgeneralas(),
        nev: "Kis Pista",
        szido: "1990.05.22",
        fiz: random(100,500)*1000
    },
    {
        id: kodgeneralas(),
        nev: "Cinc Éva",
        szido: "1991.05.11",
        fiz: random(100,500)*1000
    },
    {
        id: kodgeneralas(),
        nev: "Est Hajnalka",
        szido: "1980.10.12",
        fiz: random(100,500)*1000
    },
];

function RouteComponent() {
    const [t, setT] = useState(adatok);
    const torles = (id: string) => 
    {
        setT((adat) => 
        adat.filter((sor) => sor.id !== id));
    };
    const navigate = useNavigate();
    return (
        <div>
            {/* <Button onClick={() => {
                navigate({
                    to: "/pets/$id/edit",
                    params: {
                        id: "54"
                    }
                });
            }}>
                Következő oldal
            </Button> */}

            <Table>
                <TableCaption>A list of your recent invoices.</TableCaption>
                <TableHeader>
                    <TableRow>
                        <TableHead className="w-[100px]">Azonosító</TableHead>
                        <TableHead>Név</TableHead>
                        <TableHead>Születési idő</TableHead>
                        <TableHead className="text-right">Cafeteria</TableHead>
                         <TableHead>Funkciók</TableHead>
                    </TableRow>
                </TableHeader>
                <TableBody>
                    {
                        t.map((adat) => (
                            <TableRow>
                                <TableCell className="font-medium">{adat.id}</TableCell>
                                <TableCell>{adat.nev}</TableCell>
                                <TableCell>{adat.szido}</TableCell>
                                <TableCell className="text-right">{adat.fiz} Ft</TableCell>
                                <TableCell>
                                    <Button onClick={() => torles(adat.id)}>Törlés</Button>
                                    <Button onClick={() => navigate({
                                        to: "/pets/$id/edit",
                                        params: { id: adat.id }
                                    })}
                                    >Szerkesztes</Button>
                                </TableCell>
                            </TableRow>
                        ))}
                            <Button onClick={() => navigate({
                                        to: "/pets/$id/create",
                                        params: { id: kodgeneralas() }
                                    })}>
                                Uj elem
                            </Button>
                </TableBody>
            </Table>

        </div>

    );
}
