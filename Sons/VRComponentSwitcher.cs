using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x20002A4")]
public class VRComponentSwitcher : MonoBehaviour
{
	// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x31D3100", Offset = "0x31D1700", VA = "0x1831D3100")]
	private void OnEnable()
	{
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x31D3180", Offset = "0x31D1780", VA = "0x1831D3180")]
	private void SwitchTargets()
	{
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x31D31B0", Offset = "0x31D17B0", VA = "0x1831D31B0")]
	private void ToggleTargets(Component[] targets, bool onoff)
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
	public VRComponentSwitcher()
	{
	}

	// Token: 0x040011CF RID: 4559
	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x20")]
	public Component[] DefaultTargets;

	// Token: 0x040011D0 RID: 4560
	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0x28")]
	public Component[] VRtargets;

	// Token: 0x040011D1 RID: 4561
	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0x30")]
	public bool AutoDisableSelf;
}
