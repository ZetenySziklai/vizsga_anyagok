import './Card.css'
import React from 'react';

interface CardItem{
    className:string,
    children: React.ReactNode
}

function Card(props:CardItem){
    const cn = 'card '+props.className;
    return (
        <div className={cn}>
            {props.children}
        </div>
    );
}

export default Card;