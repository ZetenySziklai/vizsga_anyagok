import './Termek.css'

type Elem = {
    nev: string,
    id: string,
    datum: string,
    ar: number
}



// function Termek({props, item }: {props:any, item: Elem}) {
function Termek(props:any) {
    return (
        <div className='termek'>
            <div className="termek_datum">{props.item.datum}</div>
            <div className="termek_nev_ar">
                <div className="termek_nev">{props.item.nev}</div>
                <div className="termek_ar">{props.item.ar + " Ft"}</div>
            </div>
            <button onClick={()=>{props.onDelete(props.item.id)}}>
                Törlés
            </button>
            <button onClick={()=>{props.onUpdate(props.item.id)}}>
                Módosítás
            </button>
        </div>
    );
}


// function Termek(props){
//     let elem = props.item;
//     return (
//         <>
//             <div>{elem.nev}</div>
//             <div>{elem.ar +" Ft"}</div>
//         </>
//     );
// }

export default Termek;