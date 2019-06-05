using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roamer : IHero 
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Roamer Move");
	}
	public void Attack ()
	{
		Debug.Log ("Roamer Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Roamer CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Roamer Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Roamer Resurection");
	}
}
