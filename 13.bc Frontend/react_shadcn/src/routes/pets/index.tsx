import { createFileRoute, useNavigate } from '@tanstack/react-router'

import axios from 'axios'
import { QueryClient, useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import { Button } from '@/components/ui/button'

export const Route = createFileRoute('/pets/')({
    component: RouteComponent,
})

type Pet = {
    id: number,
    chip: string,
    color: string,
    type: string,
    name: string
}

const getPets = () => {
    return axios.get<Pet[]>("http://172.22.1.219/api/v1/pets",
        {
            headers: {
                identifier: "szabo.daniel"
            }
        })
}

const deletePetid = (id: number) => {
  return axios.delete(`http://172.22.1.219/api/v1/pets/${id}`, {
    headers: {
      identifier: "szabo.daniel"
    }
  })
}


// Hozz létre 4 adatsort (objektumokat), amiben ki van generálva egy 3 jegyű szám + két véletlen betű, mint azonosító! + Név, Szülidő, Éves ösztöndíj!

function RouteComponent() {
    const navigate = useNavigate();
    const queryClient = useQueryClient();
    const { data, isLoading } = useQuery({
        queryKey: ["pets"],
        //queryFn: () => {return getPets()} 
        queryFn: () => getPets() 
    });

    const {mutate: deletePet, isPending} = useMutation({
        mutationFn: (id: number) => deletePetid(id),
        onSuccess(data, variables, onMutateResult, context){
            queryClient .refetchQueries({
                queryKey: ["pets"]
            })
        }
    });

    //console.log(data);

    if (isLoading) {
        return <div>Betöltés .... </div>
    }
    return (
        <>

            <Button onClick={() => {
                navigate({
                    to: "/pets/create"
                })
            }}>Létrehozás</Button>
            {
                data?.data.map((item) => (
                    <div key={item.id}>
                        <div>Név: {item.name}</div>
                        <div>Típus: {item.type}</div>
                        <div>Szín: {item.color}</div>
                        <div>Csip: {item.chip}</div>
                        <Button onClick={()=>{
                            deletePet(item.id)
                        }}>
                            Törlés
                        </Button>
                    </div>
                ))
            }
        </>

    );
}
