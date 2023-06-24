using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class MultiplayerServerIsPrivateHelper : MonoBehaviour
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x30EBDE0", Offset = "0x30EA3E0", VA = "0x1830EBDE0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x30EBF10", Offset = "0x30EA510", VA = "0x1830EBF10")]
		public void SetServerIsPrivate(int isPrivate)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerServerIsPrivateHelper()
		{
		}

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Dropdown _dropdown;
	}
}
