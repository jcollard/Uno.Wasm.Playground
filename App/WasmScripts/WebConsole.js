const inputBuffer = [];
var isBlocking = false;

function write(data) {
    document.getElementById('console').innerText += data;
}

function isInputBufferEmpty() {
    return inputBuffer.length === 0;
}

function dequeueBuffer() {
    return inputBuffer.shift();
}

function unblockOnInput() {
    console.debug("Unblocking on Input");
    isBlocking = false;
}

function blockOnInput() {
    if (isBlocking) return;
    console.debug("Blocking on Input");
    isBlocking = true;
    const konsole = document.getElementById("console");
    const inputBox = document.createElement("INPUT");
    inputBox.addEventListener("keyup", onEnter);
    konsole.appendChild(inputBox);
    inputBox.focus();
    
}

function onEnter(event) {
    if (event.keyCode === 13) {
        write(event.target.value + "\n");
        inputBuffer.push(event.target.value);
        event.target.value = "";
        event.target.disabled = true;
        isBlocking = false;
    }
}

function enqueueInput() {
    inputBuffer.push(prompt("Enter a value:"));
}

function clear() {
    document.getElementById('console').innerText = "";
}