using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public abstract class IK : SolverManager
	{
		// Token: 0x06000221 RID: 545
		[Token(Token = "0x6000221")]
		public abstract IKSolver GetIKSolver();

		// Token: 0x06000222 RID: 546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x29110E0", Offset = "0x290F6E0", VA = "0x1829110E0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2911180", Offset = "0x290F780", VA = "0x182911180", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2911230", Offset = "0x290F830", VA = "0x182911230", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x06000225 RID: 549
		[Token(Token = "0x6000225")]
		protected abstract void OpenUserManual();

		// Token: 0x06000226 RID: 550
		[Token(Token = "0x6000226")]
		protected abstract void OpenScriptReference();

		// Token: 0x06000227 RID: 551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		protected IK()
		{
		}
	}
}
