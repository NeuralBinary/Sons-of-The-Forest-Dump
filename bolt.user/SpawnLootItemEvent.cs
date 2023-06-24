using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
public class SpawnLootItemEvent : Event
{
	// Token: 0x06001821 RID: 6177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001821")]
	[Address(RVA = "0x8BEA50", Offset = "0x8BD050", VA = "0x1808BEA50")]
	public SpawnLootItemEvent()
	{
	}

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x06001822 RID: 6178 RVA: 0x00007C38 File Offset: 0x00005E38
	// (set) Token: 0x06001823 RID: 6179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700072C")]
	public int ItemId
	{
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x06001824 RID: 6180 RVA: 0x00007C50 File Offset: 0x00005E50
	// (set) Token: 0x06001825 RID: 6181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700072D")]
	public Vector3 Position
	{
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x7DD580", Offset = "0x7DBB80", VA = "0x1807DD580")]
		set
		{
		}
	}

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x06001826 RID: 6182 RVA: 0x00007C68 File Offset: 0x00005E68
	// (set) Token: 0x06001827 RID: 6183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700072E")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x7BCDA0", Offset = "0x7BB3A0", VA = "0x1807BCDA0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x83A2C0", Offset = "0x8388C0", VA = "0x18083A2C0")]
		set
		{
		}
	}

	// Token: 0x1700072F RID: 1839
	// (get) Token: 0x06001828 RID: 6184 RVA: 0x00007C80 File Offset: 0x00005E80
	// (set) Token: 0x06001829 RID: 6185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700072F")]
	public bool Dynamic
	{
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x7EE100", Offset = "0x7EC700", VA = "0x1807EE100")]
		set
		{
		}
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182A")]
	[Address(RVA = "0x8BEAB0", Offset = "0x8BD0B0", VA = "0x1808BEAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182B")]
	[Address(RVA = "0x8BEDE0", Offset = "0x8BD3E0", VA = "0x1808BEDE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182C")]
	[Address(RVA = "0x8BEDF0", Offset = "0x8BD3F0", VA = "0x1808BEDF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x8BEFF0", Offset = "0x8BD5F0", VA = "0x1808BEFF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SpawnLootItemEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182E")]
	[Address(RVA = "0x8BF110", Offset = "0x8BD710", VA = "0x1808BF110")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x8BF120", Offset = "0x8BD720", VA = "0x1808BF120")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x8BF130", Offset = "0x8BD730", VA = "0x1808BF130")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x8BF140", Offset = "0x8BD740", VA = "0x1808BF140")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001832")]
	[Address(RVA = "0x8BF160", Offset = "0x8BD760", VA = "0x1808BF160")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise()
	{
		return null;
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x8BF180", Offset = "0x8BD780", VA = "0x1808BF180")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnLootItemEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x8BEDE0", Offset = "0x8BD3E0", VA = "0x1808BEDE0")]
	public static SpawnLootItemEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x8BF190", Offset = "0x8BD790", VA = "0x1808BF190")]
	public static SpawnLootItemEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001836")]
	[Address(RVA = "0x8BF390", Offset = "0x8BD990", VA = "0x1808BF390")]
	private static SpawnLootItemEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001837")]
	[Address(RVA = "0x8BF110", Offset = "0x8BD710", VA = "0x1808BF110")]
	public static SpawnLootItemEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001838")]
	[Address(RVA = "0x8BF120", Offset = "0x8BD720", VA = "0x1808BF120")]
	public static SpawnLootItemEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001839")]
	[Address(RVA = "0x8BF130", Offset = "0x8BD730", VA = "0x1808BF130")]
	public static SpawnLootItemEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x8BF140", Offset = "0x8BD740", VA = "0x1808BF140")]
	public static SpawnLootItemEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600183B")]
	[Address(RVA = "0x8BF160", Offset = "0x8BD760", VA = "0x1808BF160")]
	public static SpawnLootItemEvent Create()
	{
		return null;
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x8BF180", Offset = "0x8BD780", VA = "0x1808BF180")]
	public static SpawnLootItemEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
