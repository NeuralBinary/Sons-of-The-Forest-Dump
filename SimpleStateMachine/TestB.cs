using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	public class TestB : TestSimpleState
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A9")]
		public override string Name
		{
			[Token(Token = "0x6002238")]
			[Address(RVA = "0x2D6E230", Offset = "0x2D6D230", VA = "0x182D6E230", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x6002239")]
		[Address(RVA = "0x2D6DF60", Offset = "0x2D6CF60", VA = "0x182D6DF60", Slot = "6")]
		public override Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x2D6E060", Offset = "0x2D6D060", VA = "0x182D6E060")]
		public TestB(GameObject gameObject)
		{
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x2D6DE00", Offset = "0x2D6CE00", VA = "0x182D6DE00")]
		private bool CheckForAExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x2D6DEB0", Offset = "0x2D6CEB0", VA = "0x182D6DEB0")]
		private bool CheckForCExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x2D6DA40", Offset = "0x2D6CA40", VA = "0x182D6DA40")]
		private bool CheckForA()
		{
			return default(bool);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x2D6DA40", Offset = "0x2D6CA40", VA = "0x182D6DA40")]
		private bool CheckForC()
		{
			return default(bool);
		}

		// Token: 0x04001F3C RID: 7996
		[Token(Token = "0x4001F3C")]
		[FieldOffset(Offset = "0x58")]
		private readonly float _randomLifetime;
	}
}
