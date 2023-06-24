using System;
using Il2CppDummyDll;

namespace PathologicalGames
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Serializable]
	public class HitEffectGUIBacker
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x28CFD30", Offset = "0x28CE330", VA = "0x1828CFD30")]
		public HitEffectGUIBacker()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x28CFDB0", Offset = "0x28CE3B0", VA = "0x1828CFDB0")]
		public HitEffectGUIBacker(HitEffect effect)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x28CFEB0", Offset = "0x28CE4B0", VA = "0x1828CFEB0")]
		public HitEffect GetHitEffect()
		{
			return default(HitEffect);
		}

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x18")]
		public float value;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x1C")]
		public float duration;
	}
}
