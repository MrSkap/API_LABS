import { Component } from '@angular/core';
import { waitForAsync } from '@angular/core/testing';
import * as signalR from "@microsoft/signalr";

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent {
  constructor(){
    
  }
  public async GetWeather(){
    const connection = new signalR.HubConnectionBuilder()
      .withUrl("http://localhost:5167/Messenger")
      .build();
    connection.on("weatherReceived", (weather)=> {
      const wInfo = document.createElement("div");
      wInfo.innerHTML = `<div>${weather}</div>`;
      const wDiv = document.querySelector('weather');
      wDiv.appendChild(wInfo);
    });
    while(true){
      await this.sleep(5000);
      connection.send("weatherReceived", (weather)=> {
        const wInfo = document.createElement("div");
        wInfo.innerHTML = `<div>${weather}</div>`;
        const wDiv = document.querySelector('weather');
        wDiv.appendChild(wInfo);
      });
    }
  }
  private sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }
}
