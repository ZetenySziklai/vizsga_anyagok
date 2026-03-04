import { createFileRoute, useNavigate } from '@tanstack/react-router'

import { Button } from '@/components/ui/button'
import {
  Table,
  TableBody,
  TableCaption,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from '@/components/ui/table'
import {
  Dialog,
  DialogClose,
  DialogContent,
  DialogDescription,
  DialogFooter,
  DialogHeader,
  DialogTitle,
  DialogTrigger,
} from '@/components/ui/dialog'
import {
  Form,
  FormControl,
  FormDescription,
  FormField,
  FormItem,
  FormLabel,
  FormMessage,
} from '@/components/ui/form'
import { Input } from '@/components/ui/input'
import { zodResolver } from '@hookform/resolvers/zod'
import { useForm } from 'react-hook-form'
import { z } from 'zod'

export const Route = createFileRoute('/pets2/')({
  component: RouteComponent,
})

const random = (a: number, b: number) => {
  return Math.floor(Math.random() * (b - a + 1) + a)
}

const kodgeneralas = () => {
  return (
    random(100, 999) +
    String.fromCharCode(random(97, 122)) +
    String.fromCharCode(random(97, 122))
  )
}

const formSchema = z.object({
  id: z.string(),
  nev: z.string(),
  szido: z.string(),
  fiz: z.number(),
})

type FormValues = z.infer<typeof formSchema>

const adatok = [
  {
    id: kodgeneralas(),
    nev: 'Nagy János',
    szido: '1978.03.12',
    fiz: random(100, 500) * 1000,
  },
  {
    id: kodgeneralas(),
    nev: 'Kis Pista',
    szido: '1990.05.22',
    fiz: random(100, 500) * 1000,
  },
  {
    id: kodgeneralas(),
    nev: 'Cinc Éva',
    szido: '1991.05.11',
    fiz: random(100, 500) * 1000,
  },
  {
    id: kodgeneralas(),
    nev: 'Est Hajnalka',
    szido: '1980.10.12',
    fiz: random(100, 500) * 1000,
  },
]

// Hozz létre 4 adatsort (objektumokat), amiben ki van generálva egy 3 jegyű szám + két véletlen betű, mint azonosító! + Név, Szülidő, Éves ösztöndíj!

  
function RouteComponent() {
  const navigate = useNavigate()
  const form = useForm<FormValues>({
  resolver: zodResolver(formSchema),
  defaultValues: {
    id: '',
    nev: '',
    szido: '',
    fiz: 0,
  },
});

function onSubmit(values: z.infer<typeof formSchema>) {
    console.log(adatok)

    adatok.push({
      id: values.id,
      nev: values.nev,
      szido: values.szido,
      fiz: values.fiz,
    })
    console.log(adatok)
  };

  function deleteEmber(){
    console.log('szar');

  }
  return (
    <>
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
          {adatok.map((adat) => (
            <TableRow key={adat.id}>
              <TableCell className="font-medium">{adat.id}</TableCell>
              <TableCell>{adat.nev}</TableCell>
              <TableCell>{adat.szido}</TableCell>
              <TableCell className="text-right">{adat.fiz} Ft</TableCell>
              <TableCell>
                <Button variant={'destructive'} onClick={() => deleteEmber()}>Törlés</Button>
                <Button
                  onClick={() =>
                    navigate({ to: '/pets/$id/edit', params: { id: adat.id } })
                  }
                >
                  Módosítás
                </Button>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>

      <Dialog>
        <Form {...form}>
          <form onSubmit={form.handleSubmit(onSubmit)} className="space-y-8">
            <DialogTrigger asChild>
              <Button variant="outline">Létrehozás</Button>
            </DialogTrigger>  
            <DialogContent className="sm:max-w-[425px]">
              <DialogHeader>
                <DialogTitle>Ember létrehozása</DialogTitle>
                <DialogDescription />
              </DialogHeader>

              <FormField
                control={form.control}
                name="id"
                render={({ field }) => (
                  <FormItem>
                    <FormLabel>Azonosító</FormLabel>
                    <FormControl>
                      <Input placeholder="67" {...field} />
                    </FormControl>
                    <FormDescription>
                      Itt adod meg az azonosítót
                    </FormDescription>
                    <FormMessage />
                  </FormItem>
                )}
              />
              <FormField
                control={form.control}
                name="nev"
                render={({ field }) => (
                  <FormItem>
                    <FormLabel>Név</FormLabel>
                    <FormControl>
                      <Input placeholder="Six Seven" {...field} />
                    </FormControl>
                    <FormDescription>Itt adod meg a nevet</FormDescription>
                    <FormMessage />
                  </FormItem>
                )}
              />
              <FormField
                control={form.control}
                name="szido"
                render={({ field }) => (
                  <FormItem>
                    <FormLabel>Születési idő</FormLabel>
                    <FormControl>
                      <Input placeholder="6666 77 77" {...field} />
                    </FormControl>
                    <FormDescription>
                      Itt adod meg a születési dőt
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
                    <FormLabel>Fizetés</FormLabel>
                    <FormControl>
                      <Input placeholder="6677"{...field}/>
                    </FormControl>
                    <FormDescription>Itt adod meg a fizetést</FormDescription>
                    <FormMessage />
                  </FormItem>
                )}
              />

              <DialogFooter>
                <DialogClose asChild>
                  <Button variant="outline">Mégse</Button>
                </DialogClose>
                <Button type='submit'>Létrehozás</Button>
              </DialogFooter>
            </DialogContent>
          </form>
        </Form>
      </Dialog>
    </>
  )
}
