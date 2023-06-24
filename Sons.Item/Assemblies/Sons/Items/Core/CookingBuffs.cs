using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Assemblies.Sons.Items.Core
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[CreateAssetMenu(fileName = "CookingBuffs", menuName = "Sons/Cooking/CookingBuffs", order = 0)]
	public class CookingBuffs : ScriptableObject
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x30B2450", Offset = "0x30B0A50", VA = "0x1830B2450")]
		public void GetIconsFromStatEffectType(StatEffect.Types statEffectType, out Texture2D icon, out Texture2D iconBackground)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x30B26B0", Offset = "0x30B0CB0", VA = "0x1830B26B0")]
		public CookingBuffs.CookingBuffData GetData(StatEffect.Types statEffectType)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x30B2890", Offset = "0x30B0E90", VA = "0x1830B2890")]
		public CookingBuffs()
		{
		}

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x18")]
		public CookingBuffs.CookingBuffData _defaultResult;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x20")]
		public List<CookingBuffs.CookingBuffData> _cookingBuffs;

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		[Serializable]
		public class CookingBuffData
		{
			// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CookingBuffData()
			{
			}

			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x10")]
			public Texture2D _icon;

			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D _iconBackground;

			// Token: 0x0400020C RID: 524
			[Token(Token = "0x400020C")]
			[FieldOffset(Offset = "0x20")]
			public StatEffect.Types _statEffectType;
		}
	}
}
