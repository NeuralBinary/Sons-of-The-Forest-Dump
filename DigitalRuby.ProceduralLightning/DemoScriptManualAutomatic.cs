using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class DemoScriptManualAutomatic : MonoBehaviour
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA2DB90", Offset = "0xA2C190", VA = "0x180A2DB90")]
		private void Update()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA2DE80", Offset = "0xA2C480", VA = "0x180A2DE80")]
		public void AutomaticToggled()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA2DEF0", Offset = "0xA2C4F0", VA = "0x180A2DEF0")]
		public void ManualTriggerClicked()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DemoScriptManualAutomatic()
		{
		}

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject LightningPrefab;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x28")]
		public Toggle AutomaticToggle;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x30")]
		public Transform a;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		public Transform b;
	}
}
