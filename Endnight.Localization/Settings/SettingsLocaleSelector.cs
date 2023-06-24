using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

namespace Endnight.Localization.Settings
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	public class SettingsLocaleSelector : IStartupLocaleSelector, IInitialize
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public string PlayerPreferenceKey
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xA811D0", Offset = "0xA7F7D0", VA = "0x180A811D0", Slot = "5")]
		public void PostInitialization(LocalizationSettings settings)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xA81330", Offset = "0xA7F930", VA = "0x180A81330", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xA81420", Offset = "0xA7FA20", VA = "0x180A81420")]
		public SettingsLocaleSelector()
		{
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_PlayerPreferenceKey;
	}
}
