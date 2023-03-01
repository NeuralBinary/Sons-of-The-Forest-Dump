using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR;

namespace TheForest.Utils
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	public class ForestVRHapticControl : MonoBehaviour
	{
		// Token: 0x06001914 RID: 6420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x2CC5270", Offset = "0x2CC4270", VA = "0x182CC5270")]
		private void Awake()
		{
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x2CC5490", Offset = "0x2CC4490", VA = "0x182CC5490")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		private static bool IsVRHapticEnabled()
		{
			return default(bool);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x2CC56D0", Offset = "0x2CC46D0", VA = "0x182CC56D0")]
		private IEnumerator PlayPulseCurve(SteamVR_Input_Sources vrHandType, AnimationCurve curve)
		{
			return null;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x2CC5770", Offset = "0x2CC4770", VA = "0x182CC5770")]
		private void PlayPulse(float durationMicroSec, SteamVR_Input_Sources handType)
		{
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x2CC5370", Offset = "0x2CC4370", VA = "0x182CC5370")]
		private void CreateWorker(SteamVR_Input_Sources handType, AnimationCurve curve)
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x2CC5830", Offset = "0x2CC4830", VA = "0x182CC5830")]
		public static void SetItemHoverEnabled(bool value)
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x2CC57D0", Offset = "0x2CC47D0", VA = "0x182CC57D0")]
		public static void SetHitRumbledEnabled(bool value)
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x2CC55E0", Offset = "0x2CC45E0", VA = "0x182CC55E0")]
		public static void PlayItemHover(SteamVR_Input_Sources handType = 2)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x2CC5410", Offset = "0x2CC4410", VA = "0x182CC5410")]
		private static bool IsHitRumbleEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x2CC5450", Offset = "0x2CC4450", VA = "0x182CC5450")]
		private static bool IsItemHoverEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x2CC5570", Offset = "0x2CC4570", VA = "0x182CC5570")]
		public static void PlayHitRumble(SteamVR_Input_Sources handType = 2)
		{
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x2CC5690", Offset = "0x2CC4690", VA = "0x182CC5690")]
		public static void PlayMenuForward(SteamVR_Input_Sources handType = 2)
		{
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x2CC5650", Offset = "0x2CC4650", VA = "0x182CC5650")]
		public static void PlayMenuBack(SteamVR_Input_Sources handType = 2)
		{
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x2CC58F0", Offset = "0x2CC48F0", VA = "0x182CC58F0")]
		public ForestVRHapticControl()
		{
		}

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve _hitRumble;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _menuForward;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _menuBack;

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _itemHover;

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _itemHoverMinTime;

		// Token: 0x040018B3 RID: 6323
		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x0")]
		private static float _itemHoverLastTime;

		// Token: 0x040018B4 RID: 6324
		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0x4")]
		private static bool _itemHoverEnabled;

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x5")]
		private static bool _hitRumbleEnabled;

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x8")]
		private static ForestVRHapticControl _instance;

		// Token: 0x040018B7 RID: 6327
		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x48")]
		public SteamVR_Action_Vibration hapticAction;
	}
}
