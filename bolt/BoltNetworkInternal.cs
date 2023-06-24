using System;
using System.Collections.Generic;
using Bolt;
using BoltInternal;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
[Documentation(Ignore = true)]
public static class BoltNetworkInternal
{
	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x77B8E0", Offset = "0x779EE0", VA = "0x18077B8E0")]
	public static void __Initialize(BoltNetworkModes mode, UdpEndPoint endpoint, BoltConfig config, UdpPlatform platform, string autoloadScene)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x77B960", Offset = "0x779F60", VA = "0x18077B960")]
	public static void __Shutdown()
	{
	}

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x0")]
	public static bool UsingUnityPro;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x8")]
	public static Action EnvironmentSetup;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x10")]
	public static Action EnvironmentReset;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x18")]
	public static IDebugDrawer DebugDrawer;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x20")]
	public static NatCommunicator NatCommunicator;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x28")]
	public static Func<int, string> GetSceneName;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x30")]
	public static Func<string, int> GetSceneIndex;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x38")]
	public static Func<List<STuple<BoltGlobalBehaviourAttribute, Type>>> GetGlobalBehaviourTypes;
}
