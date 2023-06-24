using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Rendering
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public static class LightingUtilities
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA95850", Offset = "0xA93E50", VA = "0x180A95850")]
		public static float GetAmbientIntensity()
		{
			return 0f;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA95F40", Offset = "0xA94540", VA = "0x180A95F40")]
		private static bool IsColorZero(Color color)
		{
			return default(bool);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA95F60", Offset = "0xA94560", VA = "0x180A95F60")]
		private static float CalculateColorValue(Color color)
		{
			return 0f;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA95F90", Offset = "0xA94590", VA = "0x180A95F90")]
		private static bool CalculateColorValueMean(Color[] colors, out float result)
		{
			return default(bool);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA96380", Offset = "0xA94980", VA = "0x180A96380")]
		private static void AddOrdered(float colorValue, ref List<float> colorValueArrayCache)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xA964B0", Offset = "0xA94AB0", VA = "0x180A964B0")]
		private static Color CalculateColorAverage(Color[] color)
		{
			return default(Color);
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x0")]
		private static Color[] _realtimeSampleAmbientColors;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x8")]
		private static Vector3[] _realtimeSampleAmbientDirections;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x10")]
		private static float _historicalAmbientMin;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x14")]
		private static float _historicalAmbientMax;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x18")]
		private static float _realtimeAmbientRemapMin;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x1C")]
		private static float _realtimeAmbientRemapMax;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x20")]
		private static int _realtimeSampleFame;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x24")]
		private static float _cachedAmbientIntensity;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x28")]
		private static Color[] _cachedAmbientColorFrames;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x30")]
		private static int _cachedAmbientColorFrameIndex;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x34")]
		private static float _defaultAmbientValue;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x38")]
		private static List<float> _colorValueArrayCache;
	}
}
