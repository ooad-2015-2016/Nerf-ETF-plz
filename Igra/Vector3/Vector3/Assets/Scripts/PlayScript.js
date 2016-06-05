#pragma strict

function OnMouseEnter() { renderer.material.color = Color.black; }

function OnMouseExit() { renderer.material.color = Color.white; }

function OnMouseUpAsButton () {
 	Application.LoadLevel("LevSel");
}