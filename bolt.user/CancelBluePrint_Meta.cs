using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000103 RID: 259
[Token(Token = "0x2000103")]
internal class CancelBluePrint_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CancelBluePrint_Meta()
	{
	}

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00005B98 File Offset: 0x00003D98
	[Token(Token = "0x1700051C")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x1700051D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x857360", Offset = "0x855960", VA = "0x180857360", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700051E")]
	private Type TypeObject
	{
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x857380", Offset = "0x855980", VA = "0x180857380", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x857420", Offset = "0x855A20", VA = "0x180857420", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x857610", Offset = "0x855C10", VA = "0x180857610", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x8576A0", Offset = "0x855CA0", VA = "0x1808576A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x0")]
	internal static CancelBluePrint_Meta Instance;
}
