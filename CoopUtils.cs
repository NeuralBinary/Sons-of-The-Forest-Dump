using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000D6")]
public static class CoopUtils
{
	// Token: 0x06000658 RID: 1624 RVA: 0x00003D68 File Offset: 0x00001F68
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x2E83220", Offset = "0x2E82220", VA = "0x182E83220")]
	public static bool IsDedicatedServerAdmin(this BoltConnection connection)
	{
		return default(bool);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00003D80 File Offset: 0x00001F80
	[Token(Token = "0x6000659")]
	[Address(RVA = "0x2E82F70", Offset = "0x2E81F70", VA = "0x182E82F70")]
	public static float CalculatePriorityFor(BoltConnection connection, BoltEntity entity, float multiplier, int skipped)
	{
		return default(float);
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x2E826C0", Offset = "0x2E816C0", VA = "0x182E826C0")]
	private static BoltEntity AttachLocalPlayer(GameObject go, string name)
	{
		return null;
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065B")]
	[Address(RVA = "0x2E826D0", Offset = "0x2E816D0", VA = "0x182E826D0")]
	private static BoltEntity AttachLocalPlayer(GameObject go, string name, bool attachToRespawn)
	{
		return null;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065C")]
	[Address(RVA = "0x2E82B90", Offset = "0x2E81B90", VA = "0x182E82B90")]
	public static BoltEntity AttachLocalPlayer(string name)
	{
		return null;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065D")]
	[Address(RVA = "0x2E82CE0", Offset = "0x2E81CE0", VA = "0x182E82CE0")]
	public static BoltEntity AttachServerEntity(GameObject go, PrefabId prefabId, UniqueId stateId, bool allowInstantiateOnClient = true, bool persistThroughSceneLoads = true)
	{
		return null;
	}

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x0")]
	private static Random _random;

	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public enum PlayerConnectionState
	{
		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		Disconnected,
		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		Connected,
		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		Banned,
		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		Kicked
	}
}
