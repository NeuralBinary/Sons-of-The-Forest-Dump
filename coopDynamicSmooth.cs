using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x20000B4")]
public class coopDynamicSmooth : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x2E8E180", Offset = "0x2E8D180", VA = "0x182E8E180")]
	private void Start()
	{
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x2E8DE00", Offset = "0x2E8CE00", VA = "0x182E8DE00")]
	private void LateUpdate()
	{
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x2E8DD90", Offset = "0x2E8CD90", VA = "0x182E8DD90", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x2E8E270", Offset = "0x2E8D270", VA = "0x182E8E270")]
	public coopDynamicSmooth()
	{
	}

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x28")]
	public bool smoothRotation;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x29")]
	public bool updateOnClientOnly;

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _smoothSpeed;

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _smoothMaxRange;

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x34")]
	private float _maxRangeSqr;

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _smoothPosition;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion _smoothRotation;
}
