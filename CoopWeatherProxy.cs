using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x020000DB RID: 219
[Token(Token = "0x20000DB")]
public class CoopWeatherProxy : EntityBehaviour<IWeatherState>, IWindReceiver
{
	// Token: 0x06000666 RID: 1638 RVA: 0x00003D98 File Offset: 0x00001F98
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x2E83BC0", Offset = "0x2E82BC0", VA = "0x182E83BC0")]
	private bool IsAttached()
	{
		return default(bool);
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[Token(Token = "0x6000667")]
	[Address(RVA = "0x2E83B10", Offset = "0x2E82B10", VA = "0x182E83B10")]
	private bool IsAttachedOwner()
	{
		return default(bool);
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x2E837A0", Offset = "0x2E827A0", VA = "0x182E837A0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x2E83AB0", Offset = "0x2E82AB0", VA = "0x182E83AB0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x2E84340", Offset = "0x2E83340", VA = "0x182E84340")]
	public void Update()
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x2E83D10", Offset = "0x2E82D10", VA = "0x182E83D10")]
	private void OnRainTypeChanged()
	{
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x2E83C50", Offset = "0x2E82C50", VA = "0x182E83C50")]
	private void OnCloudStateChanged()
	{
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x2E83E60", Offset = "0x2E82E60", VA = "0x182E83E60")]
	private void OnWindChanged()
	{
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x2E841B0", Offset = "0x2E831B0", VA = "0x182E841B0", Slot = "24")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x2E844A0", Offset = "0x2E834A0", VA = "0x182E844A0")]
	public CoopWeatherProxy()
	{
	}

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x28")]
	private bool _isServer;
}
