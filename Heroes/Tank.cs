using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : IHero 
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Tank Move");
	}
	public void Attack ()
	{
		Debug.Log ("Tank Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Tank CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Tank Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Tank Resurection");
	}
}
