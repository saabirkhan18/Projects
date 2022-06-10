import React, { useEffect, useState } from "react";
const Covid=()=>{
const[data, setData]=useState([]);
    const GetcovidData= async()=>{
        alert('start');
        try{
            const result=await fetch('https://data.covid19india.org/data.json');
            const actualdata=await result.json();
            setData(actualdata.statewise[0]);
            console.log(actualdata.statewise[0]);            
        }
        catch(err)
        {
            console.log(err);
        }
 
    }
 useEffect(()=>{     
     //GetcovidData();
     
 },[]);

return (
<>
    <h1>Covid 19 tracker</h1>
    <ul>
        <li className="card_main">recovered:{data.recovered} </li>
        <li className="card_main">migratedother:{data.migratedother} </li>
        <li className="card_main">deltaconfirmed:{data.deltaconfirmed} </li>
    </ul>
</>)
}
export default Covid