using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x20006FC")]
	[CreateAssetMenu(menuName = "Sons/Create CharacterDefinition", fileName = "CharacterDefinition", order = 0)]
	public class CharacterDefinition : ScriptableObject
	{
		// Token: 0x06002F3E RID: 12094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public List<string> GetAliases()
		{
			return null;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x345BD70", Offset = "0x345A370", VA = "0x18345BD70")]
		public VailActorTypeId GetActorTypeId()
		{
			return VailActorTypeId.None;
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x345BEC0", Offset = "0x345A4C0", VA = "0x18345BEC0")]
		public bool TryGetVariation(string variationId, int numSpawned, out CharacterVariation result)
		{
			return default(bool);
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x345C260", Offset = "0x345A860", VA = "0x18345C260")]
		public CharacterVariation GetRandom(int spawnedCount)
		{
			return null;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x345C780", Offset = "0x345AD80", VA = "0x18345C780")]
		public CharacterDefinition()
		{
		}

		// Token: 0x040028EC RID: 10476
		[Token(Token = "0x40028EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _id;

		// Token: 0x040028ED RID: 10477
		[Token(Token = "0x40028ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _aliases;

		// Token: 0x040028EE RID: 10478
		[Token(Token = "0x40028EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CharacterDefinition> _forceSpawnDefinitions;

		// Token: 0x040028EF RID: 10479
		[Token(Token = "0x40028EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CharacterVariation> _variations;
	}
}
