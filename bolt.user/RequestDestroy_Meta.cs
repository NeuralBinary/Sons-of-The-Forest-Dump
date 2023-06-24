using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D3 RID: 211
[Token(Token = "0x20000D3")]
internal class RequestDestroy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RequestDestroy_Meta()
	{
	}

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x060009DF RID: 2527 RVA: 0x000056E8 File Offset: 0x000038E8
	[Token(Token = "0x170004D0")]
	private TypeId TypeId
	{
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x170004D1")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x846E10", Offset = "0x845410", VA = "0x180846E10", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004D2")]
	private Type TypeObject
	{
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x846E30", Offset = "0x845430", VA = "0x180846E30", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x846ED0", Offset = "0x8454D0", VA = "0x180846ED0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x8470C0", Offset = "0x8456C0", VA = "0x1808470C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x847150", Offset = "0x845750", VA = "0x180847150", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x0")]
	internal static RequestDestroy_Meta Instance;
}
