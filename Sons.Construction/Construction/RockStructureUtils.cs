using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	internal static class RockStructureUtils
	{
		// Token: 0x060012DB RID: 4827 RVA: 0x0000B63C File Offset: 0x0000983C
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x2F43FC0", Offset = "0x2F425C0", VA = "0x182F43FC0")]
		public static int CountFullLines(IRockStructure rockStructure)
		{
			return 0;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0000B654 File Offset: 0x00009854
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x2F44260", Offset = "0x2F42860", VA = "0x182F44260")]
		public static int CountLineChunks(IRockStructure rockStructure, int fullLines)
		{
			return 0;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0000B66C File Offset: 0x0000986C
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x2F442C0", Offset = "0x2F428C0", VA = "0x182F442C0")]
		public static bool TryAddElementFromPresetTemplate(IRockStructure rockStructure, StructureElement elementPrefab, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0000B684 File Offset: 0x00009884
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x2F448E0", Offset = "0x2F42EE0", VA = "0x182F448E0")]
		public static bool TryAddElementFromPresetTemplate(IRockStructure rockStructure, StructureElement elementPrefab, Vector3 nearPos, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0000B69C File Offset: 0x0000989C
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x2F45230", Offset = "0x2F43830", VA = "0x182F45230")]
		private static bool TryConvertToFullLine(IRockStructure rockStructure, StructureElement elementPrefab, Vector3 nearPos, int fullLines, int lineChunks, out StructureElement instance, out Vector3 pos, out Quaternion rot, out float zScale, out PresetElementsTemplate template)
		{
			return default(bool);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x2F459F0", Offset = "0x2F43FF0", VA = "0x182F459F0")]
		public static void RemoveOneChunkElement(IRockStructure rockStructure, out ElementProfile elementProfile)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x2F45D20", Offset = "0x2F44320", VA = "0x182F45D20")]
		public static void Repair(IRockStructure rockStructure, float healthAlpha)
		{
		}
	}
}
