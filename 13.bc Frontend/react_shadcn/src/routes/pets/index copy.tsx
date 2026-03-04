import { createFileRoute, useNavigate, useRouterState } from '@tanstack/react-router'
import { Button } from "@/components/ui/button"
import { Table, TableBody, TableCaption, TableCell, TableHead, TableHeader, TableRow } from "@/components/ui/table"
import { useEffect, useState } from 'react'

export const Route = createFileRoute('/pets/index copy')({
    validateSearch: (search: any) => {
        return {
            nev: String(search.nev ?? ''),
            szido: String(search.szido ?? ''),
            fiz: Number(search.fiz ?? 0),
        };
    },
    component: RouteComponent,
})



// const tombfeltoltes = () => {
//     let t = [];
//     for (let i = 1; i <= 10; i++)
//         t.push(i);
//     return t;
// }

const random = (a: number, b: number) => {
    return Math.floor(Math.random() * (b - a + 1) + a);
}

const kodgeneralas = () => {
    return random(100, 999) + String.fromCharCode(random(97, 122)) + String.fromCharCode(random(97, 122));
}

const adatok = [
    {
        id: kodgeneralas(),
        nev: "Nagy János",
        szido: "1978.03.12",
        fiz: random(100, 500) * 1000
    },
    {
        id: kodgeneralas(),
        nev: "Kis Pista",
        szido: "1990.05.22",
        fiz: random(100, 500) * 1000
    },
    {
        id: kodgeneralas(),
        nev: "Cinc Éva",
        szido: "1991.05.11",
        fiz: random(100, 500) * 1000
    },
    {
        id: kodgeneralas(),
        nev: "Est Hajnalka",
        szido: "1980.10.12",
        fiz: random(100, 500) * 1000
    },
];

// Hozz létre 4 adatsort (objektumokat), amiben ki van generálva egy 3 jegyű szám + két véletlen betű, mint azonosító! + Név, Szülidő, Éves ösztöndíj!

function RouteComponent() {
    //const t = tombfeltoltes();
    //const t = adatok;
    const [t, setT] = useState(adatok);
    const navigate = useNavigate();
    const search = Route.useSearch();
    const ujadat = {
        id: kodgeneralas(),
        nev: search.nev,
        szido: search.szido,
        fiz: Number(search.fiz)
    }
    //console.log(search);
    //setT([ujadat,...t]); // végtelen ciklusra fut

    useEffect(() => {
        // Ha nincs érkező adat (pl. első betöltés), ne csináljon semmit
        if (!search.nev) return;

        const ujadat = {
            id: kodgeneralas(),
            nev: search.nev,
            szido: search.szido,
            fiz: search.fiz,
        };

        setT(prev => [ujadat, ...prev]);

    }, [search]);




    return (
        <div>
            {/*<Button onClick={() => {
                navigate({
                    to: "/pets/$id/edit",
                    params: {
                        id: "54"
                    }
                });
            }}>
                Következő oldal
            </Button>*/}

            <Button onClick={() => { navigate({ to: '/pets/create' }); }}>
                Létrehozás
            </Button>

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
                            <TableRow key={adat.id}>
                                <TableCell className="font-medium">{adat.id}</TableCell>
                                <TableCell>{adat.nev}</TableCell>
                                <TableCell>{adat.szido}</TableCell>
                                <TableCell className="text-right">{adat.fiz} Ft</TableCell>
                                <TableCell>
                                    <Button>Törlés</Button>
                                </TableCell>
                            </TableRow>
                        ))}
                </TableBody>
            </Table>

        </div>

    );
}
