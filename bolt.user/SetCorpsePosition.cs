using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010E RID: 270
[Token(Token = "0x200010E")]
public class SetCorpsePosition : Event
{
	// Token: 0x06000C63 RID: 3171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x85AC20", Offset = "0x859220", VA = "0x18085AC20")]
	public SetCorpsePosition()
	{
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700052F")]
	public BoltEntity Corpse
	{
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x85AC80", Offset = "0x859280", VA = "0x18085AC80")]
		set
		{
		}
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00005CB8 File Offset: 0x00003EB8
	// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000530")]
	public Vector3 Position
	{
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x85AE90", Offset = "0x859490", VA = "0x18085AE90")]
		set
		{
		}
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00005CD0 File Offset: 0x00003ED0
	// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000531")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x7BCDA0", Offset = "0x7BB3A0", VA = "0x1807BCDA0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x83A2C0", Offset = "0x8388C0", VA = "0x18083A2C0")]
		set
		{
		}
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00005CE8 File Offset: 0x00003EE8
	// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000532")]
	public bool Pickup
	{
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x7EE100", Offset = "0x7EC700", VA = "0x1807EE100")]
		set
		{
		}
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00005D00 File Offset: 0x00003F00
	// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000533")]
	public bool Destroy
	{
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x85AFA0", Offset = "0x8595A0", VA = "0x18085AFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x85B310", Offset = "0x859910", VA = "0x18085B310")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x85B320", Offset = "0x859920", VA = "0x18085B320")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x85B520", Offset = "0x859B20", VA = "0x18085B520")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SetCorpsePosition Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x85B640", Offset = "0x859C40", VA = "0x18085B640")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x85B650", Offset = "0x859C50", VA = "0x18085B650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x85B660", Offset = "0x859C60", VA = "0x18085B660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x85B670", Offset = "0x859C70", VA = "0x18085B670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x85B690", Offset = "0x859C90", VA = "0x18085B690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise()
	{
		return null;
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x85B6B0", Offset = "0x859CB0", VA = "0x18085B6B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetCorpsePosition Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x85B310", Offset = "0x859910", VA = "0x18085B310")]
	public static SetCorpsePosition Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x85B6C0", Offset = "0x859CC0", VA = "0x18085B6C0")]
	public static SetCorpsePosition Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x85B8C0", Offset = "0x859EC0", VA = "0x18085B8C0")]
	private static SetCorpsePosition Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x85B640", Offset = "0x859C40", VA = "0x18085B640")]
	public static SetCorpsePosition Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x85B650", Offset = "0x859C50", VA = "0x18085B650")]
	public static SetCorpsePosition Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x85B660", Offset = "0x859C60", VA = "0x18085B660")]
	public static SetCorpsePosition Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x85B670", Offset = "0x859C70", VA = "0x18085B670")]
	public static SetCorpsePosition Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x85B690", Offset = "0x859C90", VA = "0x18085B690")]
	public static SetCorpsePosition Create()
	{
		return null;
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x85B6B0", Offset = "0x859CB0", VA = "0x18085B6B0")]
	public static SetCorpsePosition Create(ReliabilityModes reliability)
	{
		return null;
	}
}
