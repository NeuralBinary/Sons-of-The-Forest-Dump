using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class ShipInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700003D")]
		public InputActionAsset asset
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x27119C0", Offset = "0x270FFC0", VA = "0x1827119C0")]
		public ShipInputActions()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2711FF0", Offset = "0x27105F0", VA = "0x182711FF0", Slot = "17")]
		public void Dispose()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x26EF2B0", Offset = "0x26ED8B0", VA = "0x1826EF2B0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x26EF300", Offset = "0x26ED900", VA = "0x1826EF300", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003F")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x26EF360", Offset = "0x26ED960", VA = "0x1826EF360", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x26EF3B0", Offset = "0x26ED9B0", VA = "0x1826EF3B0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x17000040")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x26EF430", Offset = "0x26EDA30", VA = "0x1826EF430", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x26EF470", Offset = "0x26EDA70", VA = "0x1826EF470", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x26EF490", Offset = "0x26EDA90", VA = "0x1826EF490", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x26EF490", Offset = "0x26EDA90", VA = "0x1826EF490", Slot = "16")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x26EF4B0", Offset = "0x26EDAB0", VA = "0x1826EF4B0", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x26EF4D0", Offset = "0x26EDAD0", VA = "0x1826EF4D0", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000041")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x26EF4F0", Offset = "0x26EDAF0", VA = "0x1826EF4F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x26EF510", Offset = "0x26EDB10", VA = "0x1826EF510", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x26EF530", Offset = "0x26EDB30", VA = "0x1826EF530", Slot = "6")]
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x17000042")]
		public ShipInputActions.ShipControlsActions ShipControls
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(ShipInputActions.ShipControlsActions);
			}
		}

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		private readonly InputActionMap m_ShipControls;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		private ShipInputActions.IShipControlsActions m_ShipControlsActionsCallbackInterface;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		private readonly InputAction m_ShipControls_Steering;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		private readonly InputAction m_ShipControls_Throttle;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x38")]
		private readonly InputAction m_ShipControls_Throttle2;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x40")]
		private readonly InputAction m_ShipControls_Throttle3;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x48")]
		private readonly InputAction m_ShipControls_Throttle4;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x50")]
		private readonly InputAction m_ShipControls_BowThruster;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x58")]
		private readonly InputAction m_ShipControls_SternThruster;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x60")]
		private readonly InputAction m_ShipControls_SubmarineDepth;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x68")]
		private readonly InputAction m_ShipControls_EngineStartStop;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x70")]
		private readonly InputAction m_ShipControls_Anchor;

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public struct ShipControlsActions
		{
			// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public ShipControlsActions(ShipInputActions wrapper)
			{
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000126 RID: 294 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000043")]
			public InputAction Steering
			{
				[Token(Token = "0x6000126")]
				[Address(RVA = "0x26EF590", Offset = "0x26EDB90", VA = "0x1826EF590")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000127 RID: 295 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000044")]
			public InputAction Throttle
			{
				[Token(Token = "0x6000127")]
				[Address(RVA = "0x26EF5B0", Offset = "0x26EDBB0", VA = "0x1826EF5B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000128 RID: 296 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000045")]
			public InputAction Throttle2
			{
				[Token(Token = "0x6000128")]
				[Address(RVA = "0x26EF5D0", Offset = "0x26EDBD0", VA = "0x1826EF5D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000129 RID: 297 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000046")]
			public InputAction Throttle3
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0x26EF5F0", Offset = "0x26EDBF0", VA = "0x1826EF5F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600012A RID: 298 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000047")]
			public InputAction Throttle4
			{
				[Token(Token = "0x600012A")]
				[Address(RVA = "0x26EF610", Offset = "0x26EDC10", VA = "0x1826EF610")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600012B RID: 299 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000048")]
			public InputAction BowThruster
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x26EF630", Offset = "0x26EDC30", VA = "0x1826EF630")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x0600012C RID: 300 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x17000049")]
			public InputAction SternThruster
			{
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x26F1850", Offset = "0x26EFE50", VA = "0x1826F1850")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x0600012D RID: 301 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x1700004A")]
			public InputAction SubmarineDepth
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0x2712040", Offset = "0x2710640", VA = "0x182712040")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600012E RID: 302 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x1700004B")]
			public InputAction EngineStartStop
			{
				[Token(Token = "0x600012E")]
				[Address(RVA = "0x26F17D0", Offset = "0x26EFDD0", VA = "0x1826F17D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600012F RID: 303 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x1700004C")]
			public InputAction Anchor
			{
				[Token(Token = "0x600012F")]
				[Address(RVA = "0x26F17F0", Offset = "0x26EFDF0", VA = "0x1826F17F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000130 RID: 304 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x26EF650", Offset = "0x26EDC50", VA = "0x1826EF650")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x26EF670", Offset = "0x26EDC70", VA = "0x1826EF670")]
			public void Enable()
			{
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x26EF6E0", Offset = "0x26EDCE0", VA = "0x1826EF6E0")]
			public void Disable()
			{
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00002A14 File Offset: 0x00000C14
			[Token(Token = "0x1700004D")]
			public bool enabled
			{
				[Token(Token = "0x6000133")]
				[Address(RVA = "0x26EF720", Offset = "0x26EDD20", VA = "0x1826EF720")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x000021CE File Offset: 0x000003CE
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1674D60", Offset = "0x1673360", VA = "0x181674D60")]
			public static implicit operator InputActionMap(ShipInputActions.ShipControlsActions set)
			{
				return null;
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2712060", Offset = "0x2710660", VA = "0x182712060")]
			public void SetCallbacks(ShipInputActions.IShipControlsActions instance)
			{
			}

			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x0")]
			private ShipInputActions m_Wrapper;
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		public interface IShipControlsActions
		{
			// Token: 0x06000136 RID: 310
			[Token(Token = "0x6000136")]
			void OnSteering(InputAction.CallbackContext context);

			// Token: 0x06000137 RID: 311
			[Token(Token = "0x6000137")]
			void OnThrottle(InputAction.CallbackContext context);

			// Token: 0x06000138 RID: 312
			[Token(Token = "0x6000138")]
			void OnThrottle2(InputAction.CallbackContext context);

			// Token: 0x06000139 RID: 313
			[Token(Token = "0x6000139")]
			void OnThrottle3(InputAction.CallbackContext context);

			// Token: 0x0600013A RID: 314
			[Token(Token = "0x600013A")]
			void OnThrottle4(InputAction.CallbackContext context);

			// Token: 0x0600013B RID: 315
			[Token(Token = "0x600013B")]
			void OnBowThruster(InputAction.CallbackContext context);

			// Token: 0x0600013C RID: 316
			[Token(Token = "0x600013C")]
			void OnSternThruster(InputAction.CallbackContext context);

			// Token: 0x0600013D RID: 317
			[Token(Token = "0x600013D")]
			void OnSubmarineDepth(InputAction.CallbackContext context);

			// Token: 0x0600013E RID: 318
			[Token(Token = "0x600013E")]
			void OnEngineStartStop(InputAction.CallbackContext context);

			// Token: 0x0600013F RID: 319
			[Token(Token = "0x600013F")]
			void OnAnchor(InputAction.CallbackContext context);
		}
	}
}
