using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Input
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[AddComponentMenu("Sons/Gui/Options/Link To Input")]
	public class LinkToInput : MonoBehaviour
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
		public void SetOverrideInteractable(bool value)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000027")]
		private List<string> GetMenuDropdown
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x305B6C0", Offset = "0x3059CC0", VA = "0x18305B6C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x305B700", Offset = "0x3059D00", VA = "0x18305B700")]
		private void OnValidate()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x305BA00", Offset = "0x305A000", VA = "0x18305BA00")]
		private void Update()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x305BD80", Offset = "0x305A380", VA = "0x18305BD80")]
		private bool IsLinkedActiveOrUnset()
		{
			return default(bool);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LinkToInput()
		{
		}

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _action;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Selectable _selectable;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Selectable _selectableTarget;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _limitToActiveTarget;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _overrideInteractable;
	}
}
