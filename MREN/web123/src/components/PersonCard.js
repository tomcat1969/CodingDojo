import React, { Component } from 'react';
class PersonCard extends Component {
    render() {
        return (<div>
                    <h3>{this.props.firstName},{this.props.lastName}</h3>
                    <h5>Age : {this.props.age}</h5>
                    <h5>Hair Color : {this.props.hairColor}</h5>
                    
                </div>);
    }
}
export default PersonCard;