import { createFileRoute, useNavigate } from '@tanstack/react-router'
import { zodResolver } from "@hookform/resolvers/zod"

import {
    Form,
    FormControl,
    FormDescription,
    FormField,
    FormItem,
    FormLabel,
    FormMessage,
} from "@/components/ui/form"
import { Input } from "@/components/ui/input"
import { Button } from '@/components/ui/button';
import { useForm } from 'react-hook-form';
import { z } from "zod"
import {
    Card,
    CardAction,
    CardContent,
    CardDescription,
    CardFooter,
    CardHeader,
    CardTitle,
} from "@/components/ui/card"
import { useMutation } from '@tanstack/react-query';
import axios from 'axios';

const formSchema = z.object({
    chip: z.string(),
    color: z.string(),
    type: z.string(),
    name: z.string()
})

export const Route = createFileRoute('/pets/create')({
    component: RouteComponent,
})


const postPets = (data: z.infer<typeof formSchema>) => {
    return axios.post("http://172.22.1.219/api/v1/pets", data, {
        headers: {
            identifier: "szabo.daniel"
        }
    })
}

function RouteComponent() {

    const navigate = useNavigate();

    const form = useForm<z.infer<typeof formSchema>>({
        resolver: zodResolver(formSchema),
        defaultValues: {
            name: "",
            type: "",
            chip: "",
            color: ""
        },
    })

    const { mutate: postPet, isPending } = useMutation(
        {
            mutationFn: (data: z.infer<typeof formSchema>) => postPets(data),
            onSuccess() {
                navigate({
                    to: "/pets"
                })
            }
        })

    function onSubmit(values: z.infer<typeof formSchema>) {
        postPet(values);
    }

    return (
        <Card className='w-sm m-auto'>
            <CardHeader>
                <CardTitle>Új felhasználó</CardTitle>
                {/* <CardDescription>Card Description</CardDescription>
                    <CardAction>Card Action</CardAction> */}
            </CardHeader>
            <CardContent>
                <Form {...form}>
                    <form onSubmit={form.handleSubmit(onSubmit)} className="space-y-8">
                        <FormField
                            control={form.control}
                            name="name"
                            render={({ field }) => (
                                <FormItem>
                                    <FormLabel>Név</FormLabel>
                                    <FormControl>
                                        <Input placeholder="Add meg a kedvenc nevét" {...field} />
                                    </FormControl>
                                    <FormDescription>
                                        This is your public display name.
                                    </FormDescription>
                                    <FormMessage />
                                </FormItem>
                            )}
                        />
                        <FormField
                            control={form.control}
                            name="chip"
                            render={({ field }) => (
                                <FormItem>
                                    <FormLabel>Chip</FormLabel>
                                    <FormControl>
                                        <Input placeholder="Add meg, hogy csippeltetve vane" {...field} />
                                    </FormControl>
                                    <FormDescription>
                                        This is your public display name.
                                    </FormDescription>
                                    <FormMessage />
                                </FormItem>
                            )}
                        />
                        <FormField
                            control={form.control}
                            name="type"
                            render={({ field }) => (
                                <FormItem>
                                    <FormLabel>Típus</FormLabel>
                                    <FormControl>
                                        <Input type='Text' placeholder='Add meg a kedvenced fajtáját' {...field} />
                                    </FormControl>
                                    <FormDescription>
                                        This is your public display name.
                                    </FormDescription>
                                    <FormMessage />
                                </FormItem>
                            )}
                        />
                        <FormField
                            control={form.control}
                            name="color"
                            render={({ field }) => (
                                <FormItem>
                                    <FormLabel>Szín</FormLabel>
                                    <FormControl>
                                        <Input type='color' {...field} />
                                    </FormControl>
                                    <FormDescription>
                                        This is your public display name.
                                    </FormDescription>
                                    <FormMessage />
                                </FormItem>
                            )}
                        />
                        <Button type="submit">Submit</Button>
                    </form>
                </Form>
            </CardContent>
            {/* <CardFooter>
                    <p>Card Footer</p>
                </CardFooter> */}
        </Card>
    );
}
