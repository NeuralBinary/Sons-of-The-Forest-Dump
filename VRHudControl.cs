using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B7 RID: 695
[Token(Token = "0x20002B7")]
public class VRHudControl : MonoBehaviour
{
	// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x2B8A210", Offset = "0x2B89210", VA = "0x182B8A210")]
	private void Start()
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRHudControl()
	{
	}

	// Token: 0x040011CA RID: 4554
	[Token(Token = "0x40011CA")]
	[FieldOffset(Offset = "0x20")]
	public Camera HudCam;

	// Token: 0x040011CB RID: 4555
	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x28")]
	public Camera VRHudCam;
}
