using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : IHero 
{
	public float Health 		{get ; set ;}
	public float Speed 			{get ; set ;}
	public float Damage 		{get ; set ;}
	public float AttackRange 	{get ; set ;}
	public float AttackSpeed 	{get ; set ;}
	public IAbility Ability 	{get ; set ;}

	public void Move ()
	{
		Debug.Log ("Support Move");
	}
	public void Attack ()
	{
		Debug.Log ("Support Attack");
	}
	public void CastAbility ()
	{
		Debug.Log ("Support CastAbility");
	}
	public void Death ()
	{
		Debug.Log ("Support Death");
	}
	public void Resurection ()
	{
		Debug.Log ("Support Resurection");
	}
}
