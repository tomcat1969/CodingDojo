import React, { useState } from 'react';

export const Tabs = props => {
    // const [ tabState, setTabState ] = useState({
    //     items: props.items,
    //     contents: props.contents
       
    // })

    const onClickHandler = (e,value) => {
        
        alert(props.contents[value])
    }

    const buttonStyles = {
        border: '0',
        padding: '12px 15px',
        background: 'black',
        fontSize: '1em',
        color: 'white',
        fontWeight: 'bold'   
        
    };

    return props.items.map((item, index)=>{
                       return <button style={buttonStyles} onClick={(e) => onClickHandler(e, index)}>{item}</button>
               
    
    });
}