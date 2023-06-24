using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	public class StatAdjustment
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3143AF0", Offset = "0x31420F0", VA = "0x183143AF0")]
		public Type GetTargetStat()
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
		public float GetAdjustment()
		{
			return 0f;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x70BA10", Offset = "0x70A010", VA = "0x18070BA10")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StatAdjustment()
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		[SerializeReference]
		private Stat _targetStat;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _adjustment;
	}
}
