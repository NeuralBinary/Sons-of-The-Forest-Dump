using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
internal class SpawnImpactEffect_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060008F2 RID: 2290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SpawnImpactEffect_Meta()
	{
	}

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000053D0 File Offset: 0x000035D0
	[Token(Token = "0x170004A2")]
	private TypeId TypeId
	{
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x170004A3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x83D8E0", Offset = "0x83BEE0", VA = "0x18083D8E0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004A4")]
	private Type TypeObject
	{
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x83D900", Offset = "0x83BF00", VA = "0x18083D900", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x83D9A0", Offset = "0x83BFA0", VA = "0x18083D9A0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x83E0F0", Offset = "0x83C6F0", VA = "0x18083E0F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x83E180", Offset = "0x83C780", VA = "0x18083E180", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x0")]
	internal static SpawnImpactEffect_Meta Instance;
}
