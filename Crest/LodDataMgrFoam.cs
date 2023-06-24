using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Crest
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class LodDataMgrFoam : LodDataMgrPersistent
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700003F")]
		protected override string ShaderSim
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x9E4750", Offset = "0x9E2D50", VA = "0x1809E4750", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x17000040")]
		protected override int krnl_ShaderSim
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x9E2520", Offset = "0x9E0B20", VA = "0x1809E2520", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000041")]
		public override string SimName
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x9E4780", Offset = "0x9E2D80", VA = "0x1809E4780", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x17000042")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x9E47B0", Offset = "0x9E2DB0", VA = "0x1809E47B0", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000043")]
		public SimSettingsFoam Settings
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x9E47D0", Offset = "0x9E2DD0", VA = "0x1809E47D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9E4A20", Offset = "0x9E3020", VA = "0x1809E4A20")]
		public LodDataMgrFoam(OceanRenderer ocean)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x9E4C40", Offset = "0x9E3240", VA = "0x1809E4C40", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x9E4C70", Offset = "0x9E3270", VA = "0x1809E4C70", Slot = "18")]
		protected override void SetAdditionalSimParams(IPropertyWrapper simMaterial)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x9E4E50", Offset = "0x9E3450", VA = "0x1809E4E50", Slot = "16")]
		public override void GetSimSubstepData(float frameDt, out int numSubsteps, out float substepDt)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x9E4E60", Offset = "0x9E3460", VA = "0x1809E4E60")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x9E4ED0", Offset = "0x9E34D0", VA = "0x1809E4ED0", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x9E4F60", Offset = "0x9E3560", VA = "0x1809E4F60")]
		public static void Bind(IPropertyWrapper properties)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x9E5120", Offset = "0x9E3720", VA = "0x1809E5120")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x68")]
		private readonly int sp_FoamFadeRate;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x6C")]
		private readonly int sp_WaveFoamStrength;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x70")]
		private readonly int sp_WaveFoamCoverage;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x74")]
		private readonly int sp_ShorelineFoamMaxDepth;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x78")]
		private readonly int sp_ShorelineFoamStrength;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x80")]
		private SimSettingsFoam _defaultSettings;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_textureArrayName;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x8")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;
	}
}
