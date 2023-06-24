using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
internal class SetJoiningTimeOfDay_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600144E RID: 5198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetJoiningTimeOfDay_Meta()
	{
	}

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x0600144F RID: 5199 RVA: 0x00006E58 File Offset: 0x00005058
	[Token(Token = "0x17000666")]
	private TypeId TypeId
	{
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x06001450 RID: 5200 RVA: 0x00006E70 File Offset: 0x00005070
	[Token(Token = "0x17000667")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x89C7A0", Offset = "0x89ADA0", VA = "0x18089C7A0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x06001451 RID: 5201 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000668")]
	private Type TypeObject
	{
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x89C7C0", Offset = "0x89ADC0", VA = "0x18089C7C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001452")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x89C860", Offset = "0x89AE60", VA = "0x18089C860", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x89CA60", Offset = "0x89B060", VA = "0x18089CA60", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x89CAF0", Offset = "0x89B0F0", VA = "0x18089CAF0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x0")]
	internal static SetJoiningTimeOfDay_Meta Instance;
}
