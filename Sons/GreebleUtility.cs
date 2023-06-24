using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BC RID: 444
[Token(Token = "0x20001BC")]
public static class GreebleUtility
{
	// Token: 0x06000CCE RID: 3278 RVA: 0x00005220 File Offset: 0x00003420
	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x36EEE00", Offset = "0x36ED400", VA = "0x1836EEE00")]
	public static bool VerifySpawnLocation(GreebleGlobalDefinition greebleDefinition, Ray ray, float distance, Quaternion rotationIn, out Vector3 positionOut, out Quaternion rotationOut)
	{
		return default(bool);
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00005238 File Offset: 0x00003438
	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x36EF390", Offset = "0x36ED990", VA = "0x1836EF390")]
	private static bool PassTagMask(GreebleGlobalDefinition greebleDefinition, RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x36EF550", Offset = "0x36EDB50", VA = "0x1836EF550")]
	private static bool PassTerrainMask(GreebleGlobalDefinition greebleDefinition, RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00005268 File Offset: 0x00003468
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x36EFBA0", Offset = "0x36EE1A0", VA = "0x1836EFBA0")]
	private static bool TryGetTerrain(RaycastHit hit, out Terrain result)
	{
		return default(bool);
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x36F0080", Offset = "0x36EE680", VA = "0x1836F0080")]
	private static int GetTerrainLayerIndex()
	{
		return 0;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x36F0180", Offset = "0x36EE780", VA = "0x1836F0180")]
	public static GreebleGlobalDefinition.SpawnObjectType GetRandomVariation(GreebleGlobalDefinition definition)
	{
		return null;
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x36F0270", Offset = "0x36EE870", VA = "0x1836F0270")]
	public static GreebleGlobalDefinition GetRandomDefinitionFromArray(GreebleGlobalDefinition[] definitions, bool checkAge, float ageInMinutes = 0f)
	{
		return null;
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00005298 File Offset: 0x00003498
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x36F04F0", Offset = "0x36EEAF0", VA = "0x1836F04F0")]
	public static int RandomRange(int minValue, int maxValue)
	{
		return 0;
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x000052B0 File Offset: 0x000034B0
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x36F0550", Offset = "0x36EEB50", VA = "0x1836F0550")]
	public static float RandomRange(float minValue, float maxValue)
	{
		return 0f;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x000052C8 File Offset: 0x000034C8
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x36F0560", Offset = "0x36EEB60", VA = "0x1836F0560")]
	public static float RandomDegrees()
	{
		return 0f;
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x000052E0 File Offset: 0x000034E0
	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x36F05B0", Offset = "0x36EEBB0", VA = "0x1836F05B0")]
	public static Vector3 RandomDirectionFast()
	{
		return default(Vector3);
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x36F0670", Offset = "0x36EEC70", VA = "0x1836F0670")]
	public static Vector3 RandomDirection()
	{
		return default(Vector3);
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00005310 File Offset: 0x00003510
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x36F0770", Offset = "0x36EED70", VA = "0x1836F0770")]
	public static Quaternion RandomRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000B8B")]
	private const string TerrainLayerName = "Terrain";

	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x0")]
	private static int _cachedTerrainColliderInstanceId;

	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x8")]
	private static Terrain _cachedTerrain;

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x10")]
	private static int _cachedTerrainLayerIndex;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x14")]
	private static RaycastHit _singleHitBuffer;
}
