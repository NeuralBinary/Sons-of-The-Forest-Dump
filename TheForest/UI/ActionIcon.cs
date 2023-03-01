using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Input;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TheForest.UI
{
	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	public class ActionIcon : MonoBehaviour
	{
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00007ED8 File Offset: 0x000060D8
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B3")]
		public float StartHeight
		{
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x20452B0", Offset = "0x20442B0", VA = "0x1820452B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6001A9A")]
			[Address(RVA = "0x22A4680", Offset = "0x22A3680", VA = "0x1822A4680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
		public TextMeshProUGUI GetLabel()
		{
			return null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
		public Image GetSprite()
		{
			return null;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x5B3100", Offset = "0x5B2100", VA = "0x1805B3100")]
		public Image GetFillSprite()
		{
			return null;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
		public Image GetSideUpArrowIcon()
		{
			return null;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
		public Image GetMiddleUpArrowIcon()
		{
			return null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x2CDD990", Offset = "0x2CDC990", VA = "0x182CDD990")]
		private void OnValidate()
		{
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x2CDD8F0", Offset = "0x2CDC8F0", VA = "0x182CDD8F0")]
		private void Awake()
		{
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x2CDDB60", Offset = "0x2CDCB60", VA = "0x182CDDB60")]
		public void ShowFillSprite(bool useFillSprite)
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ActionIcon()
		{
		}

		// Token: 0x040019D3 RID: 6611
		[Token(Token = "0x40019D3")]
		[FieldOffset(Offset = "0x20")]
		public UiFollowTarget _follow;

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0x28")]
		public InputSystem.ActionId _action;

		// Token: 0x040019D5 RID: 6613
		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public GameObject _spriteGameObject;

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _sprite;

		// Token: 0x040019D7 RID: 6615
		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040019D8 RID: 6616
		[Token(Token = "0x40019D8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public GameObject _labelGameObject;

		// Token: 0x040019D9 RID: 6617
		[Token(Token = "0x40019D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public GameObject _sideUpArrowIconGameObject;

		// Token: 0x040019DA RID: 6618
		[Token(Token = "0x40019DA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _sideUpArrowIcon;

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public GameObject _middleUpArrowIconGameObject;

		// Token: 0x040019DC RID: 6620
		[Token(Token = "0x40019DC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _middleUpArrowIcon;

		// Token: 0x040019DD RID: 6621
		[Token(Token = "0x40019DD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _fillGroup;

		// Token: 0x040019DE RID: 6622
		[Token(Token = "0x40019DE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _fillSprite;

		// Token: 0x040019DF RID: 6623
		[Token(Token = "0x40019DF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public DelayedAction _fillSpriteAction;

		// Token: 0x040019E0 RID: 6624
		[Token(Token = "0x40019E0")]
		[FieldOffset(Offset = "0x88")]
		public Material _testMaterial;

		// Token: 0x020003E7 RID: 999
		[Token(Token = "0x20003E7")]
		public enum SideIconTypes
		{
			// Token: 0x040019E3 RID: 6627
			[Token(Token = "0x40019E3")]
			None = -1,
			// Token: 0x040019E4 RID: 6628
			[Token(Token = "0x40019E4")]
			UpArrow,
			// Token: 0x040019E5 RID: 6629
			[Token(Token = "0x40019E5")]
			MiddleUpArrow
		}
	}
}
