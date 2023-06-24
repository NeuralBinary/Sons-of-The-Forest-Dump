using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	internal static class GuidedPlacementUtils
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2E32350", Offset = "0x2E30950", VA = "0x182E32350")]
		public static bool TryLookupSnappingCircle(Vector3 placePos, Transform rootTr, float distanceBetweenElements, out Vector3 center, out float radius, out Vector3 neighbourPos)
		{
			return default(bool);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2E32EB0", Offset = "0x2E314B0", VA = "0x182E32EB0")]
		private static void FindCircleFromSameDistancePoints(Vector2 p1, Vector2 p2Mid, Vector2 p3, float distanceBetweenElements, out Vector2 center, out float radius)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2E330F0", Offset = "0x2E316F0", VA = "0x182E330F0")]
		public static bool CheckGrounded90Snapping(Transform rootTr, float distanceBetweenElements, ref Vector3 placePos, out Vector3 siblingPos, out bool isAligned, float dotSnapRange = 0.9925f)
		{
			return default(bool);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2E337F0", Offset = "0x2E31DF0", VA = "0x182E337F0")]
		private static bool TryGetLoneSiblingTr(Vector3 castPos, float radius, Transform rootTr, out Transform transform, [Optional] Transform exceptTrA, [Optional] Transform exceptTrB)
		{
			return default(bool);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2E33F80", Offset = "0x2E32580", VA = "0x182E33F80")]
		[CompilerGenerated]
		internal static Vector3 <FindCircleFromSameDistancePoints>g__ToWorld|1_0(Vector2 v)
		{
			return default(Vector3);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x6E2EB0", Offset = "0x6E14B0", VA = "0x1806E2EB0")]
		[CompilerGenerated]
		internal static Vector3 <FindCircleFromSameDistancePoints>g__ToWorldAxis|1_1(Vector2 v)
		{
			return default(Vector3);
		}
	}
}
