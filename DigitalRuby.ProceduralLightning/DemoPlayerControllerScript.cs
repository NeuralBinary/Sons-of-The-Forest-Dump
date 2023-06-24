using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class DemoPlayerControllerScript : MonoBehaviour
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xA2A370", Offset = "0xA28970", VA = "0x180A2A370")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xA2A700", Offset = "0xA28D00", VA = "0x180A2A700")]
		private void Start()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xA2A9F0", Offset = "0xA28FF0", VA = "0x180A2A9F0")]
		private void Update()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xA2B460", Offset = "0xA29A60", VA = "0x180A2B460")]
		private bool GuiElementShouldPassThrough()
		{
			return default(bool);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xA2B940", Offset = "0xA29F40", VA = "0x180A2B940")]
		private void UpdateSpell()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0xA2B9E0", Offset = "0xA29FE0", VA = "0x180A2B9E0")]
		private void ChangeSpell(int dir)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA2BAA0", Offset = "0xA2A0A0", VA = "0x180A2BAA0")]
		public void PreviousSpell()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA2BAB0", Offset = "0xA2A0B0", VA = "0x180A2BAB0")]
		public void NextSpell()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA2BAC0", Offset = "0xA2A0C0", VA = "0x180A2BAC0")]
		public DemoPlayerControllerScript()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		public Text SpellLabel;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public float Speed;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x2C")]
		public float RotateSpeed;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x30")]
		public LightningSpellScript[] Spells;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		private int spellIndex;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x3C")]
		private bool spellMouseButtonDown;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x40")]
		private GameObject rightHand;
	}
}
