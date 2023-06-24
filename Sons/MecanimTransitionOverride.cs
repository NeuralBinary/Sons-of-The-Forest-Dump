using System;
using Il2CppDummyDll;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000071")]
[Serializable]
public class MecanimTransitionOverride
{
	// Token: 0x06000377 RID: 887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public MecanimTransitionOverride()
	{
	}

	// Token: 0x0400030C RID: 780
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x10")]
	public string FullStateName;

	// Token: 0x0400030D RID: 781
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x18")]
	public float TransitionDuration;

	// Token: 0x0400030E RID: 782
	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x1C")]
	public float TransitionOffset;
}
