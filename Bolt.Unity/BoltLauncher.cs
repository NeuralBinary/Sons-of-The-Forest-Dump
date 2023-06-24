using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public static class BoltLauncher
{
	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7A67E0", Offset = "0x7A4DE0", VA = "0x1807A67E0")]
	public static void StartSinglePlayer()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x7A68F0", Offset = "0x7A4EF0", VA = "0x1807A68F0")]
	public static void StartSinglePlayer(BoltConfig config)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x7A69A0", Offset = "0x7A4FA0", VA = "0x1807A69A0")]
	public static void StartServer()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7A6A00", Offset = "0x7A5000", VA = "0x1807A6A00")]
	public static void StartServer(int port)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x7A6B00", Offset = "0x7A5100", VA = "0x1807A6B00")]
	public static void StartServer(BoltConfig config)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7A6B70", Offset = "0x7A5170", VA = "0x1807A6B70")]
	public static void StartServer(UdpEndPoint endpoint)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7A6C00", Offset = "0x7A5200", VA = "0x1807A6C00")]
	public static void StartServer(UdpEndPoint endpoint, BoltConfig config)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7A6C20", Offset = "0x7A5220", VA = "0x1807A6C20")]
	public static void StartClient()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7A6C80", Offset = "0x7A5280", VA = "0x1807A6C80")]
	public static void StartClient(BoltConfig config)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7A6CF0", Offset = "0x7A52F0", VA = "0x1807A6CF0")]
	public static void StartClient(UdpEndPoint endpoint)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7A6D80", Offset = "0x7A5380", VA = "0x1807A6D80")]
	public static void StartClient(UdpEndPoint endpoint, BoltConfig config)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7A6DA0", Offset = "0x7A53A0", VA = "0x1807A6DA0")]
	public static void StartClient(int port)
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7A6EA0", Offset = "0x7A54A0", VA = "0x1807A6EA0")]
	public static void Shutdown()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7A6F60", Offset = "0x7A5560", VA = "0x1807A6F60")]
	private static void Initialize(BoltNetworkModes modes, UdpEndPoint endpoint, BoltConfig config)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x7A7470", Offset = "0x7A5A70", VA = "0x1807A7470")]
	private static int GetSceneIndex(string name)
	{
		return 0;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7A74F0", Offset = "0x7A5AF0", VA = "0x1807A74F0")]
	private static string GetSceneName(int index)
	{
		return null;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7A7570", Offset = "0x7A5B70", VA = "0x1807A7570")]
	public static List<STuple<BoltGlobalBehaviourAttribute, Type>> GetGlobalBehaviourTypes()
	{
		return null;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7A7840", Offset = "0x7A5E40", VA = "0x1807A7840")]
	public static void SetUdpPlatform(UdpPlatform platform)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7A78D0", Offset = "0x7A5ED0", VA = "0x1807A78D0")]
	public static UdpPlatform CreateUdpPlatform()
	{
		return null;
	}

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x0")]
	private static UdpPlatform UserAssignedPlatform;
}
