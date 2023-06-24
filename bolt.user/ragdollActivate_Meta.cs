using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
internal class ragdollActivate_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ragdollActivate_Meta()
	{
	}

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00006678 File Offset: 0x00004878
	[Token(Token = "0x170005E0")]
	private TypeId TypeId
	{
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00006690 File Offset: 0x00004890
	[Token(Token = "0x170005E1")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x881130", Offset = "0x87F730", VA = "0x180881130", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005E2")]
	private Type TypeObject
	{
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x881150", Offset = "0x87F750", VA = "0x180881150", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x8811F0", Offset = "0x87F7F0", VA = "0x1808811F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x8813E0", Offset = "0x87F9E0", VA = "0x1808813E0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x881470", Offset = "0x87FA70", VA = "0x180881470", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400029E RID: 670
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x0")]
	internal static ragdollActivate_Meta Instance;
}
