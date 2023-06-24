using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AF RID: 687
[Token(Token = "0x20002AF")]
public class VROffsetTransform : MonoBehaviour
{
	// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x31D5C70", Offset = "0x31D4270", VA = "0x1831D5C70")]
	private void Awake()
	{
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnEnable()
	{
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnDisable()
	{
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VROffsetTransform()
	{
	}

	// Token: 0x040011FE RID: 4606
	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 rotationOffset;

	// Token: 0x040011FF RID: 4607
	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 positionOffset;

	// Token: 0x04001200 RID: 4608
	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 initialEulerRotation;

	// Token: 0x04001201 RID: 4609
	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 initialLocalPosition;
}
