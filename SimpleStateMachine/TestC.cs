using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000527 RID: 1319
	[Token(Token = "0x2000527")]
	public class TestC : TestSimpleState
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AA")]
		public override string Name
		{
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x2D6E6A0", Offset = "0x2D6D6A0", VA = "0x182D6E6A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x2D6E3C0", Offset = "0x2D6D3C0", VA = "0x182D6E3C0", Slot = "6")]
		public override Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002246")]
		[Address(RVA = "0x2D6E4C0", Offset = "0x2D6D4C0", VA = "0x182D6E4C0")]
		public TestC(GameObject gameObject)
		{
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x2D6E260", Offset = "0x2D6D260", VA = "0x182D6E260")]
		private bool CheckForAExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x2D6E310", Offset = "0x2D6D310", VA = "0x182D6E310")]
		private bool CheckForBExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x2D6DA40", Offset = "0x2D6CA40", VA = "0x182D6DA40")]
		private bool CheckForA()
		{
			return default(bool);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x600224A")]
		[Address(RVA = "0x2D6DA40", Offset = "0x2D6CA40", VA = "0x182D6DA40")]
		private bool CheckForB()
		{
			return default(bool);
		}

		// Token: 0x04001F3E RID: 7998
		[Token(Token = "0x4001F3E")]
		[FieldOffset(Offset = "0x58")]
		private float _randomLifetime;
	}
}
