using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Multiplayer
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class MultiplayerServerNameHelper : MonoBehaviour
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x30EC000", Offset = "0x30EA600", VA = "0x1830EC000")]
		private void OnEnable()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x30EC0F0", Offset = "0x30EA6F0", VA = "0x1830EC0F0")]
		private void ApplyServerNameToGui(string serverName)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x30EC120", Offset = "0x30EA720", VA = "0x1830EC120")]
		private void EnforceServerNameCharacterLimit()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x30EC1C0", Offset = "0x30EA7C0", VA = "0x1830EC1C0")]
		public void OnInputValueChanged(string name)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x30EC1D0", Offset = "0x30EA7D0", VA = "0x1830EC1D0")]
		public void OnInputEndEdit(string name)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x30EC1E0", Offset = "0x30EA7E0", VA = "0x1830EC1E0")]
		private void SetServerName(string newServerName, bool trim)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x30EC380", Offset = "0x30EA980", VA = "0x1830EC380")]
		private bool ValidateServerName(string sanitizedName)
		{
			return default(bool);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x30EC3A0", Offset = "0x30EA9A0", VA = "0x1830EC3A0")]
		private void DisableContinueButton()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x30EC3D0", Offset = "0x30EA9D0", VA = "0x1830EC3D0")]
		private void EnableContinueButton()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerServerNameHelper()
		{
		}

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_InputField _serverNameInput;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _continueButton;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x30")]
		private string _inputName;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x38")]
		private string _sanitizedName;
	}
}
