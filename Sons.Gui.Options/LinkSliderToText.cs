using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public class LinkSliderToText : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event LinkSliderToText.ActionRef<float> FilterSliderValue
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x303E090", Offset = "0x303C690", VA = "0x18303E090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x303E200", Offset = "0x303C800", VA = "0x18303E200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x28D8B60", Offset = "0x28D7160", VA = "0x1828D8B60")]
		public void SetRoundToInteger(bool value)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x303E370", Offset = "0x303C970", VA = "0x18303E370")]
		private void OnValidate()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x303E5E0", Offset = "0x303CBE0", VA = "0x18303E5E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x303E750", Offset = "0x303CD50", VA = "0x18303E750")]
		private void OnDisable()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x303E8B0", Offset = "0x303CEB0", VA = "0x18303E8B0")]
		public void OnSliderChanged(float value)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x303EAC0", Offset = "0x303D0C0", VA = "0x18303EAC0")]
		private void Update()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x303ECD0", Offset = "0x303D2D0", VA = "0x18303ECD0")]
		private string GetValueFormatted(float value)
		{
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x303EE00", Offset = "0x303D400", VA = "0x18303EE00")]
		public LinkSliderToText()
		{
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _textGroup;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _textGroupDisableTimer;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _readoutMultiplier;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _prefix;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _formatString;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _suffix;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _roundToInteger;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _maxOverrideString;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _minOverrideString;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x78")]
		private float _showTime;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x7C")]
		private float _lastValue;

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600012B RID: 299
		[Token(Token = "0x2000042")]
		public delegate void ActionRef<T>(ref T item);
	}
}
