var x = document.getElementById("time");

currtime();

$(document).ready(function () {
    setInterval(currtime, 1000);
});

function currtime(){
    timestamp = new Date();
    hour = timestamp.getHours();
    minute = timestamp.getMinutes();
    second = timestamp.getSeconds();
    if(minute < 10) minute = "0" + minute;
    if(second < 10) second = "0" + second;

    x.innerText = "" + hour + " : " + minute + " : " + second;
}