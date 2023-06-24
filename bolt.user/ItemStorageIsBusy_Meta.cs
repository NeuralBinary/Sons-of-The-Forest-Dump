using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20002B3")]
internal class ItemStorageIsBusy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ItemStorageIsBusy_Meta()
	{
	}

	// Token: 0x1700085E RID: 2142
	// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00008FB8 File Offset: 0x000071B8
	[Token(Token = "0x1700085E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700085F RID: 2143
	// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00008FD0 File Offset: 0x000071D0
	[Token(Token = "0x1700085F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x7FFF50", Offset = "0x7FE550", VA = "0x1807FFF50", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000860 RID: 2144
	// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000860")]
	private Type TypeObject
	{
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x7FFF70", Offset = "0x7FE570", VA = "0x1807FFF70", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x800010", Offset = "0x7FE610", VA = "0x180800010", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x800300", Offset = "0x7FE900", VA = "0x180800300", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x800390", Offset = "0x7FE990", VA = "0x180800390", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemStorageIsBusy_Meta Instance;
}
