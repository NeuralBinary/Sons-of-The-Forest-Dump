using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	public class CookingPotIngredientTweener : MonoBehaviour
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x00012C30 File Offset: 0x00010E30
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FC")]
		private float TweenSpeed
		{
			[Token(Token = "0x6003D8B")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003D8C")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x35C23C0", Offset = "0x35C09C0", VA = "0x1835C23C0")]
		private void Start()
		{
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x35C24A0", Offset = "0x35C0AA0", VA = "0x1835C24A0")]
		private void Update()
		{
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x35C2990", Offset = "0x35C0F90", VA = "0x1835C2990")]
		public void Register(CookingPotIngredientVisual ingredientVisual)
		{
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x35C2B50", Offset = "0x35C1150", VA = "0x1835C2B50")]
		public void Unregister(CookingPotIngredientVisual ingredientVisual)
		{
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D91")]
		[Address(RVA = "0x35C2C50", Offset = "0x35C1250", VA = "0x1835C2C50")]
		public CookingPotIngredientTweener()
		{
		}

		// Token: 0x040033EB RID: 13291
		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x20")]
		private List<CookingPotIngredientVisual> _ingredientVisuals;

		// Token: 0x040033EC RID: 13292
		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x28")]
		private List<float> _ingredientVisualsTweenAlpha;
	}
}
