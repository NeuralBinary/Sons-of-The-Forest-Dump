using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	public class ResourcesUtil
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2450380", Offset = "0x244E980", VA = "0x182450380")]
		public static ResourcesUtil.RenderPipelineEnum DetermineRenderPipeline(bool skipCache = false)
		{
			return ResourcesUtil.RenderPipelineEnum.BuiltIn;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x17000110")]
		public static ResourcesUtil.RenderPipelineEnum RenderPipeline
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x2450640", Offset = "0x244EC40", VA = "0x182450640")]
			get
			{
				return ResourcesUtil.RenderPipelineEnum.BuiltIn;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000111")]
		public static ComputeShader VoxelGen
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x2450690", Offset = "0x244EC90", VA = "0x182450690")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000112")]
		public static ComputeShader MarchingCubes
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x2450770", Offset = "0x244ED70", VA = "0x182450770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000113")]
		public static ComputeShader DualMeshing
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x2450850", Offset = "0x244EE50", VA = "0x182450850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000114")]
		public static ComputeShader SurfaceNets
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x2450930", Offset = "0x244EF30", VA = "0x182450930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000115")]
		public static ComputeShader DualContouring
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x2450A10", Offset = "0x244F010", VA = "0x182450A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000116")]
		public static ComputeShader RayTracedVoxels
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x2450AF0", Offset = "0x244F0F0", VA = "0x182450AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000117")]
		public static ComputeShader NoiseCache
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x2450BD0", Offset = "0x244F1D0", VA = "0x182450BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000118")]
		public static ComputeShader TextureSlicer
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x2450CB0", Offset = "0x244F2B0", VA = "0x182450CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000119")]
		public static ComputeShader MeshLock
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x2450D90", Offset = "0x244F390", VA = "0x182450D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011A")]
		public static ComputeShader SdfGen
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x2450E70", Offset = "0x244F470", VA = "0x182450E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011B")]
		public static Texture NoiseTexture
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x2450F50", Offset = "0x244F550", VA = "0x182450F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2451030", Offset = "0x244F630", VA = "0x182451030")]
		public static ComputeShader GetComputeResource(string resourcePath)
		{
			return null;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2451240", Offset = "0x244F840", VA = "0x182451240")]
		public static Texture GetTextureResource(string resourcePath)
		{
			return null;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011C")]
		public static Material DefaultLockedMeshMaterial
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x2451450", Offset = "0x244FA50", VA = "0x182451450")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x24515E0", Offset = "0x244FBE0", VA = "0x1824515E0")]
		public static Material GetMaterialResource(string resourcePath)
		{
			return null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ResourcesUtil()
		{
		}

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x0")]
		protected static ResourcesUtil.RenderPipelineEnum s_renderPipeline;

		// Token: 0x02000140 RID: 320
		[Token(Token = "0x2000140")]
		public enum RenderPipelineEnum
		{
			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			Unknown = -1,
			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			BuiltIn,
			// Token: 0x040004BE RID: 1214
			[Token(Token = "0x40004BE")]
			URP,
			// Token: 0x040004BF RID: 1215
			[Token(Token = "0x40004BF")]
			HDRP,
			// Token: 0x040004C0 RID: 1216
			[Token(Token = "0x40004C0")]
			Count
		}
	}
}
