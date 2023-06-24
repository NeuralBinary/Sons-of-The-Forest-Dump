using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200020B RID: 523
[Token(Token = "0x200020B")]
internal class FreeFormPlaceElement_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001818 RID: 6168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001818")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormPlaceElement_Meta()
	{
	}

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x06001819 RID: 6169 RVA: 0x00007C08 File Offset: 0x00005E08
	[Token(Token = "0x17000729")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x0600181A RID: 6170 RVA: 0x00007C20 File Offset: 0x00005E20
	[Token(Token = "0x1700072A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x8BC930", Offset = "0x8BAF30", VA = "0x1808BC930", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x0600181B RID: 6171 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700072B")]
	private Type TypeObject
	{
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x8BC950", Offset = "0x8BAF50", VA = "0x1808BC950", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600181C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600181D")]
	[Address(RVA = "0x8BC9F0", Offset = "0x8BAFF0", VA = "0x1808BC9F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600181E")]
	[Address(RVA = "0x8BE8A0", Offset = "0x8BCEA0", VA = "0x1808BE8A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600181F")]
	[Address(RVA = "0x8BE930", Offset = "0x8BCF30", VA = "0x1808BE930", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormPlaceElement_Meta Instance;
}
