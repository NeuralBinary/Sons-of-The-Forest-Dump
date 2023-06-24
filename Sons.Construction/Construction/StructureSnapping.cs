using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public static class StructureSnapping
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x2F51BD0", Offset = "0x2F501D0", VA = "0x182F51BD0")]
		public static bool IsLeaning(IFloorSupport support)
		{
			return default(bool);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0000B90C File Offset: 0x00009B0C
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x2F51D90", Offset = "0x2F50390", VA = "0x182F51D90")]
		internal static Directions CalcDirFromPos(IStructure targetStructure, Vector3 worldPos)
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x2F51EB0", Offset = "0x2F504B0", VA = "0x182F51EB0")]
		public static StructureElement GetClosestElement(Structure structure, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0000B924 File Offset: 0x00009B24
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x2F522B0", Offset = "0x2F508B0", VA = "0x182F522B0")]
		internal static float CalcClosestFloorSideLength(FloorStructure targetFloor, Vector3 hitPoint)
		{
			return 0f;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0000B93C File Offset: 0x00009B3C
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x2F52660", Offset = "0x2F50C60", VA = "0x182F52660")]
		internal static bool HasElementWithMiddleHoleProfile(IStructure targetStructure, ElementProfile profile)
		{
			return default(bool);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0000B954 File Offset: 0x00009B54
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x2F52860", Offset = "0x2F50E60", VA = "0x182F52860")]
		internal static bool IsShorterThanFirst(IStructure structure, ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0000B96C File Offset: 0x00009B6C
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x2F52A10", Offset = "0x2F51010", VA = "0x182F52A10")]
		internal static bool IsSameSizeOrShorterThanFirst(IStructure structure, ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0000B984 File Offset: 0x00009B84
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x2F52BB0", Offset = "0x2F511B0", VA = "0x182F52BB0")]
		internal static bool IsSameSizeOrShorterThanLast(IStructure structure, ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0000B99C File Offset: 0x00009B9C
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x2F52D50", Offset = "0x2F51350", VA = "0x182F52D50")]
		internal static bool IsTargetingOuterExtremity(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x2F52EC0", Offset = "0x2F514C0", VA = "0x182F52EC0")]
		internal static bool IsTargetingLeftOrRightSide(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0000B9CC File Offset: 0x00009BCC
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x2F53030", Offset = "0x2F51630", VA = "0x182F53030")]
		internal static bool IsTargetingLeftOrRightSide(Transform targetTr, Vector3 size, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x2F53110", Offset = "0x2F51710", VA = "0x182F53110")]
		internal static bool IsTargetingBackOrForwardEnd(Transform targetTr, Vector3 size, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0000B9FC File Offset: 0x00009BFC
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x2F531C0", Offset = "0x2F517C0", VA = "0x182F531C0")]
		internal static bool IsTargetingRightSide(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0000BA14 File Offset: 0x00009C14
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x2F532B0", Offset = "0x2F518B0", VA = "0x182F532B0")]
		internal static bool IsTargetingLeftSide(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0000BA2C File Offset: 0x00009C2C
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x2F532B0", Offset = "0x2F518B0", VA = "0x182F532B0")]
		internal static bool IsTargetingLeftSide(Structure structure, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0000BA44 File Offset: 0x00009C44
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x2F533A0", Offset = "0x2F519A0", VA = "0x182F533A0")]
		internal static bool IsTargetingBackSide(Structure structure, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0000BA5C File Offset: 0x00009C5C
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x2F533A0", Offset = "0x2F519A0", VA = "0x182F533A0")]
		internal static bool IsTargetingBackHalf(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0000BA74 File Offset: 0x00009C74
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x2F53490", Offset = "0x2F51A90", VA = "0x182F53490")]
		internal static bool IsTargetingMiddle(StructureElement targetElement, Vector3 point, float ratio = 0.25f)
		{
			return default(bool);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0000BA8C File Offset: 0x00009C8C
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x2F535B0", Offset = "0x2F51BB0", VA = "0x182F535B0")]
		internal static bool IsTargetingAboveMiddleSide(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x2F53700", Offset = "0x2F51D00", VA = "0x182F53700")]
		internal static bool IsTargetingLeftOrRightMiddleSide(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0000BABC File Offset: 0x00009CBC
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x2F53870", Offset = "0x2F51E70", VA = "0x182F53870")]
		internal static bool IsTargetingMiddleToForward(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x2F539A0", Offset = "0x2F51FA0", VA = "0x182F539A0")]
		internal static bool IsTargetingForward(StructureElement targetElement, Vector3 point, float forwardThreshold = 0f)
		{
			return default(bool);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0000BAEC File Offset: 0x00009CEC
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x2F53AA0", Offset = "0x2F520A0", VA = "0x182F53AA0")]
		internal static bool IsTargetingForward(Transform tr, Vector3 point, float forwardMiddleLimit = 0f)
		{
			return default(bool);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0000BB04 File Offset: 0x00009D04
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x2F53B40", Offset = "0x2F52140", VA = "0x182F53B40")]
		internal static bool IsTargetingAboveHorizontal(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0000BB1C File Offset: 0x00009D1C
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x2F53CB0", Offset = "0x2F522B0", VA = "0x182F53CB0")]
		internal static bool IsTargetingTopHalfHorizontal(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0000BB34 File Offset: 0x00009D34
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x2F53DA0", Offset = "0x2F523A0", VA = "0x182F53DA0")]
		internal static bool IsCastingFromAboveHorizontal(StructureElement targetElement, Vector3 castOrigin)
		{
			return default(bool);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0000BB4C File Offset: 0x00009D4C
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x2F53EA0", Offset = "0x2F524A0", VA = "0x182F53EA0")]
		internal static bool IsTargetingTopVertical(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0000BB64 File Offset: 0x00009D64
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x2F53FB0", Offset = "0x2F525B0", VA = "0x182F53FB0")]
		internal static bool IsTargetingTopVerticalY(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0000BB7C File Offset: 0x00009D7C
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x2F540B0", Offset = "0x2F526B0", VA = "0x182F540B0")]
		internal static bool IsTargetingTopHalfVertical(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0000BB94 File Offset: 0x00009D94
		[Token(Token = "0x6001357")]
		[Address(RVA = "0x2F541A0", Offset = "0x2F527A0", VA = "0x182F541A0")]
		internal static bool IsTargetingBottomThirdVertical(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0000BBAC File Offset: 0x00009DAC
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x2F533A0", Offset = "0x2F519A0", VA = "0x182F533A0")]
		internal static bool IsTargetingBottomHalfVertical(StructureElement targetElement, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x2F542B0", Offset = "0x2F528B0", VA = "0x182F542B0")]
		internal static bool AreInOppositeDirections(IStructure s1, IStructure s2)
		{
			return default(bool);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0000BBDC File Offset: 0x00009DDC
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x2F543B0", Offset = "0x2F529B0", VA = "0x182F543B0")]
		internal static bool AreChildStructuresSupportingOthers(IStructure structure)
		{
			return default(bool);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x2F545B0", Offset = "0x2F52BB0", VA = "0x182F545B0")]
		public static Vector3 GetDirAxis(IStructure structure, Directions dir)
		{
			return default(Vector3);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0000BC0C File Offset: 0x00009E0C
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x2F547A0", Offset = "0x2F52DA0", VA = "0x182F547A0")]
		public static bool CheckTileEdgeHaveCommonExtremity(ITileEdge tileEdgeA, ITileEdge tileEdgeB)
		{
			return default(bool);
		}
	}
}
