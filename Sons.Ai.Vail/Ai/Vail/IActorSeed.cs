using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public interface IActorSeed
	{
		// Token: 0x06000558 RID: 1368
		[Token(Token = "0x6000558")]
		void ApplySeed(int seed, int subSet);

		// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2B29470", Offset = "0x2B27A70", VA = "0x182B29470")]
		public static void ApplySeedToChildren(Transform tr, int seed, int subSet)
		{
		}
	}
}
