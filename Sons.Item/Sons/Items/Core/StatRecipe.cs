using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;

namespace Sons.Items.Core
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[CreateAssetMenu(fileName = "StatRecipe", menuName = "Sons/Cooking/StatRecipe")]
	public class StatRecipe : ScriptableObject
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x1700004F")]
		public static float CookingBuffDurationToSeconds
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x30B2150", Offset = "0x30B0750", VA = "0x1830B2150")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000050")]
		public Texture Icon
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000051")]
		public LocalizedString DisplayName
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x17000052")]
		public int Id
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x17000053")]
		public bool IsACookingBuff
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x17000054")]
		public float CookingBuffDuration
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x30B2160", Offset = "0x30B0760", VA = "0x1830B2160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x30B2180", Offset = "0x30B0780", VA = "0x1830B2180")]
		private void OnValidate()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x30B21C0", Offset = "0x30B07C0", VA = "0x1830B21C0")]
		public bool IsNetNegativeEffect()
		{
			return default(bool);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public IEnumerable<StatEffect> StatEffects()
		{
			return null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x30B21D0", Offset = "0x30B07D0", VA = "0x1830B21D0")]
		public StatRecipe()
		{
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected LocalizedString _displayName;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Texture _icon;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StatEffect> _statEffects;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isACookingBuff;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _cookingBuffDuration;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _hashId;
	}
}
