import { Component } from '@angular/core';
import { WeatherComponent } from './weather/weather.component';
import { SignalrChatComponent } from './signalr-chat/signalr-chat.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'client-app';
}
