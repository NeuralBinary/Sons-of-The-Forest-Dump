using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
internal class SimpleUnderwaterCopyNormals : CustomPass
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3186370", Offset = "0x3184970", VA = "0x183186370", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3186700", Offset = "0x3184D00", VA = "0x183186700", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3186950", Offset = "0x3184F50", VA = "0x183186950", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x5D6C10", Offset = "0x5D5210", VA = "0x1805D6C10")]
	public SimpleUnderwaterCopyNormals()
	{
	}

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x90")]
	private RTHandle _normalBuffer;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x98")]
	private Material _blitMat;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _NormalBufferTexture;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _OpaqueNormalBuffer;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _BlitTexture;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int _BlitScaleBias;
}
