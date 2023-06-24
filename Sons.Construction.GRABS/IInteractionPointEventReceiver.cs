using System;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public interface IInteractionPointEventReceiver
	{
		// Token: 0x0600019A RID: 410
		[Token(Token = "0x600019A")]
		void OnGrabbed(IAimRayProvider aimRayProvider);

		// Token: 0x0600019B RID: 411
		[Token(Token = "0x600019B")]
		void OnUnGrabbed(IAimRayProvider aimRayProvider);

		// Token: 0x0600019C RID: 412
		[Token(Token = "0x600019C")]
		void StartedOperation(IAimRayProvider aimRayProvider);

		// Token: 0x0600019D RID: 413
		[Token(Token = "0x600019D")]
		void FinishedOperation(IAimRayProvider aimRayProvider);
	}
}
