using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public class ObiSphericalForceZone : ObiExternalForce
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x27F54C0", Offset = "0x27F3AC0", VA = "0x1827F54C0", Slot = "4")]
		public override void ApplyForcesToActor(ObiActor actor)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x27F5CE0", Offset = "0x27F42E0", VA = "0x1827F5CE0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x27F61E0", Offset = "0x27F47E0", VA = "0x1827F61E0")]
		public ObiSphericalForceZone()
		{
		}

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x38")]
		public float radius;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x3C")]
		public bool radial;
	}
}
