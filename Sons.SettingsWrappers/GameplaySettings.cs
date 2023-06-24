using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[AddComponentMenu("Sons/Settings/GameplaySettings")]
	public class GameplaySettings : MonoBehaviour
	{
		// Token: 0x06000056 RID: 86 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x313BE20", Offset = "0x313A420", VA = "0x18313BE20")]
		public static string GetLanguageSettingDefault()
		{
			return null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x313BF50", Offset = "0x313A550", VA = "0x18313BF50")]
		public static List<string> GetLanguageSettingOptions()
		{
			return null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public static bool BigHeadModeActive
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x313C140", Offset = "0x313A740", VA = "0x18313C140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x313C180", Offset = "0x313A780", VA = "0x18313C180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public static bool PlayerActorsActive
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x313C1C0", Offset = "0x313A7C0", VA = "0x18313C1C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x313C200", Offset = "0x313A800", VA = "0x18313C200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x313C240", Offset = "0x313A840", VA = "0x18313C240")]
		private void OnEnable()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x313C7F0", Offset = "0x313ADF0", VA = "0x18313C7F0")]
		private static void BigHeadModeChanged(bool newValue)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x313C830", Offset = "0x313AE30", VA = "0x18313C830")]
		private static void PlayerActorsModeChanged(bool newValue)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x313C870", Offset = "0x313AE70", VA = "0x18313C870")]
		private void LanguageChanged(string newValue)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x313CA10", Offset = "0x313B010", VA = "0x18313CA10")]
		private void FovOffsetChanged(int newValue)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x313CA50", Offset = "0x313B050", VA = "0x18313CA50")]
		private void ShowAllGuiChanged(bool newValue)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x313CAA0", Offset = "0x313B0A0", VA = "0x18313CAA0")]
		private void HudGuiChanged(bool newValue)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x313CAF0", Offset = "0x313B0F0", VA = "0x18313CAF0")]
		private void MiniMapGuiChanged(bool newValue)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x313CB40", Offset = "0x313B140", VA = "0x18313CB40")]
		private void WorldUiChanged(bool newValue)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x313CB90", Offset = "0x313B190", VA = "0x18313CB90")]
		private void BuildingUiChanged(bool newValue)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x313CBE0", Offset = "0x313B1E0", VA = "0x18313CBE0")]
		private void TutorialsUiChanged(bool newValue)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x313CC30", Offset = "0x313B230", VA = "0x18313CC30")]
		private void ProjectileReticleUiChanged(bool newValue)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x313CC80", Offset = "0x313B280", VA = "0x18313CC80")]
		private void PlayerNameTagsUiChanged(bool newValue)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x313CCD0", Offset = "0x313B2D0", VA = "0x18313CCD0")]
		private void HudGuiScaleChanged(float newValue)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x313CE50", Offset = "0x313B450", VA = "0x18313CE50")]
		private void OnDisable()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x313CEF0", Offset = "0x313B4F0", VA = "0x18313CEF0")]
		public static void SetAllGuiChanged(bool value)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x313CF50", Offset = "0x313B550", VA = "0x18313CF50")]
		public static void SetMiniMapGuiChanged(bool value)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x313CFB0", Offset = "0x313B5B0", VA = "0x18313CFB0")]
		public static void SetHudGuiChanged(bool value)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x313D010", Offset = "0x313B610", VA = "0x18313D010")]
		public static void SetWorldUiChanged(bool value)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x313D070", Offset = "0x313B670", VA = "0x18313D070")]
		public static void SetBuildingGuiChanged(bool value)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x313D0D0", Offset = "0x313B6D0", VA = "0x18313D0D0")]
		public static void SetTutorialGuiChanged(bool value)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x313D130", Offset = "0x313B730", VA = "0x18313D130")]
		public GameplaySettings()
		{
		}

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		public const string LanguageSettingKey = "Gui.Language";

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		public const bool GuiSettingDefault = true;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		public const string GuiSettingKey = "Gui.Gui";

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		public const bool MiniMapGuiSettingDefault = true;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		public const string MiniMapGuiSettingKey = "Gui.MiniMap";

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		public const bool HudGuiSettingDefault = true;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		public const string HudGuiSettingKey = "Gui.HudGui";

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		public const bool WorldInteractionGuiSettingDefault = true;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		public const string WorldInteractionGuiSettingKey = "Gui.WorldInteractionGui";

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		public const bool BuildingGuiSettingDefault = true;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		public const string BuildingGuiSettingKey = "Gui.BuildingGui";

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		public const bool TutorialsGuiSettingDefault = true;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		public const string TutorialsGuiSettingKey = "Gui.TutorialsGui";

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		public const float HudGuiScaleSettingDefault = 0.5f;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		public const string HudGuiScaleSettingKey = "Gui.HudGuiScale";

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		public const bool ProjectileReticleSettingDefault = true;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		public const string ProjectileReticleSettingKey = "Gui.ProjectileReticle";

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		public const bool PlayerNameTagsSettingDefault = true;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		public const string PlayerNameTagsSettingKey = "Gui.PlayerNameTags";

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		public const string FovOffsetSettingKey = "Camera.FovOffset";

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		public const int FovOffsetDefault = 0;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		public const bool BigHeadModeSettingDefault = false;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		public const string BigHeadModeSettingKey = "Gameplay.BigHeadMode";

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		public const bool TreeRegrowthSettingDefault = true;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		public const string TreeRegrowthSettingKey = "Gameplay.TreeRegrowth";

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		public const bool StructureDamageSettingDefault = true;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		public const string StructureDamageSettingKey = "Structure.Damage";

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		public const bool PlayerActorsSettingDefault = false;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		public const string PlayerActorSettingKey = "Gameplay.PlayerActors";

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<object> _registeredActionPairs;
	}
}
