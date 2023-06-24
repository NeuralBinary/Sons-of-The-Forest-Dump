using System;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Sons/FpsUtility/FpsLimiter")]
	public class FpsLimiter : SingletonBehaviour<FpsLimiter>
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2FE31E0", Offset = "0x2FE17E0", VA = "0x182FE31E0")]
		public static void SetUnlimitedGlobalOverride(bool value)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2FE3240", Offset = "0x2FE1840", VA = "0x182FE3240")]
		private void OnEnable()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2FE3460", Offset = "0x2FE1A60", VA = "0x182FE3460")]
		private void OnSceneUnloaded(Scene arg0)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2FE34A0", Offset = "0x2FE1AA0", VA = "0x182FE34A0")]
		public static void SetIsInMenu(bool value)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2FE35A0", Offset = "0x2FE1BA0", VA = "0x182FE35A0")]
		public static void ClearIsInMenuRefCounter()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2FE3600", Offset = "0x2FE1C00", VA = "0x182FE3600")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2FE36A0", Offset = "0x2FE1CA0", VA = "0x182FE36A0")]
		private static void RefreshMainSceneLoaded()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2FE3850", Offset = "0x2FE1E50", VA = "0x182FE3850")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2FE39F0", Offset = "0x2FE1FF0", VA = "0x182FE39F0")]
		public static void LockTargetFps(int targetFps)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2FE3A50", Offset = "0x2FE2050", VA = "0x182FE3A50")]
		public static void UnlockTargetFps()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2FE3AB0", Offset = "0x2FE20B0", VA = "0x182FE3AB0")]
		private void UpdateTargetFpsValuesFromSettings(float value)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2FE3AC0", Offset = "0x2FE20C0", VA = "0x182FE3AC0")]
		private int GetCurrentFpsLimit()
		{
			return 0;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x1700000D")]
		public bool IsInMenu
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2FE3B50", Offset = "0x2FE2150", VA = "0x182FE3B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2FE3BD0", Offset = "0x2FE21D0", VA = "0x182FE3BD0")]
		private void Update()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2FE3D90", Offset = "0x2FE2390", VA = "0x182FE3D90")]
		private void FpsLimited(int limitedFps)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2FE3DE0", Offset = "0x2FE23E0", VA = "0x182FE3DE0")]
		private void FpsDefault()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2FE3E30", Offset = "0x2FE2430", VA = "0x182FE3E30")]
		private void FpsUnlimited()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2FE3E80", Offset = "0x2FE2480", VA = "0x182FE3E80")]
		public FpsLimiter()
		{
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _menuFpsMax;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x2C")]
		private int _limitedFps;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		private int _defaultFps;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		private static bool _unlimitedGlobalOverride;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x1")]
		private static bool _mainSceneLoaded;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x34")]
		private bool _wasInitialized;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x4")]
		private static int _isInMenuRefCounter;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		private static int _lockedTargetFps;
	}
}
