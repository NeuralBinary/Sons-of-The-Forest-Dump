using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[ExecuteAlways]
public class RenderStreamMask : MonoBehaviour
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x28D7A90", Offset = "0x28D6090", VA = "0x1828D7A90")]
	private RenderTexture MakeRT(bool depthStencilTarget)
	{
		return null;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x28D7C70", Offset = "0x28D6270", VA = "0x1828D7C70")]
	private void Render()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x28D8600", Offset = "0x28D6C00", VA = "0x1828D8600")]
	public RenderStreamMask()
	{
	}

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	public Camera cam;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	public RenderStreamMask.Resultion _resolution;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x2C")]
	public LayerMask _layerMask;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	public bool DoRender;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x38")]
	private Camera _streamCam;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x40")]
	private Material _copyDepthMaterial;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x48")]
	private RenderTexture _rt;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x50")]
	private RenderTexture _cacheTexture;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x58")]
	private float near;

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Serializable]
	public enum Resultion
	{
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		_1024 = 1024,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		_2048 = 2048,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		_4096 = 4096,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		_8192 = 8192
	}
}
