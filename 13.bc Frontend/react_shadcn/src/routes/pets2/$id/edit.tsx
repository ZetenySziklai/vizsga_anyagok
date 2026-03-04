import { createFileRoute, useNavigate, useParams } from '@tanstack/react-router'
import { Button } from "@/components/ui/button"


export const Route = createFileRoute('/pets2/$id/edit')({
  component: RouteComponent,
})

function RouteComponent() {

  const navigate = useNavigate();
  const params = useParams({ from: "/pets/$id/edit" });
  const { id } = params;

  return (
    <>
      <p>{id}</p>
      <Button onClick={() => {
        navigate({
          to: "/pets"
        })
      }}>
        Főoldal
      </Button>
    </>
  );
}
