using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
[Serializable]
public class GenerateRainbow : MonoBehaviour
{
	// Token: 0x06000512 RID: 1298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000512")]
	[Address(RVA = "0x2D50EA0", Offset = "0x2D4FEA0", VA = "0x182D50EA0", Slot = "4")]
	public virtual void New()
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000513")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public GenerateRainbow()
	{
	}

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x20")]
	public int segments;

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x24")]
	public float zSpacing;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x28")]
	public float ySpacing;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x2C")]
	public bool curveTypeA;
}
