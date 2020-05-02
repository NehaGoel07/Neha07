import React from 'react'

function AddFruitRow(props){
    const items=props.fruitsList;
    const rows=items.map(item=>{
        return(
            <tr>
                <td>
                    {item.name}
                </td>
                <td>
                    {item.quantity}
                </td>
                <td>
                    <button onClick={()=>
                    {
                        props.removeFruitRecord(item.name);
                    }}> Delete </button>
                </td>
            </tr>
        )
    })
    return rows;
}

export default AddFruitRow;