#pragma strict

function OnCollisionEnter(collision : Collision)
{
if(collision.gameObject.tag == "Finish")
{
Application.LoadLevel(2);
}

}