using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
internal class FreeFormStructureCreated_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureCreated_Meta()
	{
	}

	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00006FD8 File Offset: 0x000051D8
	[Token(Token = "0x1700067D")]
	private TypeId TypeId
	{
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x060014C2 RID: 5314 RVA: 0x00006FF0 File Offset: 0x000051F0
	[Token(Token = "0x1700067E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x8A0570", Offset = "0x89EB70", VA = "0x1808A0570", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700067F")]
	private Type TypeObject
	{
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x8A0590", Offset = "0x89EB90", VA = "0x1808A0590", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x8A0630", Offset = "0x89EC30", VA = "0x1808A0630", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x8A0FA0", Offset = "0x89F5A0", VA = "0x1808A0FA0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x8A1030", Offset = "0x89F630", VA = "0x1808A1030", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureCreated_Meta Instance;
}
