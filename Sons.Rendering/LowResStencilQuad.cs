using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
[RequireComponent(typeof(Camera))]
public class LowResStencilQuad : MonoBehaviour
{
	// Token: 0x0600000C RID: 12 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3124E20", Offset = "0x3123420", VA = "0x183124E20")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x31252C0", Offset = "0x31238C0", VA = "0x1831252C0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
	public LowResStencilQuad()
	{
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x20")]
	[HeaderHelpURL("Low-Resolution-Transparency-7b1aef1191384aacafe0ee410e4d2748")]
	public Mesh QuadMesh;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x28")]
	public Material QuadMaterial;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x30")]
	public bool HideAndDontSave;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x31")]
	public bool QuadAdded;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x38")]
	private Camera cam;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x40")]
	private Transform camTransform;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x48")]
	private GameObject StencilQuadGo;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x50")]
	private Transform StencilQuadTrans;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x58")]
	private MeshFilter StencilQuadMeshFilter;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x60")]
	private Renderer StencilQuadRenderer;
}
