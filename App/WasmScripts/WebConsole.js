const inputBuffer = [];
var isBlocking = false;
var term;

function write(data) {
    term.write(data);
    // document.getElementById('console').innerText += data;
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
}

function clear() {
    term.clear();
}

function initWebConsole() {
    console.debug("Initializing Terminal");
    term = new Terminal( {cursorBlink: "block" });
    term.open(document.getElementById('terminal'));
    term.onKey(handleInput);
    term.parser
    console.debug("Initialized!");
}


var inputCharBuffer = [];

function handleInput(keyData) {
    if (!isBlocking) return;
    
    if (keyData.domEvent.key === 'Backspace') {
        if (inputCharBuffer.length > 0) {
            term.write('\x1b[D \x1b[D');
            inputCharBuffer.pop();
        }
        return;
    }
    if (keyData.key.length > 1) return;

    term.write(keyData.key)

    if (keyData.domEvent.key === 'Enter') {
        inputBuffer.push(inputCharBuffer.join(""));
        inputCharBuffer = [];
        term.write("\n");
        return;
    }
    inputCharBuffer.push(keyData.key);
}