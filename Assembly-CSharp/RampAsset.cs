using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
[CreateAssetMenu]
public class RampAsset : ScriptableObject
{
	// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x5E0DA0", Offset = "0x5DF3A0", VA = "0x1805E0DA0")]
	public RampAsset()
	{
	}

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x18")]
	public Gradient gradient;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x20")]
	public int size;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x24")]
	public bool up;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x25")]
	public bool overwriteExisting;
}
