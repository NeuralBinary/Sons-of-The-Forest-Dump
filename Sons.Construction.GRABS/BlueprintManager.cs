using System;
using System.Collections.Generic;
using Construction;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class BlueprintManager : SingletonBehaviour<BlueprintManager>
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2D8F380", Offset = "0x2D8D980", VA = "0x182D8F380", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2D8F430", Offset = "0x2D8DA30", VA = "0x182D8F430")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		private void ToggleInstantBuilt(bool onOff)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		private void BuildAll(bool onOff)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2D8F490", Offset = "0x2D8DA90", VA = "0x182D8F490")]
		public static IReadOnlyList<Blueprint> GetBlueprints()
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2D8F4F0", Offset = "0x2D8DAF0", VA = "0x182D8F4F0")]
		public static void AddBlueprint(Blueprint blueprint)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2D8F630", Offset = "0x2D8DC30", VA = "0x182D8F630")]
		public static void RemoveBlueprint(Blueprint blueprint)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2D8F6B0", Offset = "0x2D8DCB0", VA = "0x182D8F6B0")]
		public static void GenerateAll()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2D8F870", Offset = "0x2D8DE70", VA = "0x182D8F870")]
		private List<Structure> GenerateBlueprintStructures(Blueprint blueprint, bool forceGenerateBuilt)
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2D8FC70", Offset = "0x2D8E270", VA = "0x182D8FC70")]
		public static void Register(IGrabsStructureGeneratedProcessor structureGeneratedProcessor)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2D8FD10", Offset = "0x2D8E310", VA = "0x182D8FD10")]
		public BlueprintManager()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _generateBuilt;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Archetype[] _archetypes;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Blueprint> _blueprints;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x40")]
		private IGrabsStructureGeneratedProcessor _structureGeneratedProcessor;
	}
}
