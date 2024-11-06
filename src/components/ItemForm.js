import { useState } from "react";
import axios from "axios";

const ItemForm = ({ fetchItems }) => {
  const [descripcion, setDescripcion] = useState("");
  const [fechaEntrega, setFechaEntrega] = useState("");
  const [relevancia, setRelevancia] = useState("baja");

  const handleSubmit = async (e) => {
    e.preventDefault();

    const newItem = {
      descripcion,
      fecha_entrega: fechaEntrega,
      relevancia,
    };

    try {
      await axios.post("https://localhost:7083/api/items", newItem);
      fetchItems();
    } catch (error) {
      console.error("Error al crear ítem", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        placeholder="Descripción del ítem"
        value={descripcion}
        onChange={(e) => setDescripcion(e.target.value)}
        style={{ marginInlineEnd: "2" }}
      />
      <input
        type="date"
        value={fechaEntrega}
        onChange={(e) => setFechaEntrega(e.target.value)}
        style={{ marginInlineEnd: "2" }}
      />
      <select
        onChange={(e) => setRelevancia(e.target.value)}
        style={{ marginInlineEnd: "2" }}
      >
        <option value="baja">Baja</option>
        <option value="alta">Alta</option>
      </select>
      <button type="submit" style={{ border: "1px solid", borderRadius: "10" }}>
        Crear Ítem
      </button>
    </form>
  );
};

export default ItemForm;
