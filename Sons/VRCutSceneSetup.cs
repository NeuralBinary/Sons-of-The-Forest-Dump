using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20002A5")]
public class VRCutSceneSetup : MonoBehaviour
{
	// Token: 0x06001205 RID: 4613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x31D3580", Offset = "0x31D1B80", VA = "0x1831D3580")]
	private void Start()
	{
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRCutSceneSetup()
	{
	}

	// Token: 0x040011D2 RID: 4562
	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0x20")]
	public Camera mainCam;

	// Token: 0x040011D3 RID: 4563
	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0x28")]
	public Camera VRCam;
}
