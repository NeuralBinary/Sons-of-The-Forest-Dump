using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AE RID: 686
[Token(Token = "0x20002AE")]
public class VRCameraControl : MonoBehaviour
{
	// Token: 0x060011C7 RID: 4551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x2B88BA0", Offset = "0x2B87BA0", VA = "0x182B88BA0")]
	private void Start()
	{
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRCameraControl()
	{
	}

	// Token: 0x040011A3 RID: 4515
	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0x20")]
	public Transform VROrigin;

	// Token: 0x040011A4 RID: 4516
	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 camVelRef;

	// Token: 0x040011A5 RID: 4517
	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 smoothedCameraPos;
}
