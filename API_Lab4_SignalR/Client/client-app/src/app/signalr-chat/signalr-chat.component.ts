import { Component } from '@angular/core';
import * as signalR from "@microsoft/signalr";

@Component({
  selector: 'app-signalr-chat',
  templateUrl: './signalr-chat.component.html',
  styleUrls: ['./signalr-chat.component.css']
})
export class SignalrChatComponent {
  
  constructor (){
    var divMessages = document.querySelector("divMessages");
    const tbMessage:HTMLInputElement = document.querySelector("tbMessage");
    var btnSend = document.querySelector("btnSend");
    
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("http://localhost:5167/Messenger")
        .build();

    connection.on("messageReceived", (username: string, message: string) => {
      const m = document.createElement("div");

      m.innerHTML = `<div class="message-author">${username}</div><div>${message}</div>`;

      if(divMessages != null){
        divMessages.appendChild(m);
        divMessages.scrollTop = divMessages.scrollHeight;
      }
        
    });

    connection.start().catch((err) => document.write(err));

    if(tbMessage != null){
      tbMessage.addEventListener("keyup", (e: KeyboardEvent) => 
      {
        if (e.key === "Enter") 
        {
          connection.send("newMessage", "username", tbMessage.value)
          .then(() => (tbMessage.value = ""));
        }
      });
    }

    if(btnSend != null)
      btnSend.addEventListener("click", () => connection.send("newMessage", "username", tbMessage.value)
      .then(() => (tbMessage.value = "")));

  }
  public signalrConnection() {  }

}
