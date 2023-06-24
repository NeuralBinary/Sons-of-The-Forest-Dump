using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Serializable]
	public class StatusEffectManager
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2FFD8B0", Offset = "0x2FFBEB0", VA = "0x182FFD8B0")]
		public void CleanUp()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2FFD980", Offset = "0x2FFBF80", VA = "0x182FFD980")]
		public void Add(StatusEffectType type, float lifetime)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2FFDBC0", Offset = "0x2FFC1C0", VA = "0x182FFDBC0")]
		public void AdjustLifetime(StatusEffectType type, float deltaLifetime)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2FFDD20", Offset = "0x2FFC320", VA = "0x182FFDD20")]
		public void Remove(StatusEffectType type)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2FFDE00", Offset = "0x2FFC400", VA = "0x182FFDE00")]
		public void GetStatusEffectAmounts(List<int> amounts)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FFDFE0", Offset = "0x2FFC5E0", VA = "0x182FFDFE0")]
		private float EffectRemainingLifetime(StatusEffectType type)
		{
			return 0f;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2FFE140", Offset = "0x2FFC740", VA = "0x182FFE140")]
		public string GetDebugString()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2FFE3A0", Offset = "0x2FFC9A0", VA = "0x182FFE3A0")]
		public StatusEffectManager()
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<StatusEffect> _effects;
	}
}
