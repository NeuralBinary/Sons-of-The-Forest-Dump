using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
internal class SetTrappedEnemy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060013CC RID: 5068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetTrappedEnemy_Meta()
	{
	}

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x060013CD RID: 5069 RVA: 0x00006D50 File Offset: 0x00004F50
	[Token(Token = "0x17000653")]
	private TypeId TypeId
	{
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x060013CE RID: 5070 RVA: 0x00006D68 File Offset: 0x00004F68
	[Token(Token = "0x17000654")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x898920", Offset = "0x896F20", VA = "0x180898920", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x060013CF RID: 5071 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000655")]
	private Type TypeObject
	{
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x898940", Offset = "0x896F40", VA = "0x180898940", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x8989E0", Offset = "0x896FE0", VA = "0x1808989E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x898CD0", Offset = "0x8972D0", VA = "0x180898CD0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x898D60", Offset = "0x897360", VA = "0x180898D60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x0")]
	internal static SetTrappedEnemy_Meta Instance;
}
