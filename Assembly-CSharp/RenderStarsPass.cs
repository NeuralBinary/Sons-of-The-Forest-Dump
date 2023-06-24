using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
internal class RenderStarsPass : CustomPass
{
	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x5D6570", Offset = "0x5D4B70", VA = "0x1805D6570", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x5D66A0", Offset = "0x5D4CA0", VA = "0x1805D66A0", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x5D6C10", Offset = "0x5D5210", VA = "0x1805D6C10")]
	public RenderStarsPass()
	{
	}

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x90")]
	public Transform _starTransform;

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x0")]
	private static ShaderTagId[] shaderTagsStars;
}
