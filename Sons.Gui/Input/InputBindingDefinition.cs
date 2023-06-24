using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Localization;
using UnityEngine.Serialization;

namespace Sons.Gui.Input
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Serializable]
	public class InputBindingDefinition
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000023")]
		private List<string> GetActionsMenuDropdown
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x3059210", Offset = "0x3057810", VA = "0x183059210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000024")]
		public bool IsComposite
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000025")]
		public int CompositeIndex
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x17000026")]
		public InputBindingDefinition.RebindMode Mode
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return (InputBindingDefinition.RebindMode)0;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x3059250", Offset = "0x3057850", VA = "0x183059250")]
		private void FillOutPaths()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x30598C0", Offset = "0x3057EC0", VA = "0x1830598C0")]
		private List<string> GetControlPathsWithGroup(InputActionAsset inputActionAsset, string group)
		{
			return null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x3059D60", Offset = "0x3058360", VA = "0x183059D60")]
		private List<string> GetActionPathsSource()
		{
			return null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetAssetName()
		{
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x305A260", Offset = "0x3058860", VA = "0x18305A260")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x305A2D0", Offset = "0x30588D0", VA = "0x18305A2D0")]
		public void OnValidate(InputActionAsset inputActionAsset)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x305A340", Offset = "0x3058940", VA = "0x18305A340")]
		public void AutoRefreshControlPath(InputActionAsset inputActionAsset, bool force = false)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		public List<string> GetActionIds()
		{
			return null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x305A710", Offset = "0x3058D10", VA = "0x18305A710")]
		public bool MatchesAction(string actionId)
		{
			return default(bool);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x305A890", Offset = "0x3058E90", VA = "0x18305A890")]
		public string GetPath(InputMapType currentType)
		{
			return null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public string GetMouseAndKeyboardPath()
		{
			return null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		public string GetGamepadPath()
		{
			return null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public List<string> GetActionPaths()
		{
			return null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x305A8B0", Offset = "0x3058EB0", VA = "0x18305A8B0")]
		public InputBindingDefinition()
		{
		}

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("_option")]
		private InputBindingDefinition.RebindMode _mode;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_nameLoc")]
		[SerializeField]
		private LocalizedString _localizedName;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isComposite;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _compositeIndex;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _actionIds;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> _actionPaths;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x40")]
		private string _mouseAndKeyboardControlPath;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x48")]
		private string _gamepadControlPath;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x50")]
		private string _xboxGamepadControlPath;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x58")]
		private string _psGamepadControlPath;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x60")]
		private InputActionAsset _inputActionAsset;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> _actionPathsSource;

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		[Flags]
		public enum RebindMode
		{
			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			KEYBOARD = 1,
			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			GAMEPAD = 2
		}
	}
}
