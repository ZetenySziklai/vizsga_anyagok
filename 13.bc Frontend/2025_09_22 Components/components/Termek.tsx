import './Termek.css'

interface Elem {
    nev: string,
    id: string,
    datum: string,
    ar: number
}


function Termek({ item }: { item: Elem }) {
    return (
        <div className='termek'>
            <div className="termek_datum">{item.datum}</div>
            <div className="termek_nev_ar">
                <div className="termek_nev">{item.nev}</div>
                <div className="termek_ar">{item.ar + " Ft"}</div>
            </div>
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