using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x0200074C RID: 1868
	[Token(Token = "0x200074C")]
	public class CameraShakeController : MonoBehaviour
	{
		// Token: 0x060030A7 RID: 12455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x2E3C6B0", Offset = "0x2E3B6B0", VA = "0x182E3C6B0")]
		public void TriggerShakeSmall()
		{
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x2E3C620", Offset = "0x2E3B620", VA = "0x182E3C620")]
		public void TriggerShakeMedium()
		{
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x2E3C520", Offset = "0x2E3B520", VA = "0x182E3C520")]
		public void TriggerShakeLarge()
		{
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x2E3C740", Offset = "0x2E3B740", VA = "0x182E3C740")]
		public void TriggerShakeVeryLarge()
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x2E3C5E0", Offset = "0x2E3B5E0", VA = "0x182E3C5E0")]
		public void TriggerShakeLoopingStart()
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x2E3C5B0", Offset = "0x2E3B5B0", VA = "0x182E3C5B0")]
		public void TriggerShakeLoopingEnd()
		{
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x2CCDAE0", Offset = "0x2CCCAE0", VA = "0x182CCDAE0")]
		private static bool IsCameraShakeAllowed()
		{
			return default(bool);
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x2E3C7D0", Offset = "0x2E3B7D0", VA = "0x182E3C7D0")]
		public CameraShakeController()
		{
		}

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animation _animation;

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _animationShakeSmallName;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _animationShakeMediumName;

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _animationShakeLargeName;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _animationShakeVeryLargeName;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _animationShakeLoopingName;
	}
}
