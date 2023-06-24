using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200027A RID: 634
[Token(Token = "0x200027A")]
internal class StructureCraftingNodeAddIngredientRejected_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StructureCraftingNodeAddIngredientRejected_Meta()
	{
	}

	// Token: 0x170007FC RID: 2044
	// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00008970 File Offset: 0x00006B70
	[Token(Token = "0x170007FC")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007FD RID: 2045
	// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00008988 File Offset: 0x00006B88
	[Token(Token = "0x170007FD")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x7EDC40", Offset = "0x7EC240", VA = "0x1807EDC40", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007FE RID: 2046
	// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007FE")]
	private Type TypeObject
	{
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x7EDC60", Offset = "0x7EC260", VA = "0x1807EDC60", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D2F")]
	[Address(RVA = "0x7EDD00", Offset = "0x7EC300", VA = "0x1807EDD00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x7EDEF0", Offset = "0x7EC4F0", VA = "0x1807EDEF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x7EDF80", Offset = "0x7EC580", VA = "0x1807EDF80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x0")]
	internal static StructureCraftingNodeAddIngredientRejected_Meta Instance;
}
