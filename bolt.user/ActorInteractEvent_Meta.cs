using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000247 RID: 583
[Token(Token = "0x2000247")]
internal class ActorInteractEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001AF0 RID: 6896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ActorInteractEvent_Meta()
	{
	}

	// Token: 0x170007A5 RID: 1957
	// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00008418 File Offset: 0x00006618
	[Token(Token = "0x170007A5")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007A6 RID: 1958
	// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00008430 File Offset: 0x00006630
	[Token(Token = "0x170007A6")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x7DBF00", Offset = "0x7DA500", VA = "0x1807DBF00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007A7 RID: 1959
	// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007A7")]
	private Type TypeObject
	{
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x7DBF20", Offset = "0x7DA520", VA = "0x1807DBF20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x7DBFC0", Offset = "0x7DA5C0", VA = "0x1807DBFC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x7DC2B0", Offset = "0x7DA8B0", VA = "0x1807DC2B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x7DC340", Offset = "0x7DA940", VA = "0x1807DC340", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x0")]
	internal static ActorInteractEvent_Meta Instance;
}
