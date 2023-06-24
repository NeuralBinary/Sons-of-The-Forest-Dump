using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200025C RID: 604
[Token(Token = "0x200025C")]
internal class GardenPlotClearPlot_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001BE4 RID: 7140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public GardenPlotClearPlot_Meta()
	{
	}

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x170007CB")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000086B8 File Offset: 0x000068B8
	[Token(Token = "0x170007CC")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0x7E4070", Offset = "0x7E2670", VA = "0x1807E4070", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007CD")]
	private Type TypeObject
	{
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x7E4090", Offset = "0x7E2690", VA = "0x1807E4090", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x7E4130", Offset = "0x7E2730", VA = "0x1807E4130", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x7E4320", Offset = "0x7E2920", VA = "0x1807E4320", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x7E43B0", Offset = "0x7E29B0", VA = "0x1807E43B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x0")]
	internal static GardenPlotClearPlot_Meta Instance;
}
