using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

// Token: 0x0200025E RID: 606
[Token(Token = "0x200025E")]
public class objectOnWater : MonoBehaviour
{
	// Token: 0x060010D2 RID: 4306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x373EEF0", Offset = "0x373D4F0", VA = "0x18373EEF0")]
	private void OnEnable()
	{
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x373F0A0", Offset = "0x373D6A0", VA = "0x18373F0A0")]
	private void Update()
	{
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x373F500", Offset = "0x373DB00", VA = "0x18373F500")]
	private void OnDisable()
	{
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public objectOnWater()
	{
	}

	// Token: 0x04000FB3 RID: 4019
	[Token(Token = "0x4000FB3")]
	[FieldOffset(Offset = "0x20")]
	[Header("FMOD EVENT")]
	public string onWaterEvent;

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x28")]
	public Buoyancy _bouyancy;

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000FB5")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance onWater;
}
