using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Input;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TheForest.UI
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	public class ActionIcon : MonoBehaviour
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00008160 File Offset: 0x00006360
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BD")]
		public float StartHeight
		{
			[Token(Token = "0x6001AD7")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001AD8")]
			[Address(RVA = "0x26FA8A0", Offset = "0x26F8EA0", VA = "0x1826FA8A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public TextMeshProUGUI GetLabel()
		{
			return null;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public Image GetSprite()
		{
			return null;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public Image GetFillSprite()
		{
			return null;
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		public Image GetSideUpArrowIcon()
		{
			return null;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
		public Image GetMiddleUpArrowIcon()
		{
			return null;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x32A9390", Offset = "0x32A7990", VA = "0x1832A9390")]
		private void OnValidate()
		{
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x32A9830", Offset = "0x32A7E30", VA = "0x1832A9830")]
		private void Awake()
		{
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x32A9930", Offset = "0x32A7F30", VA = "0x1832A9930")]
		public void ShowFillSprite(bool useFillSprite)
		{
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ActionIcon()
		{
		}

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x20")]
		public UiFollowTarget _follow;

		// Token: 0x040019F8 RID: 6648
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x28")]
		public InputSystem.ActionId _action;

		// Token: 0x040019F9 RID: 6649
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public GameObject _spriteGameObject;

		// Token: 0x040019FA RID: 6650
		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _sprite;

		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public GameObject _labelGameObject;

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public GameObject _sideUpArrowIconGameObject;

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _sideUpArrowIcon;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public GameObject _middleUpArrowIconGameObject;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _middleUpArrowIcon;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _fillGroup;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _fillSprite;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public DelayedAction _fillSpriteAction;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x88")]
		public Material _testMaterial;

		// Token: 0x020003D9 RID: 985
		[Token(Token = "0x20003D9")]
		public enum SideIconTypes
		{
			// Token: 0x04001A07 RID: 6663
			[Token(Token = "0x4001A07")]
			None = -1,
			// Token: 0x04001A08 RID: 6664
			[Token(Token = "0x4001A08")]
			UpArrow,
			// Token: 0x04001A09 RID: 6665
			[Token(Token = "0x4001A09")]
			MiddleUpArrow
		}
	}
}
