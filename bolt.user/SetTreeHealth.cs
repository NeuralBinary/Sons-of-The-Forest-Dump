using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x20000B7")]
public class SetTreeHealth : Event
{
	// Token: 0x06000859 RID: 2137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x837900", Offset = "0x835F00", VA = "0x180837900")]
	public SetTreeHealth()
	{
	}

	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x0600085A RID: 2138 RVA: 0x000051A8 File Offset: 0x000033A8
	// (set) Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000484")]
	public NetworkId TreeId
	{
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x7BA0A0", Offset = "0x7B86A0", VA = "0x1807BA0A0")]
		get
		{
			return default(NetworkId);
		}
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x7F5BE0", Offset = "0x7F41E0", VA = "0x1807F5BE0")]
		set
		{
		}
	}

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x0600085C RID: 2140 RVA: 0x000051C0 File Offset: 0x000033C0
	// (set) Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000485")]
	public int Health
	{
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x837960", Offset = "0x835F60", VA = "0x180837960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x837A80", Offset = "0x836080", VA = "0x180837A80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x837A90", Offset = "0x836090", VA = "0x180837A90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x837C90", Offset = "0x836290", VA = "0x180837C90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SetTreeHealth Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x837E20", Offset = "0x836420", VA = "0x180837E20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x837E30", Offset = "0x836430", VA = "0x180837E30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x837E40", Offset = "0x836440", VA = "0x180837E40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000865")]
	[Address(RVA = "0x837E50", Offset = "0x836450", VA = "0x180837E50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000866")]
	[Address(RVA = "0x837E70", Offset = "0x836470", VA = "0x180837E70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise()
	{
		return null;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x837E90", Offset = "0x836490", VA = "0x180837E90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTreeHealth Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000868")]
	[Address(RVA = "0x837A80", Offset = "0x836080", VA = "0x180837A80")]
	public static SetTreeHealth Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x837EA0", Offset = "0x8364A0", VA = "0x180837EA0")]
	public static SetTreeHealth Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086A")]
	[Address(RVA = "0x8380A0", Offset = "0x8366A0", VA = "0x1808380A0")]
	private static SetTreeHealth Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086B")]
	[Address(RVA = "0x837E20", Offset = "0x836420", VA = "0x180837E20")]
	public static SetTreeHealth Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x837E30", Offset = "0x836430", VA = "0x180837E30")]
	public static SetTreeHealth Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x837E40", Offset = "0x836440", VA = "0x180837E40")]
	public static SetTreeHealth Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x837E50", Offset = "0x836450", VA = "0x180837E50")]
	public static SetTreeHealth Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x837E70", Offset = "0x836470", VA = "0x180837E70")]
	public static SetTreeHealth Create()
	{
		return null;
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x837E90", Offset = "0x836490", VA = "0x180837E90")]
	public static SetTreeHealth Create(ReliabilityModes reliability)
	{
		return null;
	}
}
