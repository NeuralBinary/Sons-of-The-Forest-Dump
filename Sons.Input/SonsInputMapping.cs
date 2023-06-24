using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Sons.Input
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class SonsInputMapping : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700001F")]
		public InputActionAsset asset
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x307DB30", Offset = "0x307C130", VA = "0x18307DB30")]
		public SonsInputMapping()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x3080BF0", Offset = "0x307F1F0", VA = "0x183080BF0", Slot = "17")]
		public void Dispose()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x26EF2B0", Offset = "0x26ED8B0", VA = "0x1826EF2B0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x26EF300", Offset = "0x26ED900", VA = "0x1826EF300", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002C9C File Offset: 0x00000E9C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x26EF360", Offset = "0x26ED960", VA = "0x1826EF360", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x26EF3B0", Offset = "0x26ED9B0", VA = "0x1826EF3B0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x17000022")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x26EF430", Offset = "0x26EDA30", VA = "0x1826EF430", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x26EF470", Offset = "0x26EDA70", VA = "0x1826EF470", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x26EF490", Offset = "0x26EDA90", VA = "0x1826EF490", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x26EF490", Offset = "0x26EDA90", VA = "0x1826EF490", Slot = "16")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x26EF4B0", Offset = "0x26EDAB0", VA = "0x1826EF4B0", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x26EF4D0", Offset = "0x26EDAD0", VA = "0x1826EF4D0", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000023")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x26EF4F0", Offset = "0x26EDAF0", VA = "0x1826EF4F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x26EF510", Offset = "0x26EDB10", VA = "0x1826EF510", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x26EF530", Offset = "0x26EDB30", VA = "0x1826EF530", Slot = "6")]
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x17000024")]
		public SonsInputMapping.DefaultActions @default
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.DefaultActions);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x17000025")]
		public SonsInputMapping.ItemHotkeyActions ItemHotkey
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.ItemHotkeyActions);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x17000026")]
		public SonsInputMapping.MenuActions Menu
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.MenuActions);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x17000027")]
		public SonsInputMapping.InventoryActions Inventory
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.InventoryActions);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x17000028")]
		public SonsInputMapping.ConstructionActions Construction
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.ConstructionActions);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x17000029")]
		public SonsInputMapping.DebugActions Debug
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.DebugActions);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x1700002A")]
		public SonsInputMapping.GrabBagActions GrabBag
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.GrabBagActions);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x1700002B")]
		public SonsInputMapping.MultiplayerActions Multiplayer
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.MultiplayerActions);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x1700002C")]
		public SonsInputMapping.TextInputActions TextInput
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.TextInputActions);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x1700002D")]
		public SonsInputMapping.ConsoleActions Console
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.ConsoleActions);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x1700002E")]
		public SonsInputMapping.StructureCraftingActions StructureCrafting
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.StructureCraftingActions);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x1700002F")]
		public SonsInputMapping.GameOverActions GameOver
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.GameOverActions);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x17000030")]
		public SonsInputMapping.FirstDeathActions FirstDeath
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.FirstDeathActions);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x17000031")]
		public SonsInputMapping.InputBindingActions InputBinding
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.InputBindingActions);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x17000032")]
		public SonsInputMapping.ModalDialogActions ModalDialog
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.ModalDialogActions);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x17000033")]
		public SonsInputMapping.CutsceneActions Cutscene
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.CutsceneActions);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x17000034")]
		public SonsInputMapping.VehicleActions Vehicle
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SonsInputMapping.VehicleActions);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x17000035")]
		public InputControlScheme MouseandKeyboardScheme
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x3080C40", Offset = "0x307F240", VA = "0x183080C40")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x17000036")]
		public InputControlScheme GamepadScheme
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x3080DB0", Offset = "0x307F3B0", VA = "0x183080DB0")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x18")]
		private readonly InputActionMap m_default;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x20")]
		private SonsInputMapping.IDefaultActions m_DefaultActionsCallbackInterface;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x28")]
		private readonly InputAction m_default_Console;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x30")]
		private readonly InputAction m_default_Back;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x38")]
		private readonly InputAction m_default_PrimaryAction;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x40")]
		private readonly InputAction m_default_SecondaryAction;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x48")]
		private readonly InputAction m_default_TertiaryAction;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x50")]
		private readonly InputAction m_default_Reload;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x58")]
		private readonly InputAction m_default_MoveCursor;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x60")]
		private readonly InputAction m_default_MouseX;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x68")]
		private readonly InputAction m_default_MouseY;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x70")]
		private readonly InputAction m_default_TogglePauseMenu;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x78")]
		private readonly InputAction m_default_Skip;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x80")]
		private readonly InputAction m_default_Open;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x88")]
		private readonly InputAction m_default_RevivePlayer;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x90")]
		private readonly InputAction m_default_Sleep;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x98")]
		private readonly InputAction m_default_Save;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0xA0")]
		private readonly InputAction m_default_Use;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0xA8")]
		private readonly InputAction m_default_Take;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0xB0")]
		private readonly InputAction m_default_Interact;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xB8")]
		private readonly InputAction m_default_Place;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0xC0")]
		private readonly InputAction m_default_Drop;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0xC8")]
		private readonly InputAction m_default_IgniteObject;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xD0")]
		private readonly InputAction m_default_Jump;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xD8")]
		private readonly InputAction m_default_Crouch;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xE0")]
		private readonly InputAction m_default_Run;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xE8")]
		private readonly InputAction m_default_Lighter;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xF0")]
		private readonly InputAction m_default_Utility;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xF8")]
		private readonly InputAction m_default_GpsTracker;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x100")]
		private readonly InputAction m_default_VoiceChat;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x108")]
		private readonly InputAction m_default_Book;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x110")]
		private readonly InputAction m_default_Rotate;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x118")]
		private readonly InputAction m_default_Vertical;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x120")]
		private readonly InputAction m_default_Horizontal;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x128")]
		private readonly InputAction m_default_ShoulderTap;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x130")]
		private readonly InputAction m_default_OpenInventory;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x138")]
		private readonly InputAction m_default_OpenQuickSelect;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x140")]
		private readonly InputAction m_default_GoToBuilding;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x148")]
		private readonly InputAction m_default_BookFlipPageNext;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x150")]
		private readonly InputAction m_default_BookFlipPagePrevious;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x158")]
		private readonly InputActionMap m_ItemHotkey;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x160")]
		private SonsInputMapping.IItemHotkeyActions m_ItemHotkeyActionsCallbackInterface;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x168")]
		private readonly InputAction m_ItemHotkey_Hotkey1;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x170")]
		private readonly InputAction m_ItemHotkey_Hotkey2;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x178")]
		private readonly InputAction m_ItemHotkey_Hotkey3;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x180")]
		private readonly InputAction m_ItemHotkey_Hotkey4;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x188")]
		private readonly InputAction m_ItemHotkey_Hotkey5;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x190")]
		private readonly InputAction m_ItemHotkey_Hotkey6;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x198")]
		private readonly InputAction m_ItemHotkey_Hotkey7;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x1A0")]
		private readonly InputAction m_ItemHotkey_Hotkey8;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x1A8")]
		private readonly InputAction m_ItemHotkey_Hotkey9;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x1B0")]
		private readonly InputAction m_ItemHotkey_Hotkey0;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x1B8")]
		private readonly InputAction m_ItemHotkey_SetHotkey1;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x1C0")]
		private readonly InputAction m_ItemHotkey_SetHotkey2;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x1C8")]
		private readonly InputAction m_ItemHotkey_SetHotkey3;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x1D0")]
		private readonly InputAction m_ItemHotkey_SetHotkey4;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x1D8")]
		private readonly InputAction m_ItemHotkey_SetHotkey5;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x1E0")]
		private readonly InputAction m_ItemHotkey_SetHotkey6;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x1E8")]
		private readonly InputAction m_ItemHotkey_SetHotkey7;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x1F0")]
		private readonly InputAction m_ItemHotkey_SetHotkey8;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x1F8")]
		private readonly InputAction m_ItemHotkey_SetHotkey9;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x200")]
		private readonly InputAction m_ItemHotkey_SetHotkey0;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x208")]
		private readonly InputActionMap m_Menu;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x210")]
		private SonsInputMapping.IMenuActions m_MenuActionsCallbackInterface;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x218")]
		private readonly InputAction m_Menu_NextPage;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x220")]
		private readonly InputAction m_Menu_TogglePauseMenu;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x228")]
		private readonly InputAction m_Menu_Confirm;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x230")]
		private readonly InputAction m_Menu_Horizontal;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x238")]
		private readonly InputAction m_Menu_Vertical;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x240")]
		private readonly InputAction m_Menu_PreviousPage;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x248")]
		private readonly InputAction m_Menu_Back;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x250")]
		private readonly InputAction m_Menu_Apply;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x258")]
		private readonly InputAction m_Menu_Reset;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x260")]
		private readonly InputAction m_Menu_CycleBack;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x268")]
		private readonly InputAction m_Menu_CycleForward;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x270")]
		private readonly InputAction m_Menu_Console;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x278")]
		private readonly InputActionMap m_Inventory;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x280")]
		private SonsInputMapping.IInventoryActions m_InventoryActionsCallbackInterface;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x288")]
		private readonly InputAction m_Inventory_MoveCursor;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x290")]
		private readonly InputAction m_Inventory_Inventory;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x298")]
		private readonly InputAction m_Inventory_ClearCraftingMat;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x2A0")]
		private readonly InputAction m_Inventory_DropItemFromInventory;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x2A8")]
		private readonly InputAction m_Inventory_InteractWithItem;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x2B0")]
		private readonly InputAction m_Inventory_AlternateInteractWithItem;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x2B8")]
		private readonly InputAction m_Inventory_AddItemToMat;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x2C0")]
		private readonly InputAction m_Inventory_RemoveItemFromMat;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x2C8")]
		private readonly InputAction m_Inventory_Esc;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x2D0")]
		private readonly InputAction m_Inventory_Console;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x2D8")]
		private readonly InputAction m_Inventory_ToggleQuickSelect;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x2E0")]
		private readonly InputActionMap m_Construction;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x2E8")]
		private SonsInputMapping.IConstructionActions m_ConstructionActionsCallbackInterface;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x2F0")]
		private readonly InputAction m_Construction_PlaceElement;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x2F8")]
		private readonly InputAction m_Construction_CutElement;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x300")]
		private readonly InputAction m_Construction_RotateElement;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x308")]
		private readonly InputAction m_Construction_CancelPlace;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x310")]
		private readonly InputAction m_Construction_TogglePlaceMode;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x318")]
		private readonly InputAction m_Construction_DismantleElement;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x320")]
		private readonly InputActionMap m_Debug;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x328")]
		private SonsInputMapping.IDebugActions m_DebugActionsCallbackInterface;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x330")]
		private readonly InputAction m_Debug_QuickSave;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x338")]
		private readonly InputAction m_Debug_QuickLoad;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x340")]
		private readonly InputAction m_Debug_DebugBreak;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x348")]
		private readonly InputAction m_Debug_DebugOverlay;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x350")]
		private readonly InputAction m_Debug_DebugPlayerStats;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x358")]
		private readonly InputAction m_Debug_DebugVailStats;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x360")]
		private readonly InputAction m_Debug_DebugVailCamera;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x368")]
		private readonly InputActionMap m_GrabBag;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x370")]
		private SonsInputMapping.IGrabBagActions m_GrabBagActionsCallbackInterface;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x378")]
		private readonly InputAction m_GrabBag_MoveCursor;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x380")]
		private readonly InputAction m_GrabBag_Console;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x388")]
		private readonly InputAction m_GrabBag_InteractWithItem;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x390")]
		private readonly InputAction m_GrabBag_AlternateInteractWithItem;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x398")]
		private readonly InputAction m_GrabBag_Exit;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x3A0")]
		private readonly InputAction m_GrabBag_CloseQuickSelect;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x3A8")]
		private readonly InputAction m_GrabBag_CycleCategory;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x3B0")]
		private readonly InputAction m_GrabBag_Back;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x3B8")]
		private readonly InputActionMap m_Multiplayer;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x3C0")]
		private SonsInputMapping.IMultiplayerActions m_MultiplayerActionsCallbackInterface;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x3C8")]
		private readonly InputAction m_Multiplayer_OpenChat;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x3D0")]
		private readonly InputAction m_Multiplayer_PlayerList;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x3D8")]
		private readonly InputActionMap m_TextInput;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x3E0")]
		private SonsInputMapping.ITextInputActions m_TextInputActionsCallbackInterface;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x3E8")]
		private readonly InputAction m_TextInput_Submit;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x3F0")]
		private readonly InputAction m_TextInput_Esc;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x3F8")]
		private readonly InputActionMap m_Console;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x400")]
		private SonsInputMapping.IConsoleActions m_ConsoleActionsCallbackInterface;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x408")]
		private readonly InputAction m_Console_Submit;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x410")]
		private readonly InputAction m_Console_Close;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x418")]
		private readonly InputAction m_Console_Console;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x420")]
		private readonly InputAction m_Console_HistoryBack;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x428")]
		private readonly InputAction m_Console_HistoryForward;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x430")]
		private readonly InputAction m_Console_AutoComplete;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x438")]
		private readonly InputAction m_Console_ClearLogs;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x440")]
		private readonly InputActionMap m_StructureCrafting;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x448")]
		private SonsInputMapping.IStructureCraftingActions m_StructureCraftingActionsCallbackInterface;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x450")]
		private readonly InputAction m_StructureCrafting_AddIngredient;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x458")]
		private readonly InputAction m_StructureCrafting_Back;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x460")]
		private readonly InputAction m_StructureCrafting_Lighter;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x468")]
		private readonly InputAction m_StructureCrafting_Utility;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x470")]
		private readonly InputAction m_StructureCrafting_GpsTracker;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x478")]
		private readonly InputAction m_StructureCrafting_VoiceChat;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x480")]
		private readonly InputAction m_StructureCrafting_Drop;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x488")]
		private readonly InputAction m_StructureCrafting_Book;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x490")]
		private readonly InputAction m_StructureCrafting_GoToTutorials;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x498")]
		private readonly InputAction m_StructureCrafting_PrimaryAction;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x4A0")]
		private readonly InputAction m_StructureCrafting_SecondaryAction;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x4A8")]
		private readonly InputAction m_StructureCrafting_MoveCursor;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x4B0")]
		private readonly InputAction m_StructureCrafting_OpenQuickSelect;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x4B8")]
		private readonly InputAction m_StructureCrafting_OpenInventory;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x4C0")]
		private readonly InputAction m_StructureCrafting_Console;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x4C8")]
		private readonly InputAction m_StructureCrafting_Unequip;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x4D0")]
		private readonly InputAction m_StructureCrafting_Horizontal;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x4D8")]
		private readonly InputAction m_StructureCrafting_Vertical;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x4E0")]
		private readonly InputAction m_StructureCrafting_Run;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x4E8")]
		private readonly InputAction m_StructureCrafting_Crouch;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x4F0")]
		private readonly InputAction m_StructureCrafting_Jump;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x4F8")]
		private readonly InputAction m_StructureCrafting_MouseY;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x500")]
		private readonly InputAction m_StructureCrafting_MouseX;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x508")]
		private readonly InputAction m_StructureCrafting_Rotate;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x510")]
		private readonly InputAction m_StructureCrafting_CancelStructure;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x518")]
		private readonly InputAction m_StructureCrafting_SelectStructure;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x520")]
		private readonly InputActionMap m_GameOver;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x528")]
		private SonsInputMapping.IGameOverActions m_GameOverActionsCallbackInterface;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x530")]
		private readonly InputAction m_GameOver_Console;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x538")]
		private readonly InputAction m_GameOver_Back;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x540")]
		private readonly InputActionMap m_FirstDeath;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x548")]
		private SonsInputMapping.IFirstDeathActions m_FirstDeathActionsCallbackInterface;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x550")]
		private readonly InputAction m_FirstDeath_Use;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x558")]
		private readonly InputAction m_FirstDeath_Console;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x560")]
		private readonly InputActionMap m_InputBinding;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x568")]
		private SonsInputMapping.IInputBindingActions m_InputBindingActionsCallbackInterface;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x570")]
		private readonly InputAction m_InputBinding_Cancel;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x578")]
		private readonly InputActionMap m_ModalDialog;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x580")]
		private SonsInputMapping.IModalDialogActions m_ModalDialogActionsCallbackInterface;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x588")]
		private readonly InputAction m_ModalDialog_ConfirmModal;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x590")]
		private readonly InputAction m_ModalDialog_CancelModal;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x598")]
		private readonly InputActionMap m_Cutscene;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x5A0")]
		private SonsInputMapping.ICutsceneActions m_CutsceneActionsCallbackInterface;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x5A8")]
		private readonly InputAction m_Cutscene_Back;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x5B0")]
		private readonly InputAction m_Cutscene_MouseY;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x5B8")]
		private readonly InputAction m_Cutscene_MouseX;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x5C0")]
		private readonly InputAction m_Cutscene_Horizontal;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x5C8")]
		private readonly InputAction m_Cutscene_Skip;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x5D0")]
		private readonly InputAction m_Cutscene_Open;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x5D8")]
		private readonly InputAction m_Cutscene_Interact;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x5E0")]
		private readonly InputActionMap m_Vehicle;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x5E8")]
		private SonsInputMapping.IVehicleActions m_VehicleActionsCallbackInterface;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x5F0")]
		private readonly InputAction m_Vehicle_Boost;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x5F8")]
		private readonly InputAction m_Vehicle_HandBrake;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x600")]
		private readonly InputAction m_Vehicle_Throttle;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x608")]
		private readonly InputAction m_Vehicle_Reverse;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x610")]
		private readonly InputAction m_Vehicle_Turn;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x618")]
		private int m_MouseandKeyboardSchemeIndex;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x61C")]
		private int m_GamepadSchemeIndex;

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		public struct DefaultActions
		{
			// Token: 0x0600016C RID: 364 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public DefaultActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x0600016D RID: 365 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000037")]
			public InputAction Console
			{
				[Token(Token = "0x600016D")]
				[Address(RVA = "0x26EF590", Offset = "0x26EDB90", VA = "0x1826EF590")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600016E RID: 366 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000038")]
			public InputAction Back
			{
				[Token(Token = "0x600016E")]
				[Address(RVA = "0x26EF5B0", Offset = "0x26EDBB0", VA = "0x1826EF5B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600016F RID: 367 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000039")]
			public InputAction PrimaryAction
			{
				[Token(Token = "0x600016F")]
				[Address(RVA = "0x26EF5D0", Offset = "0x26EDBD0", VA = "0x1826EF5D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000170 RID: 368 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003A")]
			public InputAction SecondaryAction
			{
				[Token(Token = "0x6000170")]
				[Address(RVA = "0x26EF5F0", Offset = "0x26EDBF0", VA = "0x1826EF5F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000171 RID: 369 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003B")]
			public InputAction TertiaryAction
			{
				[Token(Token = "0x6000171")]
				[Address(RVA = "0x26EF610", Offset = "0x26EDC10", VA = "0x1826EF610")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000172 RID: 370 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003C")]
			public InputAction Reload
			{
				[Token(Token = "0x6000172")]
				[Address(RVA = "0x26EF630", Offset = "0x26EDC30", VA = "0x1826EF630")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000173 RID: 371 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003D")]
			public InputAction MoveCursor
			{
				[Token(Token = "0x6000173")]
				[Address(RVA = "0x26F1850", Offset = "0x26EFE50", VA = "0x1826F1850")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000174 RID: 372 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003E")]
			public InputAction MouseX
			{
				[Token(Token = "0x6000174")]
				[Address(RVA = "0x2712040", Offset = "0x2710640", VA = "0x182712040")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700003F")]
			public InputAction MouseY
			{
				[Token(Token = "0x6000175")]
				[Address(RVA = "0x26F17D0", Offset = "0x26EFDD0", VA = "0x1826F17D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000176 RID: 374 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000040")]
			public InputAction TogglePauseMenu
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x26F17F0", Offset = "0x26EFDF0", VA = "0x1826F17F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000177 RID: 375 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000041")]
			public InputAction Skip
			{
				[Token(Token = "0x6000177")]
				[Address(RVA = "0x26F1810", Offset = "0x26EFE10", VA = "0x1826F1810")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000178 RID: 376 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000042")]
			public InputAction Open
			{
				[Token(Token = "0x6000178")]
				[Address(RVA = "0x26F1830", Offset = "0x26EFE30", VA = "0x1826F1830")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000179 RID: 377 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000043")]
			public InputAction RevivePlayer
			{
				[Token(Token = "0x6000179")]
				[Address(RVA = "0x3080F20", Offset = "0x307F520", VA = "0x183080F20")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x0600017A RID: 378 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000044")]
			public InputAction Sleep
			{
				[Token(Token = "0x600017A")]
				[Address(RVA = "0x3080F40", Offset = "0x307F540", VA = "0x183080F40")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000045")]
			public InputAction Save
			{
				[Token(Token = "0x600017B")]
				[Address(RVA = "0x3080F60", Offset = "0x307F560", VA = "0x183080F60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x0600017C RID: 380 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000046")]
			public InputAction Use
			{
				[Token(Token = "0x600017C")]
				[Address(RVA = "0x3080F80", Offset = "0x307F580", VA = "0x183080F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600017D RID: 381 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000047")]
			public InputAction Take
			{
				[Token(Token = "0x600017D")]
				[Address(RVA = "0x3080FA0", Offset = "0x307F5A0", VA = "0x183080FA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000048")]
			public InputAction Interact
			{
				[Token(Token = "0x600017E")]
				[Address(RVA = "0x3080FC0", Offset = "0x307F5C0", VA = "0x183080FC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x0600017F RID: 383 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000049")]
			public InputAction Place
			{
				[Token(Token = "0x600017F")]
				[Address(RVA = "0x3080FE0", Offset = "0x307F5E0", VA = "0x183080FE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700004A")]
			public InputAction Drop
			{
				[Token(Token = "0x6000180")]
				[Address(RVA = "0x3081000", Offset = "0x307F600", VA = "0x183081000")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000181 RID: 385 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700004B")]
			public InputAction IgniteObject
			{
				[Token(Token = "0x6000181")]
				[Address(RVA = "0x3081020", Offset = "0x307F620", VA = "0x183081020")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000182 RID: 386 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700004C")]
			public InputAction Jump
			{
				[Token(Token = "0x6000182")]
				[Address(RVA = "0x3081040", Offset = "0x307F640", VA = "0x183081040")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000183 RID: 387 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700004D")]
			public InputAction Crouch
			{
				[Token(Token = "0x6000183")]
				[Address(RVA = "0x3081060", Offset = "0x307F660", VA = "0x183081060")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000184 RID: 388 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700004E")]
			public InputAction Run
			{
				[Token(Token = "0x6000184")]
				[Address(RVA = "0x3081080", Offset = "0x307F680", VA = "0x183081080")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000185 RID: 389 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700004F")]
			public InputAction Lighter
			{
				[Token(Token = "0x6000185")]
				[Address(RVA = "0x30810A0", Offset = "0x307F6A0", VA = "0x1830810A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000186 RID: 390 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000050")]
			public InputAction Utility
			{
				[Token(Token = "0x6000186")]
				[Address(RVA = "0x30810C0", Offset = "0x307F6C0", VA = "0x1830810C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000187 RID: 391 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000051")]
			public InputAction GpsTracker
			{
				[Token(Token = "0x6000187")]
				[Address(RVA = "0x30810E0", Offset = "0x307F6E0", VA = "0x1830810E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000188 RID: 392 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000052")]
			public InputAction VoiceChat
			{
				[Token(Token = "0x6000188")]
				[Address(RVA = "0x3081100", Offset = "0x307F700", VA = "0x183081100")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000189 RID: 393 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000053")]
			public InputAction Book
			{
				[Token(Token = "0x6000189")]
				[Address(RVA = "0x3081120", Offset = "0x307F720", VA = "0x183081120")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600018A RID: 394 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000054")]
			public InputAction Rotate
			{
				[Token(Token = "0x600018A")]
				[Address(RVA = "0x3081140", Offset = "0x307F740", VA = "0x183081140")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600018B RID: 395 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000055")]
			public InputAction Vertical
			{
				[Token(Token = "0x600018B")]
				[Address(RVA = "0x3081160", Offset = "0x307F760", VA = "0x183081160")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000056")]
			public InputAction Horizontal
			{
				[Token(Token = "0x600018C")]
				[Address(RVA = "0x3081180", Offset = "0x307F780", VA = "0x183081180")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600018D RID: 397 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000057")]
			public InputAction ShoulderTap
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x30811A0", Offset = "0x307F7A0", VA = "0x1830811A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x0600018E RID: 398 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000058")]
			public InputAction OpenInventory
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x30811C0", Offset = "0x307F7C0", VA = "0x1830811C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x0600018F RID: 399 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000059")]
			public InputAction OpenQuickSelect
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x30811E0", Offset = "0x307F7E0", VA = "0x1830811E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000190 RID: 400 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700005A")]
			public InputAction GoToBuilding
			{
				[Token(Token = "0x6000190")]
				[Address(RVA = "0x3081200", Offset = "0x307F800", VA = "0x183081200")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000191 RID: 401 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700005B")]
			public InputAction BookFlipPageNext
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0x3081220", Offset = "0x307F820", VA = "0x183081220")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000192 RID: 402 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700005C")]
			public InputAction BookFlipPagePrevious
			{
				[Token(Token = "0x6000192")]
				[Address(RVA = "0x3081240", Offset = "0x307F840", VA = "0x183081240")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x26EF650", Offset = "0x26EDC50", VA = "0x1826EF650")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000194 RID: 404 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x26EF670", Offset = "0x26EDC70", VA = "0x1826EF670")]
			public void Enable()
			{
			}

			// Token: 0x06000195 RID: 405 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x26EF6E0", Offset = "0x26EDCE0", VA = "0x1826EF6E0")]
			public void Disable()
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000196 RID: 406 RVA: 0x00002EC4 File Offset: 0x000010C4
			[Token(Token = "0x1700005D")]
			public bool enabled
			{
				[Token(Token = "0x6000196")]
				[Address(RVA = "0x26EF720", Offset = "0x26EDD20", VA = "0x1826EF720")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000197 RID: 407 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1674D60", Offset = "0x1673360", VA = "0x181674D60")]
			public static implicit operator InputActionMap(SonsInputMapping.DefaultActions set)
			{
				return null;
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x3081260", Offset = "0x307F860", VA = "0x183081260")]
			public void SetCallbacks(SonsInputMapping.IDefaultActions instance)
			{
			}

			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		public struct ItemHotkeyActions
		{
			// Token: 0x06000199 RID: 409 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public ItemHotkeyActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600019A RID: 410 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700005E")]
			public InputAction Hotkey1
			{
				[Token(Token = "0x600019A")]
				[Address(RVA = "0x3087200", Offset = "0x3085800", VA = "0x183087200")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600019B RID: 411 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700005F")]
			public InputAction Hotkey2
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0x3087220", Offset = "0x3085820", VA = "0x183087220")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600019C RID: 412 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000060")]
			public InputAction Hotkey3
			{
				[Token(Token = "0x600019C")]
				[Address(RVA = "0x3087240", Offset = "0x3085840", VA = "0x183087240")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600019D RID: 413 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000061")]
			public InputAction Hotkey4
			{
				[Token(Token = "0x600019D")]
				[Address(RVA = "0x3087260", Offset = "0x3085860", VA = "0x183087260")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600019E RID: 414 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000062")]
			public InputAction Hotkey5
			{
				[Token(Token = "0x600019E")]
				[Address(RVA = "0x3087280", Offset = "0x3085880", VA = "0x183087280")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600019F RID: 415 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000063")]
			public InputAction Hotkey6
			{
				[Token(Token = "0x600019F")]
				[Address(RVA = "0x30872A0", Offset = "0x30858A0", VA = "0x1830872A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000064")]
			public InputAction Hotkey7
			{
				[Token(Token = "0x60001A0")]
				[Address(RVA = "0x30872C0", Offset = "0x30858C0", VA = "0x1830872C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000065")]
			public InputAction Hotkey8
			{
				[Token(Token = "0x60001A1")]
				[Address(RVA = "0x30872E0", Offset = "0x30858E0", VA = "0x1830872E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000066")]
			public InputAction Hotkey9
			{
				[Token(Token = "0x60001A2")]
				[Address(RVA = "0x3087300", Offset = "0x3085900", VA = "0x183087300")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000067")]
			public InputAction Hotkey0
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x3087320", Offset = "0x3085920", VA = "0x183087320")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000068")]
			public InputAction SetHotkey1
			{
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0x3087340", Offset = "0x3085940", VA = "0x183087340")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000069")]
			public InputAction SetHotkey2
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0x3087360", Offset = "0x3085960", VA = "0x183087360")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700006A")]
			public InputAction SetHotkey3
			{
				[Token(Token = "0x60001A6")]
				[Address(RVA = "0x3087380", Offset = "0x3085980", VA = "0x183087380")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700006B")]
			public InputAction SetHotkey4
			{
				[Token(Token = "0x60001A7")]
				[Address(RVA = "0x30873A0", Offset = "0x30859A0", VA = "0x1830873A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700006C")]
			public InputAction SetHotkey5
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x30873C0", Offset = "0x30859C0", VA = "0x1830873C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700006D")]
			public InputAction SetHotkey6
			{
				[Token(Token = "0x60001A9")]
				[Address(RVA = "0x30873E0", Offset = "0x30859E0", VA = "0x1830873E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060001AA RID: 426 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700006E")]
			public InputAction SetHotkey7
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x3087400", Offset = "0x3085A00", VA = "0x183087400")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001AB RID: 427 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700006F")]
			public InputAction SetHotkey8
			{
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x3087420", Offset = "0x3085A20", VA = "0x183087420")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001AC RID: 428 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000070")]
			public InputAction SetHotkey9
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x3087440", Offset = "0x3085A40", VA = "0x183087440")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001AD RID: 429 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000071")]
			public InputAction SetHotkey0
			{
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x3087460", Offset = "0x3085A60", VA = "0x183087460")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x3087480", Offset = "0x3085A80", VA = "0x183087480")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x30874A0", Offset = "0x3085AA0", VA = "0x1830874A0")]
			public void Enable()
			{
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x3087520", Offset = "0x3085B20", VA = "0x183087520")]
			public void Disable()
			{
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002EDC File Offset: 0x000010DC
			[Token(Token = "0x17000072")]
			public bool enabled
			{
				[Token(Token = "0x60001B1")]
				[Address(RVA = "0x3087560", Offset = "0x3085B60", VA = "0x183087560")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x3087590", Offset = "0x3085B90", VA = "0x183087590")]
			public static implicit operator InputActionMap(SonsInputMapping.ItemHotkeyActions set)
			{
				return null;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x30875B0", Offset = "0x3085BB0", VA = "0x1830875B0")]
			public void SetCallbacks(SonsInputMapping.IItemHotkeyActions instance)
			{
			}

			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public struct MenuActions
		{
			// Token: 0x060001B4 RID: 436 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public MenuActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000073")]
			public InputAction NextPage
			{
				[Token(Token = "0x60001B5")]
				[Address(RVA = "0x308B830", Offset = "0x3089E30", VA = "0x18308B830")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000074")]
			public InputAction TogglePauseMenu
			{
				[Token(Token = "0x60001B6")]
				[Address(RVA = "0x308B850", Offset = "0x3089E50", VA = "0x18308B850")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000075")]
			public InputAction Confirm
			{
				[Token(Token = "0x60001B7")]
				[Address(RVA = "0x308B870", Offset = "0x3089E70", VA = "0x18308B870")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000076")]
			public InputAction Horizontal
			{
				[Token(Token = "0x60001B8")]
				[Address(RVA = "0x308B890", Offset = "0x3089E90", VA = "0x18308B890")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000077")]
			public InputAction Vertical
			{
				[Token(Token = "0x60001B9")]
				[Address(RVA = "0x308B8B0", Offset = "0x3089EB0", VA = "0x18308B8B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001BA RID: 442 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000078")]
			public InputAction PreviousPage
			{
				[Token(Token = "0x60001BA")]
				[Address(RVA = "0x308B8D0", Offset = "0x3089ED0", VA = "0x18308B8D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001BB RID: 443 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000079")]
			public InputAction Back
			{
				[Token(Token = "0x60001BB")]
				[Address(RVA = "0x308B8F0", Offset = "0x3089EF0", VA = "0x18308B8F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001BC RID: 444 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700007A")]
			public InputAction Apply
			{
				[Token(Token = "0x60001BC")]
				[Address(RVA = "0x308B910", Offset = "0x3089F10", VA = "0x18308B910")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001BD RID: 445 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700007B")]
			public InputAction Reset
			{
				[Token(Token = "0x60001BD")]
				[Address(RVA = "0x308B930", Offset = "0x3089F30", VA = "0x18308B930")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001BE RID: 446 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700007C")]
			public InputAction CycleBack
			{
				[Token(Token = "0x60001BE")]
				[Address(RVA = "0x308B950", Offset = "0x3089F50", VA = "0x18308B950")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001BF RID: 447 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700007D")]
			public InputAction CycleForward
			{
				[Token(Token = "0x60001BF")]
				[Address(RVA = "0x308B970", Offset = "0x3089F70", VA = "0x18308B970")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700007E")]
			public InputAction Console
			{
				[Token(Token = "0x60001C0")]
				[Address(RVA = "0x308B990", Offset = "0x3089F90", VA = "0x18308B990")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x308B9B0", Offset = "0x3089FB0", VA = "0x18308B9B0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x308B9D0", Offset = "0x3089FD0", VA = "0x18308B9D0")]
			public void Enable()
			{
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x308BA50", Offset = "0x308A050", VA = "0x18308BA50")]
			public void Disable()
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002EF4 File Offset: 0x000010F4
			[Token(Token = "0x1700007F")]
			public bool enabled
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x308BA90", Offset = "0x308A090", VA = "0x18308BA90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x308BAC0", Offset = "0x308A0C0", VA = "0x18308BAC0")]
			public static implicit operator InputActionMap(SonsInputMapping.MenuActions set)
			{
				return null;
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x308BAE0", Offset = "0x308A0E0", VA = "0x18308BAE0")]
			public void SetCallbacks(SonsInputMapping.IMenuActions instance)
			{
			}

			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000248")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		public struct InventoryActions
		{
			// Token: 0x060001C7 RID: 455 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public InventoryActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000080")]
			public InputAction MoveCursor
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x308EFE0", Offset = "0x308D5E0", VA = "0x18308EFE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000081")]
			public InputAction Inventory
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x308F000", Offset = "0x308D600", VA = "0x18308F000")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060001CA RID: 458 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000082")]
			public InputAction ClearCraftingMat
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x308F020", Offset = "0x308D620", VA = "0x18308F020")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001CB RID: 459 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000083")]
			public InputAction DropItemFromInventory
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x308F040", Offset = "0x308D640", VA = "0x18308F040")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000084")]
			public InputAction InteractWithItem
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x308F060", Offset = "0x308D660", VA = "0x18308F060")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060001CD RID: 461 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000085")]
			public InputAction AlternateInteractWithItem
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x308F080", Offset = "0x308D680", VA = "0x18308F080")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000086")]
			public InputAction AddItemToMat
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x308F0A0", Offset = "0x308D6A0", VA = "0x18308F0A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000087")]
			public InputAction RemoveItemFromMat
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x308F0C0", Offset = "0x308D6C0", VA = "0x18308F0C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000088")]
			public InputAction Esc
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x308F0E0", Offset = "0x308D6E0", VA = "0x18308F0E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000089")]
			public InputAction Console
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x308F100", Offset = "0x308D700", VA = "0x18308F100")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700008A")]
			public InputAction ToggleQuickSelect
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x308F120", Offset = "0x308D720", VA = "0x18308F120")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x308F140", Offset = "0x308D740", VA = "0x18308F140")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x308F160", Offset = "0x308D760", VA = "0x18308F160")]
			public void Enable()
			{
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x308F1E0", Offset = "0x308D7E0", VA = "0x18308F1E0")]
			public void Disable()
			{
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002F0C File Offset: 0x0000110C
			[Token(Token = "0x1700008B")]
			public bool enabled
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x308F220", Offset = "0x308D820", VA = "0x18308F220")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x308F250", Offset = "0x308D850", VA = "0x18308F250")]
			public static implicit operator InputActionMap(SonsInputMapping.InventoryActions set)
			{
				return null;
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x308F270", Offset = "0x308D870", VA = "0x18308F270")]
			public void SetCallbacks(SonsInputMapping.IInventoryActions instance)
			{
			}

			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public struct ConstructionActions
		{
			// Token: 0x060001D9 RID: 473 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public ConstructionActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700008C")]
			public InputAction PlaceElement
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x30925E0", Offset = "0x3090BE0", VA = "0x1830925E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060001DB RID: 475 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700008D")]
			public InputAction CutElement
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x3092600", Offset = "0x3090C00", VA = "0x183092600")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060001DC RID: 476 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700008E")]
			public InputAction RotateElement
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x3092620", Offset = "0x3090C20", VA = "0x183092620")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060001DD RID: 477 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700008F")]
			public InputAction CancelPlace
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x3092640", Offset = "0x3090C40", VA = "0x183092640")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060001DE RID: 478 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000090")]
			public InputAction TogglePlaceMode
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x3092660", Offset = "0x3090C60", VA = "0x183092660")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060001DF RID: 479 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000091")]
			public InputAction DismantleElement
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x3092680", Offset = "0x3090C80", VA = "0x183092680")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x30926A0", Offset = "0x3090CA0", VA = "0x1830926A0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x30926C0", Offset = "0x3090CC0", VA = "0x1830926C0")]
			public void Enable()
			{
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x3092740", Offset = "0x3090D40", VA = "0x183092740")]
			public void Disable()
			{
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002F24 File Offset: 0x00001124
			[Token(Token = "0x17000092")]
			public bool enabled
			{
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x3092780", Offset = "0x3090D80", VA = "0x183092780")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x30927B0", Offset = "0x3090DB0", VA = "0x1830927B0")]
			public static implicit operator InputActionMap(SonsInputMapping.ConstructionActions set)
			{
				return null;
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x30927D0", Offset = "0x3090DD0", VA = "0x1830927D0")]
			public void SetCallbacks(SonsInputMapping.IConstructionActions instance)
			{
			}

			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		public struct DebugActions
		{
			// Token: 0x060001E6 RID: 486 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public DebugActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000093")]
			public InputAction QuickSave
			{
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x3094970", Offset = "0x3092F70", VA = "0x183094970")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000094")]
			public InputAction QuickLoad
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x3094990", Offset = "0x3092F90", VA = "0x183094990")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000095")]
			public InputAction DebugBreak
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x30949B0", Offset = "0x3092FB0", VA = "0x1830949B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001EA RID: 490 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000096")]
			public InputAction DebugOverlay
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x30949D0", Offset = "0x3092FD0", VA = "0x1830949D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060001EB RID: 491 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000097")]
			public InputAction DebugPlayerStats
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x30949F0", Offset = "0x3092FF0", VA = "0x1830949F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001EC RID: 492 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000098")]
			public InputAction DebugVailStats
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x3094A10", Offset = "0x3093010", VA = "0x183094A10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001ED RID: 493 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000099")]
			public InputAction DebugVailCamera
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x3094A30", Offset = "0x3093030", VA = "0x183094A30")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x3094A50", Offset = "0x3093050", VA = "0x183094A50")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x3094A70", Offset = "0x3093070", VA = "0x183094A70")]
			public void Enable()
			{
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x3094AF0", Offset = "0x30930F0", VA = "0x183094AF0")]
			public void Disable()
			{
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002F3C File Offset: 0x0000113C
			[Token(Token = "0x1700009A")]
			public bool enabled
			{
				[Token(Token = "0x60001F1")]
				[Address(RVA = "0x3094B30", Offset = "0x3093130", VA = "0x183094B30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x3094B60", Offset = "0x3093160", VA = "0x183094B60")]
			public static implicit operator InputActionMap(SonsInputMapping.DebugActions set)
			{
				return null;
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x3094B80", Offset = "0x3093180", VA = "0x183094B80")]
			public void SetCallbacks(SonsInputMapping.IDebugActions instance)
			{
			}

			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		public struct GrabBagActions
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public GrabBagActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700009B")]
			public InputAction MoveCursor
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0x30972A0", Offset = "0x30958A0", VA = "0x1830972A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700009C")]
			public InputAction Console
			{
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x30972C0", Offset = "0x30958C0", VA = "0x1830972C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700009D")]
			public InputAction InteractWithItem
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0x30972E0", Offset = "0x30958E0", VA = "0x1830972E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700009E")]
			public InputAction AlternateInteractWithItem
			{
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0x3097300", Offset = "0x3095900", VA = "0x183097300")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700009F")]
			public InputAction Exit
			{
				[Token(Token = "0x60001F9")]
				[Address(RVA = "0x3097320", Offset = "0x3095920", VA = "0x183097320")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001FA RID: 506 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A0")]
			public InputAction CloseQuickSelect
			{
				[Token(Token = "0x60001FA")]
				[Address(RVA = "0x3097340", Offset = "0x3095940", VA = "0x183097340")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001FB RID: 507 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A1")]
			public InputAction CycleCategory
			{
				[Token(Token = "0x60001FB")]
				[Address(RVA = "0x3097360", Offset = "0x3095960", VA = "0x183097360")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001FC RID: 508 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A2")]
			public InputAction Back
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x3097380", Offset = "0x3095980", VA = "0x183097380")]
				get
				{
					return null;
				}
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x30973A0", Offset = "0x30959A0", VA = "0x1830973A0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x30973C0", Offset = "0x30959C0", VA = "0x1830973C0")]
			public void Enable()
			{
			}

			// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x3097440", Offset = "0x3095A40", VA = "0x183097440")]
			public void Disable()
			{
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000200 RID: 512 RVA: 0x00002F54 File Offset: 0x00001154
			[Token(Token = "0x170000A3")]
			public bool enabled
			{
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x3097480", Offset = "0x3095A80", VA = "0x183097480")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000201 RID: 513 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x30974B0", Offset = "0x3095AB0", VA = "0x1830974B0")]
			public static implicit operator InputActionMap(SonsInputMapping.GrabBagActions set)
			{
				return null;
			}

			// Token: 0x06000202 RID: 514 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x30974D0", Offset = "0x3095AD0", VA = "0x1830974D0")]
			public void SetCallbacks(SonsInputMapping.IGrabBagActions instance)
			{
			}

			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public struct MultiplayerActions
		{
			// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public MultiplayerActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000204 RID: 516 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A4")]
			public InputAction OpenChat
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0x309A170", Offset = "0x3098770", VA = "0x18309A170")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000205 RID: 517 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A5")]
			public InputAction PlayerList
			{
				[Token(Token = "0x6000205")]
				[Address(RVA = "0x309A190", Offset = "0x3098790", VA = "0x18309A190")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000206 RID: 518 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x309A1B0", Offset = "0x30987B0", VA = "0x18309A1B0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x309A1D0", Offset = "0x30987D0", VA = "0x18309A1D0")]
			public void Enable()
			{
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x309A250", Offset = "0x3098850", VA = "0x18309A250")]
			public void Disable()
			{
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000209 RID: 521 RVA: 0x00002F6C File Offset: 0x0000116C
			[Token(Token = "0x170000A6")]
			public bool enabled
			{
				[Token(Token = "0x6000209")]
				[Address(RVA = "0x309A290", Offset = "0x3098890", VA = "0x18309A290")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x309A2C0", Offset = "0x30988C0", VA = "0x18309A2C0")]
			public static implicit operator InputActionMap(SonsInputMapping.MultiplayerActions set)
			{
				return null;
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x309A2E0", Offset = "0x30988E0", VA = "0x18309A2E0")]
			public void SetCallbacks(SonsInputMapping.IMultiplayerActions instance)
			{
			}

			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public struct TextInputActions
		{
			// Token: 0x0600020C RID: 524 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public TextInputActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600020D RID: 525 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A7")]
			public InputAction Submit
			{
				[Token(Token = "0x600020D")]
				[Address(RVA = "0x309AE90", Offset = "0x3099490", VA = "0x18309AE90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x0600020E RID: 526 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000A8")]
			public InputAction Esc
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x309AEB0", Offset = "0x30994B0", VA = "0x18309AEB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600020F RID: 527 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x309AED0", Offset = "0x30994D0", VA = "0x18309AED0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x309AEF0", Offset = "0x30994F0", VA = "0x18309AEF0")]
			public void Enable()
			{
			}

			// Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x309AF70", Offset = "0x3099570", VA = "0x18309AF70")]
			public void Disable()
			{
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000212 RID: 530 RVA: 0x00002F84 File Offset: 0x00001184
			[Token(Token = "0x170000A9")]
			public bool enabled
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x309AFB0", Offset = "0x30995B0", VA = "0x18309AFB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x309AFE0", Offset = "0x30995E0", VA = "0x18309AFE0")]
			public static implicit operator InputActionMap(SonsInputMapping.TextInputActions set)
			{
				return null;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x309B000", Offset = "0x3099600", VA = "0x18309B000")]
			public void SetCallbacks(SonsInputMapping.ITextInputActions instance)
			{
			}

			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public struct ConsoleActions
		{
			// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public ConsoleActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000216 RID: 534 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000AA")]
			public InputAction Submit
			{
				[Token(Token = "0x6000216")]
				[Address(RVA = "0x309BBB0", Offset = "0x309A1B0", VA = "0x18309BBB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000217 RID: 535 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000AB")]
			public InputAction Close
			{
				[Token(Token = "0x6000217")]
				[Address(RVA = "0x309BBD0", Offset = "0x309A1D0", VA = "0x18309BBD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000218 RID: 536 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000AC")]
			public InputAction Console
			{
				[Token(Token = "0x6000218")]
				[Address(RVA = "0x309BBF0", Offset = "0x309A1F0", VA = "0x18309BBF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000219 RID: 537 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000AD")]
			public InputAction HistoryBack
			{
				[Token(Token = "0x6000219")]
				[Address(RVA = "0x309BC10", Offset = "0x309A210", VA = "0x18309BC10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600021A RID: 538 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000AE")]
			public InputAction HistoryForward
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0x309BC30", Offset = "0x309A230", VA = "0x18309BC30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600021B RID: 539 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000AF")]
			public InputAction AutoComplete
			{
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x309BC50", Offset = "0x309A250", VA = "0x18309BC50")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600021C RID: 540 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B0")]
			public InputAction ClearLogs
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x309BC70", Offset = "0x309A270", VA = "0x18309BC70")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x309BC90", Offset = "0x309A290", VA = "0x18309BC90")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x309BCB0", Offset = "0x309A2B0", VA = "0x18309BCB0")]
			public void Enable()
			{
			}

			// Token: 0x0600021F RID: 543 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x309BD30", Offset = "0x309A330", VA = "0x18309BD30")]
			public void Disable()
			{
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000220 RID: 544 RVA: 0x00002F9C File Offset: 0x0000119C
			[Token(Token = "0x170000B1")]
			public bool enabled
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x309BD70", Offset = "0x309A370", VA = "0x18309BD70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000221 RID: 545 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x309BDA0", Offset = "0x309A3A0", VA = "0x18309BDA0")]
			public static implicit operator InputActionMap(SonsInputMapping.ConsoleActions set)
			{
				return null;
			}

			// Token: 0x06000222 RID: 546 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x309BDC0", Offset = "0x309A3C0", VA = "0x18309BDC0")]
			public void SetCallbacks(SonsInputMapping.IConsoleActions instance)
			{
			}

			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public struct StructureCraftingActions
		{
			// Token: 0x06000223 RID: 547 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public StructureCraftingActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000224 RID: 548 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B2")]
			public InputAction AddIngredient
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0x309E4E0", Offset = "0x309CAE0", VA = "0x18309E4E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000225 RID: 549 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B3")]
			public InputAction Back
			{
				[Token(Token = "0x6000225")]
				[Address(RVA = "0x309E500", Offset = "0x309CB00", VA = "0x18309E500")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000226 RID: 550 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B4")]
			public InputAction Lighter
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x309E520", Offset = "0x309CB20", VA = "0x18309E520")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000227 RID: 551 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B5")]
			public InputAction Utility
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x309E540", Offset = "0x309CB40", VA = "0x18309E540")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000228 RID: 552 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B6")]
			public InputAction GpsTracker
			{
				[Token(Token = "0x6000228")]
				[Address(RVA = "0x309E560", Offset = "0x309CB60", VA = "0x18309E560")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000229 RID: 553 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B7")]
			public InputAction VoiceChat
			{
				[Token(Token = "0x6000229")]
				[Address(RVA = "0x309E580", Offset = "0x309CB80", VA = "0x18309E580")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600022A RID: 554 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B8")]
			public InputAction Drop
			{
				[Token(Token = "0x600022A")]
				[Address(RVA = "0x309E5A0", Offset = "0x309CBA0", VA = "0x18309E5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600022B RID: 555 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000B9")]
			public InputAction Book
			{
				[Token(Token = "0x600022B")]
				[Address(RVA = "0x309E5C0", Offset = "0x309CBC0", VA = "0x18309E5C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600022C RID: 556 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000BA")]
			public InputAction GoToTutorials
			{
				[Token(Token = "0x600022C")]
				[Address(RVA = "0x309E5E0", Offset = "0x309CBE0", VA = "0x18309E5E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x0600022D RID: 557 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000BB")]
			public InputAction PrimaryAction
			{
				[Token(Token = "0x600022D")]
				[Address(RVA = "0x309E600", Offset = "0x309CC00", VA = "0x18309E600")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600022E RID: 558 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000BC")]
			public InputAction SecondaryAction
			{
				[Token(Token = "0x600022E")]
				[Address(RVA = "0x309E620", Offset = "0x309CC20", VA = "0x18309E620")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600022F RID: 559 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000BD")]
			public InputAction MoveCursor
			{
				[Token(Token = "0x600022F")]
				[Address(RVA = "0x309E640", Offset = "0x309CC40", VA = "0x18309E640")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000230 RID: 560 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000BE")]
			public InputAction OpenQuickSelect
			{
				[Token(Token = "0x6000230")]
				[Address(RVA = "0x309E660", Offset = "0x309CC60", VA = "0x18309E660")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000231 RID: 561 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000BF")]
			public InputAction OpenInventory
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x309E680", Offset = "0x309CC80", VA = "0x18309E680")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000232 RID: 562 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C0")]
			public InputAction Console
			{
				[Token(Token = "0x6000232")]
				[Address(RVA = "0x309E6A0", Offset = "0x309CCA0", VA = "0x18309E6A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000233 RID: 563 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C1")]
			public InputAction Unequip
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x309E6C0", Offset = "0x309CCC0", VA = "0x18309E6C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000234 RID: 564 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C2")]
			public InputAction Horizontal
			{
				[Token(Token = "0x6000234")]
				[Address(RVA = "0x309E6E0", Offset = "0x309CCE0", VA = "0x18309E6E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000235 RID: 565 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C3")]
			public InputAction Vertical
			{
				[Token(Token = "0x6000235")]
				[Address(RVA = "0x309E700", Offset = "0x309CD00", VA = "0x18309E700")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000236 RID: 566 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C4")]
			public InputAction Run
			{
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x309E720", Offset = "0x309CD20", VA = "0x18309E720")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000237 RID: 567 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C5")]
			public InputAction Crouch
			{
				[Token(Token = "0x6000237")]
				[Address(RVA = "0x309E740", Offset = "0x309CD40", VA = "0x18309E740")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000238 RID: 568 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C6")]
			public InputAction Jump
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x309E760", Offset = "0x309CD60", VA = "0x18309E760")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000239 RID: 569 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C7")]
			public InputAction MouseY
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x309E780", Offset = "0x309CD80", VA = "0x18309E780")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x0600023A RID: 570 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C8")]
			public InputAction MouseX
			{
				[Token(Token = "0x600023A")]
				[Address(RVA = "0x309E7A0", Offset = "0x309CDA0", VA = "0x18309E7A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600023B RID: 571 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000C9")]
			public InputAction Rotate
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x309E7C0", Offset = "0x309CDC0", VA = "0x18309E7C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600023C RID: 572 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000CA")]
			public InputAction CancelStructure
			{
				[Token(Token = "0x600023C")]
				[Address(RVA = "0x309E7E0", Offset = "0x309CDE0", VA = "0x18309E7E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x0600023D RID: 573 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000CB")]
			public InputAction SelectStructure
			{
				[Token(Token = "0x600023D")]
				[Address(RVA = "0x309E800", Offset = "0x309CE00", VA = "0x18309E800")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x309E820", Offset = "0x309CE20", VA = "0x18309E820")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x309E840", Offset = "0x309CE40", VA = "0x18309E840")]
			public void Enable()
			{
			}

			// Token: 0x06000240 RID: 576 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x309E8C0", Offset = "0x309CEC0", VA = "0x18309E8C0")]
			public void Disable()
			{
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000241 RID: 577 RVA: 0x00002FB4 File Offset: 0x000011B4
			[Token(Token = "0x170000CC")]
			public bool enabled
			{
				[Token(Token = "0x6000241")]
				[Address(RVA = "0x309E900", Offset = "0x309CF00", VA = "0x18309E900")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x309E930", Offset = "0x309CF30", VA = "0x18309E930")]
			public static implicit operator InputActionMap(SonsInputMapping.StructureCraftingActions set)
			{
				return null;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x309E950", Offset = "0x309CF50", VA = "0x18309E950")]
			public void SetCallbacks(SonsInputMapping.IStructureCraftingActions instance)
			{
			}

			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		public struct GameOverActions
		{
			// Token: 0x06000244 RID: 580 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public GameOverActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000245 RID: 581 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000CD")]
			public InputAction Console
			{
				[Token(Token = "0x6000245")]
				[Address(RVA = "0x30A3570", Offset = "0x30A1B70", VA = "0x1830A3570")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000246 RID: 582 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000CE")]
			public InputAction Back
			{
				[Token(Token = "0x6000246")]
				[Address(RVA = "0x30A3590", Offset = "0x30A1B90", VA = "0x1830A3590")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x30A35B0", Offset = "0x30A1BB0", VA = "0x1830A35B0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x30A35D0", Offset = "0x30A1BD0", VA = "0x1830A35D0")]
			public void Enable()
			{
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x30A3650", Offset = "0x30A1C50", VA = "0x1830A3650")]
			public void Disable()
			{
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x0600024A RID: 586 RVA: 0x00002FCC File Offset: 0x000011CC
			[Token(Token = "0x170000CF")]
			public bool enabled
			{
				[Token(Token = "0x600024A")]
				[Address(RVA = "0x30A3690", Offset = "0x30A1C90", VA = "0x1830A3690")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600024B RID: 587 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x30A36C0", Offset = "0x30A1CC0", VA = "0x1830A36C0")]
			public static implicit operator InputActionMap(SonsInputMapping.GameOverActions set)
			{
				return null;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x30A36E0", Offset = "0x30A1CE0", VA = "0x1830A36E0")]
			public void SetCallbacks(SonsInputMapping.IGameOverActions instance)
			{
			}

			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		public struct FirstDeathActions
		{
			// Token: 0x0600024D RID: 589 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public FirstDeathActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x0600024E RID: 590 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D0")]
			public InputAction Use
			{
				[Token(Token = "0x600024E")]
				[Address(RVA = "0x30A4290", Offset = "0x30A2890", VA = "0x1830A4290")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x0600024F RID: 591 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D1")]
			public InputAction Console
			{
				[Token(Token = "0x600024F")]
				[Address(RVA = "0x30A42B0", Offset = "0x30A28B0", VA = "0x1830A42B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000250 RID: 592 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x30A42D0", Offset = "0x30A28D0", VA = "0x1830A42D0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000251 RID: 593 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x30A42F0", Offset = "0x30A28F0", VA = "0x1830A42F0")]
			public void Enable()
			{
			}

			// Token: 0x06000252 RID: 594 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x30A4370", Offset = "0x30A2970", VA = "0x1830A4370")]
			public void Disable()
			{
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x06000253 RID: 595 RVA: 0x00002FE4 File Offset: 0x000011E4
			[Token(Token = "0x170000D2")]
			public bool enabled
			{
				[Token(Token = "0x6000253")]
				[Address(RVA = "0x30A43B0", Offset = "0x30A29B0", VA = "0x1830A43B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000254 RID: 596 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x30A43E0", Offset = "0x30A29E0", VA = "0x1830A43E0")]
			public static implicit operator InputActionMap(SonsInputMapping.FirstDeathActions set)
			{
				return null;
			}

			// Token: 0x06000255 RID: 597 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x30A4400", Offset = "0x30A2A00", VA = "0x1830A4400")]
			public void SetCallbacks(SonsInputMapping.IFirstDeathActions instance)
			{
			}

			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public struct InputBindingActions
		{
			// Token: 0x06000256 RID: 598 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public InputBindingActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x06000257 RID: 599 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D3")]
			public InputAction Cancel
			{
				[Token(Token = "0x6000257")]
				[Address(RVA = "0x30A4FB0", Offset = "0x30A35B0", VA = "0x1830A4FB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000258 RID: 600 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x30A4FD0", Offset = "0x30A35D0", VA = "0x1830A4FD0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000259 RID: 601 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x30A4FF0", Offset = "0x30A35F0", VA = "0x1830A4FF0")]
			public void Enable()
			{
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x30A5070", Offset = "0x30A3670", VA = "0x1830A5070")]
			public void Disable()
			{
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00002FFC File Offset: 0x000011FC
			[Token(Token = "0x170000D4")]
			public bool enabled
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x30A50B0", Offset = "0x30A36B0", VA = "0x1830A50B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600025C RID: 604 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x30A50E0", Offset = "0x30A36E0", VA = "0x1830A50E0")]
			public static implicit operator InputActionMap(SonsInputMapping.InputBindingActions set)
			{
				return null;
			}

			// Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x30A5100", Offset = "0x30A3700", VA = "0x1830A5100")]
			public void SetCallbacks(SonsInputMapping.IInputBindingActions instance)
			{
			}

			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		public struct ModalDialogActions
		{
			// Token: 0x0600025E RID: 606 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public ModalDialogActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x0600025F RID: 607 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D5")]
			public InputAction ConfirmModal
			{
				[Token(Token = "0x600025F")]
				[Address(RVA = "0x30A5730", Offset = "0x30A3D30", VA = "0x1830A5730")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000260 RID: 608 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D6")]
			public InputAction CancelModal
			{
				[Token(Token = "0x6000260")]
				[Address(RVA = "0x30A5750", Offset = "0x30A3D50", VA = "0x1830A5750")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x30A5770", Offset = "0x30A3D70", VA = "0x1830A5770")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x30A5790", Offset = "0x30A3D90", VA = "0x1830A5790")]
			public void Enable()
			{
			}

			// Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x30A5810", Offset = "0x30A3E10", VA = "0x1830A5810")]
			public void Disable()
			{
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000264 RID: 612 RVA: 0x00003014 File Offset: 0x00001214
			[Token(Token = "0x170000D7")]
			public bool enabled
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x30A5850", Offset = "0x30A3E50", VA = "0x1830A5850")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000265 RID: 613 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x30A5880", Offset = "0x30A3E80", VA = "0x1830A5880")]
			public static implicit operator InputActionMap(SonsInputMapping.ModalDialogActions set)
			{
				return null;
			}

			// Token: 0x06000266 RID: 614 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x30A58A0", Offset = "0x30A3EA0", VA = "0x1830A58A0")]
			public void SetCallbacks(SonsInputMapping.IModalDialogActions instance)
			{
			}

			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		public struct CutsceneActions
		{
			// Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public CutsceneActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x06000268 RID: 616 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D8")]
			public InputAction Back
			{
				[Token(Token = "0x6000268")]
				[Address(RVA = "0x30A6450", Offset = "0x30A4A50", VA = "0x1830A6450")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x06000269 RID: 617 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000D9")]
			public InputAction MouseY
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x30A6470", Offset = "0x30A4A70", VA = "0x1830A6470")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x0600026A RID: 618 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000DA")]
			public InputAction MouseX
			{
				[Token(Token = "0x600026A")]
				[Address(RVA = "0x30A6490", Offset = "0x30A4A90", VA = "0x1830A6490")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600026B RID: 619 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000DB")]
			public InputAction Horizontal
			{
				[Token(Token = "0x600026B")]
				[Address(RVA = "0x30A64B0", Offset = "0x30A4AB0", VA = "0x1830A64B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600026C RID: 620 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000DC")]
			public InputAction Skip
			{
				[Token(Token = "0x600026C")]
				[Address(RVA = "0x30A64D0", Offset = "0x30A4AD0", VA = "0x1830A64D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600026D RID: 621 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000DD")]
			public InputAction Open
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0x30A64F0", Offset = "0x30A4AF0", VA = "0x1830A64F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x0600026E RID: 622 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000DE")]
			public InputAction Interact
			{
				[Token(Token = "0x600026E")]
				[Address(RVA = "0x30A6510", Offset = "0x30A4B10", VA = "0x1830A6510")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x30A6530", Offset = "0x30A4B30", VA = "0x1830A6530")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x30A6550", Offset = "0x30A4B50", VA = "0x1830A6550")]
			public void Enable()
			{
			}

			// Token: 0x06000271 RID: 625 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x30A65D0", Offset = "0x30A4BD0", VA = "0x1830A65D0")]
			public void Disable()
			{
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000272 RID: 626 RVA: 0x0000302C File Offset: 0x0000122C
			[Token(Token = "0x170000DF")]
			public bool enabled
			{
				[Token(Token = "0x6000272")]
				[Address(RVA = "0x30A6610", Offset = "0x30A4C10", VA = "0x1830A6610")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x30A6640", Offset = "0x30A4C40", VA = "0x1830A6640")]
			public static implicit operator InputActionMap(SonsInputMapping.CutsceneActions set)
			{
				return null;
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x30A6660", Offset = "0x30A4C60", VA = "0x1830A6660")]
			public void SetCallbacks(SonsInputMapping.ICutsceneActions instance)
			{
			}

			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public struct VehicleActions
		{
			// Token: 0x06000275 RID: 629 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public VehicleActions(SonsInputMapping wrapper)
			{
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x06000276 RID: 630 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000E0")]
			public InputAction Boost
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0x30A8D80", Offset = "0x30A7380", VA = "0x1830A8D80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000277 RID: 631 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000E1")]
			public InputAction HandBrake
			{
				[Token(Token = "0x6000277")]
				[Address(RVA = "0x30A8DA0", Offset = "0x30A73A0", VA = "0x1830A8DA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000278 RID: 632 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000E2")]
			public InputAction Throttle
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x30A8DC0", Offset = "0x30A73C0", VA = "0x1830A8DC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000279 RID: 633 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000E3")]
			public InputAction Reverse
			{
				[Token(Token = "0x6000279")]
				[Address(RVA = "0x30A8DE0", Offset = "0x30A73E0", VA = "0x1830A8DE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x0600027A RID: 634 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170000E4")]
			public InputAction Turn
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x30A8E00", Offset = "0x30A7400", VA = "0x1830A8E00")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x30A8E20", Offset = "0x30A7420", VA = "0x1830A8E20")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x30A8E40", Offset = "0x30A7440", VA = "0x1830A8E40")]
			public void Enable()
			{
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x30A8EC0", Offset = "0x30A74C0", VA = "0x1830A8EC0")]
			public void Disable()
			{
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x0600027E RID: 638 RVA: 0x00003044 File Offset: 0x00001244
			[Token(Token = "0x170000E5")]
			public bool enabled
			{
				[Token(Token = "0x600027E")]
				[Address(RVA = "0x30A8F00", Offset = "0x30A7500", VA = "0x1830A8F00")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x30A8F30", Offset = "0x30A7530", VA = "0x1830A8F30")]
			public static implicit operator InputActionMap(SonsInputMapping.VehicleActions set)
			{
				return null;
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x30A8F50", Offset = "0x30A7550", VA = "0x1830A8F50")]
			public void SetCallbacks(SonsInputMapping.IVehicleActions instance)
			{
			}

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x0")]
			private SonsInputMapping m_Wrapper;
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		public interface IDefaultActions
		{
			// Token: 0x06000281 RID: 641
			[Token(Token = "0x6000281")]
			void OnConsole(InputAction.CallbackContext context);

			// Token: 0x06000282 RID: 642
			[Token(Token = "0x6000282")]
			void OnBack(InputAction.CallbackContext context);

			// Token: 0x06000283 RID: 643
			[Token(Token = "0x6000283")]
			void OnPrimaryAction(InputAction.CallbackContext context);

			// Token: 0x06000284 RID: 644
			[Token(Token = "0x6000284")]
			void OnSecondaryAction(InputAction.CallbackContext context);

			// Token: 0x06000285 RID: 645
			[Token(Token = "0x6000285")]
			void OnTertiaryAction(InputAction.CallbackContext context);

			// Token: 0x06000286 RID: 646
			[Token(Token = "0x6000286")]
			void OnReload(InputAction.CallbackContext context);

			// Token: 0x06000287 RID: 647
			[Token(Token = "0x6000287")]
			void OnMoveCursor(InputAction.CallbackContext context);

			// Token: 0x06000288 RID: 648
			[Token(Token = "0x6000288")]
			void OnMouseX(InputAction.CallbackContext context);

			// Token: 0x06000289 RID: 649
			[Token(Token = "0x6000289")]
			void OnMouseY(InputAction.CallbackContext context);

			// Token: 0x0600028A RID: 650
			[Token(Token = "0x600028A")]
			void OnTogglePauseMenu(InputAction.CallbackContext context);

			// Token: 0x0600028B RID: 651
			[Token(Token = "0x600028B")]
			void OnSkip(InputAction.CallbackContext context);

			// Token: 0x0600028C RID: 652
			[Token(Token = "0x600028C")]
			void OnOpen(InputAction.CallbackContext context);

			// Token: 0x0600028D RID: 653
			[Token(Token = "0x600028D")]
			void OnRevivePlayer(InputAction.CallbackContext context);

			// Token: 0x0600028E RID: 654
			[Token(Token = "0x600028E")]
			void OnSleep(InputAction.CallbackContext context);

			// Token: 0x0600028F RID: 655
			[Token(Token = "0x600028F")]
			void OnSave(InputAction.CallbackContext context);

			// Token: 0x06000290 RID: 656
			[Token(Token = "0x6000290")]
			void OnUse(InputAction.CallbackContext context);

			// Token: 0x06000291 RID: 657
			[Token(Token = "0x6000291")]
			void OnTake(InputAction.CallbackContext context);

			// Token: 0x06000292 RID: 658
			[Token(Token = "0x6000292")]
			void OnInteract(InputAction.CallbackContext context);

			// Token: 0x06000293 RID: 659
			[Token(Token = "0x6000293")]
			void OnPlace(InputAction.CallbackContext context);

			// Token: 0x06000294 RID: 660
			[Token(Token = "0x6000294")]
			void OnDrop(InputAction.CallbackContext context);

			// Token: 0x06000295 RID: 661
			[Token(Token = "0x6000295")]
			void OnIgniteObject(InputAction.CallbackContext context);

			// Token: 0x06000296 RID: 662
			[Token(Token = "0x6000296")]
			void OnJump(InputAction.CallbackContext context);

			// Token: 0x06000297 RID: 663
			[Token(Token = "0x6000297")]
			void OnCrouch(InputAction.CallbackContext context);

			// Token: 0x06000298 RID: 664
			[Token(Token = "0x6000298")]
			void OnRun(InputAction.CallbackContext context);

			// Token: 0x06000299 RID: 665
			[Token(Token = "0x6000299")]
			void OnLighter(InputAction.CallbackContext context);

			// Token: 0x0600029A RID: 666
			[Token(Token = "0x600029A")]
			void OnUtility(InputAction.CallbackContext context);

			// Token: 0x0600029B RID: 667
			[Token(Token = "0x600029B")]
			void OnGpsTracker(InputAction.CallbackContext context);

			// Token: 0x0600029C RID: 668
			[Token(Token = "0x600029C")]
			void OnVoiceChat(InputAction.CallbackContext context);

			// Token: 0x0600029D RID: 669
			[Token(Token = "0x600029D")]
			void OnBook(InputAction.CallbackContext context);

			// Token: 0x0600029E RID: 670
			[Token(Token = "0x600029E")]
			void OnRotate(InputAction.CallbackContext context);

			// Token: 0x0600029F RID: 671
			[Token(Token = "0x600029F")]
			void OnVertical(InputAction.CallbackContext context);

			// Token: 0x060002A0 RID: 672
			[Token(Token = "0x60002A0")]
			void OnHorizontal(InputAction.CallbackContext context);

			// Token: 0x060002A1 RID: 673
			[Token(Token = "0x60002A1")]
			void OnShoulderTap(InputAction.CallbackContext context);

			// Token: 0x060002A2 RID: 674
			[Token(Token = "0x60002A2")]
			void OnOpenInventory(InputAction.CallbackContext context);

			// Token: 0x060002A3 RID: 675
			[Token(Token = "0x60002A3")]
			void OnOpenQuickSelect(InputAction.CallbackContext context);

			// Token: 0x060002A4 RID: 676
			[Token(Token = "0x60002A4")]
			void OnGoToBuilding(InputAction.CallbackContext context);

			// Token: 0x060002A5 RID: 677
			[Token(Token = "0x60002A5")]
			void OnBookFlipPageNext(InputAction.CallbackContext context);

			// Token: 0x060002A6 RID: 678
			[Token(Token = "0x60002A6")]
			void OnBookFlipPagePrevious(InputAction.CallbackContext context);
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		public interface IItemHotkeyActions
		{
			// Token: 0x060002A7 RID: 679
			[Token(Token = "0x60002A7")]
			void OnHotkey1(InputAction.CallbackContext context);

			// Token: 0x060002A8 RID: 680
			[Token(Token = "0x60002A8")]
			void OnHotkey2(InputAction.CallbackContext context);

			// Token: 0x060002A9 RID: 681
			[Token(Token = "0x60002A9")]
			void OnHotkey3(InputAction.CallbackContext context);

			// Token: 0x060002AA RID: 682
			[Token(Token = "0x60002AA")]
			void OnHotkey4(InputAction.CallbackContext context);

			// Token: 0x060002AB RID: 683
			[Token(Token = "0x60002AB")]
			void OnHotkey5(InputAction.CallbackContext context);

			// Token: 0x060002AC RID: 684
			[Token(Token = "0x60002AC")]
			void OnHotkey6(InputAction.CallbackContext context);

			// Token: 0x060002AD RID: 685
			[Token(Token = "0x60002AD")]
			void OnHotkey7(InputAction.CallbackContext context);

			// Token: 0x060002AE RID: 686
			[Token(Token = "0x60002AE")]
			void OnHotkey8(InputAction.CallbackContext context);

			// Token: 0x060002AF RID: 687
			[Token(Token = "0x60002AF")]
			void OnHotkey9(InputAction.CallbackContext context);

			// Token: 0x060002B0 RID: 688
			[Token(Token = "0x60002B0")]
			void OnHotkey0(InputAction.CallbackContext context);

			// Token: 0x060002B1 RID: 689
			[Token(Token = "0x60002B1")]
			void OnSetHotkey1(InputAction.CallbackContext context);

			// Token: 0x060002B2 RID: 690
			[Token(Token = "0x60002B2")]
			void OnSetHotkey2(InputAction.CallbackContext context);

			// Token: 0x060002B3 RID: 691
			[Token(Token = "0x60002B3")]
			void OnSetHotkey3(InputAction.CallbackContext context);

			// Token: 0x060002B4 RID: 692
			[Token(Token = "0x60002B4")]
			void OnSetHotkey4(InputAction.CallbackContext context);

			// Token: 0x060002B5 RID: 693
			[Token(Token = "0x60002B5")]
			void OnSetHotkey5(InputAction.CallbackContext context);

			// Token: 0x060002B6 RID: 694
			[Token(Token = "0x60002B6")]
			void OnSetHotkey6(InputAction.CallbackContext context);

			// Token: 0x060002B7 RID: 695
			[Token(Token = "0x60002B7")]
			void OnSetHotkey7(InputAction.CallbackContext context);

			// Token: 0x060002B8 RID: 696
			[Token(Token = "0x60002B8")]
			void OnSetHotkey8(InputAction.CallbackContext context);

			// Token: 0x060002B9 RID: 697
			[Token(Token = "0x60002B9")]
			void OnSetHotkey9(InputAction.CallbackContext context);

			// Token: 0x060002BA RID: 698
			[Token(Token = "0x60002BA")]
			void OnSetHotkey0(InputAction.CallbackContext context);
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		public interface IMenuActions
		{
			// Token: 0x060002BB RID: 699
			[Token(Token = "0x60002BB")]
			void OnNextPage(InputAction.CallbackContext context);

			// Token: 0x060002BC RID: 700
			[Token(Token = "0x60002BC")]
			void OnTogglePauseMenu(InputAction.CallbackContext context);

			// Token: 0x060002BD RID: 701
			[Token(Token = "0x60002BD")]
			void OnConfirm(InputAction.CallbackContext context);

			// Token: 0x060002BE RID: 702
			[Token(Token = "0x60002BE")]
			void OnHorizontal(InputAction.CallbackContext context);

			// Token: 0x060002BF RID: 703
			[Token(Token = "0x60002BF")]
			void OnVertical(InputAction.CallbackContext context);

			// Token: 0x060002C0 RID: 704
			[Token(Token = "0x60002C0")]
			void OnPreviousPage(InputAction.CallbackContext context);

			// Token: 0x060002C1 RID: 705
			[Token(Token = "0x60002C1")]
			void OnBack(InputAction.CallbackContext context);

			// Token: 0x060002C2 RID: 706
			[Token(Token = "0x60002C2")]
			void OnApply(InputAction.CallbackContext context);

			// Token: 0x060002C3 RID: 707
			[Token(Token = "0x60002C3")]
			void OnReset(InputAction.CallbackContext context);

			// Token: 0x060002C4 RID: 708
			[Token(Token = "0x60002C4")]
			void OnCycleBack(InputAction.CallbackContext context);

			// Token: 0x060002C5 RID: 709
			[Token(Token = "0x60002C5")]
			void OnCycleForward(InputAction.CallbackContext context);

			// Token: 0x060002C6 RID: 710
			[Token(Token = "0x60002C6")]
			void OnConsole(InputAction.CallbackContext context);
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public interface IInventoryActions
		{
			// Token: 0x060002C7 RID: 711
			[Token(Token = "0x60002C7")]
			void OnMoveCursor(InputAction.CallbackContext context);

			// Token: 0x060002C8 RID: 712
			[Token(Token = "0x60002C8")]
			void OnInventory(InputAction.CallbackContext context);

			// Token: 0x060002C9 RID: 713
			[Token(Token = "0x60002C9")]
			void OnClearCraftingMat(InputAction.CallbackContext context);

			// Token: 0x060002CA RID: 714
			[Token(Token = "0x60002CA")]
			void OnDropItemFromInventory(InputAction.CallbackContext context);

			// Token: 0x060002CB RID: 715
			[Token(Token = "0x60002CB")]
			void OnInteractWithItem(InputAction.CallbackContext context);

			// Token: 0x060002CC RID: 716
			[Token(Token = "0x60002CC")]
			void OnAlternateInteractWithItem(InputAction.CallbackContext context);

			// Token: 0x060002CD RID: 717
			[Token(Token = "0x60002CD")]
			void OnAddItemToMat(InputAction.CallbackContext context);

			// Token: 0x060002CE RID: 718
			[Token(Token = "0x60002CE")]
			void OnRemoveItemFromMat(InputAction.CallbackContext context);

			// Token: 0x060002CF RID: 719
			[Token(Token = "0x60002CF")]
			void OnEsc(InputAction.CallbackContext context);

			// Token: 0x060002D0 RID: 720
			[Token(Token = "0x60002D0")]
			void OnConsole(InputAction.CallbackContext context);

			// Token: 0x060002D1 RID: 721
			[Token(Token = "0x60002D1")]
			void OnToggleQuickSelect(InputAction.CallbackContext context);
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		public interface IConstructionActions
		{
			// Token: 0x060002D2 RID: 722
			[Token(Token = "0x60002D2")]
			void OnPlaceElement(InputAction.CallbackContext context);

			// Token: 0x060002D3 RID: 723
			[Token(Token = "0x60002D3")]
			void OnCutElement(InputAction.CallbackContext context);

			// Token: 0x060002D4 RID: 724
			[Token(Token = "0x60002D4")]
			void OnRotateElement(InputAction.CallbackContext context);

			// Token: 0x060002D5 RID: 725
			[Token(Token = "0x60002D5")]
			void OnCancelPlace(InputAction.CallbackContext context);

			// Token: 0x060002D6 RID: 726
			[Token(Token = "0x60002D6")]
			void OnTogglePlaceMode(InputAction.CallbackContext context);

			// Token: 0x060002D7 RID: 727
			[Token(Token = "0x60002D7")]
			void OnDismantleElement(InputAction.CallbackContext context);
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		public interface IDebugActions
		{
			// Token: 0x060002D8 RID: 728
			[Token(Token = "0x60002D8")]
			void OnQuickSave(InputAction.CallbackContext context);

			// Token: 0x060002D9 RID: 729
			[Token(Token = "0x60002D9")]
			void OnQuickLoad(InputAction.CallbackContext context);

			// Token: 0x060002DA RID: 730
			[Token(Token = "0x60002DA")]
			void OnDebugBreak(InputAction.CallbackContext context);

			// Token: 0x060002DB RID: 731
			[Token(Token = "0x60002DB")]
			void OnDebugOverlay(InputAction.CallbackContext context);

			// Token: 0x060002DC RID: 732
			[Token(Token = "0x60002DC")]
			void OnDebugPlayerStats(InputAction.CallbackContext context);

			// Token: 0x060002DD RID: 733
			[Token(Token = "0x60002DD")]
			void OnDebugVailStats(InputAction.CallbackContext context);

			// Token: 0x060002DE RID: 734
			[Token(Token = "0x60002DE")]
			void OnDebugVailCamera(InputAction.CallbackContext context);
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		public interface IGrabBagActions
		{
			// Token: 0x060002DF RID: 735
			[Token(Token = "0x60002DF")]
			void OnMoveCursor(InputAction.CallbackContext context);

			// Token: 0x060002E0 RID: 736
			[Token(Token = "0x60002E0")]
			void OnConsole(InputAction.CallbackContext context);

			// Token: 0x060002E1 RID: 737
			[Token(Token = "0x60002E1")]
			void OnInteractWithItem(InputAction.CallbackContext context);

			// Token: 0x060002E2 RID: 738
			[Token(Token = "0x60002E2")]
			void OnAlternateInteractWithItem(InputAction.CallbackContext context);

			// Token: 0x060002E3 RID: 739
			[Token(Token = "0x60002E3")]
			void OnExit(InputAction.CallbackContext context);

			// Token: 0x060002E4 RID: 740
			[Token(Token = "0x60002E4")]
			void OnCloseQuickSelect(InputAction.CallbackContext context);

			// Token: 0x060002E5 RID: 741
			[Token(Token = "0x60002E5")]
			void OnCycleCategory(InputAction.CallbackContext context);

			// Token: 0x060002E6 RID: 742
			[Token(Token = "0x60002E6")]
			void OnBack(InputAction.CallbackContext context);
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		public interface IMultiplayerActions
		{
			// Token: 0x060002E7 RID: 743
			[Token(Token = "0x60002E7")]
			void OnOpenChat(InputAction.CallbackContext context);

			// Token: 0x060002E8 RID: 744
			[Token(Token = "0x60002E8")]
			void OnPlayerList(InputAction.CallbackContext context);
		}

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		public interface ITextInputActions
		{
			// Token: 0x060002E9 RID: 745
			[Token(Token = "0x60002E9")]
			void OnSubmit(InputAction.CallbackContext context);

			// Token: 0x060002EA RID: 746
			[Token(Token = "0x60002EA")]
			void OnEsc(InputAction.CallbackContext context);
		}

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		public interface IConsoleActions
		{
			// Token: 0x060002EB RID: 747
			[Token(Token = "0x60002EB")]
			void OnSubmit(InputAction.CallbackContext context);

			// Token: 0x060002EC RID: 748
			[Token(Token = "0x60002EC")]
			void OnClose(InputAction.CallbackContext context);

			// Token: 0x060002ED RID: 749
			[Token(Token = "0x60002ED")]
			void OnConsole(InputAction.CallbackContext context);

			// Token: 0x060002EE RID: 750
			[Token(Token = "0x60002EE")]
			void OnHistoryBack(InputAction.CallbackContext context);

			// Token: 0x060002EF RID: 751
			[Token(Token = "0x60002EF")]
			void OnHistoryForward(InputAction.CallbackContext context);

			// Token: 0x060002F0 RID: 752
			[Token(Token = "0x60002F0")]
			void OnAutoComplete(InputAction.CallbackContext context);

			// Token: 0x060002F1 RID: 753
			[Token(Token = "0x60002F1")]
			void OnClearLogs(InputAction.CallbackContext context);
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		public interface IStructureCraftingActions
		{
			// Token: 0x060002F2 RID: 754
			[Token(Token = "0x60002F2")]
			void OnAddIngredient(InputAction.CallbackContext context);

			// Token: 0x060002F3 RID: 755
			[Token(Token = "0x60002F3")]
			void OnBack(InputAction.CallbackContext context);

			// Token: 0x060002F4 RID: 756
			[Token(Token = "0x60002F4")]
			void OnLighter(InputAction.CallbackContext context);

			// Token: 0x060002F5 RID: 757
			[Token(Token = "0x60002F5")]
			void OnUtility(InputAction.CallbackContext context);

			// Token: 0x060002F6 RID: 758
			[Token(Token = "0x60002F6")]
			void OnGpsTracker(InputAction.CallbackContext context);

			// Token: 0x060002F7 RID: 759
			[Token(Token = "0x60002F7")]
			void OnVoiceChat(InputAction.CallbackContext context);

			// Token: 0x060002F8 RID: 760
			[Token(Token = "0x60002F8")]
			void OnDrop(InputAction.CallbackContext context);

			// Token: 0x060002F9 RID: 761
			[Token(Token = "0x60002F9")]
			void OnBook(InputAction.CallbackContext context);

			// Token: 0x060002FA RID: 762
			[Token(Token = "0x60002FA")]
			void OnGoToTutorials(InputAction.CallbackContext context);

			// Token: 0x060002FB RID: 763
			[Token(Token = "0x60002FB")]
			void OnPrimaryAction(InputAction.CallbackContext context);

			// Token: 0x060002FC RID: 764
			[Token(Token = "0x60002FC")]
			void OnSecondaryAction(InputAction.CallbackContext context);

			// Token: 0x060002FD RID: 765
			[Token(Token = "0x60002FD")]
			void OnMoveCursor(InputAction.CallbackContext context);

			// Token: 0x060002FE RID: 766
			[Token(Token = "0x60002FE")]
			void OnOpenQuickSelect(InputAction.CallbackContext context);

			// Token: 0x060002FF RID: 767
			[Token(Token = "0x60002FF")]
			void OnOpenInventory(InputAction.CallbackContext context);

			// Token: 0x06000300 RID: 768
			[Token(Token = "0x6000300")]
			void OnConsole(InputAction.CallbackContext context);

			// Token: 0x06000301 RID: 769
			[Token(Token = "0x6000301")]
			void OnUnequip(InputAction.CallbackContext context);

			// Token: 0x06000302 RID: 770
			[Token(Token = "0x6000302")]
			void OnHorizontal(InputAction.CallbackContext context);

			// Token: 0x06000303 RID: 771
			[Token(Token = "0x6000303")]
			void OnVertical(InputAction.CallbackContext context);

			// Token: 0x06000304 RID: 772
			[Token(Token = "0x6000304")]
			void OnRun(InputAction.CallbackContext context);

			// Token: 0x06000305 RID: 773
			[Token(Token = "0x6000305")]
			void OnCrouch(InputAction.CallbackContext context);

			// Token: 0x06000306 RID: 774
			[Token(Token = "0x6000306")]
			void OnJump(InputAction.CallbackContext context);

			// Token: 0x06000307 RID: 775
			[Token(Token = "0x6000307")]
			void OnMouseY(InputAction.CallbackContext context);

			// Token: 0x06000308 RID: 776
			[Token(Token = "0x6000308")]
			void OnMouseX(InputAction.CallbackContext context);

			// Token: 0x06000309 RID: 777
			[Token(Token = "0x6000309")]
			void OnRotate(InputAction.CallbackContext context);

			// Token: 0x0600030A RID: 778
			[Token(Token = "0x600030A")]
			void OnCancelStructure(InputAction.CallbackContext context);

			// Token: 0x0600030B RID: 779
			[Token(Token = "0x600030B")]
			void OnSelectStructure(InputAction.CallbackContext context);
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public interface IGameOverActions
		{
			// Token: 0x0600030C RID: 780
			[Token(Token = "0x600030C")]
			void OnConsole(InputAction.CallbackContext context);

			// Token: 0x0600030D RID: 781
			[Token(Token = "0x600030D")]
			void OnBack(InputAction.CallbackContext context);
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		public interface IFirstDeathActions
		{
			// Token: 0x0600030E RID: 782
			[Token(Token = "0x600030E")]
			void OnUse(InputAction.CallbackContext context);

			// Token: 0x0600030F RID: 783
			[Token(Token = "0x600030F")]
			void OnConsole(InputAction.CallbackContext context);
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		public interface IInputBindingActions
		{
			// Token: 0x06000310 RID: 784
			[Token(Token = "0x6000310")]
			void OnCancel(InputAction.CallbackContext context);
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		public interface IModalDialogActions
		{
			// Token: 0x06000311 RID: 785
			[Token(Token = "0x6000311")]
			void OnConfirmModal(InputAction.CallbackContext context);

			// Token: 0x06000312 RID: 786
			[Token(Token = "0x6000312")]
			void OnCancelModal(InputAction.CallbackContext context);
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public interface ICutsceneActions
		{
			// Token: 0x06000313 RID: 787
			[Token(Token = "0x6000313")]
			void OnBack(InputAction.CallbackContext context);

			// Token: 0x06000314 RID: 788
			[Token(Token = "0x6000314")]
			void OnMouseY(InputAction.CallbackContext context);

			// Token: 0x06000315 RID: 789
			[Token(Token = "0x6000315")]
			void OnMouseX(InputAction.CallbackContext context);

			// Token: 0x06000316 RID: 790
			[Token(Token = "0x6000316")]
			void OnHorizontal(InputAction.CallbackContext context);

			// Token: 0x06000317 RID: 791
			[Token(Token = "0x6000317")]
			void OnSkip(InputAction.CallbackContext context);

			// Token: 0x06000318 RID: 792
			[Token(Token = "0x6000318")]
			void OnOpen(InputAction.CallbackContext context);

			// Token: 0x06000319 RID: 793
			[Token(Token = "0x6000319")]
			void OnInteract(InputAction.CallbackContext context);
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public interface IVehicleActions
		{
			// Token: 0x0600031A RID: 794
			[Token(Token = "0x600031A")]
			void OnBoost(InputAction.CallbackContext context);

			// Token: 0x0600031B RID: 795
			[Token(Token = "0x600031B")]
			void OnHandBrake(InputAction.CallbackContext context);

			// Token: 0x0600031C RID: 796
			[Token(Token = "0x600031C")]
			void OnThrottle(InputAction.CallbackContext context);

			// Token: 0x0600031D RID: 797
			[Token(Token = "0x600031D")]
			void OnReverse(InputAction.CallbackContext context);

			// Token: 0x0600031E RID: 798
			[Token(Token = "0x600031E")]
			void OnTurn(InputAction.CallbackContext context);
		}
	}
}
