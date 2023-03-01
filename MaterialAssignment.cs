using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
[Serializable]
public class MaterialAssignment
{
	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x29AB0E0", Offset = "0x29AA0E0", VA = "0x1829AB0E0")]
	public static MaterialAssignment FromRenderer(Renderer source)
	{
		return null;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x29AB1B0", Offset = "0x29AA1B0", VA = "0x1829AB1B0")]
	public bool Matches(MaterialAssignment pair)
	{
		return default(bool);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public MaterialAssignment()
	{
	}

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Renderer _renderer;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material[] _materials;
}
