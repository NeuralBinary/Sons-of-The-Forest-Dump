using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200019F RID: 415
[Token(Token = "0x200019F")]
internal class stuckArrowsSync_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001302 RID: 4866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public stuckArrowsSync_Meta()
	{
	}

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x06001303 RID: 4867 RVA: 0x00006BA0 File Offset: 0x00004DA0
	[Token(Token = "0x17000634")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x06001304 RID: 4868 RVA: 0x00006BB8 File Offset: 0x00004DB8
	[Token(Token = "0x17000635")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001304")]
		[Address(RVA = "0x8921D0", Offset = "0x8907D0", VA = "0x1808921D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x06001305 RID: 4869 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000636")]
	private Type TypeObject
	{
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x8921F0", Offset = "0x8907F0", VA = "0x1808921F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x892290", Offset = "0x890890", VA = "0x180892290", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x892BF0", Offset = "0x8911F0", VA = "0x180892BF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x892C80", Offset = "0x891280", VA = "0x180892C80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x0")]
	internal static stuckArrowsSync_Meta Instance;
}
