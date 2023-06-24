using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	[AddComponentMenu("NGUI/Interaction/Button Activate N")]
	public class UIButtonActivateN : MonoBehaviour
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x26AB450", Offset = "0x26A9A50", VA = "0x1826AB450")]
		private void OnClick()
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIButtonActivateN()
		{
		}

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x20")]
		public UIButtonActivateN.Target[] _targets;

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x200009D")]
		[Serializable]
		public class Target
		{
			// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1487590", Offset = "0x1485B90", VA = "0x181487590")]
			public Target()
			{
			}

			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			[FieldOffset(Offset = "0x18")]
			public bool state;
		}
	}
}
