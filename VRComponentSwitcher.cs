using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B0 RID: 688
[Token(Token = "0x20002B0")]
public class VRComponentSwitcher : MonoBehaviour
{
	// Token: 0x060011CC RID: 4556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x2B88D60", Offset = "0x2B87D60", VA = "0x182B88D60")]
	private void OnEnable()
	{
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x2B88DB0", Offset = "0x2B87DB0", VA = "0x182B88DB0")]
	private void SwitchTargets()
	{
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x2B88DE0", Offset = "0x2B87DE0", VA = "0x182B88DE0")]
	private void ToggleTargets(Component[] targets, bool onoff)
	{
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x62C050", Offset = "0x62B050", VA = "0x18062C050")]
	public VRComponentSwitcher()
	{
	}

	// Token: 0x040011A8 RID: 4520
	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x20")]
	public Component[] DefaultTargets;

	// Token: 0x040011A9 RID: 4521
	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x28")]
	public Component[] VRtargets;

	// Token: 0x040011AA RID: 4522
	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x30")]
	public bool AutoDisableSelf;
}
