using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	public class TestB : TestSimpleState
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BD")]
		public override string Name
		{
			[Token(Token = "0x6002325")]
			[Address(RVA = "0x334A6E0", Offset = "0x3348CE0", VA = "0x18334A6E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x334A710", Offset = "0x3348D10", VA = "0x18334A710", Slot = "6")]
		public override Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x334A730", Offset = "0x3348D30", VA = "0x18334A730")]
		public TestB(GameObject gameObject)
		{
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x334A940", Offset = "0x3348F40", VA = "0x18334A940")]
		private bool CheckForAExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x334AA80", Offset = "0x3349080", VA = "0x18334AA80")]
		private bool CheckForCExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x334A530", Offset = "0x3348B30", VA = "0x18334A530")]
		private bool CheckForA()
		{
			return default(bool);
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x334A530", Offset = "0x3348B30", VA = "0x18334A530")]
		private bool CheckForC()
		{
			return default(bool);
		}

		// Token: 0x04001FF0 RID: 8176
		[Token(Token = "0x4001FF0")]
		[FieldOffset(Offset = "0x58")]
		private readonly float _randomLifetime;
	}
}
