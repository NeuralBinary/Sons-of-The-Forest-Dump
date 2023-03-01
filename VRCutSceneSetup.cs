using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B1 RID: 689
[Token(Token = "0x20002B1")]
public class VRCutSceneSetup : MonoBehaviour
{
	// Token: 0x060011D0 RID: 4560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x2B89060", Offset = "0x2B88060", VA = "0x182B89060")]
	private void Start()
	{
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRCutSceneSetup()
	{
	}

	// Token: 0x040011AB RID: 4523
	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x20")]
	public Camera mainCam;

	// Token: 0x040011AC RID: 4524
	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x28")]
	public Camera VRCam;
}
