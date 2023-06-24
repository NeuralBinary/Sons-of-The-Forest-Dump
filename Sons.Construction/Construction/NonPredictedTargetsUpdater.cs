using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public class NonPredictedTargetsUpdater : IIdleStateUpdateReceiver
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x170001C1")]
		private bool HighPriority
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00004544 File Offset: 0x00002744
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C2")]
		private static bool ShouldPerformPhysicsLookup
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x2E1EA30", Offset = "0x2E1D030", VA = "0x182E1EA30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x2E1EA70", Offset = "0x2E1D070", VA = "0x182E1EA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C3")]
		private ConstructionManager.NonPredictedTargetsLookup NonPredictedTargetsLookup
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2E1EAB0", Offset = "0x2E1D0B0", VA = "0x182E1EAB0")]
		public NonPredictedTargetsUpdater(ConstructionManager.NonPredictedTargetsLookup nonPredictedTargetsLookup, bool highPriority)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2E1EB10", Offset = "0x2E1D110", VA = "0x182E1EB10", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}
	}
}
