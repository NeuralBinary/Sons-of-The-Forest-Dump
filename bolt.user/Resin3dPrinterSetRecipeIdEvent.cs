using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000267 RID: 615
[Token(Token = "0x2000267")]
public class Resin3dPrinterSetRecipeIdEvent : Event
{
	// Token: 0x06001C4B RID: 7243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x7E6FF0", Offset = "0x7E55F0", VA = "0x1807E6FF0")]
	public Resin3dPrinterSetRecipeIdEvent()
	{
	}

	// Token: 0x170007DB RID: 2011
	// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007DB")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x7E7050", Offset = "0x7E5650", VA = "0x1807E7050")]
		set
		{
		}
	}

	// Token: 0x170007DC RID: 2012
	// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00008778 File Offset: 0x00006978
	// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007DC")]
	public int RecipeId
	{
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x7E7260", Offset = "0x7E5860", VA = "0x1807E7260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x7E7320", Offset = "0x7E5920", VA = "0x1807E7320")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x7E7330", Offset = "0x7E5930", VA = "0x1807E7330")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x7E7530", Offset = "0x7E5B30", VA = "0x1807E7530")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static Resin3dPrinterSetRecipeIdEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x7E7650", Offset = "0x7E5C50", VA = "0x1807E7650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C55 RID: 7253 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x7E7660", Offset = "0x7E5C60", VA = "0x1807E7660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x7E7670", Offset = "0x7E5C70", VA = "0x1807E7670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C57 RID: 7255 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x7E7680", Offset = "0x7E5C80", VA = "0x1807E7680")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C58 RID: 7256 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x7E76A0", Offset = "0x7E5CA0", VA = "0x1807E76A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise()
	{
		return null;
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x7E76C0", Offset = "0x7E5CC0", VA = "0x1807E76C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetRecipeIdEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x7E7320", Offset = "0x7E5920", VA = "0x1807E7320")]
	public static Resin3dPrinterSetRecipeIdEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x7E76D0", Offset = "0x7E5CD0", VA = "0x1807E76D0")]
	public static Resin3dPrinterSetRecipeIdEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x7E78D0", Offset = "0x7E5ED0", VA = "0x1807E78D0")]
	private static Resin3dPrinterSetRecipeIdEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x7E7650", Offset = "0x7E5C50", VA = "0x1807E7650")]
	public static Resin3dPrinterSetRecipeIdEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x7E7660", Offset = "0x7E5C60", VA = "0x1807E7660")]
	public static Resin3dPrinterSetRecipeIdEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x7E7670", Offset = "0x7E5C70", VA = "0x1807E7670")]
	public static Resin3dPrinterSetRecipeIdEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x7E7680", Offset = "0x7E5C80", VA = "0x1807E7680")]
	public static Resin3dPrinterSetRecipeIdEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C61 RID: 7265 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x7E76A0", Offset = "0x7E5CA0", VA = "0x1807E76A0")]
	public static Resin3dPrinterSetRecipeIdEvent Create()
	{
		return null;
	}

	// Token: 0x06001C62 RID: 7266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x7E76C0", Offset = "0x7E5CC0", VA = "0x1807E76C0")]
	public static Resin3dPrinterSetRecipeIdEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
