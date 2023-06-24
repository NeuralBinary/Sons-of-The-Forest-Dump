using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class HelicopterOceanCrashCutscene : CrashCutsceneBase
	{
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x170005B8")]
		public override int PlayerBadGuyIntroHash
		{
			[Token(Token = "0x6002B76")]
			[Address(RVA = "0x340F5F0", Offset = "0x340DBF0", VA = "0x18340F5F0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x170005B9")]
		public override int PlayerProxyCrashTagHash
		{
			[Token(Token = "0x6002B77")]
			[Address(RVA = "0x340F650", Offset = "0x340DC50", VA = "0x18340F650", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x170005BA")]
		public override int StandUpFromCrashIndex
		{
			[Token(Token = "0x6002B78")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x340F6B0", Offset = "0x340DCB0", VA = "0x18340F6B0")]
		public void ShowDoorTrigger()
		{
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x340F780", Offset = "0x340DD80", VA = "0x18340F780")]
		private void RequestFadeSunLensFlare()
		{
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x340FA40", Offset = "0x340E040", VA = "0x18340FA40")]
		public void BeginKickDoorSequence()
		{
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x340FCF0", Offset = "0x340E2F0", VA = "0x18340FCF0")]
		private void resetParams()
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x340FF00", Offset = "0x340E500", VA = "0x18340FF00")]
		private void EnableDoorTrigger()
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x34100A0", Offset = "0x340E6A0", VA = "0x1834100A0", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x3402A90", Offset = "0x3401090", VA = "0x183402A90")]
		public HelicopterOceanCrashCutscene()
		{
		}

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Animator _helicopterAnimator;

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private bool _waitForPlayerInput;

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _doorTriggerObject;

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[FormerlySerializedAs("_enableBashDoorTrigerDelay")]
		private float _enableBashDoorTriggerDelay;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		private int _bashDoorAttempts;

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x1B0")]
		private int _bashDoorCounter;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x1B8")]
		private CutsceneTrigger _doorTriggerComponent;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x1C0")]
		private LensFlareFader _lensFlareFader;
	}
}
