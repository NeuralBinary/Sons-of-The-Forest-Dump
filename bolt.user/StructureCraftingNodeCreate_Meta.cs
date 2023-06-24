using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000238 RID: 568
[Token(Token = "0x2000238")]
internal class StructureCraftingNodeCreate_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001A32 RID: 6706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StructureCraftingNodeCreate_Meta()
	{
	}

	// Token: 0x17000782 RID: 1922
	// (get) Token: 0x06001A33 RID: 6707 RVA: 0x000081F0 File Offset: 0x000063F0
	[Token(Token = "0x17000782")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000783 RID: 1923
	// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00008208 File Offset: 0x00006408
	[Token(Token = "0x17000783")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x8CFA00", Offset = "0x8CE000", VA = "0x1808CFA00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000784")]
	private Type TypeObject
	{
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x8CFA20", Offset = "0x8CE020", VA = "0x1808CFA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x8CFAC0", Offset = "0x8CE0C0", VA = "0x1808CFAC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x8D01F0", Offset = "0x8CE7F0", VA = "0x1808D01F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x8D0280", Offset = "0x8CE880", VA = "0x1808D0280", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x0")]
	internal static StructureCraftingNodeCreate_Meta Instance;
}
