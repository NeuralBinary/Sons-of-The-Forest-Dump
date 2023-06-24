using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[CreateAssetMenu(fileName = "NewStatRecipesData", menuName = "Sons/Data/Items/StatRecipesData", order = 0)]
	public class StatRecipesData : ScriptableObject
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000055")]
		public List<StatRecipe> StatRecipes
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x30B2290", Offset = "0x30B0890", VA = "0x1830B2290")]
		public StatRecipesData()
		{
		}

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StatRecipe> _statRecipes;
	}
}
