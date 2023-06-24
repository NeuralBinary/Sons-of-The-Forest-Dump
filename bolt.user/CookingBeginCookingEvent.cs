using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200029D RID: 669
[Token(Token = "0x200029D")]
public class CookingBeginCookingEvent : Event
{
	// Token: 0x06001E9B RID: 7835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x7F8BF0", Offset = "0x7F71F0", VA = "0x1807F8BF0")]
	public CookingBeginCookingEvent()
	{
	}

	// Token: 0x1700083B RID: 2107
	// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700083B")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x7F8C50", Offset = "0x7F7250", VA = "0x1807F8C50")]
		set
		{
		}
	}

	// Token: 0x1700083C RID: 2108
	// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00008D90 File Offset: 0x00006F90
	// (set) Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700083C")]
	public int RecipeId
	{
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x7F8E60", Offset = "0x7F7460", VA = "0x1807F8E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x7F8F20", Offset = "0x7F7520", VA = "0x1807F8F20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x7F8F30", Offset = "0x7F7530", VA = "0x1807F8F30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x7F9130", Offset = "0x7F7730", VA = "0x1807F9130")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static CookingBeginCookingEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x7F9250", Offset = "0x7F7850", VA = "0x1807F9250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x7F9260", Offset = "0x7F7860", VA = "0x1807F9260")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x7F9270", Offset = "0x7F7870", VA = "0x1807F9270")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x7F9280", Offset = "0x7F7880", VA = "0x1807F9280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x7F92A0", Offset = "0x7F78A0", VA = "0x1807F92A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise()
	{
		return null;
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x7F92C0", Offset = "0x7F78C0", VA = "0x1807F92C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingBeginCookingEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x7F8F20", Offset = "0x7F7520", VA = "0x1807F8F20")]
	public static CookingBeginCookingEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x7F92D0", Offset = "0x7F78D0", VA = "0x1807F92D0")]
	public static CookingBeginCookingEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x7F94D0", Offset = "0x7F7AD0", VA = "0x1807F94D0")]
	private static CookingBeginCookingEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x7F9250", Offset = "0x7F7850", VA = "0x1807F9250")]
	public static CookingBeginCookingEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0x7F9260", Offset = "0x7F7860", VA = "0x1807F9260")]
	public static CookingBeginCookingEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x7F9270", Offset = "0x7F7870", VA = "0x1807F9270")]
	public static CookingBeginCookingEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x7F9280", Offset = "0x7F7880", VA = "0x1807F9280")]
	public static CookingBeginCookingEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x7F92A0", Offset = "0x7F78A0", VA = "0x1807F92A0")]
	public static CookingBeginCookingEvent Create()
	{
		return null;
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0x7F92C0", Offset = "0x7F78C0", VA = "0x1807F92C0")]
	public static CookingBeginCookingEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
