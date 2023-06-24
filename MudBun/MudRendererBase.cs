using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace MudBun
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[ExecuteInEditMode]
	public abstract class MudRendererBase : MonoBehaviour
	{
		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x23CE5F0", Offset = "0x23CCBF0", VA = "0x1823CE5F0")]
		private void BuildMesh(Mesh mesh, MudRendererBase.GeneratedMeshType meshType, NativeArray<GenPoint> aGenPoint, Transform rootBone, List<Transform> bones, bool doRigging, bool generateTextureUV, bool generateLightMapUV, bool weldVertices, bool optimizeMeshForRendering)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x23CF7F0", Offset = "0x23CDDF0", VA = "0x1823CF7F0")]
		private void BuildMeshOpt(Mesh mesh, MudRendererBase.GeneratedMeshType meshType, NativeArray<GenPoint> aGenPoint, Transform rootBone, List<Transform> bones, bool doRigging, bool generateTextureUV, bool generateLightMapUV, bool weldVertices, bool optimizeMeshForRendering)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x23D0AC0", Offset = "0x23CF0C0", VA = "0x1823D0AC0")]
		private void BuildMeshJob(Mesh mesh, MudRendererBase.GeneratedMeshType meshType, NativeArray<GenPoint> aGenPoint, Transform rootBone, List<Transform> bones, bool doRigging, bool generateTextureUV, bool generateLightMapUV, bool weldVertices, bool optimizeMeshForRendering)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public virtual void InvokeOnMeshGenerated(Mesh mesh)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006F")]
		public static int[] VoxelTreeBranchingFactors
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x23D0C00", Offset = "0x23CF200", VA = "0x1823D0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x17000070")]
		public static int VoxelNodeDepth
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x23D0C50", Offset = "0x23CF250", VA = "0x1823D0C50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x17000071")]
		public static int ChunkVoxelDensity
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x23D0CE0", Offset = "0x23CF2E0", VA = "0x1823D0CE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x17000072")]
		public static int MaxBrushMaskInts
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x23D0FA0", Offset = "0x23CF5A0", VA = "0x1823D0FA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000073")]
		public static int[] NoiseCacheDimensionInts
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x23D1000", Offset = "0x23CF600", VA = "0x1823D1000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000074")]
		public static float[] NoiseCacheDimensionFloats
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x23D1050", Offset = "0x23CF650", VA = "0x1823D1050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000075")]
		public static float[] NoiseCachePeriod
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x23D1360", Offset = "0x23CF960", VA = "0x1823D1360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x17000076")]
		public int VoxelToVertexFactor
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x23D1670", Offset = "0x23CFC70", VA = "0x1823D1670")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000077")]
		public static RenderTexture NoiseCache
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x23D1690", Offset = "0x23CFC90", VA = "0x1823D1690")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x17000078")]
		public static ResourcesUtil.RenderPipelineEnum RenderPipeline
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x23D16F0", Offset = "0x23CFCF0", VA = "0x1823D16F0")]
			get
			{
				return ResourcesUtil.RenderPipelineEnum.BuiltIn;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x17000079")]
		public static int GlobalResourceGpuMemoryAllocated
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x23D1770", Offset = "0x23CFD70", VA = "0x1823D1770")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x23D20D0", Offset = "0x23D06D0", VA = "0x1823D20D0")]
		public static void ReloadAllShaders()
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x1700007A")]
		public int MaxVoxels
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x23D2250", Offset = "0x23D0850", VA = "0x1823D2250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x1700007B")]
		public int MaxVoxelNodes
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x23D2260", Offset = "0x23D0860", VA = "0x1823D2260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x1700007C")]
		public int MaxBrushMasks
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x23D2270", Offset = "0x23D0870", VA = "0x1823D2270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x1700007D")]
		public int MaxGenPoints
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x23D2280", Offset = "0x23D0880", VA = "0x1823D2280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x1700007E")]
		public float TopVoxelNodeSize
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x23D22B0", Offset = "0x23D08B0", VA = "0x1823D22B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007F")]
		public float[] NodeSizes
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x23D2360", Offset = "0x23D0960", VA = "0x1823D2360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x17000080")]
		public Vector4 NodeSizesVector
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x23D2590", Offset = "0x23D0B90", VA = "0x1823D2590")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x17000081")]
		public float VoxelSize
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x23D2640", Offset = "0x23D0C40", VA = "0x1823D2640")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x17000082")]
		private bool AllowSharedRWBuffers
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x23D2700", Offset = "0x23D0D00", VA = "0x1823D2700")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x17000083")]
		private NativeArray<int> IndirectDrawArgsInitData
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x23D27A0", Offset = "0x23D0DA0", VA = "0x1823D27A0")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x17000084")]
		private static NativeArray<int> NumAllocatoinsBufferInitData
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x23D2AB0", Offset = "0x23D10B0", VA = "0x1823D2AB0")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x17000085")]
		private static NativeArray<int> UnitIndirectDispatchArgsInitData
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x23D2CD0", Offset = "0x23D12D0", VA = "0x1823D2CD0")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x17000086")]
		public int NodeHashTableSize
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x23D2EA0", Offset = "0x23D14A0", VA = "0x1823D2EA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x17000087")]
		public int AutoSmoothVertDataTableSize
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x23D2F40", Offset = "0x23D1540", VA = "0x1823D2F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x17000088")]
		public long LocalResourceGpuMemoryAllocated
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x23D2FA0", Offset = "0x23D15A0", VA = "0x1823D2FA0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x17000089")]
		public long LocalResourceGpuMemoryUsed
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x23D3A80", Offset = "0x23D2080", VA = "0x1823D3A80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x1700008A")]
		public int NumVerticesAllocated
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x23D45B0", Offset = "0x23D2BB0", VA = "0x1823D45B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x1700008B")]
		public int NumVerticesGenerated
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x23D45F0", Offset = "0x23D2BF0", VA = "0x1823D45F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x1700008C")]
		public int NumVoxelsAllocated
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x23D4790", Offset = "0x23D2D90", VA = "0x1823D4790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x1700008D")]
		public int NumChunksAllocated
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x23D47B0", Offset = "0x23D2DB0", VA = "0x1823D47B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x1700008E")]
		public int NumVoxelsUsed
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x23D47D0", Offset = "0x23D2DD0", VA = "0x1823D47D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x1700008F")]
		public int NumChunksUsed
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x23D49C0", Offset = "0x23D2FC0", VA = "0x1823D49C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x23D4BB0", Offset = "0x23D31B0", VA = "0x1823D4BB0")]
		private bool ShouldForceAllBrushes()
		{
			return default(bool);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x17000090")]
		public MudRendererBase.RenderModeCategoryEnum RenderModeCategory
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x23D4BC0", Offset = "0x23D31C0", VA = "0x1823D4BC0")]
			get
			{
				return MudRendererBase.RenderModeCategoryEnum.Mesh;
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x23D4C20", Offset = "0x23D3220", VA = "0x1823D4C20")]
		private static MudRendererBase.RenderModeCategoryEnum GetMaterialRenderModeCategory(Material material)
		{
			return MudRendererBase.RenderModeCategoryEnum.Mesh;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x23D4D90", Offset = "0x23D3390", VA = "0x1823D4D90")]
		private static bool MaterialNeedsSdfProperties(Material material)
		{
			return default(bool);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x23D4EC0", Offset = "0x23D34C0", VA = "0x1823D4EC0")]
		private static bool MaterialNeedsRayMarchingProperties(Material material)
		{
			return default(bool);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x17000091")]
		private MudRendererBase.RenderGeometryTypeEnum RenderGeometryType
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x23D4FF0", Offset = "0x23D35F0", VA = "0x1823D4FF0")]
			get
			{
				return MudRendererBase.RenderGeometryTypeEnum.Mesh;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x17000092")]
		private bool RenderMaterialNeedsSdfProperties
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x23D5040", Offset = "0x23D3640", VA = "0x1823D5040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x17000093")]
		public float NormalDifferentialStep
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x23D51B0", Offset = "0x23D37B0", VA = "0x1823D51B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x17000094")]
		private bool ShouldDoAutoSmoothing
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x23D5210", Offset = "0x23D3810", VA = "0x1823D5210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000095")]
		public ICollection<MudBrushBase> Brushes
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x23D5250", Offset = "0x23D3850", VA = "0x1823D5250")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x23D5260", Offset = "0x23D3860", VA = "0x1823D5260")]
		private void ValidateAabbTree()
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00003CF0 File Offset: 0x00001EF0
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public Color MasterColor
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x23D5360", Offset = "0x23D3960", VA = "0x1823D5360")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x23D5450", Offset = "0x23D3A50", VA = "0x1823D5450")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00003D08 File Offset: 0x00001F08
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public Color MasterEmission
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x23D5460", Offset = "0x23D3A60", VA = "0x1823D5460")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x23D5550", Offset = "0x23D3B50", VA = "0x1823D5550")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00003D20 File Offset: 0x00001F20
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		public float MasterMetallic
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x23D5560", Offset = "0x23D3B60", VA = "0x1823D5560")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x23D5650", Offset = "0x23D3C50", VA = "0x1823D5650")]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00003D38 File Offset: 0x00001F38
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		public float MasterSmoothness
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x23D5660", Offset = "0x23D3C60", VA = "0x1823D5660")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x23D5750", Offset = "0x23D3D50", VA = "0x1823D5750")]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700009A")]
		public Material RenderMaterial
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x23D5760", Offset = "0x23D3D60", VA = "0x1823D5760")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700009B")]
		public MaterialPropertyBlock RenderMaterialPropertyBlock
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x23D57D0", Offset = "0x23D3DD0", VA = "0x1823D57D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x1700009C")]
		public Aabb RenderBounds
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x23D58C0", Offset = "0x23D3EC0", VA = "0x1823D58C0")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x1700009D")]
		public Aabb RenderBoundsRs
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x23D59E0", Offset = "0x23D3FE0", VA = "0x1823D59E0")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700009E")]
		public string FirstTrackedVersion
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x23D5B60", Offset = "0x23D4160", VA = "0x1823D5B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700009F")]
		public string PreviousTrackedVersion
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x23D5B70", Offset = "0x23D4170", VA = "0x1823D5B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A0")]
		public string CurrentTrackedVersion
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x23D5B80", Offset = "0x23D4180", VA = "0x1823D5B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x170000A1")]
		public float MeshGenerationVoxelDensity
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x23D5B90", Offset = "0x23D4190", VA = "0x1823D5B90")]
		private bool HashNonMudBunObjectInHierarchy(Transform t)
		{
			return default(bool);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x23D60F0", Offset = "0x23D46F0", VA = "0x1823D60F0")]
		private bool HasBrushInHierarchy(Transform t)
		{
			return default(bool);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x23D6320", Offset = "0x23D4920", VA = "0x1823D6320")]
		private void DetectMixedHierarchy(Transform t)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x23D63B0", Offset = "0x23D49B0", VA = "0x1823D63B0")]
		private void CacheBoneTransforms()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x23D6600", Offset = "0x23D4C00", VA = "0x1823D6600")]
		private void NormalizeBoneTransforms()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x23D6DB0", Offset = "0x23D53B0", VA = "0x1823D6DB0")]
		private void CacheBoneTransformsRecursive(Transform t)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x23D7450", Offset = "0x23D5A50", VA = "0x1823D7450")]
		private void RestoreBoneTransforms()
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x170000A2")]
		public bool IsAnyMeshGenerationPending
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x23D7B20", Offset = "0x23D6120", VA = "0x1823D7B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x23D7B70", Offset = "0x23D6170", VA = "0x1823D7B70")]
		public bool IsMeshGenerationPending(Mesh mesh)
		{
			return default(bool);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x23D7DE0", Offset = "0x23D63E0", VA = "0x1823D7DE0")]
		public void WaitForMeshGeneration(Mesh mesh)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x23D80C0", Offset = "0x23D66C0", VA = "0x1823D80C0")]
		public Mesh GenerateMesh(MudRendererBase.GeneratedMeshType meshType, bool async, [Optional] Mesh mesh, bool generateTextureUV = false, bool generateLightMapUV = false, bool weldVertices = false, bool optimizeMeshForRendering = false)
		{
			return null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x23D8120", Offset = "0x23D6720", VA = "0x1823D8120")]
		public Mesh GenerateMesh(MudRendererBase.GeneratedMeshType meshType, Transform rootBone, out Transform[] aBone, bool async, [Optional] Mesh mesh, bool genreateTextureUV = false, bool generateLightMapUV = false, bool weldVertices = false, bool optimizeMeshForRendering = false)
		{
			return null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x23D8850", Offset = "0x23D6E50", VA = "0x1823D8850")]
		private void OnIndirectDrawArgsBufferRead(AsyncGPUReadbackRequest request)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x23D8C20", Offset = "0x23D7220", VA = "0x1823D8C20")]
		private void OnGenPointsBufferRead(AsyncGPUReadbackRequest request)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public virtual void RectifyNonUnitScaledParents()
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		protected virtual bool GenerateUV(Mesh mesh, bool generateTextureUV, bool generateLightMapUV)
		{
			return default(bool);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x170000A3")]
		public bool MeshLocked
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x23D9240", Offset = "0x23D7840", VA = "0x1823D9240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x170000A4")]
		protected virtual MudRendererBase.LockMeshIntermediateStateEnum LockMeshIntermediateState
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "7")]
			get
			{
				return MudRendererBase.LockMeshIntermediateStateEnum.Idle;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		public virtual Mesh AddCollider(GameObject go, bool async, [Optional] Mesh mesh, bool forceConvexCollider = false, bool makeRigidBody = false)
		{
			return null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "9")]
		public virtual Mesh AddLockedStandardMesh(GameObject go, bool autoRigging, bool async, [Optional] Mesh mesh, bool generateTextureUV = false, bool generateLightMapUV = false, bool weldVertices = false, bool optimizeMeshForRendering = false)
		{
			return null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x23D9250", Offset = "0x23D7850", VA = "0x1823D9250", Slot = "10")]
		public virtual void LockMesh(bool autoRigging, bool async, [Optional] Mesh mesh, bool generateTextureUV = false, bool generateLightMapUV = false, bool weldVertices = false, bool optimizeMeshForRendering = false)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x23D9260", Offset = "0x23D7860", VA = "0x1823D9260")]
		public void RememberLockedMeshMaterial()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x23D9540", Offset = "0x23D7B40", VA = "0x1823D9540", Slot = "11")]
		public virtual void UnlockMesh()
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x23D9580", Offset = "0x23D7B80", VA = "0x1823D9580")]
		public void ValidateAssetNames()
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x23D9A80", Offset = "0x23D8080", VA = "0x1823D9A80", Slot = "12")]
		public virtual void GenerateSdf(RenderTexture sdf, Vector3 origin, Vector3 dimension)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x23D9EE0", Offset = "0x23D84E0", VA = "0x1823D9EE0", Slot = "13")]
		public virtual void GenerateSdf(Texture3D sdf, Vector3 origin, Vector3 dimension)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x23DA250", Offset = "0x23D8850", VA = "0x1823DA250")]
		internal void UpdateComputeData()
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x23DA2A0", Offset = "0x23D88A0", VA = "0x1823DA2A0")]
		public static MudBrushBase LookupBrush(float hash)
		{
			return null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		protected virtual void OnSharedMaterialChanged(UnityEngine.Object material)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x23DA3C0", Offset = "0x23D89C0", VA = "0x1823DA3C0", Slot = "15")]
		protected virtual void InitBeforeFirstRenderer()
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x23DA400", Offset = "0x23D8A00", VA = "0x1823DA400", Slot = "16")]
		protected virtual void CleanUpAfterLastRenderer()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x23DA570", Offset = "0x23D8B70", VA = "0x1823DA570")]
		private void Start()
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x23DA6B0", Offset = "0x23D8CB0", VA = "0x1823DA6B0", Slot = "17")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x23DAE70", Offset = "0x23D9470", VA = "0x1823DAE70", Slot = "18")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x23DB330", Offset = "0x23D9930", VA = "0x1823DB330", Slot = "19")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x23DB370", Offset = "0x23D9970", VA = "0x1823DB370")]
		internal void OnBrushDisabled(MudBrushBase brush)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x23DB380", Offset = "0x23D9980", VA = "0x1823DB380")]
		public void MarkNeedsCompute()
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x23DB3A0", Offset = "0x23D99A0", VA = "0x1823DB3A0")]
		private bool UpdateNeedsCompute()
		{
			return default(bool);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x23DBAE0", Offset = "0x23DA0E0", VA = "0x1823DBAE0")]
		public void MarkRenderMaterialDirty()
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
		protected virtual bool IsEditorBusy()
		{
			return default(bool);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x23DBAF0", Offset = "0x23DA0F0", VA = "0x1823DBAF0")]
		private void TryAutoAdjustBudgets()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "21")]
		protected virtual bool PreUpdateValidate()
		{
			return default(bool);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x23DBB30", Offset = "0x23DA130", VA = "0x1823DBB30")]
		protected void LateUpdate()
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x23DBEF0", Offset = "0x23DA4F0", VA = "0x1823DBEF0")]
		public void ForceCompute()
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x23DBF00", Offset = "0x23DA500", VA = "0x1823DBF00", Slot = "22")]
		public virtual void ReloadShaders()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x23DBF70", Offset = "0x23DA570", VA = "0x1823DBF70")]
		private void TryCompute(bool forceCompute = false)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x23DC0A0", Offset = "0x23DA6A0", VA = "0x1823DC0A0")]
		private void SanitizeParameters()
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x23DC130", Offset = "0x23DA730", VA = "0x1823DC130")]
		private bool ValidateResources()
		{
			return default(bool);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x23DC190", Offset = "0x23DA790", VA = "0x1823DC190")]
		public static void ValidateShaderConstantId()
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x23DED40", Offset = "0x23DD340", VA = "0x1823DED40")]
		private static void RegisterCommonMeshingConstants(ComputeShader shader)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x23DF370", Offset = "0x23DD970", VA = "0x1823DF370")]
		public static bool ValidateComputeShaders()
		{
			return default(bool);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x23E2E60", Offset = "0x23E1460", VA = "0x1823E2E60")]
		private bool ValidateGlobalResources()
		{
			return default(bool);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x23E36E0", Offset = "0x23E1CE0", VA = "0x1823E36E0", Slot = "23")]
		protected virtual bool ValidateLocalResources()
		{
			return default(bool);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x23E4960", Offset = "0x23E2F60", VA = "0x1823E4960")]
		protected static void DisposeGlobalResources()
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x23E5090", Offset = "0x23E3690", VA = "0x1823E5090")]
		protected void DisposeLocalResources()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x23E5970", Offset = "0x23E3F70", VA = "0x1823E5970")]
		public void AddBrush(MudBrushBase brush)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x23E5C80", Offset = "0x23E4280", VA = "0x1823E5C80")]
		public void RemoveBrush(MudBrushBase brush)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x23E5E20", Offset = "0x23E4420", VA = "0x1823E5E20")]
		public void DestroyAllBrushes()
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x23E6070", Offset = "0x23E4670", VA = "0x1823E6070")]
		public void DestroyAllBrushesImmediate()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x23E62C0", Offset = "0x23E48C0", VA = "0x1823E62C0", Slot = "24")]
		public virtual void NotifyHierarchyChange()
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x23E62D0", Offset = "0x23E48D0", VA = "0x1823E62D0")]
		private void ClearBrushes()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x23E62C0", Offset = "0x23E48C0", VA = "0x1823E62C0")]
		public void RescanBrushes()
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x23E6510", Offset = "0x23E4B10", VA = "0x1823E6510")]
		public void RescanBrushesImmediate()
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x23E66E0", Offset = "0x23E4CE0", VA = "0x1823E66E0")]
		private int ComputeBrushListHash()
		{
			return 0;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x23E6840", Offset = "0x23E4E40", VA = "0x1823E6840")]
		private void ScanHierarchyRecursive(Transform parent)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x23E6D40", Offset = "0x23E5340", VA = "0x1823E6D40")]
		private void SetUpResources()
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x23E6D60", Offset = "0x23E5360", VA = "0x1823E6D60")]
		private void UpdateActivePreCompute()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x23E72D0", Offset = "0x23E58D0", VA = "0x1823E72D0")]
		private void UpdateActivePostCompute()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x23E7370", Offset = "0x23E5970", VA = "0x1823E7370")]
		private bool ValidateAabbTreeBuffer(ref ComputeBuffer aabbTreeBuffer)
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x23E7530", Offset = "0x23E5B30", VA = "0x1823E7530")]
		private void ValidateRenderMaterial()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "25")]
		protected virtual bool ShouldHighlightBrushFromSelection(MudBrushBase brush)
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x23E79D0", Offset = "0x23E5FD0", VA = "0x1823E79D0")]
		private void UpdateBrushData()
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x23E8210", Offset = "0x23E6810", VA = "0x1823E8210")]
		private void UpdateAabbTreeData()
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x23E9160", Offset = "0x23E7760", VA = "0x1823E9160")]
		private void WriteResources()
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x23EA990", Offset = "0x23E8F90", VA = "0x1823EA990")]
		private void BindComputeResources()
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x23EB1A0", Offset = "0x23E97A0", VA = "0x1823EB1A0")]
		private void BindRenderResources()
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x23ED140", Offset = "0x23EB740", VA = "0x1823ED140")]
		private void SetComputeNodeDepth(int depth)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x23ED2A0", Offset = "0x23EB8A0", VA = "0x1823ED2A0")]
		private void ComputeGpu()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ComputeCpu()
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x23EEBF0", Offset = "0x23ED1F0", VA = "0x1823EEBF0")]
		private void Render()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x23EF1B0", Offset = "0x23ED7B0", VA = "0x1823EF1B0")]
		private void UnpackVertex(Mesh mesh, NativeArray<GenPoint> aGenPoint)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x23EF6B0", Offset = "0x23EDCB0", VA = "0x1823EF6B0")]
		private void UnpackTint(Mesh mesh, NativeArray<GenPoint> aGenPoint)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x23EFE30", Offset = "0x23EE430", VA = "0x1823EFE30")]
		private void WeldVertex(Mesh mesh, int numVerts, int textureUvIndex)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x23F19D0", Offset = "0x23EFFD0", VA = "0x1823F19D0")]
		protected MudRendererBase()
		{
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		public const int ThreadGroupExtent = 4;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int ThreadGroupSize;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		public const int ClearThreadGroupSize = 256;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int VoxelTreeBranchingFactorsCompressed;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static int s_chunkVoxelDensity;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int MaxBrushes;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int MaxBrushGroupDepth;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int[] s_noiseCacheDimensionInts;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float[] s_noiseCacheDimensionFloats;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly float NoiseCacheDensity;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static float[] s_noiseCachePeriod;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static bool s_globalResourcesValid;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected static HashSet<MudRendererBase> s_renderers;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected static Dictionary<float, MudBrushBase> s_brushMap;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static ComputeShader s_computeVoxelGen;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static ComputeShader s_computeMarchingCubes;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static ComputeShader s_computeDualMeshing;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static ComputeShader s_computeSurfaceNets;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static ComputeShader s_computeDualContouring;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static ComputeShader s_computeRayTracedVoxels;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static ComputeShader s_computeNoiseCache;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static ComputeShader s_computeMeshLock;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static ComputeShader s_computeSdfGen;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static ComputeBuffer s_triTableBuffer;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static ComputeBuffer s_vertTableBuffer;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static ComputeBuffer s_triTable2dBuffer;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static ComputeBuffer s_brushesBuffer;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static ComputeBuffer s_brushMaterialBuffer;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static ComputeBuffer s_aabbTreeBuffer;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static ComputeBuffer s_dummyBuffer;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static RenderTexture s_noiseCache;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_localResourcesValid;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected NativeArray<SdfBrush> m_aSdfBrush;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected NativeArray<SdfBrushMaterial> m_aSdfBrushMaterial;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Dictionary<int, int> m_sdfBrushMaterialIndexMap;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(1f, 2048f)]
		public int MaxVoxelsK;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(16f, 1024f)]
		public int MaxChunks;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool UseVoxelCache;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool ShowGpuMemoryUsage;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool AutoAdjustBudgetsToHighWaterMarks;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 100f)]
		public int AutoAdjustBudgetsToHighWaterMarksMarginPercent;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_autoAdjustBudgetsToHighWaterMarks;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0.1f, 100f)]
		public float VoxelDensity;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] m_aNodeSize;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ComputeBuffer m_brushesBuffer;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ComputeBuffer m_brushMaterialBuffer;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ComputeBuffer m_aabbTreeBuffer;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int m_aabbTreeBufferRoot;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ComputeBuffer m_nodeHashTableBuffer;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected ComputeBuffer m_nodePoolBuffer;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected ComputeBuffer m_numNodesAllocatedBuffer;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ComputeBuffer m_numAllocationsBuffer;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ComputeBuffer m_voxelCacheIdTableBuffer;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ComputeBuffer m_voxelCacheBuffer;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ComputeBuffer m_brushMaskPoolBuffer;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ComputeBuffer m_indirectDispatchArgsBuffer;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ComputeBuffer m_autoSmoothVertDataTableBuffer;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected ComputeBuffer m_genPointsBufferDefault;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected ComputeBuffer m_indirectDrawArgsBufferDefault;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected ComputeBuffer m_genPointsBufferOverride;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected ComputeBuffer m_indirectDrawArgsBufferOverride;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected ComputeBuffer m_genPointsBufferUsedForCompute;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected ComputeBuffer m_indirectDrawArgsBufferUsedForCompute;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private NativeArray<int> m_indirectDrawArgsInitData;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static NativeArray<int> s_numAllocatoinsBufferInitData;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static NativeArray<int> s_unitIndirectDispatchArgsInitData;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int[] m_numAllocationsBufferInitData;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static readonly int NodeHashTableAllocationMultiplier;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private static readonly int AutoSmoothVertDataAllocationMultiplier;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static bool s_warnedResourceAccessPerformanceImpact;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool ForceEvaluateAllBrushes;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		public bool Enable2dMode;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Range(-1f, 1f)]
		public float SurfaceShift;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public MudRendererBase.HardwareModeEnum HardwareMode;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public MudRendererBase.RenderModeEnum RenderMode;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public MudRendererBase.MeshingModeEnum MeshingMode;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public MudRendererBase.RayTracedVoxelModeEnum RayTracedVoxelMode;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Range(0f, 1f)]
		public float RayTracedVoxelSizeMultiplier;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[Range(0f, 1f)]
		public float RayTracedVoxelSmoothCubeNormal;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Range(0f, 1f)]
		public float RayTracedVoxelSphereFullness;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public MudRendererBase.RayTracedVoxelPaddingModeEnum RayTracedVoxelPaddingMode;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float RayTracedVoxelInternalPaddingDistance;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float RayTracedVoxelSizeFadeDistance;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private MudRendererBase.RenderGeometryTypeEnum m_prevRenderGeometryType;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public bool ShowAdvancedNormalOptions;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Range(0f, 1f)]
		public float SmoothNormalBlurRelative;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[Range(0f, 0.2f)]
		public float SmoothNormalBlurAbsolute;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[Range(0f, 1f)]
		public float NormalQuantization;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[Range(0f, 1f)]
		public float Normal2dFade;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Range(0f, 1f)]
		public float Normal2dStrength;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool EnableAutoSmoothing;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[Range(0f, 180f)]
		public float AutoSmoothingMaxAngle;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public bool EnableSmoothCorner;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Range(1f, 4f)]
		public int SmoothCornerSubdivision;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[Range(0.001f, 0.1f)]
		public float SmoothCornerNormalBlur;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Range(0f, 1f)]
		public float SmoothCornerFade;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public bool ShowAdvancedSplatOptions;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Range(0f, 5f)]
		public float SplatSize;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[Range(0f, 1f)]
		public float SplatSizeJitter;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Range(-1f, 1f)]
		public float SplatNormalShift;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[Range(0f, 1f)]
		public float SplatNormalShiftJitter;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Range(0f, 1f)]
		public float SplatColorJitter;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[Range(0f, 1f)]
		public float SplatPositionJitter;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Range(0f, 1f)]
		public float SplatRotationJitter;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		[Range(0f, 1f)]
		public float SplatOrientationJitter;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[Range(0f, 1f)]
		public float SplatOriginalNormalBlend;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[Range(0.01f, 1f)]
		public float SplatJitterNoisiness;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[Range(0f, 1f)]
		public float SplatCameraFacing;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public bool SplatNormalsMatchCameraFacing;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		public bool SplatShadowsMatchCameraFacing;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[Range(0f, 1f)]
		public float SplatScreenSpaceFlattening;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[Range(0f, 1f)]
		public float SurfaceNetsDualQuadsBlend;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool ShowAdvancedGeometryOptions;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool SurfaceNetsHighAccuracyMode;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		[Range(0f, 1f)]
		public float DualContouringDualQuadsBlend;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[Range(0f, 1f)]
		public float DualContouringRelaxation;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool DualContouringHighAccuracyMode;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public ShadowCastingMode CastShadows;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool ReceiveShadows;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<MudBrushBase> m_aBrush;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<MudBrushBase> m_aBrushToProcess;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool m_needRescanBrushes;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private static readonly float AabbTreeFatBoundsRadius;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		internal AabbTree<MudBrushBase> m_aabbTree;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private MudSharedMaterialBase m_usedSharedMaterial;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public MudSharedMaterialBase SharedMaterial;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private Color m_masterColor;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private Color m_masterEmission;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_masterMetallic;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_masterSmoothness;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public Material RenderMaterialMesh;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public Material RenderMaterialSplats;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public Material RenderMaterialDecal;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public Material RenderMaterialRayMarchedSurface;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public Material RenderMaterialRayTracedVoxels;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private Material m_materialCloned;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Material m_materialUsed;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private MaterialPropertyBlock m_materialProps;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[Range(8f, 256f)]
		public int MaxRayMarchSteps;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		[Range(0f, 1f)]
		public float RayMarchAccuracy;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[Range(1f, 2000f)]
		public float RayMarchMaxRayDistance;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		[Range(0.1f, 10f)]
		public float RayMarchStepSize;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		[Range(1f, 16f)]
		public int NumLightMarchSteps;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		[Range(0f, 20f)]
		public float RayMarchVolumeDensity;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public Light RayMarchLight;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[Range(0f, 10f)]
		public float RayMarchVolumeAbsorption;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		[Range(0f, 10f)]
		public float RayMarchLightAbsorption;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[Range(0f, 1f)]
		public float RayMarchDarknesThreshold;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		[Range(0f, 10f)]
		public float RayMarchTransmittanceCurve;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public bool UseRayMarchNoise;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		[Range(0f, 1f)]
		public float RayMarchNoiseThreshold;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		[Range(0f, 10f)]
		public float RayMarchNoiseEdgeFade;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		public Vector3 RayMarchNoiseScrollSpeed;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public Vector3 RayMarchNoiseBaseOctaveSize;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
		[Range(1f, 3f)]
		public int RayMarchNoiseNumOctaves;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public float RayMarchNoiseOctaveOffsetFactor;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private Sdf.EvalJob[] m_aEvalJob;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public MudRendererBase.ClickSelectionEnum ClickSelection;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		public bool AlwaysDrawGizmos;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DD")]
		public bool DrawRawBrushBounds;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DE")]
		public bool DrawComputeBrushBounds;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DF")]
		public bool DrawRenderBounds;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public bool DrawVoxelNodes;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		[Range(-1f, 3f)]
		public int DrawVoxelNodesDepth;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		[Range(0f, 1f)]
		public float DrawVoxelNodesScale;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		[SerializeField]
		[HideInInspector]
		private string m_firstTrackedVersion;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		[SerializeField]
		[HideInInspector]
		private string m_previousTrackedVersion;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		[SerializeField]
		[HideInInspector]
		private string m_currentTrackedVersion;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static readonly float MaxMeshGenerationVoxelDensityFreeVersion;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public static readonly int MaxMeshGenerationTrianglesFreeVersion;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public bool MeshGenerationCreateNewObject;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x309")]
		public bool MeshGenerationCreateCollider;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30A")]
		public bool MeshGenerationForceConvexCollider;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		[Range(-1f, 1f)]
		public float MeshGenerationColliderSurfaceShift;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public bool MeshGenerationCreateRigidBody;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x311")]
		public bool GenerateColliderMeshAssetByEditor;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public string GenerateColliderMeshAssetByEditorName;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		[Range(0f, 128f)]
		public float MeshGenerationColliderVoxelDensity;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		public MudRendererBase.RenderableMeshMode MeshGenerationRenderableMeshMode;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public bool MeshGenerationAutoRigging;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x329")]
		public bool MeshGenerationGenerateTextureUV;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32A")]
		public bool MeshGenerationGenerateLightMapUV;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32B")]
		public bool MeshGenerationWeldVertices;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		public bool MeshGenerationLockOnStart;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32D")]
		public bool GenerateMeshAssetByEditor;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public string GenerateMeshAssetByEditorName;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public bool RecursiveLockMeshByEditor;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x339")]
		public bool RememberLockedMeshMaterialByEditor;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33A")]
		[SerializeField]
		[HideInInspector]
		public bool MeshGenerationLockOnStartByEditor;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		[SerializeField]
		protected Material m_lastLockedMeshMaterial;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		[SerializeField]
		[HideInInspector]
		private List<MudRendererBase.TransformCache> m_aBrushTransformCache;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		[SerializeField]
		[HideInInspector]
		private List<MudRendererBase.TransformCache> m_aNestedRendereTransformCache;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private Dictionary<AsyncGPUReadbackRequest, MudRendererBase.PendingMeshData> m_pendingMeshTable;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Stopwatch _sw;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		[SerializeField]
		[HideInInspector]
		private bool m_isMeshLocked;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x369")]
		protected bool m_doRigging;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36A")]
		public bool DrawGenerateSdfGizmos;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public string GenerateSdfByEditorName;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public Vector3 GenerateSdfCenter;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		public Vector3 GenerateSdfDimension;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		public Vector3Int GenerateSdfTextureSize;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		protected List<Sdf.EvalJobHandle> m_jobQueue;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		protected List<Sdf.EvalJobHandle> m_jobCompleteQueue;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public bool UseCutoffVolume;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public Transform CutoffVolumeCenter;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public Vector3 CutoffVolumeSize;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		private bool m_brushDataDirty;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CD")]
		private bool m_aabbTreeDirty;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CE")]
		private bool m_needsCompute;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public MudRendererBase.RenderMaterialModeEnum RenderMaterialMode;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
		private bool m_renderMaterialDirty;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private int m_numVoxelsHighWaterMark;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
		private int m_numChunksHighWaterMark;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static bool s_shaderConstantIdPopulated;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static readonly string MaxBrushWarningMessage;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private int m_brushSetHash;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
		private int m_brushGroupDepth;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		protected int m_numSdfBrushes;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
		protected int m_numSdfMaterials;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		protected List<Transform> m_aBone;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private Stack<Aabb> m_brushGroupBoundsStack;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private Stack<Aabb> m_accumulatedBoundsStack;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private Stack<MudSolid.SymmetryMode> m_brushGroupSymmetryStack;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		public MudRendererBase.ComputeModeEnum ComputeMode;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
		public MudRendererBase.TimeSliceModeEnum TimeSliceMode;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		[Min(1f)]
		public int TimeSliceFrames;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
		public int TimeSliceFramesOffset;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		[Min(0.0001f)]
		public float TimeSlicePeriod;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
		public float TimeSliceTimeOffset;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private float m_lastUpdateTimeSliceTime;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
		private int m_rendererIndex;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private Mesh m_renderBoxProxy;

		// Token: 0x0200006B RID: 107
		[Token(Token = "0x200006B")]
		public enum HardwareModeEnum
		{
			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			[InspectorName("GPU")]
			Gpu
		}

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		public enum RenderModeEnum
		{
			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x40001E1")]
			FlatMesh,
			// Token: 0x040001E2 RID: 482
			[Token(Token = "0x40001E2")]
			SmoothMesh,
			// Token: 0x040001E3 RID: 483
			[Token(Token = "0x40001E3")]
			CircleSplats,
			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			QuadSplats,
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			Decal,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			RayMarchedSurface,
			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			RayTracedVoxels
		}

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		public enum RenderMaterialModeEnum
		{
			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x40001E9")]
			Static,
			// Token: 0x040001EA RID: 490
			[Token(Token = "0x40001EA")]
			Dynamic
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		public enum RayTracedVoxelModeEnum
		{
			// Token: 0x040001EC RID: 492
			[Token(Token = "0x40001EC")]
			FlatCubes,
			// Token: 0x040001ED RID: 493
			[Token(Token = "0x40001ED")]
			FacetedCubes,
			// Token: 0x040001EE RID: 494
			[Token(Token = "0x40001EE")]
			FlatSpheres,
			// Token: 0x040001EF RID: 495
			[Token(Token = "0x40001EF")]
			SmoothSpheres,
			// Token: 0x040001F0 RID: 496
			[Token(Token = "0x40001F0")]
			Custom = 100
		}

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		public enum RayTracedVoxelPaddingModeEnum
		{
			// Token: 0x040001F2 RID: 498
			[Token(Token = "0x40001F2")]
			None,
			// Token: 0x040001F3 RID: 499
			[Token(Token = "0x40001F3")]
			ByDistance,
			// Token: 0x040001F4 RID: 500
			[Token(Token = "0x40001F4")]
			Full
		}

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		public enum RenderModeCategoryEnum
		{
			// Token: 0x040001F6 RID: 502
			[Token(Token = "0x40001F6")]
			Unknown = -1,
			// Token: 0x040001F7 RID: 503
			[Token(Token = "0x40001F7")]
			Mesh,
			// Token: 0x040001F8 RID: 504
			[Token(Token = "0x40001F8")]
			Splats,
			// Token: 0x040001F9 RID: 505
			[Token(Token = "0x40001F9")]
			Decal,
			// Token: 0x040001FA RID: 506
			[Token(Token = "0x40001FA")]
			RayMarchedSurface,
			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40001FB")]
			RayTracedVoxels
		}

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		public enum MeshingModeEnum
		{
			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			MarchingCubes,
			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001FE")]
			DualQuads,
			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001FF")]
			SurfaceNets,
			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			DualContouring
		}

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		public enum ComputeModeEnum
		{
			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			Auto,
			// Token: 0x04000203 RID: 515
			[Token(Token = "0x4000203")]
			Manual,
			// Token: 0x04000204 RID: 516
			[Token(Token = "0x4000204")]
			EveryFrame,
			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000205")]
			TimeSliced
		}

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		public enum TimeSliceModeEnum
		{
			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			ByFramesAutoOffset,
			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			ByFramesManualOffset,
			// Token: 0x04000209 RID: 521
			[Token(Token = "0x4000209")]
			ByPeriodAutoOffset,
			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			ByPeriodManualOffset
		}

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		public struct Const
		{
			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static MudRendererBase.Const.KernelIndex Kernel;

			// Token: 0x0400020C RID: 524
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public static int TriTable;

			// Token: 0x0400020D RID: 525
			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static int VertTable;

			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public static int TriTable2d;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static int Brushes;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public static int BrushMaterials;

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static int NumBrushes;

			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public static int SurfaceShift;

			// Token: 0x04000213 RID: 531
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static int RenderMode;

			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public static int MeshingMode;

			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static int RayTracedVoxelMode;

			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			public static int RayTracedVoxelSizeMultiplier;

			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static int RayTracedVoxelSmoothCubeNormal;

			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			public static int RayTracedVoxelRadius;

			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static int RayTracedVoxelPaddingMode;

			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			public static int RayTracedVoxelInternalPaddingDistance;

			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static int RayTracedVoxelSizeFadeDistance;

			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			public static int NormalDifferentiationStep;

			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static int NormalQuantization;

			// Token: 0x0400021E RID: 542
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			public static int Normal2dFadeDist;

			// Token: 0x0400021F RID: 543
			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static int Normal2dStrength;

			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			public static int EnableAutoSmooth;

			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static int AutoSmoothMaxAngle;

			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			public static int AutoSmoothVertDataTable;

			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static int AutoSmoothVertDataPoolSize;

			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			public static int EnableSmoothCorner;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public static int SmoothCornerSubdivision;

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			public static int SmoothCornerNormalBlur;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static int SmoothCornerFade;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			public static int SplatSize;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public static int SplatSizeJitter;

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			public static int SplatNormalShift;

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static int SplatNormalShiftJitter;

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			public static int SplatColorJitter;

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public static int SplatPositionJitter;

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			public static int SplatRotationJitter;

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static int SplatOrientationJitter;

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			public static int SplatOriginalNormalBlend;

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public static int SplatJitterNoisiness;

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			public static int SplatCameraFacing;

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static int SplatNormalsMatchCameraFacing;

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			public static int SplatShadowsMatchCameraFacing;

			// Token: 0x04000235 RID: 565
			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public static int SplatScreenSpaceFlattening;

			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			public static int SurfaceNetsDualQuadsBlend;

			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static int SurfaceNetsBinarySearchIterations;

			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			public static int SurfaceNetsGradientDescentIterations;

			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public static int SurfaceNetsGradientDescentFactor;

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			public static int DualContouringDualQuadsBlend;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static int DualContouringRelaxation;

			// Token: 0x0400023C RID: 572
			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			public static int DualContouringBinarySearchIterations;

			// Token: 0x0400023D RID: 573
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public static int DualContouringGradientDescentIterations;

			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			public static int DualContouringGradientDescentFactor;

			// Token: 0x0400023F RID: 575
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static int AabbTree;

			// Token: 0x04000240 RID: 576
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			public static int AabbRoot;

			// Token: 0x04000241 RID: 577
			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public static int Enable2dMode;

			// Token: 0x04000242 RID: 578
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			public static int ForceAllBrushes;

			// Token: 0x04000243 RID: 579
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static int NumAllocations;

			// Token: 0x04000244 RID: 580
			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			public static int NodeHashTable;

			// Token: 0x04000245 RID: 581
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			public static int NodeHashTableSize;

			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			public static int NodePool;

			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static int NodePoolSize;

			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			public static int NumNodesAllocated;

			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			public static int UseVoxelCache;

			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			public static int VoxelCacheIdTable;

			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static int VoxelCache;

			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			public static int VoxelCacheSize;

			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			public static int BrushMaskPool;

			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			public static int BrushMaskPoolSize;

			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			public static int IndirectDispatchArgs;

			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			public static int CurrentNodeDepth;

			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			public static int CurrentNodeBranchingFactor;

			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			public static int CurrentNodeSize;

			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			public static int VoxelSize;

			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			public static int VoxelTreeBranchingFactorsCompressed;

			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			public static int VoxelNodeSizes;

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			public static int MaxNodeDepth;

			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			public static int ChunkVoxelDensity;

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			public static int GenPoints;

			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			public static int MaxGenPoints;

			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			public static int IndirectDrawArgs;

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			public static int MasterColor;

			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			public static int MasterEmission;

			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			public static int MasterMetallic;

			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			public static int MasterSmoothness;

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			public static int LocalToWorld;

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			public static int LocalToWorldIt;

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			public static int LocalToWorldScale;

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			public static int WorldToLocal;

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			public static int WorldToLocalIt;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			public static int NoiseCache;

			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			public static int NoiseCacheDimension;

			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			public static int NoiseCacheDensity;

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			public static int NoiseCachePeriod;

			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			public static int SdfOutput;

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			public static int SdfOutputSize;

			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			public static int SdfCenter;

			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			public static int SdfDimension;

			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			public static int MaxRayMarchSteps;

			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			public static int RayMarchHitDistance;

			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			public static int RayMarchMaxRayDistance;

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			public static int IsMeshRenderMaterial;

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
			public static int IsSplatRenderMaterial;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			public static int MaterialNeedsSdfProperties;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
			public static int MaterialNeedsRayMarchingProperties;

			// Token: 0x02000075 RID: 117
			[Token(Token = "0x2000075")]
			public struct KernelIndex
			{
				// Token: 0x04000273 RID: 627
				[Token(Token = "0x4000273")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int ClearVoxelHashTable;

				// Token: 0x04000274 RID: 628
				[Token(Token = "0x4000274")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public int ClearAutoSmoothVertDataTable;

				// Token: 0x04000275 RID: 629
				[Token(Token = "0x4000275")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int ClearVoxelCache;

				// Token: 0x04000276 RID: 630
				[Token(Token = "0x4000276")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public int RegisterTopNodes;

				// Token: 0x04000277 RID: 631
				[Token(Token = "0x4000277")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int UpdateBranchingIndirectDispatchArgs;

				// Token: 0x04000278 RID: 632
				[Token(Token = "0x4000278")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public int AllocateChildNodes;

				// Token: 0x04000279 RID: 633
				[Token(Token = "0x4000279")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int UpdateVoxelIndirectDispatchArgs;

				// Token: 0x0400027A RID: 634
				[Token(Token = "0x400027A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public int GenerateFlatMarchingCubesMesh;

				// Token: 0x0400027B RID: 635
				[Token(Token = "0x400027B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public int GenerateSmoothMarchingCubesMesh;

				// Token: 0x0400027C RID: 636
				[Token(Token = "0x400027C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				public int GenerateMarchingCubesSplats;

				// Token: 0x0400027D RID: 637
				[Token(Token = "0x400027D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public int GenerateFlatMarchingCubesMesh2d;

				// Token: 0x0400027E RID: 638
				[Token(Token = "0x400027E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				public int GenerateSmoothMarchingCubesMesh2d;

				// Token: 0x0400027F RID: 639
				[Token(Token = "0x400027F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public int GenerateMarchingCubesSplats2d;

				// Token: 0x04000280 RID: 640
				[Token(Token = "0x4000280")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				public int UpdateMarchingCubesAutoSmoothIndirectDispatchArgs;

				// Token: 0x04000281 RID: 641
				[Token(Token = "0x4000281")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public int MarchingCubesUpdateAutoSmooth;

				// Token: 0x04000282 RID: 642
				[Token(Token = "0x4000282")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				public int MarchingCubesComputeAutoSmooth;

				// Token: 0x04000283 RID: 643
				[Token(Token = "0x4000283")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public int GenerateDualQuads;

				// Token: 0x04000284 RID: 644
				[Token(Token = "0x4000284")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				public int GenerateDualQuads2d;

				// Token: 0x04000285 RID: 645
				[Token(Token = "0x4000285")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public int UpdateDualMeshingIndirectDispatchArgs;

				// Token: 0x04000286 RID: 646
				[Token(Token = "0x4000286")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				public int DualMeshingFlatMeshNormal;

				// Token: 0x04000287 RID: 647
				[Token(Token = "0x4000287")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public int DualMeshingSmoothMeshNormal;

				// Token: 0x04000288 RID: 648
				[Token(Token = "0x4000288")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				public int DualMeshingFlatMeshNormal2d;

				// Token: 0x04000289 RID: 649
				[Token(Token = "0x4000289")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public int DualMeshingSmoothMeshNormal2d;

				// Token: 0x0400028A RID: 650
				[Token(Token = "0x400028A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				public int DualMeshingUpdateAutoSmooth;

				// Token: 0x0400028B RID: 651
				[Token(Token = "0x400028B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public int DualMeshingComputeAutoSmooth;

				// Token: 0x0400028C RID: 652
				[Token(Token = "0x400028C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
				public int DualMeshingUpdateSmoothCornerIndirectDispatchArgs;

				// Token: 0x0400028D RID: 653
				[Token(Token = "0x400028D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public int DualMeshingSmoothCorner;

				// Token: 0x0400028E RID: 654
				[Token(Token = "0x400028E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
				public int UpdateDualMeshingSplatsIndirectArgs;

				// Token: 0x0400028F RID: 655
				[Token(Token = "0x400028F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public int ConvertDualMeshingSplats;

				// Token: 0x04000290 RID: 656
				[Token(Token = "0x4000290")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
				public int SurfaceNetsMovePoint;

				// Token: 0x04000291 RID: 657
				[Token(Token = "0x4000291")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public int SurfaceNetsMovePoint2d;

				// Token: 0x04000292 RID: 658
				[Token(Token = "0x4000292")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
				public int DualContouringMovePoint;

				// Token: 0x04000293 RID: 659
				[Token(Token = "0x4000293")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				public int DualContouringMovePoint2d;

				// Token: 0x04000294 RID: 660
				[Token(Token = "0x4000294")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
				public int UpdateRayTracedVoxelIndirectDispatchArgs;

				// Token: 0x04000295 RID: 661
				[Token(Token = "0x4000295")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				public int ComputeRayTracedVoxelGenPoints;

				// Token: 0x04000296 RID: 662
				[Token(Token = "0x4000296")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
				public int ComputeRayTracedVoxelGenPointsWithNormals;

				// Token: 0x04000297 RID: 663
				[Token(Token = "0x4000297")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				public int GenerateNoiseCache;

				// Token: 0x04000298 RID: 664
				[Token(Token = "0x4000298")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
				public int RigBones;

				// Token: 0x04000299 RID: 665
				[Token(Token = "0x4000299")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				public int GenerateSdf;
			}
		}

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		public enum NumAllcationIndex
		{
			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			BrushMask,
			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			VoxelCache,
			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			VoxelHash,
			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			AutoSmoothVertData
		}

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		private enum RenderGeometryTypeEnum
		{
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			Unknown = -1,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			Mesh,
			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			BoxProxy,
			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			Chunks
		}

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		public enum ClickSelectionEnum
		{
			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			None,
			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			Gizmos,
			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			Raycast,
			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[InspectorName("Raycast (Forced Zero-Blend Union)")]
			RaycastForcedZeroBlendUnion
		}

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000079")]
		public enum RenderableMeshMode
		{
			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			None,
			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			Procedural,
			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			MeshRenderer
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		[Serializable]
		private class TransformCache
		{
			// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public TransformCache()
			{
			}

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Transform;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform Parent;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 GlobalPosition;

			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion GlobalRotation;

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 LocalPosition;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion LocalRotation;

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 LocalScale;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public bool HasBrushDescendants;
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		public enum GeneratedMeshType
		{
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			Standard,
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			Compute,
			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			Collider
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		private class PendingMeshData
		{
			// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x23F80B0", Offset = "0x23F66B0", VA = "0x1823F80B0")]
			public void Dispose()
			{
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PendingMeshData()
			{
			}

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mesh Mesh;

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MudRendererBase.GeneratedMeshType MeshType;

			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform RootBone;

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Transform> Bones;

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool DoRigging;

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool GenerateTextureUV;

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public bool GenerateLightMapUV;

			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public bool WeldVertices;

			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool OptimizeMeshForRendering;

			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			public bool Async;

			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ComputeBuffer IndirectDrawArgsBuffer;

			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ComputeBuffer GenPointsBuffer;
		}

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		protected enum LockMeshIntermediateStateEnum
		{
			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			Idle,
			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			PreLock,
			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			PostLock,
			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			PreUnlock
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		public struct VertexUnpackJob : IJobParallelFor
		{
			// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x23F81B0", Offset = "0x23F67B0", VA = "0x1823F81B0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NativeArray<GenPoint> _aGenPoint;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NativeArray<Vector3> _outVertex;

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NativeArray<Vector3> _outNorm;

			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public NativeArray<int> _outVertIndex;
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		public struct LinearTintUnpackJob : IJobParallelFor
		{
			// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x23F82D0", Offset = "0x23F68D0", VA = "0x1823F82D0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002CE RID: 718
			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float4 _masterColor;

			// Token: 0x040002CF RID: 719
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float4 _masterEmission;

			// Token: 0x040002D0 RID: 720
			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float _masterMetallic;

			// Token: 0x040002D1 RID: 721
			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float _masterSmoothness;

			// Token: 0x040002D2 RID: 722
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NativeArray<GenPoint> _aGenPoint;

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public NativeArray<float4> _aColor;

			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public NativeArray<float4> _aEmissionHash;

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public NativeArray<float2> _aMetallicSmoothness;
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		[BurstCompile]
		public struct WeldVertexGenerateVertsKeyJob : IJobParallelFor
		{
			// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x23F85E0", Offset = "0x23F6BE0", VA = "0x1823F85E0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public int _textureUvIndex;

			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[ReadOnly]
			public float _uvTolerance;

			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[ReadOnly]
			public float _positionTolerance;

			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[ReadOnly]
			public float _normalTolerance;

			// Token: 0x040002DA RID: 730
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<Vector3> _oldVert;

			// Token: 0x040002DB RID: 731
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<Vector3> _oldNorm;

			// Token: 0x040002DC RID: 732
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<Vector2> _oldTextureUv;

			// Token: 0x040002DD RID: 733
			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[WriteOnly]
			public NativeArray<MeshUtil.VertKey> _vertexKeys;
		}

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x2000081")]
		[BurstCompile]
		public struct WeldVertexLookupUniqueVertsJob : IJobParallelFor
		{
			// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x23F88C0", Offset = "0x23F6EC0", VA = "0x1823F88C0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<MeshUtil.VertKey> _vertexKeys;

			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeHashSet<MeshUtil.VertKey>.ParallelWriter _vertToIndexHashset;
		}

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		[BurstCompile]
		public struct WeldVertexAssignUniqueIdsJob : IJobParallelFor
		{
			// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x23F8960", Offset = "0x23F6F60", VA = "0x1823F8960", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<MeshUtil.VertKey> _uniqueVertsKeys;

			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[WriteOnly]
			public NativeHashMap<MeshUtil.VertKey, int>.ParallelWriter _uniqueVertKeysToIndexMap;
		}

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		[BurstCompile]
		public struct WeldVertexCalcNewIndicesJob : IJobParallelFor
		{
			// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x23F89E0", Offset = "0x23F6FE0", VA = "0x1823F89E0", Slot = "4")]
			public void Execute(int oldIndex)
			{
			}

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeHashMap<MeshUtil.VertKey, int> _vertToIndexMap;

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<MeshUtil.VertKey> _vertexKeys;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[WriteOnly]
			public NativeArray<int> _newIndexMap;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[WriteOnly]
			public NativeHashMap<int, int>.ParallelWriter _uniqueNewIndexToOldIndexMap;
		}

		// Token: 0x02000084 RID: 132
		[Token(Token = "0x2000084")]
		[BurstCompile]
		public struct WeldVertexApplyNewIndexesJob : IJobParallelFor
		{
			// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x23F8AB0", Offset = "0x23F70B0", VA = "0x1823F8AB0", Slot = "4")]
			public void Execute(int newIndex)
			{
			}

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public int _textureUvIndex;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[ReadOnly]
			public NativeArray<Vector3> _oldVert;

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[ReadOnly]
			public NativeArray<Vector3> _oldNorm;

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[ReadOnly]
			public NativeArray<Vector2> _oldTextureUv;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[ReadOnly]
			public NativeArray<Color> _oldColor;

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[ReadOnly]
			public NativeArray<Vector4> _oldEmissionHash;

			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[ReadOnly]
			public NativeArray<Vector2> _oldMetallicSmoothness;

			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[ReadOnly]
			public NativeHashMap<int, int> _indexToIndexMap;

			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[WriteOnly]
			public NativeArray<Vector3> _aNewVert;

			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[WriteOnly]
			public NativeArray<Vector3> _aNewNorm;

			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[WriteOnly]
			public NativeArray<Vector2> _aNewTextureUv;

			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[WriteOnly]
			public NativeArray<Color> _aNewColor;

			// Token: 0x040002F2 RID: 754
			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[WriteOnly]
			public NativeArray<Vector4> _aNewEmissionHash;

			// Token: 0x040002F3 RID: 755
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[WriteOnly]
			public NativeArray<Vector2> _aNewMetallicSmoothness;
		}

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		public static class Tests
		{
			// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x23F8CE0", Offset = "0x23F72E0", VA = "0x1823F8CE0")]
			private static void MudbunJobifiedMeshGeneration(bool obj)
			{
			}

			// Token: 0x040002F4 RID: 756
			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static bool Opt;

			// Token: 0x040002F5 RID: 757
			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public static bool Job;
		}
	}
}
