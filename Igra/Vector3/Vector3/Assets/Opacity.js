var pocniRaditi: boolean = false;
var alphaStart : float = 0.0;
var alphaEnd : float = 1.0;
var duration : float = 10.0;

function Update() {

if(pocniRaditi==true)
{

var lerp : float = Mathf.PingPong(Time.time,duration);//duration;
renderer.material.color.a = Mathf.Lerp(alphaStart,alphaEnd,lerp);
}
else
{
renderer.material.color.a = Mathf.Lerp(alphaEnd,alphaStart,lerp);
}

}
