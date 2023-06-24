using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	public class TestC : TestSimpleState
	{
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BE")]
		public override string Name
		{
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x334AD60", Offset = "0x3349360", VA = "0x18334AD60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x334AD90", Offset = "0x3349390", VA = "0x18334AD90", Slot = "6")]
		public override Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x334ADB0", Offset = "0x33493B0", VA = "0x18334ADB0")]
		public TestC(GameObject gameObject)
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x334AFD0", Offset = "0x33495D0", VA = "0x18334AFD0")]
		private bool CheckForAExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x334B110", Offset = "0x3349710", VA = "0x18334B110")]
		private bool CheckForBExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x334A530", Offset = "0x3348B30", VA = "0x18334A530")]
		private bool CheckForA()
		{
			return default(bool);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x334A530", Offset = "0x3348B30", VA = "0x18334A530")]
		private bool CheckForB()
		{
			return default(bool);
		}

		// Token: 0x04001FF2 RID: 8178
		[Token(Token = "0x4001FF2")]
		[FieldOffset(Offset = "0x58")]
		private float _randomLifetime;
	}
}
