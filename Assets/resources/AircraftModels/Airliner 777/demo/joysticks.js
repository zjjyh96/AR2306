var turnSpeed = 50;

function Update()
{
 var eang = gameObject.transform.localEulerAngles;
 if(Input.GetKey(KeyCode.Z))
 {
 eang.z += turnSpeed * Time.deltaTime;
  //transform.RotateAround(transform.position, transform.up, Time.deltaTime * turnSpeed);
 }
 if(Input.GetKey(KeyCode.X))
 {
 eang.z -= turnSpeed * Time.deltaTime;
  //transform.RotateAround(transform.position, transform.up, Time.deltaTime * -turnSpeed);
 }
 //eang.z = 0;
 //eang.x = 0;
 if(eang.z > 180) eang.z -= 360;
  if(eang.z > 30) eang.z = 30;
else if(eang.z < -30) eang.z = -30;
if(eang.z < 0) eang.z += 360; 
 gameObject.transform.localEulerAngles = eang;

}