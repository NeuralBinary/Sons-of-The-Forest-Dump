using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000023")]
public static class RenderOrthoCameraPassConstatants
{
	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	private const string NormalProjectorTag = "NormalProjector";

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	private const string DiggingProjectorTag = "DiggingProjector";

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	private const string GrassProjectorTag = "GrassProjector";

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x0")]
	public static readonly ShaderTagId[] ShaderTagsWaterDisplacement;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x8")]
	public static readonly ShaderTagId[] ShaderTagsDigging;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x10")]
	public static readonly ShaderTagId[] ShaderTagsGrass;
}
