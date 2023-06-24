using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[Serializable]
	internal class LookAtWeight
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2B10E80", Offset = "0x2B0F480", VA = "0x182B10E80")]
		internal static float Lerp(LookAtWeight lookAtWeightMin, LookAtWeight lookAtWeightMax, float factor)
		{
			return 0f;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LookAtWeight()
		{
		}

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _weight;
	}
}
