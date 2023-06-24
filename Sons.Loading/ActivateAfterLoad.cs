using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Loading
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class ActivateAfterLoad : SceneLoadingListener
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x30B2B90", Offset = "0x30B1190", VA = "0x1830B2B90")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA508B0", Offset = "0xA4EEB0", VA = "0x180A508B0", Slot = "9")]
		public override void ErrorFallback()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x30B2D80", Offset = "0x30B1380", VA = "0x1830B2D80", Slot = "10")]
		public override void Completed()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x6BC7C0", Offset = "0x6BADC0", VA = "0x1806BC7C0")]
		public ActivateAfterLoad()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _targets;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _disableOnAwake;
	}
}
