import { useEffect, useState } from 'react';
import './App.css'
import Termek from './components/termek';
import UjTermek from './components/ujTermek';

const termekek_alap = [
  {
    nev: "Víz",
    id: "123",
    datum: "2025-09-29",
    ar: 325
  },
  {
    nev: "Szóda",
    id: "987",
    datum: "2025-09-28",
    ar: 189
  },
  {
    nev: "Coca-cola",
    id: "1298",
    datum: "2025-09-27",
    ar: 656
  }
];

const App = () => {

  const [termekek, setTermekek] = useState(termekek_alap);

  const onDeleteHandler = (termekId:string)=>{
    const index = termekek.findIndex(termek=>{
      return termek.id === termekId;
    });
    termekek.splice(index,1);
    setTermekek(termekek=>[...termekek]);
  }

  const onSaveHandler =(ujtermek:any)=>{
    const index = termekek.findIndex(termek=>{
      return termek.id === ujtermek.id;
    });
    termekek[index] = ujtermek;
    setTermekek(termekek=>[...termekek]);
  }
  return (
    <>
      <h1>Ital bolt</h1>
      <UjTermek/>
      <div className='termekek'>
      {
        termekek.map((termek)=>(
          <Termek key={termek.id} termek={termek} onSave={onSaveHandler} onDelete={onDeleteHandler}/>
        ))
      }
      </div>
      
    </>
  );
}

export default App
















/*  <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>*/