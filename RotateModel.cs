using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000099 RID: 153
[Token(Token = "0x2000099")]
public class RotateModel : MonoBehaviour
{
	// Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x2D521C0", Offset = "0x2D511C0", VA = "0x182D521C0")]
	private void Start()
	{
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x2D52220", Offset = "0x2D51220", VA = "0x182D52220")]
	private void Update()
	{
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x2D522C0", Offset = "0x2D512C0", VA = "0x182D522C0")]
	public RotateModel()
	{
	}

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x20")]
	public float rotationY;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x24")]
	private float rotationX;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x28")]
	private float time;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x2C")]
	public float Speed;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x30")]
	public bool rotate;
}
