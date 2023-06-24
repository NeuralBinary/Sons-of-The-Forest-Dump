using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000118 RID: 280
[Token(Token = "0x2000118")]
internal class SledGrab_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SledGrab_Meta()
	{
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00005E20 File Offset: 0x00004020
	[Token(Token = "0x17000548")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00005E38 File Offset: 0x00004038
	[Token(Token = "0x17000549")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x860170", Offset = "0x85E770", VA = "0x180860170", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700054A")]
	private Type TypeObject
	{
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x860190", Offset = "0x85E790", VA = "0x180860190", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x860230", Offset = "0x85E830", VA = "0x180860230", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x860520", Offset = "0x85EB20", VA = "0x180860520", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x8605B0", Offset = "0x85EBB0", VA = "0x1808605B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000280 RID: 640
	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x0")]
	internal static SledGrab_Meta Instance;
}
