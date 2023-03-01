using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AF RID: 687
[Token(Token = "0x20002AF")]
public class VRCameraTextureSwitcher : MonoBehaviour
{
	// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x2B88BE0", Offset = "0x2B87BE0", VA = "0x182B88BE0")]
	private void Update()
	{
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRCameraTextureSwitcher()
	{
	}

	// Token: 0x040011A6 RID: 4518
	[Token(Token = "0x40011A6")]
	[FieldOffset(Offset = "0x20")]
	public Camera VRCam;

	// Token: 0x040011A7 RID: 4519
	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x28")]
	public RenderTexture TheatreMode;
}
