using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace NWH.Common.Demo
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class DemoWelcomeMessage : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x26EA930", Offset = "0x26E8F30", VA = "0x1826EA930")]
		private void Start()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x26EAA40", Offset = "0x26E9040", VA = "0x1826EAA40")]
		private void Close()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DemoWelcomeMessage()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public GameObject welcomeMessageGO;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		public Button closeButton;
	}
}
