using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
public class HighlightObject : MonoBehaviour
{
	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x5D5000", Offset = "0x5D3600", VA = "0x1805D5000")]
	private void OnEnable()
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x5D5450", Offset = "0x5D3A50", VA = "0x1805D5450")]
	private void Update()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x5D56F0", Offset = "0x5D3CF0", VA = "0x1805D56F0")]
	public HighlightObject()
	{
	}

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x20")]
	public bool Selected;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x21")]
	private bool wasSelected;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x28")]
	public Material OutlineMaterial;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x30")]
	private Renderer rend;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x38")]
	private Material[] BaseMatArray;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x40")]
	private Material[] SelectedMatArray;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x48")]
	private int[] origStencilVals;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int StencilRefDepth;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int StencilWriteMaskDepth;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int StencilRefGBuffer;
}
