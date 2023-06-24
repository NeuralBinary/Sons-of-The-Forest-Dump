using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002A0 RID: 672
[Token(Token = "0x20002A0")]
public class CookingPotRemovedEvent : Event
{
	// Token: 0x06001EBD RID: 7869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBD")]
	[Address(RVA = "0x7F9C80", Offset = "0x7F8280", VA = "0x1807F9C80")]
	public CookingPotRemovedEvent()
	{
	}

	// Token: 0x17000840 RID: 2112
	// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000840")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x7F9CE0", Offset = "0x7F82E0", VA = "0x1807F9CE0")]
		set
		{
		}
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x7F9EF0", Offset = "0x7F84F0", VA = "0x1807F9EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x7F9F40", Offset = "0x7F8540", VA = "0x1807F9F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0x7F9F50", Offset = "0x7F8550", VA = "0x1807F9F50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0x7FA150", Offset = "0x7F8750", VA = "0x1807FA150")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static CookingPotRemovedEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x7FA270", Offset = "0x7F8870", VA = "0x1807FA270")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x7FA280", Offset = "0x7F8880", VA = "0x1807FA280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x7FA290", Offset = "0x7F8890", VA = "0x1807FA290")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0x7FA2A0", Offset = "0x7F88A0", VA = "0x1807FA2A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0x7FA2C0", Offset = "0x7F88C0", VA = "0x1807FA2C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise()
	{
		return null;
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x7FA2E0", Offset = "0x7F88E0", VA = "0x1807FA2E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingPotRemovedEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x7F9F40", Offset = "0x7F8540", VA = "0x1807F9F40")]
	public static CookingPotRemovedEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x7FA2F0", Offset = "0x7F88F0", VA = "0x1807FA2F0")]
	public static CookingPotRemovedEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x7FA4F0", Offset = "0x7F8AF0", VA = "0x1807FA4F0")]
	private static CookingPotRemovedEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0x7FA270", Offset = "0x7F8870", VA = "0x1807FA270")]
	public static CookingPotRemovedEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0x7FA280", Offset = "0x7F8880", VA = "0x1807FA280")]
	public static CookingPotRemovedEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x7FA290", Offset = "0x7F8890", VA = "0x1807FA290")]
	public static CookingPotRemovedEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x7FA2A0", Offset = "0x7F88A0", VA = "0x1807FA2A0")]
	public static CookingPotRemovedEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x7FA2C0", Offset = "0x7F88C0", VA = "0x1807FA2C0")]
	public static CookingPotRemovedEvent Create()
	{
		return null;
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED2")]
	[Address(RVA = "0x7FA2E0", Offset = "0x7F88E0", VA = "0x1807FA2E0")]
	public static CookingPotRemovedEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
