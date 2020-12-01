document.addEventListener('keydown', function(event) {
    if (event.key == 'Escape') {
        switchStyleSheet('print.css', 'style.css');
    }
});

function switchStyleSheet(oldFile, newFile) {
    let style = document.getElementById('stylesheet');
    style.href = style.href.replace(oldFile, newFile);
}
