using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024C RID: 588
[Token(Token = "0x200024C")]
public class ZiplineCreateEvent : Event
{
	// Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x7DD480", Offset = "0x7DBA80", VA = "0x1807DD480")]
	public ZiplineCreateEvent()
	{
	}

	// Token: 0x170007AD RID: 1965
	// (get) Token: 0x06001B1C RID: 6940 RVA: 0x000084A8 File Offset: 0x000066A8
	// (set) Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007AD")]
	public Vector3 AnchorAPosition
	{
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x7DD4E0", Offset = "0x7DBAE0", VA = "0x1807DD4E0")]
		set
		{
		}
	}

	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x06001B1E RID: 6942 RVA: 0x000084C0 File Offset: 0x000066C0
	// (set) Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007AE")]
	public Vector3 AnchorBPosition
	{
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x7DD580", Offset = "0x7DBB80", VA = "0x1807DD580")]
		set
		{
		}
	}

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x06001B20 RID: 6944 RVA: 0x000084D8 File Offset: 0x000066D8
	// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007AF")]
	public bool CanBeDismantled
	{
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x7DD620", Offset = "0x7DBC20", VA = "0x1807DD620")]
		set
		{
		}
	}

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x06001B22 RID: 6946 RVA: 0x000084F0 File Offset: 0x000066F0
	// (set) Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B0")]
	public Guid AnchorATreeID
	{
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x06001B24 RID: 6948 RVA: 0x00008508 File Offset: 0x00006708
	// (set) Token: 0x06001B25 RID: 6949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B1")]
	public Guid AnchorBTreeID
	{
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x7C22A0", Offset = "0x7C08A0", VA = "0x1807C22A0")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x7DD7D0", Offset = "0x7DBDD0", VA = "0x1807DD7D0")]
		set
		{
		}
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B26")]
	[Address(RVA = "0x7DD870", Offset = "0x7DBE70", VA = "0x1807DD870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x7DDC40", Offset = "0x7DC240", VA = "0x1807DDC40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x7DDC50", Offset = "0x7DC250", VA = "0x1807DDC50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x7DDE50", Offset = "0x7DC450", VA = "0x1807DDE50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ZiplineCreateEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x7DDF70", Offset = "0x7DC570", VA = "0x1807DDF70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x7DDF80", Offset = "0x7DC580", VA = "0x1807DDF80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x7DDF90", Offset = "0x7DC590", VA = "0x1807DDF90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x7DDFA0", Offset = "0x7DC5A0", VA = "0x1807DDFA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x7DDFC0", Offset = "0x7DC5C0", VA = "0x1807DDFC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise()
	{
		return null;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x7DDFE0", Offset = "0x7DC5E0", VA = "0x1807DDFE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineCreateEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x7DDC40", Offset = "0x7DC240", VA = "0x1807DDC40")]
	public static ZiplineCreateEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x7DDFF0", Offset = "0x7DC5F0", VA = "0x1807DDFF0")]
	public static ZiplineCreateEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x7DE1F0", Offset = "0x7DC7F0", VA = "0x1807DE1F0")]
	private static ZiplineCreateEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x7DDF70", Offset = "0x7DC570", VA = "0x1807DDF70")]
	public static ZiplineCreateEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x7DDF80", Offset = "0x7DC580", VA = "0x1807DDF80")]
	public static ZiplineCreateEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x7DDF90", Offset = "0x7DC590", VA = "0x1807DDF90")]
	public static ZiplineCreateEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B36")]
	[Address(RVA = "0x7DDFA0", Offset = "0x7DC5A0", VA = "0x1807DDFA0")]
	public static ZiplineCreateEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B37")]
	[Address(RVA = "0x7DDFC0", Offset = "0x7DC5C0", VA = "0x1807DDFC0")]
	public static ZiplineCreateEvent Create()
	{
		return null;
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x7DDFE0", Offset = "0x7DC5E0", VA = "0x1807DDFE0")]
	public static ZiplineCreateEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
