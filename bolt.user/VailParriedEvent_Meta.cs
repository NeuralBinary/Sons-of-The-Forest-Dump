using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200022F RID: 559
[Token(Token = "0x200022F")]
internal class VailParriedEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailParriedEvent_Meta()
	{
	}

	// Token: 0x17000770 RID: 1904
	// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000080A0 File Offset: 0x000062A0
	[Token(Token = "0x17000770")]
	private TypeId TypeId
	{
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000771 RID: 1905
	// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000080B8 File Offset: 0x000062B8
	[Token(Token = "0x17000771")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x8CC4E0", Offset = "0x8CAAE0", VA = "0x1808CC4E0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000772 RID: 1906
	// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000772")]
	private Type TypeObject
	{
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x8CC500", Offset = "0x8CAB00", VA = "0x1808CC500", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x8CC5A0", Offset = "0x8CABA0", VA = "0x1808CC5A0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x8CC8B0", Offset = "0x8CAEB0", VA = "0x1808CC8B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x8CC940", Offset = "0x8CAF40", VA = "0x1808CC940", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x0")]
	internal static VailParriedEvent_Meta Instance;
}
