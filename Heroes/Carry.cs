using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : IHero
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Carry Move");
	}
	public void Attack ()
	{
		Debug.Log ("Carry Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Carry CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Carry Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Carry Resurection");
	}	
}
