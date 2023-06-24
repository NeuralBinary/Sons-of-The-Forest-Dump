using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
internal class WorldObjectLocatorRequestAllData_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001666 RID: 5734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public WorldObjectLocatorRequestAllData_Meta()
	{
	}

	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x06001667 RID: 5735 RVA: 0x000075A8 File Offset: 0x000057A8
	[Token(Token = "0x170006CE")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006CF RID: 1743
	// (get) Token: 0x06001668 RID: 5736 RVA: 0x000075C0 File Offset: 0x000057C0
	[Token(Token = "0x170006CF")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x8AE730", Offset = "0x8ACD30", VA = "0x1808AE730", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x06001669 RID: 5737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006D0")]
	private Type TypeObject
	{
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x8AE750", Offset = "0x8ACD50", VA = "0x1808AE750", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x8AE7F0", Offset = "0x8ACDF0", VA = "0x1808AE7F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x8AE8A0", Offset = "0x8ACEA0", VA = "0x1808AE8A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x8AE930", Offset = "0x8ACF30", VA = "0x1808AE930", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C6 RID: 710
	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x0")]
	internal static WorldObjectLocatorRequestAllData_Meta Instance;
}
