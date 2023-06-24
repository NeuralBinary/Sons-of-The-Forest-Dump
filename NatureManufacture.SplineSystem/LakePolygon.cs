using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[RequireComponent(typeof(MeshFilter))]
public class LakePolygon : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x245E2B0", Offset = "0x245C8B0", VA = "0x18245E2B0")]
	public void AddPoint(Vector3 position)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x245E380", Offset = "0x245C980", VA = "0x18245E380")]
	public void AddPointAfter(int i)
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x245E740", Offset = "0x245CD40", VA = "0x18245E740")]
	public void ChangePointPosition(int i, Vector3 position)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x245E7D0", Offset = "0x245CDD0", VA = "0x18245E7D0")]
	public void RemovePoint(int i)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x245E870", Offset = "0x245CE70", VA = "0x18245E870")]
	public void RemovePoints(int fromID = -1)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x245E960", Offset = "0x245CF60", VA = "0x18245E960")]
	private void CenterPivot()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x245ED70", Offset = "0x245D370", VA = "0x18245ED70")]
	public void GeneratePolygon()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2460B90", Offset = "0x245F190", VA = "0x182460B90")]
	public static LakePolygon CreatePolygon(Material material, [Optional] List<Vector3> positions)
	{
		return null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2460F80", Offset = "0x245F580", VA = "0x182460F80")]
	private void CalculateCatmullRomSpline(int pos)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2461300", Offset = "0x245F900", VA = "0x182461300")]
	public int ClampListPos(int pos)
	{
		return 0;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2461390", Offset = "0x245F990", VA = "0x182461390")]
	private Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x24616C0", Offset = "0x245FCC0", VA = "0x1824616C0")]
	public float DistancePointLine(Vector2 point, Vector2 lineStart, Vector2 lineEnd, out Vector2 pointProject)
	{
		return 0f;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2461860", Offset = "0x245FE60", VA = "0x182461860")]
	public Vector2 ProjectPointLine(Vector2 point, Vector2 lineStart, Vector2 lineEnd)
	{
		return default(Vector2);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x24619E0", Offset = "0x245FFE0", VA = "0x1824619E0")]
	public void TerrainCarve(bool terrainShow = false)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2464250", Offset = "0x2462850", VA = "0x182464250")]
	public void TerrainPaint(bool terrainShow = false)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x24669C0", Offset = "0x2464FC0", VA = "0x1824669C0")]
	public void TerrainClearTrees(bool details = true)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2468E10", Offset = "0x2467410", VA = "0x182468E10")]
	public void Simulation()
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x246A400", Offset = "0x2468A00", VA = "0x18246A400")]
	public static bool AreLinesIntersecting(Vector3 l1_p1, Vector3 l1_p2, Vector3 l2_p1, Vector3 l2_p2, bool shouldIncludeEndPoints = true)
	{
		return default(bool);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x246A520", Offset = "0x2468B20", VA = "0x18246A520")]
	public static float DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return 0f;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x246A790", Offset = "0x2468D90", VA = "0x18246A790")]
	public static Vector3 ProjectPointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return default(Vector3);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x246A980", Offset = "0x2468F80", VA = "0x18246A980")]
	public LakePolygon()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int toolbarInt;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LakePolygonProfile currentProfile;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LakePolygonProfile oldProfile;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector3> points;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector3> splinePoints;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve terrainCarve;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float distSmooth;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float terrainSmoothMultiplier;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool overrideLakeRender;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float uvScale;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool receiveShadows;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public ShadowCastingMode shadowCastingMode;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AnimationCurve terrainPaintCarve;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int currentSplatMap;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float distanceClearFoliage;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float distanceClearFoliageTrees;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool mixTwoSplatMaps;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int secondSplatMap;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool addCliffSplatMap;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int cliffSplatMap;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float cliffAngle;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float cliffBlend;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int cliffSplatMapOutside;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float cliffAngleOutside;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float cliffBlendOutside;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool noiseCarve;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float noiseMultiplierInside;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float noiseMultiplierOutside;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float noiseSizeX;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float noiseSizeZ;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool noisePaint;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float noiseMultiplierInsidePaint;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float noiseMultiplierOutsidePaint;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float noiseSizeXPaint;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float noiseSizeZPaint;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float maximumTriangleSize;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float traingleDensity;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float height;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool lockHeight;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float yOffset;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public float trianglesGenerated;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float vertsGenerated;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Mesh currentMesh;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public MeshFilter meshfilter;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool showVertexColors;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
	public bool showFlowMap;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
	public bool overrideFlowMap;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float automaticFlowMapScale;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool noiseflowMap;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float noiseMultiplierflowMap;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float noiseSizeXflowMap;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float noiseSizeZflowMap;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool drawOnMesh;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
	public bool drawOnMeshFlowMap;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public Color drawColor;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public bool drawColorR;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
	public bool drawColorG;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
	public bool drawColorB;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
	public bool drawColorA;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public bool drawOnMultiple;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public float opacity;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float drawSize;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Material oldMaterial;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Color[] colors;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public List<Vector2> colorsFlowMap;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public float floatSpeed;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public float flowSpeed;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public float flowDirection;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public float closeDistanceSimulation;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public int angleSimulation;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public float checkDistanceSimulation;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public bool removeFirstPointSimulation;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public LakePolygonCarveData lakePolygonCarveData;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public LakePolygonCarveData lakePolygonPaintData;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public LakePolygonCarveData lakePolygonClearData;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public List<GameObject> meshGOs;
}
