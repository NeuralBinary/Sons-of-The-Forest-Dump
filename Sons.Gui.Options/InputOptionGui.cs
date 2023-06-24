using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public abstract class InputOptionGui : MenuOptionGui
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event Action<string> OnValueChanged
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x304E260", Offset = "0x304C860", VA = "0x18304E260")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x304E3D0", Offset = "0x304C9D0", VA = "0x18304E3D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "29")]
		public virtual string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x304E540", Offset = "0x304CB40", VA = "0x18304E540", Slot = "30")]
		public virtual string GetInitialValue()
		{
			return null;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000058")]
		public override string ValueChangedAudioEventPath
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000059")]
		public TMP_Text Label
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x304E5E0", Offset = "0x304CBE0", VA = "0x18304E5E0", Slot = "28")]
		public override void SetSelectedAudioEvent(FmodEmitterBuffer selectedAudioEvent)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x304E7D0", Offset = "0x304CDD0", VA = "0x18304E7D0")]
		private void SetupEventTriggers(FmodEmitterBuffer selectedAudioEvent)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x304EA60", Offset = "0x304D060", VA = "0x18304EA60", Slot = "8")]
		public override void SetInteractable(bool value)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x304EB50", Offset = "0x304D150", VA = "0x18304EB50", Slot = "9")]
		public override bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x304EC30", Offset = "0x304D230", VA = "0x18304EC30", Slot = "10")]
		public override bool MatchesSelectable(GameObject target)
		{
			return default(bool);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "31")]
		public virtual string GetLabelText()
		{
			return null;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x1700005A")]
		public virtual bool ShouldShowDefaultValue
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x1700005B")]
		public virtual bool ShouldShowValueOptions
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x304EE60", Offset = "0x304D460", VA = "0x18304EE60")]
		internal void SetupLabel()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x304F1B0", Offset = "0x304D7B0", VA = "0x18304F1B0", Slot = "5")]
		public override void Initialize()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x304AEC0", Offset = "0x30494C0", VA = "0x18304AEC0", Slot = "27")]
		protected override void HideSetting()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x304AF40", Offset = "0x3049540", VA = "0x18304AF40", Slot = "26")]
		protected override void ShowSetting()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x304F400", Offset = "0x304DA00", VA = "0x18304F400")]
		private void AssignLabelText()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x304F4E0", Offset = "0x304DAE0", VA = "0x18304F4E0", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "34")]
		public virtual void SetValue(string value)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void SetInput(string value)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ShowInput(string value)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "35")]
		public virtual void SetValueWithoutNotify(string value)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnInputButtonClicked()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void StartWaitForInput()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x304F640", Offset = "0x304DC40", VA = "0x18304F640")]
		private void EndWaitForInput()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x304F660", Offset = "0x304DC60", VA = "0x18304F660", Slot = "36")]
		public virtual void InternalValueChanged(string newValue)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "37")]
		public virtual void ValueChanged(string newValue)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x304F7B0", Offset = "0x304DDB0", VA = "0x18304F7B0", Slot = "6")]
		public override bool ApplyCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x304F840", Offset = "0x304DE40", VA = "0x18304F840", Slot = "16")]
		public override void RevertCachedChanges()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x304F8A0", Offset = "0x304DEA0", VA = "0x18304F8A0", Slot = "17")]
		public override bool HasCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x304F8B0", Offset = "0x304DEB0", VA = "0x18304F8B0")]
		protected InputOptionGui()
		{
		}

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject _optionGuiRoot;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected string _valueChangedEventPath;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Button _inputSelectButton;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TMP_Text _label;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected string _defaultValue;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x70")]
		protected string _cachedStringValue;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x78")]
		private EventTrigger _inputEventProxy;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x80")]
		private string _sampledInputValue;
	}
}
