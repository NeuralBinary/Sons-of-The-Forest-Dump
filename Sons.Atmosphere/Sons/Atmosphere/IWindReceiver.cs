using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public interface IWindReceiver
	{
		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		void UpdateWind(Vector3 direction, float intensity);
	}
}
