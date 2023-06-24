using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AtmosphereDatatypes.cs")]
	public class AtmosphereDatatypes
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xAC3190", Offset = "0xAC1790", VA = "0x180AC3190")]
		public static bool integrateInScreenspace(AtmosphereDatatypes.DensityDistribution d)
		{
			return default(bool);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public AtmosphereDatatypes()
		{
		}

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		public const uint kMaxAtmosphereLayers = 8U;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		public const uint kNumPhaseFunctions = 3U;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		public const uint kNumDensityDistributions = 4U;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AtmosphereDatatypes.cs")]
		public enum AtmosphereLayer
		{
			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			Layer0,
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			Layer1,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			Layer2,
			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			Layer3,
			// Token: 0x040001E8 RID: 488
			[Token(Token = "0x40001E8")]
			Layer4,
			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x40001E9")]
			Layer5,
			// Token: 0x040001EA RID: 490
			[Token(Token = "0x40001EA")]
			Layer6,
			// Token: 0x040001EB RID: 491
			[Token(Token = "0x40001EB")]
			Layer7
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AtmosphereDatatypes.cs")]
		public enum PhaseFunction
		{
			// Token: 0x040001ED RID: 493
			[Token(Token = "0x40001ED")]
			Isotropic,
			// Token: 0x040001EE RID: 494
			[Token(Token = "0x40001EE")]
			Rayleigh,
			// Token: 0x040001EF RID: 495
			[Token(Token = "0x40001EF")]
			Mie
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AtmosphereDatatypes.cs")]
		public enum DensityDistribution
		{
			// Token: 0x040001F1 RID: 497
			[Token(Token = "0x40001F1")]
			Exponential,
			// Token: 0x040001F2 RID: 498
			[Token(Token = "0x40001F2")]
			Tent,
			// Token: 0x040001F3 RID: 499
			[Token(Token = "0x40001F3")]
			ScreenspaceUniform,
			// Token: 0x040001F4 RID: 500
			[Token(Token = "0x40001F4")]
			ScreenspaceHeightFog
		}
	}
}
