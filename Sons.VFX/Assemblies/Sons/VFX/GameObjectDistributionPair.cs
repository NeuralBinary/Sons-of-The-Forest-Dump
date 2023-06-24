using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Assemblies.Sons.VFX
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[Serializable]
	public class GameObjectDistributionPair
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public GameObjectDistributionPair()
		{
		}

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x10")]
		public GameObject _target;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x18")]
		public MapDistributionData _distribution;
	}
}
