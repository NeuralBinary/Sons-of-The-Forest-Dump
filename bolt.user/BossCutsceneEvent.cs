using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B8 RID: 696
[Token(Token = "0x20002B8")]
public class BossCutsceneEvent : Event
{
	// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0x801930", Offset = "0x7FFF30", VA = "0x180801930")]
	public BossCutsceneEvent()
	{
	}

	// Token: 0x17000867 RID: 2151
	// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00009048 File Offset: 0x00007248
	// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000867")]
	public int Type
	{
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x801990", Offset = "0x7FFF90", VA = "0x180801990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x801A40", Offset = "0x800040", VA = "0x180801A40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x801A50", Offset = "0x800050", VA = "0x180801A50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x801C50", Offset = "0x800250", VA = "0x180801C50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static BossCutsceneEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x801D70", Offset = "0x800370", VA = "0x180801D70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x801D80", Offset = "0x800380", VA = "0x180801D80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x801D90", Offset = "0x800390", VA = "0x180801D90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x801DA0", Offset = "0x8003A0", VA = "0x180801DA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x801DC0", Offset = "0x8003C0", VA = "0x180801DC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise()
	{
		return null;
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x801DE0", Offset = "0x8003E0", VA = "0x180801DE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BossCutsceneEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x801A40", Offset = "0x800040", VA = "0x180801A40")]
	public static BossCutsceneEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x801DF0", Offset = "0x8003F0", VA = "0x180801DF0")]
	public static BossCutsceneEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x801FF0", Offset = "0x8005F0", VA = "0x180801FF0")]
	private static BossCutsceneEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x801D70", Offset = "0x800370", VA = "0x180801D70")]
	public static BossCutsceneEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x801D80", Offset = "0x800380", VA = "0x180801D80")]
	public static BossCutsceneEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x801D90", Offset = "0x800390", VA = "0x180801D90")]
	public static BossCutsceneEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x801DA0", Offset = "0x8003A0", VA = "0x180801DA0")]
	public static BossCutsceneEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x801DC0", Offset = "0x8003C0", VA = "0x180801DC0")]
	public static BossCutsceneEvent Create()
	{
		return null;
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x801DE0", Offset = "0x8003E0", VA = "0x180801DE0")]
	public static BossCutsceneEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
