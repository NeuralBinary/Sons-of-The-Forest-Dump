using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Serializable]
	public class GenericInputBindingOptionGui : InputOptionGui
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x303C850", Offset = "0x303AE50", VA = "0x18303C850")]
		public GenericInputBindingOptionGui(List<string> actionIds, GameObject guiRoot, string labelText, List<string> actionPaths, string defaultBindValue, int controlType, InputBindingData bindingData, InputBindingDefinition bindingDefinition, GameObject bindingInputState, GameObject eventSystem)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x303CD60", Offset = "0x303B360", VA = "0x18303CD60")]
		private void StartRebindOperation()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x303CEC0", Offset = "0x303B4C0", VA = "0x18303CEC0")]
		private void OnBindingStarted()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x303CFA0", Offset = "0x303B5A0", VA = "0x18303CFA0")]
		private void OnBindingChanged()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x303CFA0", Offset = "0x303B5A0", VA = "0x18303CFA0")]
		private void OnBindingCancelled()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x303CFE0", Offset = "0x303B5E0", VA = "0x18303CFE0")]
		private void DisableEventSystem()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x303D0A0", Offset = "0x303B6A0", VA = "0x18303D0A0")]
		private void EnableEventSystemWithDelay()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390", Slot = "31")]
		public override string GetLabelText()
		{
			return null;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000033")]
		public override string SettingKey
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x303D250", Offset = "0x303B850", VA = "0x18303D250", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010", Slot = "29")]
		public override string GetDefaultStringValue()
		{
			return null;
		}

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x90")]
		private readonly string _labelText;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x98")]
		private readonly List<string> _actionPaths;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xA0")]
		private readonly string _group;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xA8")]
		private readonly string _defaultBindValue;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xB0")]
		private Button _bindingButton;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xB8")]
		private readonly int _controlType;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xC0")]
		private InputBindingData _bindingData;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xC8")]
		private InputBindingDefinition _bindingDefinition;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject _bindingInputState;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xD8")]
		private List<string> _actionIds;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject _eventSystem;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xE8")]
		private RebindingInputOptionGui _rebindingInputOptionGui;
	}
}
