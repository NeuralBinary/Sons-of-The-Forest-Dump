using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
internal class SkinnedAnimal_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SkinnedAnimal_Meta()
	{
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x060009BF RID: 2495 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x170004CC")]
	private TypeId TypeId
	{
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x060009C0 RID: 2496 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x170004CD")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x845F10", Offset = "0x844510", VA = "0x180845F10", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004CE")]
	private Type TypeObject
	{
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x845F30", Offset = "0x844530", VA = "0x180845F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x845FD0", Offset = "0x8445D0", VA = "0x180845FD0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x8461C0", Offset = "0x8447C0", VA = "0x1808461C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x846250", Offset = "0x844850", VA = "0x180846250", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000268 RID: 616
	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x0")]
	internal static SkinnedAnimal_Meta Instance;
}
