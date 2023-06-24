using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000100 RID: 256
[Token(Token = "0x2000100")]
internal class TrapResetEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TrapResetEvent_Meta()
	{
	}

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x17000518")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x17000519")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x8563F0", Offset = "0x8549F0", VA = "0x1808563F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700051A")]
	private Type TypeObject
	{
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x856410", Offset = "0x854A10", VA = "0x180856410", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x8564B0", Offset = "0x854AB0", VA = "0x1808564B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x8566A0", Offset = "0x854CA0", VA = "0x1808566A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x856730", Offset = "0x854D30", VA = "0x180856730", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000278 RID: 632
	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x0")]
	internal static TrapResetEvent_Meta Instance;
}
