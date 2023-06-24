using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR;

namespace TheForest.Utils
{
	// Token: 0x020003AF RID: 943
	[Token(Token = "0x20003AF")]
	public class ForestVRHapticControl : MonoBehaviour
	{
		// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x32928F0", Offset = "0x3290EF0", VA = "0x1832928F0")]
		private void Awake()
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x3292A80", Offset = "0x3291080", VA = "0x183292A80")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private static bool IsVRHapticEnabled()
		{
			return default(bool);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x3292C40", Offset = "0x3291240", VA = "0x183292C40")]
		private IEnumerator PlayPulseCurve(SteamVR_Input_Sources vrHandType, AnimationCurve curve)
		{
			return null;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x3292D50", Offset = "0x3291350", VA = "0x183292D50")]
		private void PlayPulse(float durationMicroSec, SteamVR_Input_Sources handType)
		{
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x3292DB0", Offset = "0x32913B0", VA = "0x183292DB0")]
		private void CreateWorker(SteamVR_Input_Sources handType, AnimationCurve curve)
		{
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x3292ED0", Offset = "0x32914D0", VA = "0x183292ED0")]
		public static void SetItemHoverEnabled(bool value)
		{
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x3292F30", Offset = "0x3291530", VA = "0x183292F30")]
		public static void SetHitRumbledEnabled(bool value)
		{
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x3292F90", Offset = "0x3291590", VA = "0x183292F90")]
		public static void PlayItemHover(SteamVR_Input_Sources handType = SteamVR_Input_Sources.RightHand)
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x3293000", Offset = "0x3291600", VA = "0x183293000")]
		private static bool IsHitRumbleEnabled()
		{
			return default(bool);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x3293040", Offset = "0x3291640", VA = "0x183293040")]
		private static bool IsItemHoverEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x3293080", Offset = "0x3291680", VA = "0x183293080")]
		public static void PlayHitRumble(SteamVR_Input_Sources handType = SteamVR_Input_Sources.RightHand)
		{
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x32930F0", Offset = "0x32916F0", VA = "0x1832930F0")]
		public static void PlayMenuForward(SteamVR_Input_Sources handType = SteamVR_Input_Sources.RightHand)
		{
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x3293130", Offset = "0x3291730", VA = "0x183293130")]
		public static void PlayMenuBack(SteamVR_Input_Sources handType = SteamVR_Input_Sources.RightHand)
		{
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x3293170", Offset = "0x3291770", VA = "0x183293170")]
		public ForestVRHapticControl()
		{
		}

		// Token: 0x040018CD RID: 6349
		[Token(Token = "0x40018CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve _hitRumble;

		// Token: 0x040018CE RID: 6350
		[Token(Token = "0x40018CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _menuForward;

		// Token: 0x040018CF RID: 6351
		[Token(Token = "0x40018CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _menuBack;

		// Token: 0x040018D0 RID: 6352
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _itemHover;

		// Token: 0x040018D1 RID: 6353
		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _itemHoverMinTime;

		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x0")]
		private static float _itemHoverLastTime;

		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x4")]
		private static bool _itemHoverEnabled;

		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x5")]
		private static bool _hitRumbleEnabled;

		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x8")]
		private static ForestVRHapticControl _instance;

		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x48")]
		public SteamVR_Action_Vibration hapticAction;
	}
}
