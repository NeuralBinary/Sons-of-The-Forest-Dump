using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gui.Input;
using Sons.UiElements;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[AddComponentMenu("Sons/Gui/DropdownEventManager")]
	public class DropdownEventManager : MonoBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000002")]
		public Selectable RightSelectable
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		public Selectable LeftSelectable
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3002270", Offset = "0x3000870", VA = "0x183002270")]
		private void OnValidate()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x30026F0", Offset = "0x3000CF0", VA = "0x1830026F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3002790", Offset = "0x3000D90", VA = "0x183002790")]
		private void OnDisable()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x3002860", Offset = "0x3000E60", VA = "0x183002860")]
		private void Update()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3002A50", Offset = "0x3001050", VA = "0x183002A50")]
		private void RefreshActiveLinks()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3002B40", Offset = "0x3001140", VA = "0x183002B40")]
		private bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3002D50", Offset = "0x3001350", VA = "0x183002D50")]
		private void RefreshTargetInteractable()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3002E70", Offset = "0x3001470", VA = "0x183002E70")]
		public void ChangeValueToNext()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3002F50", Offset = "0x3001550", VA = "0x183002F50")]
		private void ChangeValueToNextInternal()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3002FE0", Offset = "0x30015E0", VA = "0x183002FE0")]
		private void RefreshArrowSelectables(int newValue, List<TMP_Dropdown.OptionData> options)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x30030A0", Offset = "0x30016A0", VA = "0x1830030A0")]
		private void SetSelectableAndLink(Selectable arrowSelectable, List<LinkToInput> linkToInputs, bool isAtLastItem)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3003230", Offset = "0x3001830", VA = "0x183003230")]
		private void UpdateInteractable(Selectable arrowSelectable, List<LinkToInput> linkToInputs, bool value)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x30032F0", Offset = "0x30018F0", VA = "0x1830032F0")]
		public void ChangeValueToPrevious()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x30033D0", Offset = "0x30019D0", VA = "0x1830033D0")]
		private void ChangeValueToPreviousInternal()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3003460", Offset = "0x3001A60", VA = "0x183003460")]
		private void SetTargetValue(int newValue)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3003490", Offset = "0x3001A90", VA = "0x183003490")]
		private void OnValueChanged(int newValue)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x656600", Offset = "0x654C00", VA = "0x180656600")]
		public DropdownEventManager()
		{
		}

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SonsDropdown _target;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _invert;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _wrapAround;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Selectable _rightSelectable;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<LinkToInput> _rightLinks;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Selectable _leftSelectable;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<LinkToInput> _leftLinks;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x50")]
		private bool _wasSetToNonInteractable;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x51")]
		private bool _isSelected;
	}
}
