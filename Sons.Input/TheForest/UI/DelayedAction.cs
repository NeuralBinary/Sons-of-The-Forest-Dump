using System;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;
using UnityEngine.UI;

namespace TheForest.UI
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class DelayedAction : MonoBehaviour
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E6")]
		public Image FillIcon
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x30AC200", Offset = "0x30AA800", VA = "0x1830AC200")]
		private void OnValidate()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x30AC450", Offset = "0x30AAA50", VA = "0x1830AC450")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x30AC670", Offset = "0x30AAC70", VA = "0x1830AC670")]
		public void SetAction(InputSystem.ActionId action)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x30AC720", Offset = "0x30AAD20", VA = "0x1830AC720")]
		public void ClearAction()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x30AC7D0", Offset = "0x30AADD0", VA = "0x1830AC7D0")]
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x30AC8F0", Offset = "0x30AAEF0", VA = "0x1830AC8F0")]
		public DelayedAction()
		{
		}

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _visibleGroup;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _fillIcon;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _background;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x38")]
		private InputSystem.Action _action;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x48")]
		public bool _useFillSprite;
	}
}
