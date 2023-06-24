using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	public static class SnappingUtils
	{
		// Token: 0x060012E2 RID: 4834 RVA: 0x0000B6B4 File Offset: 0x000098B4
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x2F469D0", Offset = "0x2F44FD0", VA = "0x182F469D0")]
		public static bool TryGetTargetedExtremity(Vector3 targetWorldPos, StructureElement target, out Vector3 targetExtremity, float maxForwardDistance, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
			return default(bool);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0000B6CC File Offset: 0x000098CC
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x2F46C60", Offset = "0x2F45260", VA = "0x182F46C60")]
		public static bool TryGetTargetedExtremity(Vector3 targetWorldPos, Transform targetTr, Vector3 size, out Vector3 targetExtremity, float maxDistance, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
			return default(bool);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x2F46DC0", Offset = "0x2F453C0", VA = "0x182F46DC0")]
		public static void CalculateExtremities(Transform target, Vector3 size, out Vector3 backExtremityWorldPos, out Vector3 forwardExtremityWorldPos, float penetrationOffset = 0f, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x2F46FC0", Offset = "0x2F455C0", VA = "0x182F46FC0")]
		public static void CalculateExtremities(Transform target, Vector3 size, out Vector3 centerPos, out Vector3 backExtremityWorldPos, out Vector3 forwardExtremityWorldPos, float penetrationOffset = 0f, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x2F471B0", Offset = "0x2F457B0", VA = "0x182F471B0")]
		public static void CalculateExtremities(StructureElement element, out Vector3 backExtremityWorldPos, out Vector3 forwardExtremityWorldPos)
		{
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0000B6E4 File Offset: 0x000098E4
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x2F47420", Offset = "0x2F45A20", VA = "0x182F47420")]
		public static Vector3 CalcBackExtremitySnapPoint(StructureElement element, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
			return default(Vector3);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0000B6FC File Offset: 0x000098FC
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x2F47680", Offset = "0x2F45C80", VA = "0x182F47680")]
		public static Vector3 CalcForwardExtremitySnapPoint(StructureElement element, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
			return default(Vector3);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x2F478E0", Offset = "0x2F45EE0", VA = "0x182F478E0")]
		public static void GetClosestAndRemoteExtremities(Transform target, Vector3 size, Vector3 targetWorldPos, out Vector3 closestExtremityWorldPos, out Vector3 remoteExtremityWorldPos, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z, float penetrationOffset = 0f)
		{
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x2F47B00", Offset = "0x2F46100", VA = "0x182F47B00")]
		public static void GetClosestExtremitySnapPoint(StructureElement element, Vector3 targetWorldPos, out Vector3 snapPos, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z)
		{
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x2F47D90", Offset = "0x2F46390", VA = "0x182F47D90")]
		public static void GetClosestExtremity(Transform target, Vector3 size, Vector3 targetWorldPos, out Vector3 closestExtremityWorldPos, SnappingUtils.Axis forwardAxis = SnappingUtils.Axis.Z, float penetrationOffset = 0f)
		{
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x2F47F90", Offset = "0x2F46590", VA = "0x182F47F90")]
		public static void ApplyPositionFromExtremities(Transform target, Vector3 offsetToCenter, Vector3 backExtremityWorldPos, Vector3 forwardExtremityWorldPos)
		{
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0000B714 File Offset: 0x00009914
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x2F480E0", Offset = "0x2F466E0", VA = "0x182F480E0")]
		public static Vector3 CalcSnappedPlaceAxis(Vector3 snapPos, Vector3 lookAtPos, Transform targetTr, bool allow45Deg)
		{
			return default(Vector3);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0000B72C File Offset: 0x0000992C
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x2F485D0", Offset = "0x2F46BD0", VA = "0x182F485D0")]
		public static Vector3 GetMainDirAxis(Transform tr, Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0000B744 File Offset: 0x00009944
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x2F486A0", Offset = "0x2F46CA0", VA = "0x182F486A0")]
		public static bool IsWithinDistance(Vector3 from, Vector3 to, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0000B75C File Offset: 0x0000995C
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x2F487A0", Offset = "0x2F46DA0", VA = "0x182F487A0")]
		public static bool IsWithinDistance(Vector3 from, Vector3 to, float minDistance, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0000B774 File Offset: 0x00009974
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x2F488B0", Offset = "0x2F46EB0", VA = "0x182F488B0")]
		public static bool IsWithinDistanceFlat(Vector3 from, Vector3 to, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0000B78C File Offset: 0x0000998C
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x2F489B0", Offset = "0x2F46FB0", VA = "0x182F489B0")]
		public static bool IsWithinDistanceFlat(Vector3 from, Vector3 to, float minDistance, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0000B7A4 File Offset: 0x000099A4
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x2F48AD0", Offset = "0x2F470D0", VA = "0x182F48AD0")]
		public static float CalcLengthScaleToFitSnapDistance(StructureElement elementPrefab, float distance)
		{
			return 0f;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0000B7BC File Offset: 0x000099BC
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x2F48B60", Offset = "0x2F47160", VA = "0x182F48B60")]
		public static float CalcLengthScaleToFitDistance(StructureElement elementPrefab, float distance)
		{
			return 0f;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0000B7D4 File Offset: 0x000099D4
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x2F48BB0", Offset = "0x2F471B0", VA = "0x182F48BB0")]
		public static int CalcQuartersToFitDistance(StructureElement elementPrefab, float distance)
		{
			return 0;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0000B7EC File Offset: 0x000099EC
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x2F48C30", Offset = "0x2F47230", VA = "0x182F48C30")]
		public static int CalcQuartersToFitSnapDistance(StructureElement elementPrefab, float distance)
		{
			return 0;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x2F48CD0", Offset = "0x2F472D0", VA = "0x182F48CD0")]
		public static void ApplyLengthScale(StructureElement instance, float lengthScale)
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0000B804 File Offset: 0x00009A04
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x2F48E30", Offset = "0x2F47430", VA = "0x182F48E30")]
		public static Vector3 GetLeftOrRightPlaceAxis(Vector3 worldPos, Transform target)
		{
			return default(Vector3);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0000B81C File Offset: 0x00009A1C
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x2F48F40", Offset = "0x2F47540", VA = "0x182F48F40")]
		public static Vector3 GetForwardOrBackwardPlaceAxis(Vector3 worldPos, Transform target)
		{
			return default(Vector3);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000B834 File Offset: 0x00009A34
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x2F49050", Offset = "0x2F47650", VA = "0x182F49050")]
		internal static Vector3 GetDetachedPlaceAxisForDirFromNode(IDetachedPlacementStructure node, Directions targetDir)
		{
			return default(Vector3);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0000B84C File Offset: 0x00009A4C
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x2F492E0", Offset = "0x2F478E0", VA = "0x182F492E0")]
		public static Directions GetForwardOrBackwardDirection(Vector3 worldPos, Transform target)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0000B864 File Offset: 0x00009A64
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x2F49370", Offset = "0x2F47970", VA = "0x182F49370")]
		public static Directions GetLeftOrRightDirection(Vector3 worldPos, Transform target)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0000B87C File Offset: 0x00009A7C
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x2F49400", Offset = "0x2F47A00", VA = "0x182F49400")]
		public static Directions GetDirFromPosition(Transform target, Vector3 hitPoint)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0000B894 File Offset: 0x00009A94
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x2F494D0", Offset = "0x2F47AD0", VA = "0x182F494D0")]
		public static bool IsAimingToTheRight(Vector3 worldPos, Transform target)
		{
			return default(bool);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x2F49590", Offset = "0x2F47B90", VA = "0x182F49590")]
		public static void ConformWithTerrain(Transform target, Vector3 size, bool verticalPost)
		{
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001300")]
		[Address(RVA = "0x2F49830", Offset = "0x2F47E30", VA = "0x182F49830")]
		public static void EnsurePhysicallyGroundedPosition(Transform target, Vector3 size, Vector3 offsetToCenter, float maxDistance = 3f, bool aboveTerrain = true)
		{
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0000B8AC File Offset: 0x00009AAC
		[Token(Token = "0x6001301")]
		[Address(RVA = "0x2F49A90", Offset = "0x2F48090", VA = "0x182F49A90")]
		public static float CalcBackToForwardSnapPointsDistance(StructureElement elementPrefab)
		{
			return 0f;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001302")]
		[Address(RVA = "0x2F49AD0", Offset = "0x2F480D0", VA = "0x182F49AD0")]
		public static StructureElement GetClosestElement(Structure structure, Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x02000270 RID: 624
		[Token(Token = "0x2000270")]
		public enum Axis
		{
			// Token: 0x0400095C RID: 2396
			[Token(Token = "0x400095C")]
			X,
			// Token: 0x0400095D RID: 2397
			[Token(Token = "0x400095D")]
			Y,
			// Token: 0x0400095E RID: 2398
			[Token(Token = "0x400095E")]
			Z
		}
	}
}
