using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.UiElements;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Sons.Gui.Options
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Serializable]
	public abstract class CustomMenuOptionGui : MenuOptionGui
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action<string> OnValueChanged
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x3049BA0", Offset = "0x30481A0", VA = "0x183049BA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x3049D10", Offset = "0x3048310", VA = "0x183049D10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "29")]
		public virtual string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x3049E80", Offset = "0x3048480", VA = "0x183049E80", Slot = "30")]
		public virtual string GetCurrentValue()
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x3049F20", Offset = "0x3048520", VA = "0x183049F20")]
		public string GetCurrentValueCached()
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "31")]
		public virtual List<string> GetValueOptions()
		{
			return null;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x1700004E")]
		internal virtual bool Localize
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004F")]
		internal virtual List<List<object>> LocalizationArgs
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000050")]
		public override bool IsSettingEnabled
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000051")]
		public override string ValueChangedAudioEventPath
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x304A060", Offset = "0x3048660", VA = "0x18304A060", Slot = "28")]
		public override void SetSelectedAudioEvent(FmodEmitterBuffer selectedAudioEvent)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x304A260", Offset = "0x3048860", VA = "0x18304A260")]
		private void SetupEventTriggers(FmodEmitterBuffer selectedAudioEvent)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x304A500", Offset = "0x3048B00", VA = "0x18304A500", Slot = "8")]
		public override void SetInteractable(bool value)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x304A5F0", Offset = "0x3048BF0", VA = "0x18304A5F0", Slot = "9")]
		public override bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x304A6D0", Offset = "0x3048CD0", VA = "0x18304A6D0", Slot = "10")]
		public override bool MatchesSelectable(GameObject target)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "34")]
		public virtual string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x17000052")]
		public virtual bool ShouldShowDefaultValue
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x17000053")]
		public virtual bool ShouldShowValueOptions
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000054")]
		public TMP_Text Label
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x304ABB0", Offset = "0x30491B0", VA = "0x18304ABB0", Slot = "5")]
		public override void Initialize()
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x304AEC0", Offset = "0x30494C0", VA = "0x18304AEC0", Slot = "27")]
		protected override void HideSetting()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x304AF40", Offset = "0x3049540", VA = "0x18304AF40", Slot = "26")]
		protected override void ShowSetting()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x304AFC0", Offset = "0x30495C0", VA = "0x18304AFC0")]
		private void SetupLocalization()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x304B8F0", Offset = "0x3049EF0", VA = "0x18304B8F0")]
		private void AssignLabelText()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x304B9D0", Offset = "0x3049FD0", VA = "0x18304B9D0", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x304BB30", Offset = "0x304A130", VA = "0x18304BB30")]
		internal void InitializeOptions(List<string> valueOptions, string currentValue)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60", Slot = "37")]
		public virtual int GetValueIndexFallback(string value)
		{
			return 0;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x304C1B0", Offset = "0x304A7B0", VA = "0x18304C1B0")]
		public int GetValueIndex(string value)
		{
			return 0;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x304C340", Offset = "0x304A940", VA = "0x18304C340", Slot = "38")]
		public virtual void SetValue(string value)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x304C370", Offset = "0x304A970", VA = "0x18304C370", Slot = "39")]
		public virtual void SetValue(int value)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x304C3A0", Offset = "0x304A9A0", VA = "0x18304C3A0", Slot = "40")]
		public virtual void SetValueWithoutNotify(string value)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x304C3D0", Offset = "0x304A9D0", VA = "0x18304C3D0", Slot = "41")]
		public virtual void SetValueWithoutNotify(int value)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x304C400", Offset = "0x304AA00", VA = "0x18304C400", Slot = "42")]
		public virtual void InternalValueChanged(int newValue)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x304C630", Offset = "0x304AC30", VA = "0x18304C630")]
		private string GetValueOption(int newValue)
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		internal void SetCachedStringValue(string newStringValue)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "43")]
		public virtual void ValueChanged(int newValue)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "44")]
		public virtual void ValueChanged(string newValue)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x304C780", Offset = "0x304AD80", VA = "0x18304C780")]
		public string GetValue()
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x304C7B0", Offset = "0x304ADB0", VA = "0x18304C7B0", Slot = "45")]
		public virtual bool MatchesValue(string result)
		{
			return default(bool);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x304C7E0", Offset = "0x304ADE0", VA = "0x18304C7E0", Slot = "6")]
		public override bool ApplyCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x304C870", Offset = "0x304AE70", VA = "0x18304C870", Slot = "16")]
		public override void RevertCachedChanges()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x141EE60", Offset = "0x141D460", VA = "0x18141EE60", Slot = "17")]
		public override bool HasCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x304C8D0", Offset = "0x304AED0", VA = "0x18304C8D0")]
		protected CustomMenuOptionGui()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_dropdownRoot")]
		[SerializeField]
		protected GameObject _optionGuiRoot;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected string _valueChangedEventPath;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected SonsDropdown _dropdown;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TMP_Text _label;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected string _defaultValue;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal List<string> _valueOptions;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x78")]
		protected string _cachedStringValue;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x80")]
		private bool _isEnabled;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x88")]
		private EventTrigger _inputEventProxy;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x90")]
		private string _currentSettingCache;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x98")]
		private int _currentValueCacheFrame;
	}
}
