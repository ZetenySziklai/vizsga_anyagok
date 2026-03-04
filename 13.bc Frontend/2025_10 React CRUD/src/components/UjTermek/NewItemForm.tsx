import { useState } from "react";


const TermekForm = (props:any)=>{

    const [nev,setNev] = useState("");
    const [ar, setAr] = useState(0);
    const [datum, setDatum] = useState("");
    
    const nevChangeHandler = (event:any)=>{
        setNev(event.target.value);     
    }
    const arChangeHandler = (event:any)=>{
        setAr(event.target.value);
    }
    const datumChangeHandler = (event:any)=>{
        setDatum(event.target.value);
    }

    const submitHandler = (event:any) => {
        event.preventDefault();
        const ujAdat = {
            id: Math.floor(Math.random()*1000000+100),
            nev: nev,
            ar: ar,
            datum: datum
        }
    
        props.saveData(ujAdat);

    }

    return (
        <>
            <form onSubmit={submitHandler}>
                <div>
                    <label>Név: </label>
                    <input type="text" onChange={nevChangeHandler}/>
                </div>
                <div>
                    <label>Ár</label>
                    <input type="number" onChange={arChangeHandler}/>
                </div>
                <div>
                    <label>Dátum</label>
                    <input type="date" onChange={datumChangeHandler}/>
                </div>
                <div>
                    <button type="submit">
                        Új termék
                    </button>
                </div>
            </form>
        </>
    );
}

export default TermekForm;