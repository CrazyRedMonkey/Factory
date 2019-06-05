using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucker : IHero 
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Nucker Move");
	}
	public void Attack ()
	{
		Debug.Log ("Nucker Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Nucker CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Nucker Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Nucker Resurection");
	}
}
