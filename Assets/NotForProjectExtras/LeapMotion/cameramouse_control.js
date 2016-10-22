#pragma strict



// Move Camera Script
 
var horizontalSpeed : float = 40.0;
var verticalSpeed : float = 40.0;
 
function Update () {
   
    // If Right Button is clicked Camera will move.
    while (Input.GetMouseButtonDown(1)) {
    var h : float = horizontalSpeed * Input.GetAxis ("Mouse Y");
    var v : float = verticalSpeed * Input.GetAxis ("Mouse X");
    transform.Translate(v,h,0);
    }
 
}
 
function Start () {

}

