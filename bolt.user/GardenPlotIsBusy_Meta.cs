using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200022C RID: 556
[Token(Token = "0x200022C")]
internal class GardenPlotIsBusy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060019A4 RID: 6564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public GardenPlotIsBusy_Meta()
	{
	}

	// Token: 0x1700076B RID: 1899
	// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00008058 File Offset: 0x00006258
	[Token(Token = "0x1700076B")]
	private TypeId TypeId
	{
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700076C RID: 1900
	// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00008070 File Offset: 0x00006270
	[Token(Token = "0x1700076C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x8CB470", Offset = "0x8C9A70", VA = "0x1808CB470", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700076D RID: 1901
	// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700076D")]
	private Type TypeObject
	{
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x8CB490", Offset = "0x8C9A90", VA = "0x1808CB490", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x8CB530", Offset = "0x8C9B30", VA = "0x1808CB530", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x8CB820", Offset = "0x8C9E20", VA = "0x1808CB820", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x8CB8B0", Offset = "0x8C9EB0", VA = "0x1808CB8B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x0")]
	internal static GardenPlotIsBusy_Meta Instance;
}
