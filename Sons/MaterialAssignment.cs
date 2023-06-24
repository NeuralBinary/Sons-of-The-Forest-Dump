using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
[Serializable]
public class MaterialAssignment
{
	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2F69C10", Offset = "0x2F68210", VA = "0x182F69C10")]
	public static MaterialAssignment FromRenderer(Renderer source)
	{
		return null;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2F69E10", Offset = "0x2F68410", VA = "0x182F69E10")]
	public bool Matches(MaterialAssignment pair)
	{
		return default(bool);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public MaterialAssignment()
	{
	}

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Renderer _renderer;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material[] _materials;
}
