var turnSpeed = 50;
var angle = -30;
function Update()
{
 var eang = gameObject.transform.localEulerAngles;
 if(Input.GetKey(KeyCode.A))
 {
 eang.x -= turnSpeed * Time.deltaTime;
  //transform.RotateAround(transform.position, transform.up, Time.deltaTime * turnSpeed);
 }
 if(Input.GetKey(KeyCode.S))
 {
 eang.x += turnSpeed * Time.deltaTime;
  //transform.RotateAround(transform.position, transform.up, Time.deltaTime * -turnSpeed);
 }
 //eang.z = 0;
 //eang.x = 0;
 if(eang.x > 180) eang.x -= 360;
  if(eang.x > 0) eang.x = 0;
else if(eang.x < angle) eang.x = angle;
if(eang.x < 0) eang.x += 360; 
 gameObject.transform.localEulerAngles = eang;

}