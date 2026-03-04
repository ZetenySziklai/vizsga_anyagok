import {  useEffect, useState } from 'react';
import './termek.css'

const Termek = (props: any) => {
    const [termek,setTermek] = useState(props.termek);
    const [modGomb, setModGomb] = useState(termek.nev !== "");

    useEffect(()=>{
        setTermek({...termek})
    },[props.termek])

    const mentes = ()=>{
        setModGomb(true);
        props.onSave(termek);
    }

    return (
        <div className='termek'>
            <div>
                <img src="https://pngimg.com/uploads/bottle/bottle_PNG2090.png" alt="bottle" />
            </div>
            <div>
                <label>név: </label>
                <label>{termek.nev}</label>
            </div>
            <div>
                <label>ár: </label>
                {
                    modGomb ?
                    <label>{termek.ar}</label> :
                    <input value={termek.ar} type='number' onChange={(e)=>{ termek.ar = e.target.value; setTermek({...termek})}}/>
                }   
            </div>
            {
                modGomb ?
                <button onClick={()=>{setModGomb(false); }}>Módosít</button>:
                <button onClick={mentes}>Mentés</button>
            }
            <button onClick={()=>props.onDelete(termek.id)}>Töröl</button>
        </div>
    );
}

export default Termek;