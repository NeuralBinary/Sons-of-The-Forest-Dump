using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class DigMergeTester : MonoBehaviour
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2FAAF60", Offset = "0x2FA9560", VA = "0x182FAAF60")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2FAB8F0", Offset = "0x2FA9EF0", VA = "0x182FAB8F0")]
		public DigMergeTester()
		{
		}

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x20")]
		public List<Transform> _nodes;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x28")]
		public float Threshold;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x2C")]
		public bool _debugMerged;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x30")]
		public string _optimized;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x38")]
		public float _secondaryMergeThreshold;
	}
}
