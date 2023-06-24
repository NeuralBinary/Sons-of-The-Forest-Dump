using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x020006A9 RID: 1705
	[Token(Token = "0x20006A9")]
	[Serializable]
	public class ReparentObjectPair
	{
		// Token: 0x06002D20 RID: 11552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D20")]
		[Address(RVA = "0x3430BB0", Offset = "0x342F1B0", VA = "0x183430BB0")]
		private void Collect()
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x3430D10", Offset = "0x342F310", VA = "0x183430D10")]
		public void Apply()
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x3431120", Offset = "0x342F720", VA = "0x183431120")]
		public void Revert()
		{
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x3431230", Offset = "0x342F830", VA = "0x183431230")]
		public void OnValidate()
		{
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ReparentObjectPair()
		{
		}

		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _disableChildWhenNotParented;

		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _child;

		// Token: 0x0400278E RID: 10126
		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x28")]
		private Transform _originalParent;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x30")]
		private bool _performed;
	}
}
