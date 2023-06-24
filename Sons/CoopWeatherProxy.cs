using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
public class CoopWeatherProxy : EntityBehaviour<IWeatherState>, IWindReceiver
{
	// Token: 0x060006B0 RID: 1712 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x35226A0", Offset = "0x3520CA0", VA = "0x1835226A0")]
	private bool IsAttached()
	{
		return default(bool);
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x3522790", Offset = "0x3520D90", VA = "0x183522790")]
	private bool IsAttachedOwner()
	{
		return default(bool);
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x35228A0", Offset = "0x3520EA0", VA = "0x1835228A0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x3522C70", Offset = "0x3521270", VA = "0x183522C70", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x3522CD0", Offset = "0x35212D0", VA = "0x183522CD0")]
	public void Update()
	{
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x3522EE0", Offset = "0x35214E0", VA = "0x183522EE0")]
	private void OnRainTypeChanged()
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x35230C0", Offset = "0x35216C0", VA = "0x1835230C0")]
	private void OnCloudStateChanged()
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x35231A0", Offset = "0x35217A0", VA = "0x1835231A0")]
	private void OnWindChanged()
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x3523540", Offset = "0x3521B40", VA = "0x183523540", Slot = "24")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x3523750", Offset = "0x3521D50", VA = "0x183523750")]
	public CoopWeatherProxy()
	{
	}

	// Token: 0x0400058A RID: 1418
	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x28")]
	private bool _isServer;
}
