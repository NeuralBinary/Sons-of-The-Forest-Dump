using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200023B RID: 571
[Token(Token = "0x200023B")]
internal class TerrainDigNodeAdded_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001A58 RID: 6744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TerrainDigNodeAdded_Meta()
	{
	}

	// Token: 0x17000789 RID: 1929
	// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00008280 File Offset: 0x00006480
	[Token(Token = "0x17000789")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700078A RID: 1930
	// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00008298 File Offset: 0x00006498
	[Token(Token = "0x1700078A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x8D11D0", Offset = "0x8CF7D0", VA = "0x1808D11D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700078B RID: 1931
	// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700078B")]
	private Type TypeObject
	{
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x8D11F0", Offset = "0x8CF7F0", VA = "0x1808D11F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x8D1290", Offset = "0x8CF890", VA = "0x1808D1290", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x8D1930", Offset = "0x8CFF30", VA = "0x1808D1930", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x8D19C0", Offset = "0x8CFFC0", VA = "0x1808D19C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x0")]
	internal static TerrainDigNodeAdded_Meta Instance;
}
