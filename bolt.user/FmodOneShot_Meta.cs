using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000FD RID: 253
[Token(Token = "0x20000FD")]
internal class FmodOneShot_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FmodOneShot_Meta()
	{
	}

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x17000514")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00005B50 File Offset: 0x00003D50
	[Token(Token = "0x17000515")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x855310", Offset = "0x853910", VA = "0x180855310", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000516")]
	private Type TypeObject
	{
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x855330", Offset = "0x853930", VA = "0x180855330", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x8553D0", Offset = "0x8539D0", VA = "0x1808553D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x8557A0", Offset = "0x853DA0", VA = "0x1808557A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x855830", Offset = "0x853E30", VA = "0x180855830", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x0")]
	internal static FmodOneShot_Meta Instance;
}
