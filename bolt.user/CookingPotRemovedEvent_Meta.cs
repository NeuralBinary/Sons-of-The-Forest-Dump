using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002A1 RID: 673
[Token(Token = "0x20002A1")]
internal class CookingPotRemovedEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CookingPotRemovedEvent_Meta()
	{
	}

	// Token: 0x17000841 RID: 2113
	// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00008DD8 File Offset: 0x00006FD8
	[Token(Token = "0x17000841")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000842 RID: 2114
	// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00008DF0 File Offset: 0x00006FF0
	[Token(Token = "0x17000842")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x7FA720", Offset = "0x7F8D20", VA = "0x1807FA720", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000843 RID: 2115
	// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000843")]
	private Type TypeObject
	{
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x7FA740", Offset = "0x7F8D40", VA = "0x1807FA740", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0x7FA7E0", Offset = "0x7F8DE0", VA = "0x1807FA7E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0x7FA9D0", Offset = "0x7F8FD0", VA = "0x1807FA9D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EDB")]
	[Address(RVA = "0x7FAA60", Offset = "0x7F9060", VA = "0x1807FAA60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x0")]
	internal static CookingPotRemovedEvent_Meta Instance;
}
