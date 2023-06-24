using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200086D RID: 2157
	[Token(Token = "0x200086D")]
	public class CookingPotLid : MonoBehaviour
	{
		// Token: 0x06003D95 RID: 15765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D95")]
		[Address(RVA = "0x35C2F10", Offset = "0x35C1510", VA = "0x1835C2F10")]
		public void SetRemainingCookingTime(float remainingCookingTime)
		{
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x35C2FF0", Offset = "0x35C15F0", VA = "0x1835C2FF0")]
		public void LidHitSfx()
		{
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x35C3090", Offset = "0x35C1690", VA = "0x1835C3090")]
		public void BeginCooking(CookingRecipe cookingRecipe)
		{
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x35C3330", Offset = "0x35C1930", VA = "0x1835C3330")]
		public void FinishedCooking()
		{
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x35C3430", Offset = "0x35C1A30", VA = "0x1835C3430")]
		public void PausedCooking()
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x35C3580", Offset = "0x35C1B80", VA = "0x1835C3580")]
		public void ResumeCooking()
		{
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CookingPotLid()
		{
		}

		// Token: 0x040033EF RID: 13295
		[Token(Token = "0x40033EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040033F0 RID: 13296
		[Token(Token = "0x40033F0")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		[SerializeField]
		private string _lidHitSfx;

		// Token: 0x040033F1 RID: 13297
		[Token(Token = "0x40033F1")]
		[FieldOffset(Offset = "0x30")]
		private CookingRecipe _cookingRecipe;

		// Token: 0x040033F2 RID: 13298
		[Token(Token = "0x40033F2")]
		[FieldOffset(Offset = "0x38")]
		private float _recipeTotalCookDuration;

		// Token: 0x040033F3 RID: 13299
		[Token(Token = "0x40033F3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int RecipeProgress;

		// Token: 0x040033F4 RID: 13300
		[Token(Token = "0x40033F4")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BeginCookingTrigger;

		// Token: 0x040033F5 RID: 13301
		[Token(Token = "0x40033F5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int FinishedCookingTrigger;

		// Token: 0x040033F6 RID: 13302
		[Token(Token = "0x40033F6")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int PauseCookingTrigger;

		// Token: 0x040033F7 RID: 13303
		[Token(Token = "0x40033F7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int ResumeCookingTrigger;
	}
}
