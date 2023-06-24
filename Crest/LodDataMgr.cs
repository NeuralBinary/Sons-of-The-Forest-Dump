using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public abstract class LodDataMgr
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000FE RID: 254
		[Token(Token = "0x17000028")]
		public abstract string SimName { [Token(Token = "0x60000FE")] get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000FF RID: 255
		[Token(Token = "0x17000029")]
		protected abstract GraphicsFormat RequestedTextureFormat { [Token(Token = "0x60000FF")] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public GraphicsFormat CompatibleTextureFormat
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return GraphicsFormat.None;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000102 RID: 258
		[Token(Token = "0x6000102")]
		protected abstract int GetParamIdSampler(bool sourceLod = false);

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000103 RID: 259
		[Token(Token = "0x1700002B")]
		protected abstract bool NeedToReadWriteTextureData { [Token(Token = "0x6000103")] get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700002C")]
		public RenderTexture DataTexture
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x1700002D")]
		protected int ScaleDifferencePow2
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public bool enabled
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x9DD220", Offset = "0x9DB820", VA = "0x1809DD220")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9DD230", Offset = "0x9DB830", VA = "0x1809DD230")]
		public LodDataMgr(OceanRenderer ocean)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x9DD290", Offset = "0x9DB890", VA = "0x1809DD290", Slot = "8")]
		public virtual void Start()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x9DD2C0", Offset = "0x9DB8C0", VA = "0x1809DD2C0")]
		public static RenderTexture CreateLodDataTextures(RenderTextureDescriptor desc, string name, bool needToReadWriteTextureData)
		{
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x9DD650", Offset = "0x9DBC50", VA = "0x1809DD650", Slot = "9")]
		protected virtual void InitData()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x9DDA30", Offset = "0x9DC030", VA = "0x1809DDA30", Slot = "10")]
		public virtual void UpdateLodData()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public virtual void BuildCommandBuffer(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x9DDD00", Offset = "0x9DC300", VA = "0x1809DDD00")]
		protected void SubmitDraws(int lodIdx, CommandBuffer buf)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x9DE080", Offset = "0x9DC680", VA = "0x1809DE080")]
		protected void SubmitDrawsFiltered(int lodIdx, CommandBuffer buf, LodDataMgr.IDrawFilter filter)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		internal virtual void OnEnable()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x9DE4D0", Offset = "0x9DCAD0", VA = "0x1809DE4D0", Slot = "13")]
		internal virtual void OnDisable()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x9DE540", Offset = "0x9DCB40", VA = "0x1809DE540")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		public const int MAX_LOD_COUNT = 15;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		public const int THREAD_GROUP_SIZE_X = 8;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		public const int THREAD_GROUP_SIZE_Y = 8;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		protected RenderTexture _targets;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x0")]
		public static int sp_LD_SliceIndex;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x4")]
		protected static int sp_LODChange;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x20")]
		private int _shapeRes;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x24")]
		private float _oceanLocalScalePrev;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x28")]
		private int _scaleDifferencePow2;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x30")]
		protected OceanRenderer _ocean;

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		public interface IDrawFilter
		{
			// Token: 0x06000115 RID: 277
			[Token(Token = "0x6000115")]
			float Filter(ILodDataInput data, out int isTransition);
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		protected struct TextureArrayParamIds
		{
			// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x9DE740", Offset = "0x9DCD40", VA = "0x1809DE740")]
			public TextureArrayParamIds(string textureArrayName)
			{
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00002568 File Offset: 0x00000768
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x9DE820", Offset = "0x9DCE20", VA = "0x1809DE820")]
			public int GetId(bool sourceLod)
			{
				return 0;
			}

			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x0")]
			private int _paramId;

			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x4")]
			private int _paramId_Source;
		}
	}
}
