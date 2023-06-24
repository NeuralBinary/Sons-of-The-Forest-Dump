using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public static class UnderwaterStreamCustomPassConstants
{
	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	private const string StreamsSurfacePassTag = "StreamsSurfacePass";

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	private const string StreamsSurfaceBackfacesTag = "StreamsSurfaceBackfacesPass";

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	private const string StreamsCagePassTag = "StreamsCagePass";

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	private const string StreamsMaskObjectsPassTag = "StreamsMaskObjectsPass";

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x0")]
	public static readonly ShaderTagId[] shaderTagsWaterSurface;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x8")]
	public static readonly ShaderTagId[] shaderTagsWaterSurfaceBackfaces;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x10")]
	public static readonly ShaderTagId[] shaderTagsWaterCage;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x18")]
	public static readonly ShaderTagId[] shaderTagsWaterMaskObjects;
}
