using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[ExecuteAlways]
public class RenderStreamDepth : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x28D5ED0", Offset = "0x28D44D0", VA = "0x1828D5ED0")]
	private RenderTexture MakeRT(bool depthStencilTarget)
	{
		return null;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x28D60D0", Offset = "0x28D46D0", VA = "0x1828D60D0")]
	private void Render()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x28D7A30", Offset = "0x28D6030", VA = "0x1828D7A30")]
	public RenderStreamDepth()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public RenderStreamDepth.Resultion _resolution;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask _layerMask;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public bool UseUnorm;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x29")]
	public bool DoRender;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private Camera _streamCam;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	private Material _copyDepthMaterial;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture _rt;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	private RenderTexture _cacheTexture;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	private float near;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[Serializable]
	public enum Resultion
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		_1024 = 1024,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		_2048 = 2048,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		_4096 = 4096,
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		_4097
	}
}
