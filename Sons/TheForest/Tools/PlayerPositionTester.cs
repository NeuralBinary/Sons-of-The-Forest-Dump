using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace TheForest.Tools
{
	// Token: 0x02000417 RID: 1047
	[Token(Token = "0x2000417")]
	public class PlayerPositionTester : MonoBehaviour
	{
		// Token: 0x06001BAB RID: 7083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x32BB2F0", Offset = "0x32B98F0", VA = "0x1832BB2F0")]
		public void DoPositionningTest()
		{
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x32BB360", Offset = "0x32B9960", VA = "0x1832BB360")]
		private void ProximityTest()
		{
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x32BB5E0", Offset = "0x32B9BE0", VA = "0x1832BB5E0")]
		private void InFrontTest()
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x32BB620", Offset = "0x32B9C20", VA = "0x1832BB620")]
		private void BehindTest()
		{
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x32BB660", Offset = "0x32B9C60", VA = "0x1832BB660")]
		private float Dot()
		{
			return 0f;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x32BB890", Offset = "0x32B9E90", VA = "0x1832BB890")]
		public PlayerPositionTester()
		{
		}

		// Token: 0x04001AC8 RID: 6856
		[Token(Token = "0x4001AC8")]
		[FieldOffset(Offset = "0x20")]
		public PlayerPositionTester.Tests _test;

		// Token: 0x04001AC9 RID: 6857
		[Token(Token = "0x4001AC9")]
		[FieldOffset(Offset = "0x24")]
		public float _proximityRange;

		// Token: 0x04001ACA RID: 6858
		[Token(Token = "0x4001ACA")]
		[FieldOffset(Offset = "0x28")]
		public Transform _playerTrOverride;

		// Token: 0x04001ACB RID: 6859
		[Token(Token = "0x4001ACB")]
		[FieldOffset(Offset = "0x30")]
		public Transform _testTarget;

		// Token: 0x04001ACC RID: 6860
		[Token(Token = "0x4001ACC")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent _callback;

		// Token: 0x02000418 RID: 1048
		[Token(Token = "0x2000418")]
		public enum Tests
		{
			// Token: 0x04001ACE RID: 6862
			[Token(Token = "0x4001ACE")]
			Proximity,
			// Token: 0x04001ACF RID: 6863
			[Token(Token = "0x4001ACF")]
			InFront,
			// Token: 0x04001AD0 RID: 6864
			[Token(Token = "0x4001AD0")]
			Behind
		}
	}
}
