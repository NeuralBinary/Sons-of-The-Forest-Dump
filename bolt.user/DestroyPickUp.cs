using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000BA RID: 186
[Token(Token = "0x20000BA")]
public class DestroyPickUp : Event
{
	// Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600087B")]
	[Address(RVA = "0x8388C0", Offset = "0x836EC0", VA = "0x1808388C0")]
	public DestroyPickUp()
	{
	}

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x0600087C RID: 2172 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000489")]
	public BoltEntity PickUpEntity
	{
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x838920", Offset = "0x836F20", VA = "0x180838920")]
		set
		{
		}
	}

	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x0600087E RID: 2174 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048A")]
	public BoltEntity PickUpPlayer
	{
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x838B30", Offset = "0x837130", VA = "0x180838B30")]
		set
		{
		}
	}

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06000880 RID: 2176 RVA: 0x00005208 File Offset: 0x00003408
	// (set) Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048B")]
	public int ItemId
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06000882 RID: 2178 RVA: 0x00005220 File Offset: 0x00003420
	// (set) Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048C")]
	public int SibblingId
	{
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x838D40", Offset = "0x837340", VA = "0x180838D40")]
		set
		{
		}
	}

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06000884 RID: 2180 RVA: 0x00005238 File Offset: 0x00003438
	// (set) Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048D")]
	public bool FakeDrop
	{
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000886")]
	[Address(RVA = "0x838DF0", Offset = "0x8373F0", VA = "0x180838DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000887")]
	[Address(RVA = "0x8390F0", Offset = "0x8376F0", VA = "0x1808390F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000888")]
	[Address(RVA = "0x839100", Offset = "0x837700", VA = "0x180839100")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000889")]
	[Address(RVA = "0x839300", Offset = "0x837900", VA = "0x180839300")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DestroyPickUp Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x839420", Offset = "0x837A20", VA = "0x180839420")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600088B")]
	[Address(RVA = "0x839430", Offset = "0x837A30", VA = "0x180839430")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600088C")]
	[Address(RVA = "0x839440", Offset = "0x837A40", VA = "0x180839440")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x839450", Offset = "0x837A50", VA = "0x180839450")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x839470", Offset = "0x837A70", VA = "0x180839470")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise()
	{
		return null;
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x839490", Offset = "0x837A90", VA = "0x180839490")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DestroyPickUp Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000890")]
	[Address(RVA = "0x8390F0", Offset = "0x8376F0", VA = "0x1808390F0")]
	public static DestroyPickUp Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000891")]
	[Address(RVA = "0x8394A0", Offset = "0x837AA0", VA = "0x1808394A0")]
	public static DestroyPickUp Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000892")]
	[Address(RVA = "0x8396A0", Offset = "0x837CA0", VA = "0x1808396A0")]
	private static DestroyPickUp Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000893")]
	[Address(RVA = "0x839420", Offset = "0x837A20", VA = "0x180839420")]
	public static DestroyPickUp Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x839430", Offset = "0x837A30", VA = "0x180839430")]
	public static DestroyPickUp Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x839440", Offset = "0x837A40", VA = "0x180839440")]
	public static DestroyPickUp Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000896")]
	[Address(RVA = "0x839450", Offset = "0x837A50", VA = "0x180839450")]
	public static DestroyPickUp Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x839470", Offset = "0x837A70", VA = "0x180839470")]
	public static DestroyPickUp Create()
	{
		return null;
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x839490", Offset = "0x837A90", VA = "0x180839490")]
	public static DestroyPickUp Create(ReliabilityModes reliability)
	{
		return null;
	}
}
