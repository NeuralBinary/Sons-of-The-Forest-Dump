using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public interface IVailWeapon
	{
		// Token: 0x0600059B RID: 1435
		[Token(Token = "0x600059B")]
		void Shoot(Vector3 targetPos, Vector3 targetVel, Vector3 forwardDir);
	}
}
