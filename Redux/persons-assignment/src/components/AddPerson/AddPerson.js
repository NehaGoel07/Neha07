import React ,{useState} from 'react';
import './AddPerson.css';

const AddPerson = (props) => {

    const [name, setName] = useState(null);
    const [age, setAge] = useState(null);

    return(
    <div className="AddPerson">
        <input type="text" placeholder="Name" onChange={(e)=>setName(e.target.value)} value={name}/>
        <input type="number" placeholder="Age" onChange={(e)=>setAge(e.target.value)} value={age}/>
        <button onClick={()=>props.personAdded(name,age)}>Add Person</button>
    </div>
    );
};

export default AddPerson;