using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabler : IHero 
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Disabler Move");
	}
	public void Attack ()
	{
		Debug.Log ("Disabler Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Disabler CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Disabler Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Disabler Resurection");
	}	
}
