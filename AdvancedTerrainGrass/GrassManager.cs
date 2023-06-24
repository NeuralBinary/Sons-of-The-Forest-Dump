using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace AdvancedTerrainGrass
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[RequireComponent(typeof(Terrain))]
	public class GrassManager : MonoBehaviour
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5A02F0", Offset = "0x59E8F0", VA = "0x1805A02F0")]
		public static GrassManager GetInstance()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5A0340", Offset = "0x59E940", VA = "0x1805A0340")]
		public void RemoveGrass(Vector3 Worldposition, float Radius)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5A0A80", Offset = "0x59F080", VA = "0x1805A0A80")]
		private void Cleanup(bool ClearAll)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UpdateGrass()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UpdateDensity()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5A1340", Offset = "0x59F940", VA = "0x1805A1340")]
		private void Awake()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5A15B0", Offset = "0x59FBB0", VA = "0x1805A15B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5A1770", Offset = "0x59FD70", VA = "0x1805A1770")]
		private void OnEnable()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5A19E0", Offset = "0x59FFE0", VA = "0x1805A19E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5A19F0", Offset = "0x59FFF0", VA = "0x1805A19F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5A1A00", Offset = "0x5A0000", VA = "0x1805A1A00")]
		public float GetATGRandomNext()
		{
			return 0f;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5A1AB0", Offset = "0x5A00B0", VA = "0x1805A1AB0")]
		public void UpdateDensityMap()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5A22F0", Offset = "0x5A08F0", VA = "0x1805A22F0")]
		public void RefreshGrassRenderingSettings(float t_DetailDensity, float t_CullDistance, float t_FadeLength, float t_CacheDistance, float t_SmallDetailFadeStart, float t_SmallDetailFadeLength, float t_DetailFadeStart, float t_DetailFadeLength, float t_ShadowStart, float t_ShadowFadeLength, float t_ShadowStartFoliage, float t_ShadowFadeLengthFoliage, bool t_UseLodMesh)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5A2E20", Offset = "0x5A1420", VA = "0x1805A2E20")]
		public void InitCellsFast()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5A3850", Offset = "0x5A1E50", VA = "0x1805A3850")]
		public void InitCells()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5A4A50", Offset = "0x5A3050", VA = "0x1805A4A50")]
		public void Init()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5A77A0", Offset = "0x5A5DA0", VA = "0x1805A77A0")]
		public void BurstInit()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5A7E20", Offset = "0x5A6420", VA = "0x1805A7E20")]
		private void StateChangedMethod(CullingGroupEvent evt)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5A7F90", Offset = "0x5A6590", VA = "0x1805A7F90")]
		private void DrawGrass()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5A9C50", Offset = "0x5A8250", VA = "0x1805A9C50")]
		public float GetHeight(int x, int y)
		{
			return 0f;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5A9C90", Offset = "0x5A8290", VA = "0x1805A9C90")]
		public float GetfilteredHeight(float normalizedHeightPos_x, float normalizedHeightPos_y)
		{
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5A9DB0", Offset = "0x5A83B0", VA = "0x1805A9DB0")]
		private void InitCellContentOnThread()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5AA170", Offset = "0x5A8770", VA = "0x1805AA170")]
		public float InitCellContent(int cellIndex)
		{
			return 0f;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5AB1A0", Offset = "0x5A97A0", VA = "0x1805AB1A0")]
		public GrassManager()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		private static GrassManager _instance;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		public bool AutoInitialize;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x21")]
		public bool DoRenderGrass;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x22")]
		public bool DrawInEditMode;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x23")]
		public bool UpdateHeightMap;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x24")]
		public GrassCameras rtCameraSelection;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x28")]
		public bool rtIngnoreOcclusion;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x2C")]
		public float rtBurstRadius;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x30")]
		public Camera Cam;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x38")]
		public bool IngnoreOcclusion;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		private Transform CamTransform;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x48")]
		public bool showGrid;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x50")]
		private GameObject go;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x58")]
		public Material ProjMat;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x60")]
		public ulong ATGSeed;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x8")]
		public static float OneOverInt32MaxVal;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x68")]
		public Terrain ter;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x70")]
		public TerrainData terData;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x78")]
		public GrassTerrainDefinitions SavedTerrainData;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x80")]
		public bool useBurst;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x84")]
		public float BurstRadius;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x88")]
		[Range(1f, 8f)]
		public int CellsPerFrame;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8C")]
		public float DetailDensity;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x90")]
		private float CurrentDetailDensity;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x94")]
		public bool usingURP;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x95")]
		private bool usingSinglePassInstanced;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer t_argsbuffer;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xA0")]
		private uint[] t_args;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 TerrainPosition;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 TerrainSize;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 OneOverTerrainSize;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xCC")]
		private Vector2 TerrainDetailSize;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xD4")]
		private float SqrTerrainCullingDist;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xD8")]
		private bool ThreadIsRunning;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xE0")]
		private Thread WorkerThread;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xE8")]
		private EventWaitHandle WorkerThreadWait;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xF0")]
		private EventWaitHandle MainThreadWait;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xF8")]
		private List<int> wt_cellindexList;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x100")]
		private int wt_cellindexListCount;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x104")]
		private bool _stopThread;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x108")]
		private object _threadEndSync;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x110")]
		private int TerrainHeightmapWidth;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x114")]
		private int TerrainHeightmapHeight;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x118")]
		private float[] TerrainHeights;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x120")]
		private float OneOverHeightmapWidth;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x124")]
		private float OneOverHeightmapHeight;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x128")]
		private float TerrainSizeOverHeightmap;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x12C")]
		private float OneOverHeightmapWidthRight;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x130")]
		private float OneOverHeightmapHeightUp;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x134")]
		public GrassCameras CameraSelection;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x138")]
		private Camera CameraInWichGrassWillBeDrawn;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x140")]
		public int CameraLayer;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x148")]
		private CullingGroup cullingGroup;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x150")]
		private BoundingSphere[] boundingSpheres;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x158")]
		private BoundingSphere[] origBoundingSpheres;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x160")]
		private int numResults;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x168")]
		private int[] resultIndices;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x170")]
		private bool[] isVisibleBoundingSpheres;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x178")]
		private int numOfVisibleCells;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x17C")]
		public float CullDistance;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x180")]
		private float CurrentCullDistance;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x184")]
		public float FadeLength;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x188")]
		private float CurrentFadeLength;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18C")]
		public float CacheDistance;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x190")]
		private float CurrentCacheDistance;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x194")]
		public float SmallDetailFadeStart;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x198")]
		private float CurrentSmallDetailFadeStart;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x19C")]
		public float SmallDetailFadeLength;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x1A0")]
		private float CurrentSmallDetailFadeLength;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int GrassSmallFadePropsPID;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x1A4")]
		public float DetailFadeStart;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x1A8")]
		private float CurrentDetailFadeStart;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x1AC")]
		public float DetailFadeLength;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x1B0")]
		private float CurrentDetailFadeLength;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x1B4")]
		public float ShadowStart;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x1B8")]
		private float CurrentShadowStart;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x1BC")]
		public float ShadowFadeLength;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x1C0")]
		private float CurrentShadowFadeLength;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x1C4")]
		public float ShadowStartFoliage;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x1C8")]
		private float CurrentShadowStartFoliage;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x1CC")]
		public float ShadowFadeLengthFoliage;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x1D0")]
		private float CurrentShadowFadeLengthFoliage;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x1D4")]
		private Vector4 GrassFadeProperties;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x1E4")]
		private Vector2 GrassSmallFadeProperties;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x1EC")]
		public float CullingGroupDistanceFactor;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x1F0")]
		[Space(12f)]
		private int NumberOfLayers;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x1F4")]
		private int OrigNumberOfLayers;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x1F8")]
		public Mesh[] v_mesh;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x200")]
		private Mesh[] v_meshHigh;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x208")]
		public Mesh[] v_meshLow;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x210")]
		public Material[] v_mat;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x218")]
		public float[] v_clip;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x220")]
		public Vector3[] v_boundsCenter;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x228")]
		public Vector3[] v_boundsExtents;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x230")]
		public RotationMode[] InstanceRotation;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x238")]
		public bool[] WriteNormalBuffer;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x240")]
		public ShadowCastingMode[] ShadowCastingMode;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x248")]
		public MotionVectorGenerationMode[] motionVectorGenerationMode;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x250")]
		public float[] MinSize;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x258")]
		public float[] MaxSize;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x260")]
		public float[] Noise;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x268")]
		public int[] LayerToMergeWith;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x270")]
		public bool[] DoSoftMerge;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x278")]
		public int[][] SoftlyMergedLayers;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x280")]
		public bool rtUseCompute;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x281")]
		public bool UseCompute;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x284")]
		public float GrassInstanceSize;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x288")]
		private int NumberOfFinalLayers;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x290")]
		private int[] FinalLayersIndices;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x298")]
		private GraphicsBuffer[] MergedCellcontentsBuffer;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x2A0")]
		private GraphicsBuffer DummyMatrixBuffer;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x2A8")]
		private GraphicsBuffer DummyMergeBuffer;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x2B0")]
		private MaterialPropertyBlock[] MergedMatrixBlock;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x2B8")]
		private int[] LayersMaxDensity;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x2C0")]
		private GrassManager.LayerData[] layerData;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		private ComputeShader ComputeCellcontentsBufferShader;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x2D0")]
		private int ComputeCellcontentsKernel;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x2D4")]
		private int SourceCellcontentsBufferID;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x2D8")]
		private int MergedCellcontentsBufferID;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x2DC")]
		private int AtgVPPID;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x2E0")]
		private int AtgVPID;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x2E4")]
		private int AtgCameraPositionPID;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x2E8")]
		private int AtgSurfaceCameraPositionPID;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x2EC")]
		private int AtgCameraForwardPID;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x2F0")]
		private int AtgInstanceCountPID;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x2F4")]
		private int AtgCullDistSqrPID;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x2F8")]
		private int AtgGrassFadePropsPID;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x2FC")]
		private int AtgTerrainShiftComputePID;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x300")]
		private int AtgClipValPID;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x304")]
		private int AtgBoundsCenterPID;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x308")]
		private int AtgBoundsExtentsPID;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int _AtgClipVal0;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int _AtgClipVal1;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int _AtgClipVal2;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int _AtgClipVal3;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int _AtgClipVal4;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int _AtgClipVal5;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int _AtgInstanceCount0;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int _AtgInstanceCount1;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int _AtgInstanceCount2;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int _AtgInstanceCount3;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int _AtgInstanceCount4;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int _AtgInstanceCount5;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int CellcontentsSourceBuffer0;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int CellcontentsSourceBuffer1;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int CellcontentsSourceBuffer2;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly int CellcontentsSourceBuffer3;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int CellcontentsSourceBuffer4;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x54")]
		private static readonly int CellcontentsSourceBuffer5;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x58")]
		private static readonly int MergedCellcontentsBuffer0;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x5C")]
		private static readonly int MergedCellcontentsBuffer1;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x60")]
		private static readonly int MergedCellcontentsBuffer2;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x64")]
		private static readonly int MergedCellcontentsBuffer3;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x68")]
		private static readonly int MergedCellcontentsBuffer4;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x6C")]
		private static readonly int MergedCellcontentsBuffer5;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x310")]
		private int[] ClipValArray;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x318")]
		private int[] InstanceCountArray;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x320")]
		private int[] CellcontentsSourceBufferArray;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x328")]
		private int[] MergedCellcontentsBufferArray;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x330")]
		private float[] VP_MatrixAsFloats;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x338")]
		private Matrix4x4 VP_Matrix;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x378")]
		public AtgHiZBuffer HiZBuffer;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x380")]
		private int AtgHiZBufferPID;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x384")]
		private int AtgHiZBufferSizePID;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x388")]
		public bool EnableTerrainShift;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x38C")]
		private Vector3 TerrainShift;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x398")]
		private int AtgTerrainShiftSurfacePID;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x3A0")]
		private byte[][] mapByte;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x3A8")]
		private int GrassMatrixBufferPID;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x3AC")]
		private int TotalCellCount;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x3B0")]
		private int NumberOfCells;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x3B4")]
		public BucketsPerCell NumberOfBucketsPerCellEnum;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x3B8")]
		private int NumberOfBucketsPerCell;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x3BC")]
		private float CellSize;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x3C0")]
		private float BucketSize;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x3C4")]
		private bool firstFrameSkipped;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x3C8")]
		private int maxBucketDensity;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x3D0")]
		private Matrix4x4[] tempMatrixArray;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x3D8")]
		private Vector2 samplePosition;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x3E0")]
		private Vector2 tempSamplePosition;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x3E8")]
		private GrassCell[] Cells;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x3F0")]
		private GrassCellContent[] CellContent;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x3F8")]
		private List<int> CellsOrCellContentsToInit;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x400")]
		private int GrassFadePropsPID;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x404")]
		private Vector4 GrassFadeProps;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x414")]
		private int GrassShadowFadePropsPID;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x418")]
		private Vector2 GrassShadowFadeProps;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x420")]
		private Matrix4x4 tempMatrix;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x460")]
		private Vector3 tempPosition;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x46C")]
		private Quaternion tempRotation;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x47C")]
		private Vector3 tempScale;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x488")]
		private Quaternion ZeroQuat;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x498")]
		public bool FreezeSizeAndColor;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x499")]
		public bool DebugStats;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x49A")]
		public bool DebugCells;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x49B")]
		public bool FirstTimeSynced;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x49C")]
		public int LayerEditMode;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x4A0")]
		public int LayerSelection;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x4A4")]
		public bool Foldout_Rendersettings;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x4A5")]
		public bool Foldout_Advancedsettings;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x4A6")]
		public bool Foldout_Prototypes;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x4A7")]
		public bool AutoUpdateDensity;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x4A8")]
		private int UpdateCounter;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x4AC")]
		private bool isInitialized;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x4B0")]
		private int[] CurrentlyAffectedCells;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x4B8")]
		private bool _usingVulkan;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		private struct LayerData
		{
			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public RenderParams rp;

			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0x60")]
			[NonSerialized]
			public GraphicsBuffer commandBuf;

			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x68")]
			[NonSerialized]
			public GraphicsBuffer.IndirectDrawIndexedArgs[] commandData;
		}
	}
}
