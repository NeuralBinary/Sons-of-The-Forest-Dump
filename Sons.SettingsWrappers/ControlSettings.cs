using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[AddComponentMenu("Sons/Settings/ControlSettings")]
	public class ControlSettings : MonoBehaviour
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3138AF0", Offset = "0x31370F0", VA = "0x183138AF0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3138EA0", Offset = "0x31374A0", VA = "0x183138EA0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3138F40", Offset = "0x3137540", VA = "0x183138F40")]
		private void MouseXSensitivityChanged(float value)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3139050", Offset = "0x3137650", VA = "0x183139050")]
		private void MouseYSensitivityChanged(float value)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3139160", Offset = "0x3137760", VA = "0x183139160")]
		private void GamePadXSensitivityChanged(float value)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3139270", Offset = "0x3137870", VA = "0x183139270")]
		private void GamePadYSensitivityChanged(float value)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3139380", Offset = "0x3137980", VA = "0x183139380")]
		private void GamePadDeadzoneChanged(float value)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3139430", Offset = "0x3137A30", VA = "0x183139430")]
		private void RumbleChanged(bool value)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x31394C0", Offset = "0x3137AC0", VA = "0x1831394C0")]
		private void InvertYChanged(bool value)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3139550", Offset = "0x3137B50", VA = "0x183139550")]
		private void SprintToggleChanged(bool value)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x31395E0", Offset = "0x3137BE0", VA = "0x1831395E0")]
		private void CrouchToggleChanged(bool value)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3139670", Offset = "0x3137C70", VA = "0x183139670")]
		public static void SetInvertLookY(bool value)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x31396D0", Offset = "0x3137CD0", VA = "0x1831396D0")]
		public static void SetMouseXSensitivity(float value)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3139740", Offset = "0x3137D40", VA = "0x183139740")]
		public static void SetMouseYSensitivity(float value)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x31397B0", Offset = "0x3137DB0", VA = "0x1831397B0")]
		public static void SetGamePadXSensitivity(float value)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3139820", Offset = "0x3137E20", VA = "0x183139820")]
		public static void SetGamePadYSensitivity(float value)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3139890", Offset = "0x3137E90", VA = "0x183139890")]
		public static void SetGamePadDeadzone(float value)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3139900", Offset = "0x3137F00", VA = "0x183139900")]
		public static void SetCrouchToggle(bool value)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3139960", Offset = "0x3137F60", VA = "0x183139960")]
		public static void SetSprintToggle(bool value)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x31399C0", Offset = "0x3137FC0", VA = "0x1831399C0")]
		public ControlSettings()
		{
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		public const bool DefaultInvertYValue = false;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		public const bool CrouchToggleSettingDefault = false;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		public const bool DefaultSprintToggleValue = false;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		public const bool DefaultRumbleValue = true;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		public const float DefaultMouseXSensitivity = 0.45000002f;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		public const float DefaultMouseYSensitivity = 0.45000002f;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		public const float DefaultGamePadXSensitivity = 0.45000002f;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		public const float DefaultGamePadYSensitivity = 0.45000002f;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		public const float DefaultGamePadDeadzone = 0.2f;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		public const string InvertYSettingKey = "Control.InvertY";

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		public const string MouseXSensitivitySettingKey = "Control.MouseXSensitivity";

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		public const string MouseYSensitivitySettingKey = "Control.MouseYSensitivity";

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		public const string GamePadXSensitivitySettingKey = "Control.GamePadXSensitivity";

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		public const string GamePadYSensitivitySettingKey = "Control.GamePadYSensitivity";

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		public const string GamePadDeadzoneSettingKey = "Control.GamePadDeadzone";

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		public const string CrouchToggleSettingKey = "Control.CrouchToggle";

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		public const string SprintToggleSettingKey = "Control.SprintToggle";

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		public const string RumbleSettingKey = "Control.Rumble";

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		private const float SensitivityRangeMin = 0.05f;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		private const float SensitivityRangeMax = 1.05f;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		private const float DefaultSensitivitySetting = 0.5f;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		private const float DefaultSensitivityLerped = 0.45000002f;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<object> _registeredActionPairs;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 MouseXSensitivityMinMax;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 MouseYSensitivityMinMax;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2 GamePadXSensitivityMinMax;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector2 GamePadYSensitivityMinMax;
	}
}
