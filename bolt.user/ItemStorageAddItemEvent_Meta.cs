using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000241 RID: 577
[Token(Token = "0x2000241")]
internal class ItemStorageAddItemEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001AA6 RID: 6822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ItemStorageAddItemEvent_Meta()
	{
	}

	// Token: 0x17000798 RID: 1944
	// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x00008358 File Offset: 0x00006558
	[Token(Token = "0x17000798")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000799 RID: 1945
	// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00008370 File Offset: 0x00006570
	[Token(Token = "0x17000799")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x7D93F0", Offset = "0x7D79F0", VA = "0x1807D93F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700079A RID: 1946
	// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700079A")]
	private Type TypeObject
	{
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x7D9410", Offset = "0x7D7A10", VA = "0x1807D9410", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x7D94B0", Offset = "0x7D7AB0", VA = "0x1807D94B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x7D9B00", Offset = "0x7D8100", VA = "0x1807D9B00", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x7D9B90", Offset = "0x7D8190", VA = "0x1807D9B90", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemStorageAddItemEvent_Meta Instance;
}
