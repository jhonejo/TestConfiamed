import { useState } from "react";
import ItemForm from "./components/ItemForm";
import ItemList from "./components/ItemList";

function App() {
  const [items, setItems] = useState([]);

  const getItems = async () => {
    const response = await fetch("https://localhost:7083/api/items");
    const data = await response.json();
    setItems(data);
  };

  return (
    <div>
      <h1>Gestion de Items de Trabajo</h1>
      <ItemForm fetchItems={getItems} />
      <ItemList items={items} />
    </div>
  );
}

export default App;
