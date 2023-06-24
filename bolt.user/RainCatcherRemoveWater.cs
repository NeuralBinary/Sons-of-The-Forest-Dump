using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200028B RID: 651
[Token(Token = "0x200028B")]
public class RainCatcherRemoveWater : Event
{
	// Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x7F2160", Offset = "0x7F0760", VA = "0x1807F2160")]
	public RainCatcherRemoveWater()
	{
	}

	// Token: 0x17000818 RID: 2072
	// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00008B50 File Offset: 0x00006D50
	// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000818")]
	public float Amount
	{
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x7F21C0", Offset = "0x7F07C0", VA = "0x1807F21C0")]
		set
		{
		}
	}

	// Token: 0x17000819 RID: 2073
	// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000819")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x7F2270", Offset = "0x7F0870", VA = "0x1807F2270")]
		set
		{
		}
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x7F2480", Offset = "0x7F0A80", VA = "0x1807F2480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x7F2540", Offset = "0x7F0B40", VA = "0x1807F2540")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x7F2550", Offset = "0x7F0B50", VA = "0x1807F2550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x7F2750", Offset = "0x7F0D50", VA = "0x1807F2750")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RainCatcherRemoveWater Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x7F2870", Offset = "0x7F0E70", VA = "0x1807F2870")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x7F2880", Offset = "0x7F0E80", VA = "0x1807F2880")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x7F2890", Offset = "0x7F0E90", VA = "0x1807F2890")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x7F28A0", Offset = "0x7F0EA0", VA = "0x1807F28A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x7F28C0", Offset = "0x7F0EC0", VA = "0x1807F28C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise()
	{
		return null;
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x7F28E0", Offset = "0x7F0EE0", VA = "0x1807F28E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherRemoveWater Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x7F2540", Offset = "0x7F0B40", VA = "0x1807F2540")]
	public static RainCatcherRemoveWater Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x7F28F0", Offset = "0x7F0EF0", VA = "0x1807F28F0")]
	public static RainCatcherRemoveWater Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x7F2AF0", Offset = "0x7F10F0", VA = "0x1807F2AF0")]
	private static RainCatcherRemoveWater Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x7F2870", Offset = "0x7F0E70", VA = "0x1807F2870")]
	public static RainCatcherRemoveWater Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x7F2880", Offset = "0x7F0E80", VA = "0x1807F2880")]
	public static RainCatcherRemoveWater Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DE1")]
	[Address(RVA = "0x7F2890", Offset = "0x7F0E90", VA = "0x1807F2890")]
	public static RainCatcherRemoveWater Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DE2")]
	[Address(RVA = "0x7F28A0", Offset = "0x7F0EA0", VA = "0x1807F28A0")]
	public static RainCatcherRemoveWater Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x7F28C0", Offset = "0x7F0EC0", VA = "0x1807F28C0")]
	public static RainCatcherRemoveWater Create()
	{
		return null;
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0x7F28E0", Offset = "0x7F0EE0", VA = "0x1807F28E0")]
	public static RainCatcherRemoveWater Create(ReliabilityModes reliability)
	{
		return null;
	}
}
