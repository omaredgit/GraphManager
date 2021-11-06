import React, { Component } from 'react';
import App from '../App';

export class FetchData extends Component {
    static displayName = FetchData.name;


    constructor() {
        super();
        this.state = {

            monsters:
                []
        }
    }

    componentDidMount() {
        this.populateWeatherData();
    }



    async populateWeatherData() {
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ title: 'React POST Request Example' })
        };

        fetch('http://localhost:48708/WeatherForecast', requestOptions)
            .then(response => response.json())
            .then(users => this.setState({ monsters: users }))

    }
    render() { return (App); }
}
