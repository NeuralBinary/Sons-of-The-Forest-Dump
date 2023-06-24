using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
internal class UnderwaterStreamCustomPass : CustomPass
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3186CB0", Offset = "0x31852B0", VA = "0x183186CB0", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x31871A0", Offset = "0x31857A0", VA = "0x1831871A0", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3188750", Offset = "0x3186D50", VA = "0x183188750", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x31889F0", Offset = "0x3186FF0", VA = "0x1831889F0")]
	public UnderwaterStreamCustomPass()
	{
	}

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x0")]
	private static RTHandle _colorBuffer;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x8")]
	private static RTHandle _depthBuffer;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x90")]
	public bool _renderOnlyMaskOjects;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x94")]
	public float _streamSurfaceClipDistance;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x98")]
	public bool _debugUnderwater;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int StreamsMaskPID;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int StreamsDepthPID;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int StreamsSurfaceClipDistance;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int DebugUnderWater;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0xA0")]
	private RenderTexture m_UnderwaterMaskRT;
}
