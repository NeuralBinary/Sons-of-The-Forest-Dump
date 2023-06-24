using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000165 RID: 357
[Token(Token = "0x2000165")]
public class PlaceTrophy : Event
{
	// Token: 0x06001057 RID: 4183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x87CAB0", Offset = "0x87B0B0", VA = "0x18087CAB0")]
	public PlaceTrophy()
	{
	}

	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06001058 RID: 4184 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001059 RID: 4185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005CD")]
	public BoltEntity Maker
	{
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x87CB10", Offset = "0x87B110", VA = "0x18087CB10")]
		set
		{
		}
	}

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x0600105A RID: 4186 RVA: 0x00006588 File Offset: 0x00004788
	// (set) Token: 0x0600105B RID: 4187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005CE")]
	public int ItemId
	{
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x87CD20", Offset = "0x87B320", VA = "0x18087CD20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x87CE60", Offset = "0x87B460", VA = "0x18087CE60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x87CE70", Offset = "0x87B470", VA = "0x18087CE70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x87D070", Offset = "0x87B670", VA = "0x18087D070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlaceTrophy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x87D190", Offset = "0x87B790", VA = "0x18087D190")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x87D1A0", Offset = "0x87B7A0", VA = "0x18087D1A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x87D1B0", Offset = "0x87B7B0", VA = "0x18087D1B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x87D1C0", Offset = "0x87B7C0", VA = "0x18087D1C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x87D1E0", Offset = "0x87B7E0", VA = "0x18087D1E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise()
	{
		return null;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x87D200", Offset = "0x87B800", VA = "0x18087D200")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceTrophy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x87CE60", Offset = "0x87B460", VA = "0x18087CE60")]
	public static PlaceTrophy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x87D210", Offset = "0x87B810", VA = "0x18087D210")]
	public static PlaceTrophy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x87D410", Offset = "0x87BA10", VA = "0x18087D410")]
	private static PlaceTrophy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x87D190", Offset = "0x87B790", VA = "0x18087D190")]
	public static PlaceTrophy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x87D1A0", Offset = "0x87B7A0", VA = "0x18087D1A0")]
	public static PlaceTrophy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x87D1B0", Offset = "0x87B7B0", VA = "0x18087D1B0")]
	public static PlaceTrophy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x87D1C0", Offset = "0x87B7C0", VA = "0x18087D1C0")]
	public static PlaceTrophy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x87D1E0", Offset = "0x87B7E0", VA = "0x18087D1E0")]
	public static PlaceTrophy Create()
	{
		return null;
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x87D200", Offset = "0x87B800", VA = "0x18087D200")]
	public static PlaceTrophy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
