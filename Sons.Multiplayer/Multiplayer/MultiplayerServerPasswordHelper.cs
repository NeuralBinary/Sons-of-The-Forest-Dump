using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class MultiplayerServerPasswordHelper : MonoBehaviour
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x30EC400", Offset = "0x30EAA00", VA = "0x1830EC400")]
		private void OnEnable()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x30EC0F0", Offset = "0x30EA6F0", VA = "0x1830EC0F0")]
		private void ApplyServerPasswordToGui(string serverName)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x30EC410", Offset = "0x30EAA10", VA = "0x1830EC410")]
		public void SetServerPassword(string serverPassword)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x30EC640", Offset = "0x30EAC40", VA = "0x1830EC640")]
		private void ClearServerPassword()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerServerPasswordHelper()
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_InputField _serverPasswordInput;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x28")]
		private string _inputPassword;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x30")]
		private string _generatedHash;
	}
}
