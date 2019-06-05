using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesFactory : IFactroy
{
	public object Create (object Enum)
	{
		EnumHeroes code = (EnumHeroes)Enum;
		IHero hero = null;
		switch(code)
		{
		case EnumHeroes.Carry:
			hero = new Carry ();
			break;
		case EnumHeroes.Disabler:
			hero = new Disabler ();
			break;
		case EnumHeroes.Jungler:
			hero = new Jungler ();
			break;
		case EnumHeroes.Nucker:
			hero = new Nucker ();
			break;
		case EnumHeroes.Roamer:
			hero = new Roamer ();
			break;
		case EnumHeroes.Support:
			hero = new Support ();
			break;
		case EnumHeroes.Tank:
			hero = new Tank ();
			break;
		}
		SetHeroStats (ref hero, GetJsonParams (code));
		return hero;
	}

	private string GetJsonParams(EnumHeroes code)
	{
		//подгрузка jsona
		string json = code.ToString ();
		return json;
	}

	private void SetHeroStats(ref IHero hero, string jsonParams)
	{
		//парсим джейсона и записываем в героя все параметры
		switch(jsonParams)
		{
		case "Carry":
			hero.Health = 20;
			break;
		case "Disabler":
			hero.Health = 60;
			break;
		case "Jungler":
			hero.Health = 40;
			break;
		case "Nucker":
			hero.Health = 70;
			break;
		case "Roamer":
			hero.Health = 70;
			break;
		case "Support":
			hero.Health = 50;
			break;
		case "Tank":
			hero.Health = 100;
			break;
		}
	}
}
