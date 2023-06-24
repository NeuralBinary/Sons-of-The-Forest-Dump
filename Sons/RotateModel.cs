using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000099 RID: 153
[Token(Token = "0x2000099")]
public class RotateModel : MonoBehaviour
{
	// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x3500E00", Offset = "0x34FF400", VA = "0x183500E00")]
	private void Start()
	{
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x3500FB0", Offset = "0x34FF5B0", VA = "0x183500FB0")]
	private void Update()
	{
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x35010C0", Offset = "0x34FF6C0", VA = "0x1835010C0")]
	public RotateModel()
	{
	}

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x20")]
	public float rotationY;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x24")]
	private float rotationX;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x28")]
	private float time;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x2C")]
	public float Speed;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x30")]
	public bool rotate;
}
