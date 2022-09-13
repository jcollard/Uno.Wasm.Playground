const inputBuffer = [];
var isLoaded = false;
var isBlocking = false;
var blockOutput = false;
var term;
var pauseWrite = false;
var pauseBuffer = [];

function write(data) {
    if (pauseWrite) {
        return;
    }
    term.io.print(data);
}

function isInputBufferEmpty() {
    return inputBuffer.length === 0;
}

function dequeueBuffer() {
    return inputBuffer.shift();
}

function unblockOnInput() { 
    console.debug("Unblocking on Input");
    term.setCursorVisible(false);
    isBlocking = false;
}

function blockOnInput() {
    if (isBlocking) return;
    console.debug("Blocking on Input");
    term.setCursorVisible(true);
    isBlocking = true;
}

function clear() {
    pauseWrite = true;
    term.clearHome();
    pauseWrite = false;
}

function isReady() {
    return isLoaded;
}

async function initWebConsole() {
    isLoaded = false;
    await lib.init();
    setupHterm();
}

function setupHterm() {
    console.debug("Setting up hterm");
    term = new hterm.Terminal();
    term.onTerminalReady = onTerminalReady;
    term.decorate(document.getElementById('terminal'));
    term.installKeyboard();
    isLoaded = true;
}

function onTerminalReady() {
    const io = term.io.push();
    
    term.setCursorVisible(false);
    term.setCursorBlink(true);
    term.keyboard.backspaceSendsBackspace = true;

    io.onVTKeystroke = onVTKeystroke;
    io.sendString = sendString;
    io.onTerminalResize = onTerminalResize;
    console.debug("hterm is ready.");
}

var inputCharBuffer = [];

function onVTKeystroke(str) {
    if (!isBlocking) return;
    
    // Debug Information
    console.debug(`onVTKeyStroke: ${str}`);
    const codes = [];
    for(let ch of str) {
        codes.push(ch.charCodeAt(0));
    }
    console.debug(` - Char Code: ${codes}`);
    
    const keyCode = getKeyCode(codes);
    
    if (keyCode === 'Backspace') {
        if (inputCharBuffer.length > 0) {
            // TODO: Check for backspace on tab
            term.io.print('\x1b[D \x1b[D');
            inputCharBuffer.pop();
        }
        return;
    }

    

    if (keyCode === 'Enter') {
        inputBuffer.push(inputCharBuffer.join(""));
        inputCharBuffer = [];
        term.io.print("\n");
        return;
    }

    // TODO: Control / Alt / Esc
    // Only allow strings of length 1 to be written? Maybe
    // should check that the string is a character that can be displayed?
    if (codes.length > 1 || codes[0] < 32) return;

    term.io.print(str)
    inputCharBuffer.push(str);
}

function sendString(str) {
    console.debug(`sendString: ${str}`);
}

function onTerminalResize(columns, rows) {
    console.debug(`onTerminalResize: (${columns}, ${rows})`);
}

const keyCodes = {
    [8]: 'Backspace',
    [9]: 'Tab',
    [13]: 'Enter',
    [27]: 'Escape',
    
};

function getKeyCode(codes) {
    if (keyCodes[codes] === undefined) {
        console.debug(`Unknown key codes: ${codes}`);
        return undefined;
    }
    return keyCodes[codes];
}