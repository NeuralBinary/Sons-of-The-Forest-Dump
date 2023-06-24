using System;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class ArchetypeUtils
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2D80C90", Offset = "0x2D7F290", VA = "0x182D80C90")]
		public static void SetGenerateBuilt(bool generateBuilt)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D80CD0", Offset = "0x2D7F2D0", VA = "0x182D80CD0")]
		public static Vector3 ConvertSizeToBlueprintSpace(BlueprintFace face, out bool preserveTileAxis)
		{
			return default(Vector3);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D81090", Offset = "0x2D7F690", VA = "0x182D81090")]
		public static void CalcFaceTileFromTo(out Vector3Int tileFrom, out Vector3Int tileTo, Vector3 size, float tileLength, Vector3 tileLocalOrigin)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2D81220", Offset = "0x2D7F820", VA = "0x182D81220")]
		public static void SortMembers(ref Vector3Int from, ref Vector3Int to)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2D81260", Offset = "0x2D7F860", VA = "0x182D81260")]
		public static void InitGhostStructure(Structure ghostStructure, ElementProfile interactionElement, ElementProfile fallbackBuiltElement, float lengthScale = 1f)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2D81450", Offset = "0x2D7FA50", VA = "0x182D81450")]
		public static void InitGhostStructure(Structure ghostStructure, ElementProfile interactionElement, ElementProfile fallbackBuiltElement, Vector3 elementPos, Quaternion elementRot, float lengthScale = 1f)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static bool GenerateBuilt;
	}
}
