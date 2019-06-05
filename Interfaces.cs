public interface IHero
{
	float Health		{ get; set;}
	float Speed			{ get; set;}
	float Damage		{ get; set;}
	float AttackRange	{ get; set;}
	float AttackSpeed	{ get; set;}
	IAbility Ability 	{ get; set;}

	void Move ();
	void Attack ();
	void CastAbility ();
	void Death ();
	void Resurection ();
}

public interface IAbility
{
	float CastTime	{ get; set;}
	float CastRange	{ get; set;}
	float Damage	{ get; set;}
	float Cooldown	{ get; set;}
}

public interface IFactroy
{
	object Create(object Enum);
}