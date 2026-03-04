import { useState } from 'react'
import Termek from './components/Termekek/Termek'
import './App.css'
import Koszones from './components/Koszones'
import Card from './components/Megjelenites/Card'
import TermekForm from './components/UjTermek/NewItemForm'

const termekek_alap = [
  {
    nev: "kalapács",
    id: "123",
    datum: "2025-09-29",
    ar: 3250
  },
  {
    nev: "labda",
    id: "987",
    datum: "2025-09-28",
    ar: 1890
  },
  {
    nev: "szék",
    id: "1298",
    datum: "2025-09-27",
    ar: 2560
  }
];

const App = () => {
  const [count, setCount] = useState(0)
  const [termekek, setTermekek] = useState(termekek_alap);
  const [updateItem, setUpdateItem] = useState({nev:"", ar:0, datum:""});
  //let a = 0;


  const deleteHandler = (itemId: string) => {
    const indexOfObject = termekek.findIndex(item => {
      return item.id === itemId;
    });
    termekek.splice(indexOfObject, 1);
    setTermekek(termekek => [...termekek]);
  }

  const saveDataHandler = (item: any) => {
    termekek.push(item);
    termekek.sort((a,b)=>a.datum.localeCompare(b.datum)).sort((a,b)=>a.nev.localeCompare(b.nev));
    setTermekek(termekek => [...termekek]);
  }

  const setUpdateDataItem =(item:any)=>{
    setUpdateItem(item);
  }

  const updateHandler = (item: any) => {
    const index = termekek.findIndex(data => {
      return data.id === item.id;
    });
    termekek[index] = item;
    setTermekek(termekek=> [...termekek]);
  }

  return (
    <>
      <Koszones kername="Pista" veznev="Kis" />

      <button onClick={() => { setCount(count + 1) }}>
        {count}
      </button>

      <TermekForm saveData={saveDataHandler}  onUpdate={updateHandler} updateData={updateItem}/>

      <Card className='termekek'>
        {
          termekek.map((item) => (
            <Termek 
              key={item.id} 
              item={item} 
              onDelete={deleteHandler} 
              onUpdateData = {setUpdateDataItem}/>
          ))
        }
      </Card>     
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