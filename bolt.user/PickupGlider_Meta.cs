using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001C3 RID: 451
[Token(Token = "0x20001C3")]
internal class PickupGlider_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PickupGlider_Meta()
	{
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x06001499 RID: 5273 RVA: 0x00006F30 File Offset: 0x00005130
	[Token(Token = "0x17000673")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x0600149A RID: 5274 RVA: 0x00006F48 File Offset: 0x00005148
	[Token(Token = "0x17000674")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x89EB40", Offset = "0x89D140", VA = "0x18089EB40", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x0600149B RID: 5275 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000675")]
	private Type TypeObject
	{
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x89EB60", Offset = "0x89D160", VA = "0x18089EB60", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600149C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600149D")]
	[Address(RVA = "0x89EC00", Offset = "0x89D200", VA = "0x18089EC00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600149E")]
	[Address(RVA = "0x89F520", Offset = "0x89DB20", VA = "0x18089F520", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600149F")]
	[Address(RVA = "0x89F5B0", Offset = "0x89DBB0", VA = "0x18089F5B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x0")]
	internal static PickupGlider_Meta Instance;
}
