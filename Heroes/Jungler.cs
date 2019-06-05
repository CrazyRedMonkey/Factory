using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jungler : IHero 
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Jungler Move");
	}
	public void Attack ()
	{
		Debug.Log ("Jungler Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Jungler CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Jungler Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Jungler Resurection");
	}	
}
