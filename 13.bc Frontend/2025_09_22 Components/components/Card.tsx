import './Card.css'

function Card(props){
    const cn = 'card '+props.className;
    return (
        <div className={cn}>
            {props.children}
        </div>
    );
}

export default Card;