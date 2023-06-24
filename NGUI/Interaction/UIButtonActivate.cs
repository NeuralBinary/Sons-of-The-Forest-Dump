using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	[AddComponentMenu("NGUI/Interaction/Button Activate")]
	public class UIButtonActivate : MonoBehaviour
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x26AB320", Offset = "0x26A9920", VA = "0x1826AB320")]
		private void OnClick()
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB4160", VA = "0x180AB5B60")]
		public UIButtonActivate()
		{
		}

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x20")]
		public GameObject target;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x28")]
		public bool state;
	}
}
