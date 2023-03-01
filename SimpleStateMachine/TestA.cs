using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public class TestA : TestSimpleState
	{
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A8")]
		public override string Name
		{
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x2D6DDD0", Offset = "0x2D6CDD0", VA = "0x182D6DDD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x2D6DB00", Offset = "0x2D6CB00", VA = "0x182D6DB00", Slot = "6")]
		public override Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x2D6DC00", Offset = "0x2D6CC00", VA = "0x182D6DC00")]
		public TestA(GameObject gameObject)
		{
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x2D6D990", Offset = "0x2D6C990", VA = "0x182D6D990")]
		private bool CheckForBExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x2D6DA50", Offset = "0x2D6CA50", VA = "0x182D6DA50")]
		private bool CheckForCExplicit(out Func<SimpleState> nextstateconstructor)
		{
			return default(bool);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x2D6DA40", Offset = "0x2D6CA40", VA = "0x182D6DA40")]
		private bool CheckForB()
		{
			return default(bool);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x2D6DA40", Offset = "0x2D6CA40", VA = "0x182D6DA40")]
		private bool CheckForC()
		{
			return default(bool);
		}

		// Token: 0x04001F3A RID: 7994
		[Token(Token = "0x4001F3A")]
		[FieldOffset(Offset = "0x58")]
		private readonly float _randomLifetime;
	}
}
