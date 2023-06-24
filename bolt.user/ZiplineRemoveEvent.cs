using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200024F RID: 591
[Token(Token = "0x200024F")]
public class ZiplineRemoveEvent : Event
{
	// Token: 0x06001B43 RID: 6979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x7DEDB0", Offset = "0x7DD3B0", VA = "0x1807DEDB0")]
	public ZiplineRemoveEvent()
	{
	}

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B5")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x7DEE10", Offset = "0x7DD410", VA = "0x1807DEE10")]
		set
		{
		}
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B46")]
	[Address(RVA = "0x7DF020", Offset = "0x7DD620", VA = "0x1807DF020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x7DF070", Offset = "0x7DD670", VA = "0x1807DF070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x7DF080", Offset = "0x7DD680", VA = "0x1807DF080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x7DF280", Offset = "0x7DD880", VA = "0x1807DF280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ZiplineRemoveEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x7DF3A0", Offset = "0x7DD9A0", VA = "0x1807DF3A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x7DF3B0", Offset = "0x7DD9B0", VA = "0x1807DF3B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x7DF3C0", Offset = "0x7DD9C0", VA = "0x1807DF3C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x7DF3D0", Offset = "0x7DD9D0", VA = "0x1807DF3D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x7DF3F0", Offset = "0x7DD9F0", VA = "0x1807DF3F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise()
	{
		return null;
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x7DF410", Offset = "0x7DDA10", VA = "0x1807DF410")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ZiplineRemoveEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x7DF070", Offset = "0x7DD670", VA = "0x1807DF070")]
	public static ZiplineRemoveEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x7DF420", Offset = "0x7DDA20", VA = "0x1807DF420")]
	public static ZiplineRemoveEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x7DF620", Offset = "0x7DDC20", VA = "0x1807DF620")]
	private static ZiplineRemoveEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x7DF3A0", Offset = "0x7DD9A0", VA = "0x1807DF3A0")]
	public static ZiplineRemoveEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x7DF3B0", Offset = "0x7DD9B0", VA = "0x1807DF3B0")]
	public static ZiplineRemoveEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x7DF3C0", Offset = "0x7DD9C0", VA = "0x1807DF3C0")]
	public static ZiplineRemoveEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x7DF3D0", Offset = "0x7DD9D0", VA = "0x1807DF3D0")]
	public static ZiplineRemoveEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x7DF3F0", Offset = "0x7DD9F0", VA = "0x1807DF3F0")]
	public static ZiplineRemoveEvent Create()
	{
		return null;
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x7DF410", Offset = "0x7DDA10", VA = "0x1807DF410")]
	public static ZiplineRemoveEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
