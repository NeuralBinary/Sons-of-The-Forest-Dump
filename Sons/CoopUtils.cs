using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[Token(Token = "0x20000D4")]
public static class CoopUtils
{
	// Token: 0x060006A3 RID: 1699 RVA: 0x00003F60 File Offset: 0x00002160
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x3520E00", Offset = "0x351F400", VA = "0x183520E00")]
	public static float CalculatePriorityFor(BoltConnection connection, BoltEntity entity, float multiplier, int skipped)
	{
		return 0f;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x3521240", Offset = "0x351F840", VA = "0x183521240")]
	private static BoltEntity AttachLocalPlayer(GameObject go, string name)
	{
		return null;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x3521250", Offset = "0x351F850", VA = "0x183521250")]
	private static BoltEntity AttachLocalPlayer(GameObject go, string name, bool attachToRespawn)
	{
		return null;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x35218A0", Offset = "0x351FEA0", VA = "0x1835218A0")]
	public static BoltEntity AttachLocalPlayer(string name)
	{
		return null;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x3521A50", Offset = "0x3520050", VA = "0x183521A50")]
	public static BoltEntity AttachServerEntity(GameObject go, PrefabId prefabId, UniqueId stateId, bool allowInstantiateOnClient = true, bool persistThroughSceneLoads = true)
	{
		return null;
	}

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x0")]
	private static System.Random _random;

	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public enum PlayerConnectionState
	{
		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		Disconnected,
		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		Connected,
		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		Banned,
		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		Kicked
	}
}
