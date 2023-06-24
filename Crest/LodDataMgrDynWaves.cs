using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Crest
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class LodDataMgrDynWaves : LodDataMgrPersistent
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000036")]
		protected override string ShaderSim
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x9E24F0", Offset = "0x9E0AF0", VA = "0x1809E24F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x17000037")]
		protected override int krnl_ShaderSim
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x9E2520", Offset = "0x9E0B20", VA = "0x1809E2520", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000038")]
		public override string SimName
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x9E25A0", Offset = "0x9E0BA0", VA = "0x1809E25A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x17000039")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x9E25D0", Offset = "0x9E0BD0", VA = "0x1809E25D0", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x9E25E0", Offset = "0x9E0BE0", VA = "0x1809E25E0")]
		public bool SimActive(int lodIdx)
		{
			return default(bool);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700003A")]
		public SimSettingsWave Settings
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x9E2610", Offset = "0x9E0C10", VA = "0x1809E2610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x9E2860", Offset = "0x9E0E60", VA = "0x1809E2860")]
		public LodDataMgrDynWaves(OceanRenderer ocean)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9E2A90", Offset = "0x9E1090", VA = "0x1809E2A90", Slot = "9")]
		protected override void InitData()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9E2C00", Offset = "0x9E1200", VA = "0x1809E2C00", Slot = "12")]
		internal override void OnEnable()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x9E2C70", Offset = "0x9E1270", VA = "0x1809E2C70", Slot = "13")]
		internal override void OnDisable()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x9E2D40", Offset = "0x9E1340", VA = "0x1809E2D40", Slot = "17")]
		protected override bool BuildCommandBufferInternal(int lodIdx)
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x9E2F10", Offset = "0x9E1510", VA = "0x1809E2F10")]
		public void BindCopySettings(IPropertyWrapper target)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9E2FC0", Offset = "0x9E15C0", VA = "0x1809E2FC0", Slot = "18")]
		protected override void SetAdditionalSimParams(IPropertyWrapper simMaterial)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9E3270", Offset = "0x9E1870", VA = "0x1809E3270")]
		public static void CountWaveSims(int countFrom, out int o_present, out int o_active)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9E33A0", Offset = "0x9E19A0", VA = "0x1809E33A0")]
		private float MaxSimDt(int lodIdx)
		{
			return 0f;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9E3530", Offset = "0x9E1B30", VA = "0x1809E3530", Slot = "16")]
		public override void GetSimSubstepData(float frameDt, out int numSubsteps, out float substepDt)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9E3740", Offset = "0x9E1D40", VA = "0x1809E3740")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9E37B0", Offset = "0x9E1DB0", VA = "0x1809E37B0", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9E3840", Offset = "0x9E1E40", VA = "0x1809E3840")]
		public static void Bind(IPropertyWrapper properties)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x9E3A00", Offset = "0x9E2000", VA = "0x1809E3A00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x68")]
		public bool _rotateLaplacian;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		public const string DYNWAVES_KEYWORD = "CREST_DYNAMIC_WAVE_SIM_ON_INTERNAL";

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x70")]
		private bool[] _active;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x78")]
		private readonly int sp_HorizDisplace;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x7C")]
		private readonly int sp_DisplaceClamp;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x80")]
		private readonly int sp_Damping;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x84")]
		private readonly int sp_Gravity;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x88")]
		private readonly int sp_LaplacianAxisX;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x90")]
		private SimSettingsWave _defaultSettings;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_textureArrayName;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x8")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;
	}
}
