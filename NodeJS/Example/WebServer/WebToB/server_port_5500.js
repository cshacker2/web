const WebSocket = require('ws');

const wws = new WebSocket.Server({port : 5500});
wws.on('connection', ws => {
    ws.on('message', message => {
        console.dir(message);
        console.dir('message received from browser');
    })
    setInterval(() => {
        ws.send('WebSocket Connected! PORT : 5500');
    }, 2000);
})