using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
internal class PlaceConstruction_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000850 RID: 2128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlaceConstruction_Meta()
	{
	}

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06000851 RID: 2129 RVA: 0x00005178 File Offset: 0x00003378
	[Token(Token = "0x17000481")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06000852 RID: 2130 RVA: 0x00005190 File Offset: 0x00003390
	[Token(Token = "0x17000482")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x836D30", Offset = "0x835330", VA = "0x180836D30", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06000853 RID: 2131 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000483")]
	private Type TypeObject
	{
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x836D50", Offset = "0x835350", VA = "0x180836D50", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x836DF0", Offset = "0x8353F0", VA = "0x180836DF0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x837750", Offset = "0x835D50", VA = "0x180837750", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x8377E0", Offset = "0x835DE0", VA = "0x1808377E0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x0")]
	internal static PlaceConstruction_Meta Instance;
}
