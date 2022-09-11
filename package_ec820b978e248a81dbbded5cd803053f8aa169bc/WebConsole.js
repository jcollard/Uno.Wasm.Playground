const inputBuffer = [];
var isBlocking = false;
var blockOutput = false;
var term;
var pauseWrite = false;
var pauseBuffer = [];

function write(data) {
    if (pauseWrite) {
        return;
    }
    term.write(data);
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
    term.setOption('cursorBlink', false);
    term.setOption('cursorStyle', null);
}

function blockOnInput() {
    if (isBlocking) return;
    console.debug("Blocking on Input");
    isBlocking = true;
    term.setOption('cursorBlink', 'block');
}

function clear() {
    pauseWrite = true;
    term.clear();
    pauseWrite = false;
}

function initWebConsole() {
    console.debug("Initializing Terminal");
    term = new Terminal( );
    term.open(document.getElementById('terminal'));
    term.onKey(handleInput);
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