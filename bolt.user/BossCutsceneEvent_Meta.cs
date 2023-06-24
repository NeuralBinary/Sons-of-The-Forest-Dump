using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
internal class BossCutsceneEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public BossCutsceneEvent_Meta()
	{
	}

	// Token: 0x17000868 RID: 2152
	// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00009060 File Offset: 0x00007260
	[Token(Token = "0x17000868")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000869 RID: 2153
	// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00009078 File Offset: 0x00007278
	[Token(Token = "0x17000869")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x802220", Offset = "0x800820", VA = "0x180802220", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700086A RID: 2154
	// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700086A")]
	private Type TypeObject
	{
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x802240", Offset = "0x800840", VA = "0x180802240", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x8022E0", Offset = "0x8008E0", VA = "0x1808022E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x8024E0", Offset = "0x800AE0", VA = "0x1808024E0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x802570", Offset = "0x800B70", VA = "0x180802570", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400030B RID: 779
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x0")]
	internal static BossCutsceneEvent_Meta Instance;
}
