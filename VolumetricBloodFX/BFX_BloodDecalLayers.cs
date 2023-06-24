using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class BFX_BloodDecalLayers : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x4B063F0", Offset = "0x4B049F0", VA = "0x184B063F0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x4B06B40", Offset = "0x4B05140", VA = "0x184B06B40")]
	private void OnDisable()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x4B06CF0", Offset = "0x4B052F0", VA = "0x184B06CF0")]
	private void Update()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x4B06F20", Offset = "0x4B05520", VA = "0x184B06F20")]
	private void CreateDepthTexture()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2FAD760", Offset = "0x2FABD60", VA = "0x182FAD760")]
	public BFX_BloodDecalLayers()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask DecalLayers;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	public BFX_BloodDecalLayers.DecalLayersProperty DecalRenderingMode;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public BFX_BloodDecalLayers.DepthMode LayerDepthResoulution;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	private DepthTextureMode defaultMode;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture rt;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	private Camera depthCamera;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public enum DecalLayersProperty
	{
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		DrawToSelectedLayers,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		IgnoreSelectedLayers
	}

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public enum DepthMode
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		FullScreen,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		HalfScreen,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		QuarterScreen
	}
}
