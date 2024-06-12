import { Typography } from '@mui/material';
import { useEffect, useState } from "react";
import { Product } from "../models/Product";
import Catalog from "../../feature/catalog/Catalog";

function App() {
  const [products,setProducts]=useState<Product[]>([]); 

    useEffect(()=>{
        fetch('http://localhost:3000/api/products')
        .then(response=>response.json())
        .then(data=>setProducts(data));
    },[])

  function addProduct(){
    setProducts(prevState => [...prevState,
      {
        id:prevState.length+101,
        name:'product'+(prevState.length+1),
        brand:'some brand',
        price:(prevState.length*100)+100,
        description:'test',
        pictureUrl:'http://picsum.photos/200'
       
      }
    ])
  }
  return (
    <>

      <Typography variant='h1'>Hy i m h1</Typography>
      <Catalog products={products} addProduct={addProduct}/>
     </>
  );
}

export default App;
 