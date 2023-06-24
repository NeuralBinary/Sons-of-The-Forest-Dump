using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class LodDataMgrAnimWaves : LodDataMgr
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700002F")]
		public override string SimName
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x9DE830", Offset = "0x9DCE30", VA = "0x1809DE830", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000030")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x9DE860", Offset = "0x9DCE60", VA = "0x1809DE860", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000031")]
		protected override bool NeedToReadWriteTextureData
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x9DE870", Offset = "0x9DCE70", VA = "0x1809DE870")]
		public static void RegisterUpdatable(LodDataMgrAnimWaves.IShapeUpdatable updatable)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x9DE930", Offset = "0x9DCF30", VA = "0x1809DE930")]
		public static void DeregisterUpdatable(LodDataMgrAnimWaves.IShapeUpdatable updatable)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000032")]
		public SimSettingsAnimatedWaves Settings
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x9DEA70", Offset = "0x9DD070", VA = "0x1809DEA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x9DECC0", Offset = "0x9DD2C0", VA = "0x1809DECC0")]
		public LodDataMgrAnimWaves(OceanRenderer ocean)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x9DEF50", Offset = "0x9DD550", VA = "0x1809DEF50", Slot = "9")]
		protected override void InitData()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x9DFAF0", Offset = "0x9DE0F0", VA = "0x1809DFAF0")]
		private RenderTexture CreateCombineBuffer(RenderTextureDescriptor desc)
		{
			return null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x9DFDF0", Offset = "0x9DE3F0", VA = "0x1809DFDF0", Slot = "11")]
		public override void BuildCommandBuffer(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x9E0700", Offset = "0x9DED00", VA = "0x1809E0700")]
		private void CombinePassPingPong(CommandBuffer buf)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x9E0EA0", Offset = "0x9DF4A0", VA = "0x1809E0EA0")]
		private void CombinePassCompute(CommandBuffer buf)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x9E1340", Offset = "0x9DF940", VA = "0x1809E1340")]
		public void BindWaveBuffer(IPropertyWrapper properties)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x9E13A0", Offset = "0x9DF9A0", VA = "0x1809E13A0")]
		public static int SuggestDataLOD(Rect sampleAreaXZ)
		{
			return 0;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x9E1410", Offset = "0x9DFA10", VA = "0x1809E1410")]
		public static int SuggestDataLOD(Rect sampleAreaXZ, float minSpatialLength)
		{
			return 0;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x9E1660", Offset = "0x9DFC60", VA = "0x1809E1660")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x9E16D0", Offset = "0x9DFCD0", VA = "0x1809E16D0", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x9E1760", Offset = "0x9DFD60", VA = "0x1809E1760")]
		public static void Bind(IPropertyWrapper properties)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x9E1920", Offset = "0x9DFF20", VA = "0x1809E1920")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Read shape textures back to the CPU for collision purposes.")]
		public bool _readbackShapeForCollision;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x0")]
		public static bool _shapeCombinePass;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x1")]
		public static bool _shapeCombinePassPingPong;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture _waveBuffers;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture _combineBuffer;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		private const string ShaderName = "ShapeCombine";

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x50")]
		private int krnl_ShapeCombine;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x54")]
		private int krnl_ShapeCombine_DISABLE_COMBINE;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x58")]
		private int krnl_ShapeCombine_FLOW_ON;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x5C")]
		private int krnl_ShapeCombine_FLOW_ON_DISABLE_COMBINE;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x60")]
		private int krnl_ShapeCombine_DYNAMIC_WAVE_SIM_ON;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x64")]
		private int krnl_ShapeCombine_DYNAMIC_WAVE_SIM_ON_DISABLE_COMBINE;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x68")]
		private int krnl_ShapeCombine_FLOW_ON_DYNAMIC_WAVE_SIM_ON;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x6C")]
		private int krnl_ShapeCombine_FLOW_ON_DYNAMIC_WAVE_SIM_ON_DISABLE_COMBINE;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x70")]
		private ComputeShader _combineShader;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x78")]
		private PropertyWrapperCompute _combineProperties;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x80")]
		private PropertyWrapperMaterial[] _combineMaterial;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x88")]
		private readonly int sp_LD_TexArray_AnimatedWaves_Compute;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x8C")]
		private readonly int sp_LD_TexArray_WaveBuffer;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		private const string s_textureArrayName = "_LD_TexArray_AnimatedWaves";

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x8")]
		private static List<LodDataMgrAnimWaves.IShapeUpdatable> _updatables;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x90")]
		private SimSettingsAnimatedWaves _defaultSettings;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x98")]
		private LodDataMgrAnimWaves.FilterWavelength _filterWavelength;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0xA0")]
		private LodDataMgrAnimWaves.FilterNoLodPreference _filterNoLodPreference;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		public interface IShapeUpdatable
		{
			// Token: 0x0600012C RID: 300
			[Token(Token = "0x600012C")]
			void CrestUpdate(CommandBuffer buf);
		}

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		public class FilterWavelength : LodDataMgr.IDrawFilter
		{
			// Token: 0x0600012D RID: 301 RVA: 0x00002610 File Offset: 0x00000810
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x9E1BD0", Offset = "0x9E01D0", VA = "0x1809E1BD0", Slot = "4")]
			public float Filter(ILodDataInput data, out int isTransition)
			{
				return 0f;
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public FilterWavelength()
			{
			}

			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0x10")]
			public float _lodMinWavelength;

			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0x14")]
			public float _lodMaxWavelength;

			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0x18")]
			public int _lodIdx;

			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			[FieldOffset(Offset = "0x1C")]
			public int _lodCount;

			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			[FieldOffset(Offset = "0x20")]
			public float _globalMaxWavelength;
		}

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		public class FilterNoLodPreference : LodDataMgr.IDrawFilter
		{
			// Token: 0x0600012F RID: 303 RVA: 0x00002628 File Offset: 0x00000828
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x9E1D40", Offset = "0x9E0340", VA = "0x1809E1D40", Slot = "4")]
			public float Filter(ILodDataInput data, out int isTransition)
			{
				return 0f;
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public FilterNoLodPreference()
			{
			}
		}
	}
}
