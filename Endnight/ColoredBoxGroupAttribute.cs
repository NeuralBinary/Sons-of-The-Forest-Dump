using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class ColoredBoxGroupAttribute : BoxGroupAttribute
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0xA5FC20", Offset = "0xA5E220", VA = "0x180A5FC20")]
	public ColoredBoxGroupAttribute(string group, float r = 1f, float g = 1f, float b = 1f, float a = 1f, bool showLabel = true, bool centerLabel = false, int order = 0)
	{
	}

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x48")]
	public float R;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x4C")]
	public float G;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x50")]
	public float B;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x54")]
	public float A;
}
