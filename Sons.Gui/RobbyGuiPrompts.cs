using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class RobbyGuiPrompts : MonoBehaviour
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x300D990", Offset = "0x300BF90", VA = "0x18300D990")]
		public void ShowConfirm(bool show)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x300DA00", Offset = "0x300C000", VA = "0x18300DA00")]
		public void ShowDown(bool show)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x300DA70", Offset = "0x300C070", VA = "0x18300DA70")]
		public void ShowNext(bool show)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x300DAE0", Offset = "0x300C0E0", VA = "0x18300DAE0")]
		public void ShowBack(bool show)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x300DB50", Offset = "0x300C150", VA = "0x18300DB50")]
		public void ShowCancel(bool show)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RobbyGuiPrompts()
		{
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _backButton;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _confirmButton;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _nextButton;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cancelButton;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _downButton;
	}
}
