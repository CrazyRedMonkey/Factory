using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityFactory : IFactroy 
{
	public object Create (object Enum)
	{
		return new object ();
	}
}
