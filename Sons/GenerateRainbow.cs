using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
[Serializable]
public class GenerateRainbow : MonoBehaviour
{
	// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x34FFFF0", Offset = "0x34FE5F0", VA = "0x1834FFFF0", Slot = "4")]
	public virtual void New()
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public GenerateRainbow()
	{
	}

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x20")]
	public int segments;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x24")]
	public float zSpacing;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x28")]
	public float ySpacing;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x2C")]
	public bool curveTypeA;
}
