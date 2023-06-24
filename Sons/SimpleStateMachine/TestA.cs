using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	public class TestA : TestSimpleState
	{
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BC")]
		public override string Name
		{
			[Token(Token = "0x6002319")]
			[Address(RVA = "0x334A050", Offset = "0x3348650", VA = "0x18334A050", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x334A080", Offset = "0x3348680", VA = "0x18334A080", Slot = "6")]
		public override Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x334A0A0", Offset = "0x33486A0", VA = "0x18334A0A0")]
		public TestA(GameObject gameObject)
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x334A2B0", Offset = "0x33488B0", VA = "0x18334A2B0")]
		private bool CheckForBExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x334A3F0", Offset = "0x33489F0", VA = "0x18334A3F0")]
		private bool CheckForCExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x334A530", Offset = "0x3348B30", VA = "0x18334A530")]
		private bool CheckForB()
		{
			return default(bool);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x334A530", Offset = "0x3348B30", VA = "0x18334A530")]
		private bool CheckForC()
		{
			return default(bool);
		}

		// Token: 0x04001FEE RID: 8174
		[Token(Token = "0x4001FEE")]
		[FieldOffset(Offset = "0x58")]
		private readonly float _randomLifetime;
	}
}
