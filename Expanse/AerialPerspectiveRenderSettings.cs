using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AerialPerspectiveRenderSettings.cs", needAccessors = false)]
	public struct AerialPerspectiveRenderSettings
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xAC2830", Offset = "0xAC0E30", VA = "0x180AC2830")]
		public static void register(AerialPerspectiveSettingsBlock b)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xAC28E0", Offset = "0xAC0EE0", VA = "0x180AC28E0")]
		public static void deregister(AerialPerspectiveSettingsBlock b)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xAC2AA0", Offset = "0xAC10A0", VA = "0x180AC2AA0")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xAC2DC0", Offset = "0xAC13C0", VA = "0x180AC2DC0")]
		public static void build()
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xAC2FD0", Offset = "0xAC15D0", VA = "0x180AC2FD0")]
		public static void cleanup()
		{
		}

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x0")]
		public float uniformOcclusionSpread;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x4")]
		public float uniformOcclusionBias;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x8")]
		public float directionalOcclusionSpread;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0xC")]
		public float directionalOcclusionBias;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x10")]
		public float nightScatteringMultiplier;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x0")]
		private static AerialPerspectiveSettingsBlock m_settings;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x8")]
		private static ComputeBuffer kComputeBuffer;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x10")]
		private static AerialPerspectiveRenderSettings[] kArray;
	}
}
