using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A2 RID: 674
[Token(Token = "0x20002A2")]
public class VRCameraControl : MonoBehaviour
{
	// Token: 0x060011FC RID: 4604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x31D2D70", Offset = "0x31D1370", VA = "0x1831D2D70")]
	private void Start()
	{
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void LateUpdate()
	{
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRCameraControl()
	{
	}

	// Token: 0x040011CA RID: 4554
	[Token(Token = "0x40011CA")]
	[FieldOffset(Offset = "0x20")]
	public Transform VROrigin;

	// Token: 0x040011CB RID: 4555
	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 camVelRef;

	// Token: 0x040011CC RID: 4556
	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 smoothedCameraPos;
}
