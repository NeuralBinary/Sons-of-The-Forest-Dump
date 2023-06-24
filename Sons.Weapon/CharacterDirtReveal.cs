using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[AddComponentMenu("Sons/Weapon/Character Dirt Reveal")]
	public class CharacterDirtReveal : MonoBehaviour
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x3197DB0", Offset = "0x31963B0", VA = "0x183197DB0")]
		private void Start()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x3197E20", Offset = "0x3196420", VA = "0x183197E20")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3197E30", Offset = "0x3196430", VA = "0x183197E30")]
		private void DestroyMaterialInstance()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3197F90", Offset = "0x3196590", VA = "0x183197F90")]
		private void RestoreMaterial()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x31980B0", Offset = "0x31966B0", VA = "0x1831980B0")]
		private void UpdateMaterial()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3198450", Offset = "0x3196A50", VA = "0x183198450")]
		public void CleanDirt(float delta)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x31984E0", Offset = "0x3196AE0", VA = "0x1831984E0")]
		public void AddDirt(float delta)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3198570", Offset = "0x3196B70", VA = "0x183198570")]
		public float GetDirtPercentage()
		{
			return 0f;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3197DB0", Offset = "0x31963B0", VA = "0x183197DB0")]
		public void UpdateDirtiness()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnVariationChanged()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x31985A0", Offset = "0x3196BA0", VA = "0x1831985A0")]
		public CharacterDirtReveal()
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _sectionIndex;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _dirtMinMax;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 _dirtHeightMinMax;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _dirtAmount;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x40")]
		private float _dirtMaxValue;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x44")]
		private float _dirtHeightValue;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x48")]
		private readonly int _dirtHeightPropertyId;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x4C")]
		private readonly int _dirtMaxPropertyId;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x50")]
		private Material _materialInstance;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x58")]
		private Material _oldMaterial;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x60")]
		private bool _existingMaterialInstance;
	}
}
