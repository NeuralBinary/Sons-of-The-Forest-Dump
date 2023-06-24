using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[Serializable]
	public class InteractWith : ActionTemplate
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2D1E3B0", Offset = "0x2D1C9B0", VA = "0x182D1E3B0", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2D1E3D0", Offset = "0x2D1C9D0", VA = "0x182D1E3D0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2D1E440", Offset = "0x2D1CA40", VA = "0x182D1E440", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2D1E560", Offset = "0x2D1CB60", VA = "0x182D1E560", Slot = "12")]
		internal override bool Update()
		{
			return default(bool);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2D1E740", Offset = "0x2D1CD40", VA = "0x182D1E740", Slot = "13")]
		internal override void DoEnd()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2D1E820", Offset = "0x2D1CE20", VA = "0x182D1E820", Slot = "14")]
		internal override void DoInterrupted()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2D1E900", Offset = "0x2D1CF00", VA = "0x182D1E900", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2D1E920", Offset = "0x2D1CF20", VA = "0x182D1E920")]
		private void CompletedCallback()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public InteractWith()
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x60")]
		private float _lastUpdated;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x64")]
		private bool _interactionCompleted;
	}
}
