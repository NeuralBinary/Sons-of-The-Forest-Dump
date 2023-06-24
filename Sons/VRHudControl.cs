using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AB RID: 683
[Token(Token = "0x20002AB")]
public class VRHudControl : MonoBehaviour
{
	// Token: 0x06001221 RID: 4641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001221")]
	[Address(RVA = "0x31D54B0", Offset = "0x31D3AB0", VA = "0x1831D54B0")]
	private void Start()
	{
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRHudControl()
	{
	}

	// Token: 0x040011F1 RID: 4593
	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x20")]
	public Camera HudCam;

	// Token: 0x040011F2 RID: 4594
	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x28")]
	public Camera VRHudCam;
}
