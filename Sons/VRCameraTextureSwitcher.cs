using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A3 RID: 675
[Token(Token = "0x20002A3")]
public class VRCameraTextureSwitcher : MonoBehaviour
{
	// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x31D2E00", Offset = "0x31D1400", VA = "0x1831D2E00")]
	private void Update()
	{
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRCameraTextureSwitcher()
	{
	}

	// Token: 0x040011CD RID: 4557
	[Token(Token = "0x40011CD")]
	[FieldOffset(Offset = "0x20")]
	public Camera VRCam;

	// Token: 0x040011CE RID: 4558
	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x28")]
	public RenderTexture TheatreMode;
}
