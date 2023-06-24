using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	internal static class StructureTransformationUtils
	{
		// Token: 0x0600135D RID: 4957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x2F54C60", Offset = "0x2F53260", VA = "0x182F54C60")]
		public static void TransformPilarIntoDefensiveWall(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x2F54F50", Offset = "0x2F53550", VA = "0x182F54F50")]
		public static void TransformGateIntoDefensiveWall(DefensiveWallGateStructure fromGate)
		{
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x2F554B0", Offset = "0x2F53AB0", VA = "0x182F554B0")]
		public static void TransformDefensiveWallIntoGate(TargetInfo targetInfo)
		{
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001360")]
		public static void TransformStructureIntoCompoundStructure<T>(TargetInfo targetInfo) where T : Structure
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x2F55A60", Offset = "0x2F54060", VA = "0x182F55A60")]
		public static PresetStructure TransformStructureIntoPresetStructure(Structure structure, Vector3 placeAxis)
		{
			return null;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x2F55E20", Offset = "0x2F54420", VA = "0x182F55E20")]
		public static void TransformStructureIntoPresetStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001363")]
		public static void TransformStructureIntoPilarStructure<T>(TargetInfo targetInfo) where T : Structure
		{
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x2F55E80", Offset = "0x2F54480", VA = "0x182F55E80")]
		public static void TransformWallIntoApexStructure(TargetInfo targetInfo)
		{
		}
	}
}
