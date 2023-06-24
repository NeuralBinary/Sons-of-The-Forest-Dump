using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
internal class StructuresGhostPass : CustomPass
{
	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3169FC0", Offset = "0x31685C0", VA = "0x183169FC0", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x316A2F0", Offset = "0x31688F0", VA = "0x18316A2F0", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x5D6C10", Offset = "0x5D5210", VA = "0x1805D6C10")]
	public StructuresGhostPass()
	{
	}

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x0")]
	private static ShaderTagId[] shaderTagsDepth;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x8")]
	private static ShaderTagId[] shaderTagsOutline;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x10")]
	private static ShaderTagId[] shaderTagsOutline2nd;
}
