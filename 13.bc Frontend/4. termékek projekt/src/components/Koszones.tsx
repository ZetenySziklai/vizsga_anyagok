import './Koszones.css'

function Koszones({ kername, veznev }: { kername: string, veznev:string }){
  //return <h1> Szia!</h1>;
  return (
    <div>
      <h1>
        Szia {veznev} {kername}!
      </h1>
      {/* <p>
          {kername} menj boltba!
      </p> */}
    </div>
  );
}

export default Koszones