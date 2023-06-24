using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200027D RID: 637
[Token(Token = "0x200027D")]
internal class FreeFormStructureDamagedStatus_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureDamagedStatus_Meta()
	{
	}

	// Token: 0x17000803 RID: 2051
	// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00008A00 File Offset: 0x00006C00
	[Token(Token = "0x17000803")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000804 RID: 2052
	// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00008A18 File Offset: 0x00006C18
	[Token(Token = "0x17000804")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x7EE960", Offset = "0x7ECF60", VA = "0x1807EE960", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000805 RID: 2053
	// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000805")]
	private Type TypeObject
	{
		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x7EE980", Offset = "0x7ECF80", VA = "0x1807EE980", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D50")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x7EEA20", Offset = "0x7ED020", VA = "0x1807EEA20", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x7EEF70", Offset = "0x7ED570", VA = "0x1807EEF70", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x7EF000", Offset = "0x7ED600", VA = "0x1807EF000", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureDamagedStatus_Meta Instance;
}
