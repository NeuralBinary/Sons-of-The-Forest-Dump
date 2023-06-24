using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[CreateAssetMenu(menuName = "Sons/Ai/Health Variations", fileName = "ActorHealth", order = 0)]
	public class ActorHealthVariations : ScriptableObject
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2AF3DA0", Offset = "0x2AF23A0", VA = "0x182AF3DA0")]
		public float GetMaxHealth(int variationId, float defaultHealth)
		{
			return 0f;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ActorHealthVariations()
		{
		}

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ActorHealthVariations.HealthVariation> _healthVariations;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		[Serializable]
		private class HealthVariation
		{
			// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public HealthVariation()
			{
			}

			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x10")]
			public int VariationId;

			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x14")]
			public float Health;
		}
	}
}
