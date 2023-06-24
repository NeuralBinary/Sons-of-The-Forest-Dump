using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class ShowInput : MonoBehaviour
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000010")]
		private List<string> GetActionsMenuDropdown
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x30181B0", Offset = "0x30167B0", VA = "0x1830181B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x30181F0", Offset = "0x30167F0", VA = "0x1830181F0")]
		private void Update()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x30182F0", Offset = "0x30168F0", VA = "0x1830182F0")]
		public ShowInput()
		{
		}

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _indicator;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _buttonId;
	}
}
