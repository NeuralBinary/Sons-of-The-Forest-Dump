using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Tests
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Serializable]
	public class ButtonTest : TestAction
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x314A3B0", Offset = "0x31489B0", VA = "0x18314A3B0", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ButtonTest()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _target;
	}
}
