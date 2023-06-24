using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class UiElementMono : MonoBehaviour
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x301BE80", Offset = "0x301A480", VA = "0x18301BE80")]
		private void OnEnable()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x301C020", Offset = "0x301A620", VA = "0x18301C020")]
		private void OnDisable()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public UiElement GetUiElement()
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetUiElement(UiElement eachItem)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UiElementMono()
		{
		}

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UiElement _uiElement;
	}
}
