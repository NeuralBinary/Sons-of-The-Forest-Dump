using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200017E")]
internal class DropBodyEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DropBodyEvent_Meta()
	{
	}

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x0600117F RID: 4479 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x170005F6")]
	private TypeId TypeId
	{
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x06001180 RID: 4480 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x170005F7")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001180")]
		[Address(RVA = "0x885510", Offset = "0x883B10", VA = "0x180885510", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x06001181 RID: 4481 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005F8")]
	private Type TypeObject
	{
		[Token(Token = "0x6001181")]
		[Address(RVA = "0x885530", Offset = "0x883B30", VA = "0x180885530", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001183")]
	[Address(RVA = "0x8855D0", Offset = "0x883BD0", VA = "0x1808855D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x885DE0", Offset = "0x8843E0", VA = "0x180885DE0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x885E70", Offset = "0x884470", VA = "0x180885E70", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x0")]
	internal static DropBodyEvent_Meta Instance;
}
