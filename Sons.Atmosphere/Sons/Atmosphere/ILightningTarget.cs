using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public interface ILightningTarget
	{
		// Token: 0x06000167 RID: 359
		[Token(Token = "0x6000167")]
		void LightningHit();

		// Token: 0x06000168 RID: 360
		[Token(Token = "0x6000168")]
		Vector3 GetLightningStrikePosition();
	}
}
