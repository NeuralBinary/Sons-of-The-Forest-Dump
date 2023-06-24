using System;
using Il2CppDummyDll;
using Sons.UiElements;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gui.Options
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Serializable]
	public abstract class FloatOptionGui : MenuOptionGui
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000055")]
		public override string ValueChangedAudioEventPath
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000056")]
		public TMP_Text Label
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x304C970", Offset = "0x304AF70", VA = "0x18304C970", Slot = "29")]
		public virtual float GetInitialValue()
		{
			return 0f;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "30")]
		public virtual string GetLabelText()
		{
			return null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x304CAC0", Offset = "0x304B0C0", VA = "0x18304CAC0", Slot = "10")]
		public override bool MatchesSelectable(GameObject target)
		{
			return default(bool);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x304CFA0", Offset = "0x304B5A0", VA = "0x18304CFA0", Slot = "9")]
		public override bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "31")]
		public virtual bool RoundToInteger()
		{
			return default(bool);
		}

		// Token: 0x060001EA RID: 490
		[Token(Token = "0x60001EA")]
		public abstract float GetDefaultFloatValue();

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x304D080", Offset = "0x304B680", VA = "0x18304D080", Slot = "8")]
		public override void SetInteractable(bool value)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x304D170", Offset = "0x304B770", VA = "0x18304D170", Slot = "5")]
		public override void Initialize()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x304AEC0", Offset = "0x30494C0", VA = "0x18304AEC0", Slot = "27")]
		protected override void HideSetting()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x304AF40", Offset = "0x3049540", VA = "0x18304AF40", Slot = "26")]
		protected override void ShowSetting()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60", Slot = "33")]
		internal virtual float GetMinValue()
		{
			return 0f;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640", Slot = "34")]
		internal virtual float GetMaxValue()
		{
			return 0f;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x304D410", Offset = "0x304BA10", VA = "0x18304D410")]
		private void AssignLabelText()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x304D4F0", Offset = "0x304BAF0", VA = "0x18304D4F0", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x304D650", Offset = "0x304BC50", VA = "0x18304D650")]
		private void PreValueChanged(float newValue)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x304D790", Offset = "0x304BD90", VA = "0x18304D790")]
		private void InitializeOptions(float min, float max, float current)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "35")]
		public virtual void ValueChanged(float newValue)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x304D960", Offset = "0x304BF60", VA = "0x18304D960", Slot = "16")]
		public override void RevertCachedChanges()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x304D970", Offset = "0x304BF70", VA = "0x18304D970", Slot = "6")]
		public override bool ApplyCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x304DA90", Offset = "0x304C090", VA = "0x18304DA90", Slot = "17")]
		public override bool HasCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x304DAD0", Offset = "0x304C0D0", VA = "0x18304DAD0")]
		protected FloatOptionGui()
		{
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject _optionGuiRoot;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected string _valueChangedEventPath;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected SonsSlider _slider;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TMP_Text _label;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public UnityEvent<float> _onInitializeValue;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected float _defaultValue;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected float _min;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected float _max;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x7C")]
		protected float? _cachedFloatValue;
	}
}
