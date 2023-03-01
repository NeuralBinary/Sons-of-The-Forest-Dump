using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x02000770 RID: 1904
	[Token(Token = "0x2000770")]
	public class HelicopterOceanCrashCutscene : CrashCutsceneBase
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x1700064B")]
		public override int PlayerBadGuyIntroHash
		{
			[Token(Token = "0x60031FF")]
			[Address(RVA = "0x2E46250", Offset = "0x2E45250", VA = "0x182E46250", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[Token(Token = "0x1700064C")]
		public override int PlayerProxyCrashTagHash
		{
			[Token(Token = "0x6003200")]
			[Address(RVA = "0x2E462B0", Offset = "0x2E452B0", VA = "0x182E462B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[Token(Token = "0x1700064D")]
		public override int StandUpFromCrashIndex
		{
			[Token(Token = "0x6003201")]
			[Address(RVA = "0xC91EB0", Offset = "0xC90EB0", VA = "0x180C91EB0", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x2E46130", Offset = "0x2E45130", VA = "0x182E46130")]
		public void ShowDoorTrigger()
		{
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x2E46040", Offset = "0x2E45040", VA = "0x182E46040")]
		private void RequestFadeSunLensFlare()
		{
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x2E45D60", Offset = "0x2E44D60", VA = "0x182E45D60")]
		public void BeginKickDoorSequence()
		{
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x2E46310", Offset = "0x2E45310", VA = "0x182E46310")]
		private void resetParams()
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x2E45F80", Offset = "0x2E44F80", VA = "0x182E45F80")]
		private void EnableDoorTrigger()
		{
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x2E45EF0", Offset = "0x2E44EF0", VA = "0x182E45EF0", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x2E3EBA0", Offset = "0x2E3DBA0", VA = "0x182E3EBA0")]
		public HelicopterOceanCrashCutscene()
		{
		}

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Animator _helicopterAnimator;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private bool _waitForPlayerInput;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _doorTriggerObject;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x1A8")]
		[FormerlySerializedAs("_enableBashDoorTrigerDelay")]
		[SerializeField]
		private float _enableBashDoorTriggerDelay;

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		private int _bashDoorAttempts;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x1B0")]
		private int _bashDoorCounter;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x1B8")]
		private CutsceneTrigger _doorTriggerComponent;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x1C0")]
		private LensFlareFader _lensFlareFader;
	}
}
