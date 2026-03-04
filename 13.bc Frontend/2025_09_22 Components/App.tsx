// import { useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
import Termek from './components/Termek';
import './App.css'
import Koszones from './components/Koszones'
import Card from './components/Card'

function App() {
  //const [count, setCount] = useState(0)

  let termekek = [
    {
      nev: "kalapács",
      id: "123",
      datum: "2025.09.29",
      ar: 3250
    },
    {
      nev: "labda",
      id: "987",
      datum: "2025.09.28",
      ar: 1890
    },
    {
      nev: "szék",
      id: "1298",
      datum: "2025.09.27",
      ar: 2560
    }
  ]

  return (
    <>
      <Koszones kername="Pista" veznev="Kis" />
      {/* <div className='termekek'> */}
      <Card className='termekek'>
        {
          termekek.map((item) =>(
            <Termek item={item} />
          ))
        }
      </Card>

      {/* <Termek item={termekek[0]} />
      <Termek item={termekek[1]} />
      <Termek item={termekek[2]} /> */}
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