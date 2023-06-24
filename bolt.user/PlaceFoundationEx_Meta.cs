using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
internal class PlaceFoundationEx_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000CD0 RID: 3280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlaceFoundationEx_Meta()
	{
	}

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00005DF0 File Offset: 0x00003FF0
	[Token(Token = "0x17000543")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00005E08 File Offset: 0x00004008
	[Token(Token = "0x17000544")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x85EB10", Offset = "0x85D110", VA = "0x18085EB10", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000545")]
	private Type TypeObject
	{
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x85EB30", Offset = "0x85D130", VA = "0x18085EB30", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x85EBD0", Offset = "0x85D1D0", VA = "0x18085EBD0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x85F300", Offset = "0x85D900", VA = "0x18085F300", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x85F390", Offset = "0x85D990", VA = "0x18085F390", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400027F RID: 639
	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x0")]
	internal static PlaceFoundationEx_Meta Instance;
}
