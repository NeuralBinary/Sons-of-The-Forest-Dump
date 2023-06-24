using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
[Documentation]
[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
public sealed class BoltGlobalBehaviourAttribute : Attribute
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000045 RID: 69 RVA: 0x00002058 File Offset: 0x00000258
	// (set) Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	public BoltNetworkModes Mode
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		[CompilerGenerated]
		get
		{
			return BoltNetworkModes.None;
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000047 RID: 71 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000002")]
	public string[] Scenes
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x77B670", Offset = "0x779C70", VA = "0x18077B670")]
	public BoltGlobalBehaviourAttribute()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x77B700", Offset = "0x779D00", VA = "0x18077B700")]
	public BoltGlobalBehaviourAttribute(BoltNetworkModes mode)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x77B790", Offset = "0x779D90", VA = "0x18077B790")]
	public BoltGlobalBehaviourAttribute(params string[] scenes)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x77B7F0", Offset = "0x779DF0", VA = "0x18077B7F0")]
	public BoltGlobalBehaviourAttribute(BoltNetworkModes mode, params string[] scenes)
	{
	}
}
