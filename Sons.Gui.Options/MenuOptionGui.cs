using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace Sons.Gui.Options
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[Serializable]
	public abstract class MenuOptionGui
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x304F990", Offset = "0x304DF90", VA = "0x18304F990", Slot = "4")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public virtual void Initialize()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public virtual bool ApplyCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void SetInteractable(bool value)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x304FA40", Offset = "0x304E040", VA = "0x18304FA40")]
		public void SetVisible(bool value)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		public virtual bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x06000234 RID: 564
		[Token(Token = "0x6000234")]
		public abstract bool MatchesSelectable(GameObject target);

		// Token: 0x06000235 RID: 565 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public LocalizeStringEvent GetLocalizedLabel()
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		public void SetLocalizedLabel(LocalizeStringEvent label)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700005C")]
		public virtual string SettingKey
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700005D")]
		public virtual string ValueChangedAudioEventPath
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x1700005E")]
		public bool IsSettingDisabled
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x304FAA0", Offset = "0x304E0A0", VA = "0x18304FAA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x1700005F")]
		public virtual bool IsSettingEnabled
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x17000060")]
		public bool IsSettingHidden
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x304FAD0", Offset = "0x304E0D0", VA = "0x18304FAD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x17000061")]
		public virtual bool IsSettingVisible
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x17000062")]
		public virtual bool ApplyChangesInstantly
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023F RID: 575
		[Token(Token = "0x600023F")]
		public abstract void RevertCachedChanges();

		// Token: 0x06000240 RID: 576
		[Token(Token = "0x6000240")]
		public abstract bool HasCachedChanges();

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetChangedAudioEventCallback(Action<string> changedAudioEvent)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetCachedChangesCallback(Action cachedChangesCallback)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2FF7310", Offset = "0x2FF5910", VA = "0x182FF7310")]
		internal void TriggerCacheChangesCallback()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x304FB00", Offset = "0x304E100", VA = "0x18304FB00")]
		public void TriggerChangedAudioEvent()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x304FB70", Offset = "0x304E170", VA = "0x18304FB70")]
		protected string ConvertToOnOffOption(bool value)
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x304FBC0", Offset = "0x304E1C0", VA = "0x18304FBC0")]
		protected string ConvertToHighLowOption(bool value)
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x304FC10", Offset = "0x304E210", VA = "0x18304FC10")]
		protected string ConvertToArrayOption(int setting, List<string> items)
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x304FC80", Offset = "0x304E280", VA = "0x18304FC80")]
		protected bool TryParseOnOffOption(string newValueString, out bool result)
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x304FE40", Offset = "0x304E440", VA = "0x18304FE40")]
		protected static void SanitizeDefaultHighLowOption(ref string target)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x304FEA0", Offset = "0x304E4A0", VA = "0x18304FEA0")]
		protected static void SanitizeDefaultOffOnOption(ref string target)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x304FF00", Offset = "0x304E500", VA = "0x18304FF00")]
		private static void SanitizeDualOption(ref string target, string firstOption, string secondOption, string fallback)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000063")]
		internal virtual Func<string, int, int> GetIntSettingDelegate
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x30500F0", Offset = "0x304E6F0", VA = "0x1830500F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000064")]
		internal virtual Func<string, string, string> GetStringSettingDelegate
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x3050150", Offset = "0x304E750", VA = "0x183050150", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000065")]
		internal virtual Func<string, bool, bool> GetBoolSettingDelegate
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x30501B0", Offset = "0x304E7B0", VA = "0x1830501B0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000066")]
		internal virtual Func<string, float, float> GetFloatSettingDelegate
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x3050210", Offset = "0x304E810", VA = "0x183050210", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000067")]
		internal virtual Action<string, int> SetIntSettingDelegate
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x3050270", Offset = "0x304E870", VA = "0x183050270", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000068")]
		internal virtual Action<string, string> SetStringSettingDelegate
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x30502D0", Offset = "0x304E8D0", VA = "0x1830502D0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000069")]
		internal virtual Action<string, bool> SetBoolSettingDelegate
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x3050330", Offset = "0x304E930", VA = "0x183050330", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006A")]
		internal virtual Action<string, float> SetFloatSettingDelegate
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x3050390", Offset = "0x304E990", VA = "0x183050390", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x30503F0", Offset = "0x304E9F0", VA = "0x1830503F0")]
		internal int GetSetting(string settingKey, int defaultResult)
		{
			return 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x3050440", Offset = "0x304EA40", VA = "0x183050440")]
		internal string GetSetting(string settingKey, string defaultResult)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3050490", Offset = "0x304EA90", VA = "0x183050490")]
		internal bool GetSetting(string settingKey, bool defaultResult)
		{
			return default(bool);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x30504E0", Offset = "0x304EAE0", VA = "0x1830504E0")]
		internal float GetSetting(string settingKey, float defaultResult)
		{
			return 0f;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x3050530", Offset = "0x304EB30", VA = "0x183050530")]
		internal void SetSetting(string settingKey, string newValue)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3050580", Offset = "0x304EB80", VA = "0x183050580")]
		internal void SetSetting(string settingKey, int newValue)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x30505D0", Offset = "0x304EBD0", VA = "0x1830505D0")]
		internal void SetSetting(string settingKey, bool newValue)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3050620", Offset = "0x304EC20", VA = "0x183050620")]
		internal void SetSetting(string settingKey, float newValue)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3050670", Offset = "0x304EC70", VA = "0x183050670")]
		protected void RefreshVisibility()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		protected virtual void ShowSetting()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		protected virtual void HideSetting()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x30506C0", Offset = "0x304ECC0", VA = "0x1830506C0")]
		public void SetLinkedInteractive(MenuOptionGui target)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x30507F0", Offset = "0x304EDF0", VA = "0x1830507F0")]
		public void SetLinkedInteractiveInverted(MenuOptionGui target)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public virtual void SetSelectedAudioEvent(FmodEmitterBuffer selectedAudioEvent)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x21BE7E0", Offset = "0x21BCDE0", VA = "0x1821BE7E0")]
		protected MenuOptionGui()
		{
		}

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x10")]
		protected List<MenuOptionGui> _interactiveLinked;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		protected List<MenuOptionGui> _interactiveInvertedLinked;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x20")]
		private Action<string> _onChangedAudioEvent;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x28")]
		private Action _onCachedChangesEvent;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x30")]
		private bool _isVisible;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		protected const string OffOption = "OFF";

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		protected const string OnOption = "ON";

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		protected const string HighOption = "HIGH";

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		protected const string MediumOption = "MEDIUM";

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		protected const string LowOption = "LOW";

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _tooltipKey;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LocalizeStringEvent _localizedLabel;
	}
}
