using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[AddComponentMenu("Sons/Gui/Options/ControlOptionsGui")]
	public class ControlOptionsGui : OptionsGui
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x303F940", Offset = "0x303DF40", VA = "0x18303F940", Slot = "4")]
		public override MenuOptionGui[] GetMenuOptionsOrder()
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x303FDE0", Offset = "0x303E3E0", VA = "0x18303FDE0", Slot = "5")]
		internal override void OnPreEnable()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x303FF60", Offset = "0x303E560", VA = "0x18303FF60", Slot = "7")]
		internal override void OnPreDisable()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x3040030", Offset = "0x303E630", VA = "0x183040030")]
		private void SetActiveList(List<GameObject> gameObjects, bool active)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x30401B0", Offset = "0x303E7B0", VA = "0x1830401B0")]
		private void ShowKeyboardBindingOptions()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x30403A0", Offset = "0x303E9A0", VA = "0x1830403A0")]
		private void ShowGamepadBindingOptions()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x3040630", Offset = "0x303EC30", VA = "0x183040630")]
		private void SetupResetBindingButtonNavigationForKeyboardAndMouse()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x30407D0", Offset = "0x303EDD0", VA = "0x1830407D0")]
		private void SetupResetBindingButtonNavigationForGamepad()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x3040970", Offset = "0x303EF70", VA = "0x183040970")]
		private void SetActiveBindingHeader(GameObject header)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x3040CE0", Offset = "0x303F2E0", VA = "0x183040CE0")]
		private void SetupGamepadBindings(List<InputBindingDefinition> definitions)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3040F50", Offset = "0x303F550", VA = "0x183040F50")]
		private void SetupKeyboardAndMouseBindings(List<InputBindingDefinition> definitions)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x30411C0", Offset = "0x303F7C0", VA = "0x1830411C0")]
		private GameObject CreateBindOption(string defaultBindValue, InputBindingDefinition inputBindingDefinition, string objectNameSuffix, GameObject inputBindingTemplate, int controlType)
		{
			return null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x3041580", Offset = "0x303FB80", VA = "0x183041580")]
		public void ResetUserInputBindings()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x30415B0", Offset = "0x303FBB0", VA = "0x1830415B0")]
		private static void InitializeOptionInstanceList(ref List<GameObject> list)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x303F930", Offset = "0x303DF30", VA = "0x18303F930")]
		public ControlOptionsGui()
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[FormerlySerializedAs("_inputIconMap")]
		private InputBindingData _inputBindingData;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _keyboardAndMouseInputBindingTemplate;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _gamepadInputBindingTemplate;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _keyboardAndMouseBindingOptions;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<GameObject> _gamepadBindingOptions;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _resetBindingButton;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private InputBindingData _bindingData;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _bindingInputState;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _eventSystem;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _keyboardMouseHeader;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _xboxGamepadHeader;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _psGamepadHeader;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0xE0")]
		private bool _keyboardBindingsActive;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0xE1")]
		private bool _gamepadBindingsActive;
	}
}
