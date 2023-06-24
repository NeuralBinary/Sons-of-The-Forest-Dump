using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[Serializable]
public class ItemAndRange
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x305B6B0", Offset = "0x3059CB0", VA = "0x18305B6B0")]
	public ItemAndRange()
	{
	}

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[ItemIdPicker(true)]
	public int _itemId;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public Vector2Int _count;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	[SerializeField]
	public float _chance;
}
