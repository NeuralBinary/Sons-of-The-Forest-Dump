using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
internal class syncWorkBench_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600134E RID: 4942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public syncWorkBench_Meta()
	{
	}

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x0600134F RID: 4943 RVA: 0x00006C60 File Offset: 0x00004E60
	[Token(Token = "0x17000642")]
	private TypeId TypeId
	{
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x06001350 RID: 4944 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x17000643")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x894E50", Offset = "0x893450", VA = "0x180894E50", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x06001351 RID: 4945 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000644")]
	private Type TypeObject
	{
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x894E70", Offset = "0x893470", VA = "0x180894E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001352")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x894F10", Offset = "0x893510", VA = "0x180894F10", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x895530", Offset = "0x893B30", VA = "0x180895530", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x8955C0", Offset = "0x893BC0", VA = "0x1808955C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x0")]
	internal static syncWorkBench_Meta Instance;
}
