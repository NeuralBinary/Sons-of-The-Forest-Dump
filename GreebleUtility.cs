using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
public static class GreebleUtility
{
	// Token: 0x06000C74 RID: 3188 RVA: 0x00004FF8 File Offset: 0x000031F8
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x2F6A0F0", Offset = "0x2F690F0", VA = "0x182F6A0F0")]
	public static bool VerifySpawnLocation(GreebleGlobalDefinition greebleDefinition, Ray ray, float distance, Quaternion rotationIn, out Vector3 positionOut, out Quaternion rotationOut)
	{
		return default(bool);
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00005010 File Offset: 0x00003210
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x2F699F0", Offset = "0x2F689F0", VA = "0x182F699F0")]
	private static bool PassTerrainMask(GreebleGlobalDefinition greebleDefinition, RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00005028 File Offset: 0x00003228
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x2F69E40", Offset = "0x2F68E40", VA = "0x182F69E40")]
	private static bool TryGetTerrain(RaycastHit hit, out Terrain result)
	{
		return default(bool);
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00005040 File Offset: 0x00003240
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x2F68E80", Offset = "0x2F67E80", VA = "0x182F68E80")]
	private static int GetTerrainLayerIndex()
	{
		return default(int);
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x2F68DE0", Offset = "0x2F67DE0", VA = "0x182F68DE0")]
	public static GreebleGlobalDefinition.SpawnObjectType GetRandomVariation(GreebleGlobalDefinition definition)
	{
		return null;
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x2F68C20", Offset = "0x2F67C20", VA = "0x182F68C20")]
	public static GreebleGlobalDefinition GetRandomDefinitionFromArray(GreebleGlobalDefinition[] definitions, bool checkAge, float ageInMinutes = 0f)
	{
		return null;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00005058 File Offset: 0x00003258
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x2F69220", Offset = "0x2F68220", VA = "0x182F69220")]
	public static int RandomRange(int minValue, int maxValue)
	{
		return default(int);
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x2F69210", Offset = "0x2F68210", VA = "0x182F69210")]
	public static float RandomRange(float minValue, float maxValue)
	{
		return default(float);
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x2F69B30", Offset = "0x2F68B30", VA = "0x182F69B30")]
	public static float RandomDegrees()
	{
		return default(float);
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x2F69B80", Offset = "0x2F68B80", VA = "0x182F69B80")]
	public static Vector3 RandomDirectionFast()
	{
		return default(Vector3);
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x2F69C40", Offset = "0x2F68C40", VA = "0x182F69C40")]
	public static Vector3 RandomDirection()
	{
		return default(Vector3);
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x2F69CC0", Offset = "0x2F68CC0", VA = "0x182F69CC0")]
	public static Quaternion RandomRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x4000B5C")]
	private const string TerrainLayerName = "Terrain";

	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x0")]
	private static int _cachedTerrainColliderInstanceId;

	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x8")]
	private static Terrain _cachedTerrain;

	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0x10")]
	private static int _cachedTerrainLayerIndex;

	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x14")]
	private static RaycastHit _singleHitBuffer;
}
