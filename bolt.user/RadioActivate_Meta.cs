using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
internal class RadioActivate_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001860 RID: 6240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001860")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RadioActivate_Meta()
	{
	}

	// Token: 0x17000735 RID: 1845
	// (get) Token: 0x06001861 RID: 6241 RVA: 0x00007CE0 File Offset: 0x00005EE0
	[Token(Token = "0x17000735")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000736 RID: 1846
	// (get) Token: 0x06001862 RID: 6242 RVA: 0x00007CF8 File Offset: 0x00005EF8
	[Token(Token = "0x17000736")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x8C0960", Offset = "0x8BEF60", VA = "0x1808C0960", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000737 RID: 1847
	// (get) Token: 0x06001863 RID: 6243 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000737")]
	private Type TypeObject
	{
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x8C0980", Offset = "0x8BEF80", VA = "0x1808C0980", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x8C0A20", Offset = "0x8BF020", VA = "0x1808C0A20", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x8C0D20", Offset = "0x8BF320", VA = "0x1808C0D20", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001867")]
	[Address(RVA = "0x8C0DB0", Offset = "0x8BF3B0", VA = "0x1808C0DB0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x0")]
	internal static RadioActivate_Meta Instance;
}
