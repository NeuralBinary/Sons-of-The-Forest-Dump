using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200013F RID: 319
[Token(Token = "0x200013F")]
internal class RemoveWater_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RemoveWater_Meta()
	{
	}

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00006210 File Offset: 0x00004410
	[Token(Token = "0x1700058E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x1700058F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x86F170", Offset = "0x86D770", VA = "0x18086F170", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000590")]
	private Type TypeObject
	{
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x86F190", Offset = "0x86D790", VA = "0x18086F190", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x86F540", Offset = "0x86DB40", VA = "0x18086F540", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x86F5D0", Offset = "0x86DBD0", VA = "0x18086F5D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x0")]
	internal static RemoveWater_Meta Instance;
}
