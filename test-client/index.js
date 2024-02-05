const signalR = require('@microsoft/signalr');

let conn = new signalR.HubConnectionBuilder()
    .withUrl('http://localhost:5121/chat-hub')
    .build();

conn.on("send", data => {
    console.log(data)
})

conn.on('ReceiveMessage', data => {
    console.log(`Received: ${data}`)
})

conn.start()
    .then(() => conn.send('SendMessage', 'reporting'))