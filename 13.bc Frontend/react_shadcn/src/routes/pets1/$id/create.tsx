import { createFileRoute, useNavigate } from '@tanstack/react-router'
import { Button } from "@/components/ui/button"
import {Form,FormControl,FormDescription,FormField,FormItem,FormLabel,FormMessage,} from "@/components/ui/form"
import { Input } from "@/components/ui/input"
import { useForm } from 'react-hook-form'
import { z } from "zod"
import axios from 'axios';
import { useMutation } from '@tanstack/react-query'
import { zodResolver } from "@hookform/resolvers/zod"


export const Route = createFileRoute('/pets1/$id/create')({
  component: RouteComponent,
})
const formSchema = z.object({
    nev: z.string().nonempty(),
    szido: z.string().nonempty(),
    fiz: z.string().nonempty(),
})

const postPets =(data:z.infer<typeof formSchema>) => {
    return axios.post("http://172.22.1.219/api/v1/pets",data,{
        headers: {
            identifier: "B4lin1"
        }
    })
}

function RouteComponent() {
  const form = useForm<z.infer<typeof formSchema>>({
        resolver: zodResolver(formSchema),
        defaultValues: {
            nev: "",
            szido: "",
            fiz: "",
        },
    })
    
  const navigate = useNavigate();
  const {mutate:postPet} = useMutation({
        mutationFn: (data:z.infer<typeof formSchema>) => postPets(data),
        onSuccess() {
          navigate({
            to: "/pets",
          })
        }
    })
    // 2. Define a submit handler.
    function onSubmit(values: z.infer<typeof formSchema>) {
        postPet(values)
    }
    
    return (
      <>
        <Form {...form}>
      <form onSubmit={form.handleSubmit(onSubmit)} className="space-y-8">
        <FormField
          control={form.control}
          name="nev"
          render={({ field }) => (
            <FormItem>
              <FormLabel>név</FormLabel>
              <FormControl>
                <Input placeholder="Add meg a nevet" {...field} />
              </FormControl>
              <FormDescription>
                Ügyfél neve
              </FormDescription>
              <FormMessage />
            </FormItem>
          )}
        />
        <FormField
          control={form.control}
          name="szido"
          render={({ field }) => (
            <FormItem>
              <FormLabel>dátum</FormLabel>
              <FormControl>
                <Input placeholder="Add meg a születési dátumot" {...field} />
              </FormControl>
              <FormDescription>
                Születési dátum
              </FormDescription>
              <FormMessage />
            </FormItem>
          )}
        />
        <FormField
          control={form.control}
          name="fiz"
          render={({ field }) => (
            <FormItem>
              <FormLabel>fizetés</FormLabel>
              <FormControl>
                <Input placeholder="Add meg a fizetést"{...field}/>
              </FormControl>
              <FormDescription>
                fizetés
              </FormDescription>
              <FormMessage />
            </FormItem>
          )}
        />
        <Button type="submit" onClick={() => {
          navigate({
            to: "/pets"
          })
          }}>
        Beküldés
        </Button>
      </form>
    </Form>
    </>
  );
}

      {/* <Button onClick={() => {
        navigate({
          to: "/pets"
        })
      }}>
        vissza a Főoldalra
      </Button> */}
