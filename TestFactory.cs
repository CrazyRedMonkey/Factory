using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestFactory : MonoBehaviour 
{
	private IFactroy heroFactroy 	= new HeroesFactory ();
	private IFactroy abilityFactory = new AbilityFactory ();

	private List<IAbility> listAbility = new List<IAbility> ();

	[SerializeField] private Transform buttonsHeroes;
	private IHero MyHero;
	private void Start () 
	{
		Button[] buttons = buttonsHeroes.GetComponentsInChildren<Button> ();
		for (int i = 0; i < buttons.Length; ++i)
		{
			int index = i;
			EnumHeroes eHero = GetHeroByID (index);
			buttons [i].GetComponentInChildren<Text> ().text = eHero.ToString();
			buttons [i].onClick.AddListener (()=>{
				CreateHero(eHero);
			});
		}
	}

	private void CreateHero(EnumHeroes eHero)
	{
		MyHero = (IHero)heroFactroy.Create (eHero);
		MyHero.Ability = (IAbility)abilityFactory.Create (eHero);
		Debug.Log (MyHero.Health);
		MyHero.Attack ();
		MyHero.CastAbility ();
		MyHero.Death ();
		MyHero.Move ();
		MyHero.Resurection ();
	}

	private EnumHeroes GetHeroByID(int id)
	{
		EnumHeroes eHero = (EnumHeroes)id;
		return eHero;
	}
}
