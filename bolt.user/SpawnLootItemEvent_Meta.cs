using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200020E RID: 526
[Token(Token = "0x200020E")]
internal class SpawnLootItemEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600183E RID: 6206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SpawnLootItemEvent_Meta()
	{
	}

	// Token: 0x17000730 RID: 1840
	// (get) Token: 0x0600183F RID: 6207 RVA: 0x00007C98 File Offset: 0x00005E98
	[Token(Token = "0x17000730")]
	private TypeId TypeId
	{
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000731 RID: 1841
	// (get) Token: 0x06001840 RID: 6208 RVA: 0x00007CB0 File Offset: 0x00005EB0
	[Token(Token = "0x17000731")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x8BF5C0", Offset = "0x8BDBC0", VA = "0x1808BF5C0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000732 RID: 1842
	// (get) Token: 0x06001841 RID: 6209 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000732")]
	private Type TypeObject
	{
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x8BF5E0", Offset = "0x8BDBE0", VA = "0x1808BF5E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x8BF680", Offset = "0x8BDC80", VA = "0x1808BF680", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x8BFCA0", Offset = "0x8BE2A0", VA = "0x1808BFCA0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x8BFD30", Offset = "0x8BE330", VA = "0x1808BFD30", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x0")]
	internal static SpawnLootItemEvent_Meta Instance;
}
