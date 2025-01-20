window.updateMapSrc = (id, url) => {
    const map = document.getElementById(id);
    if (map) {
        map.src = url; // Set the iframe source directly
    } else {
        console.error("Map element not found!");
    }
};
    