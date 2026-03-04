import axios from "axios";

export type Robotporszivo = {
    id: number,
    marka: string,
    tipus: string,
    teljesitmeny: number,
    ar: number
}


export const getRobotp = () => {
    return axios.get<Robotporszivo[]>("http://localhost:3001/api/robotporszivo");
}