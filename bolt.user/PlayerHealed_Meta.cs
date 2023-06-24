using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
internal class PlayerHealed_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000C14 RID: 3092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerHealed_Meta()
	{
	}

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x17000521")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00005BF8 File Offset: 0x00003DF8
	[Token(Token = "0x17000522")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x8582D0", Offset = "0x8568D0", VA = "0x1808582D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000523")]
	private Type TypeObject
	{
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x8582F0", Offset = "0x8568F0", VA = "0x1808582F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x858390", Offset = "0x856990", VA = "0x180858390", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x8586A0", Offset = "0x856CA0", VA = "0x1808586A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x858730", Offset = "0x856D30", VA = "0x180858730", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerHealed_Meta Instance;
}
