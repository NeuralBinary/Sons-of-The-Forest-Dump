using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
internal class VisibilityBuffer : CustomPass
{
	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x316B0D0", Offset = "0x31696D0", VA = "0x18316B0D0", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x316B820", Offset = "0x3169E20", VA = "0x18316B820")]
	public VisibilityBuffer()
	{
	}

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x90")]
	public Material m_VisibiliyBufferTerrainMaterial;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x98")]
	private RenderTargetIdentifier _diffuseTarget;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0xC0")]
	private RenderTargetIdentifier _normalTarget;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTargetIdentifier _specTarget;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x110")]
	private RenderTargetIdentifier _emissiveTarget;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _GBufferTexture0;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _GBufferTexture2;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _GBufferTexture3;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x138")]
	private RenderTargetIdentifier[] _rtIdentifier;
}
