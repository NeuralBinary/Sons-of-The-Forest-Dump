using System;
using Il2CppDummyDll;
using Sons.UiElements;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class SonsDropdownGamepadHelper : MonoBehaviour
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x301A0C0", Offset = "0x30186C0", VA = "0x18301A0C0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x301A1B0", Offset = "0x30187B0", VA = "0x18301A1B0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x301A310", Offset = "0x3018910", VA = "0x18301A310")]
		private void OnClickRight()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x301A400", Offset = "0x3018A00", VA = "0x18301A400")]
		private void OnClickLeft()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x301A4F0", Offset = "0x3018AF0", VA = "0x18301A4F0")]
		private void Update()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x301A930", Offset = "0x3018F30", VA = "0x18301A930")]
		public SonsDropdownGamepadHelper()
		{
		}

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		private DropdownEventManager _source;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SonsDropdown _dropdown;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x30")]
		[Header("Gui Links")]
		[SerializeField]
		private Button _leftArrow;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _rightArrow;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x40")]
		private bool _init;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x41")]
		private bool _isActive;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x44")]
		private int _dropdownValue;
	}
}
