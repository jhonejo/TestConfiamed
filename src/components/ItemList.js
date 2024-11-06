const ItemList = ({ items }) => {
  return (
    <div>
      <h2>Lista de Ítems</h2>
      <ul>
        {items.map((item) => (
          <li key={item.id}>
            {item.descripcion} - {item.relevancia} - {item.estado}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ItemList;
