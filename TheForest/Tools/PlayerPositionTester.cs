using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Tools
{
	// Token: 0x02000425 RID: 1061
	[Token(Token = "0x2000425")]
	public class PlayerPositionTester : MonoBehaviour
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x2CE7F90", Offset = "0x2CE6F90", VA = "0x182CE7F90")]
		public void DoPositionningTest()
		{
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x2CE8340", Offset = "0x2CE7340", VA = "0x182CE8340")]
		private void ProximityTest()
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x2CE8300", Offset = "0x2CE7300", VA = "0x182CE8300")]
		private void InFrontTest()
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x2CE7F50", Offset = "0x2CE6F50", VA = "0x182CE7F50")]
		private void BehindTest()
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x2CE81A0", Offset = "0x2CE71A0", VA = "0x182CE81A0")]
		private float Dot()
		{
			return default(float);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x2CE8500", Offset = "0x2CE7500", VA = "0x182CE8500")]
		public PlayerPositionTester()
		{
		}

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[FieldOffset(Offset = "0x20")]
		public PlayerPositionTester.Tests _test;

		// Token: 0x04001AA5 RID: 6821
		[Token(Token = "0x4001AA5")]
		[FieldOffset(Offset = "0x24")]
		public float _proximityRange;

		// Token: 0x04001AA6 RID: 6822
		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x28")]
		public Transform _playerTrOverride;

		// Token: 0x04001AA7 RID: 6823
		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0x30")]
		public Transform _testTarget;

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent _callback;

		// Token: 0x02000426 RID: 1062
		[Token(Token = "0x2000426")]
		public enum Tests
		{
			// Token: 0x04001AAA RID: 6826
			[Token(Token = "0x4001AAA")]
			Proximity,
			// Token: 0x04001AAB RID: 6827
			[Token(Token = "0x4001AAB")]
			InFront,
			// Token: 0x04001AAC RID: 6828
			[Token(Token = "0x4001AAC")]
			Behind
		}
	}
}
