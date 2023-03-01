using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x20007EF")]
	[CreateAssetMenu(menuName = "Sons/Create CharacterDefinition", fileName = "CharacterDefinition", order = 0)]
	public class CharacterDefinition : ScriptableObject
	{
		// Token: 0x0600359E RID: 13726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public List<string> GetAliases()
		{
			return null;
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x2E8E300", Offset = "0x2E8D300", VA = "0x182E8E300")]
		public VailActorTypeId GetActorTypeId()
		{
			return default(VailActorTypeId);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x2E8E850", Offset = "0x2E8D850", VA = "0x182E8E850")]
		public bool TryGetVariation(string variationId, int numSpawned, out CharacterVariation result)
		{
			return default(bool);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x2E8E430", Offset = "0x2E8D430", VA = "0x182E8E430")]
		public CharacterVariation GetRandom(int spawnedCount)
		{
			return null;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x2E8EA50", Offset = "0x2E8DA50", VA = "0x182E8EA50")]
		public CharacterDefinition()
		{
		}

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _id;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _aliases;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CharacterDefinition> _forceSpawnDefinitions;

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CharacterVariation> _variations;
	}
}
