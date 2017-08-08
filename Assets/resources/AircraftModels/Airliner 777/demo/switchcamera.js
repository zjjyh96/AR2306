var cameraMain : Camera;
var camera3rd : Camera;
function Start () {
cameraMain.enabled = true;
camera3rd.enabled = false;
}
function Update () {
if (Input.GetKeyDown ("c")){
if ( cameraMain.enabled == true){
camera3rd.enabled = true;
cameraMain.enabled = false;
}
else if (camera3rd.enabled == true){
cameraMain.enabled = true;
camera3rd.enabled = false;
}
}
}