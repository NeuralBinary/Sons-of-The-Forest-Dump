using System;
using Il2CppDummyDll;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
[Serializable]
public class MecanimTransitionOverride
{
	// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public MecanimTransitionOverride()
	{
	}

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x10")]
	public string FullStateName;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x18")]
	public float TransitionDuration;

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x1C")]
	public float TransitionOffset;
}
