using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace NWH.Common.Input
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class SceneInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002276 File Offset: 0x00000476
		[Token(Token = "0x17000001")]
		public InputActionAsset asset
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x26EEBC0", Offset = "0x26ED1C0", VA = "0x1826EEBC0")]
		public SceneInputActions()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x26EF260", Offset = "0x26ED860", VA = "0x1826EF260", Slot = "17")]
		public void Dispose()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x26EF2B0", Offset = "0x26ED8B0", VA = "0x1826EF2B0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x26EF300", Offset = "0x26ED900", VA = "0x1826EF300", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002294 File Offset: 0x00000494
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x26EF360", Offset = "0x26ED960", VA = "0x1826EF360", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x26EF3B0", Offset = "0x26ED9B0", VA = "0x1826EF3B0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x17000004")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x26EF430", Offset = "0x26EDA30", VA = "0x1826EF430", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x26EF470", Offset = "0x26EDA70", VA = "0x1826EF470", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002276 File Offset: 0x00000476
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x26EF490", Offset = "0x26EDA90", VA = "0x1826EF490", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002276 File Offset: 0x00000476
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x26EF490", Offset = "0x26EDA90", VA = "0x1826EF490", Slot = "16")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x26EF4B0", Offset = "0x26EDAB0", VA = "0x1826EF4B0", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x26EF4D0", Offset = "0x26EDAD0", VA = "0x1826EF4D0", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002276 File Offset: 0x00000476
		[Token(Token = "0x17000005")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x26EF4F0", Offset = "0x26EDAF0", VA = "0x1826EF4F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002276 File Offset: 0x00000476
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x26EF510", Offset = "0x26EDB10", VA = "0x1826EF510", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x26EF530", Offset = "0x26EDB30", VA = "0x1826EF530", Slot = "6")]
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x17000006")]
		public SceneInputActions.CameraControlsActions CameraControls
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SceneInputActions.CameraControlsActions);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x17000007")]
		public SceneInputActions.SceneControlsActions SceneControls
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2392060", Offset = "0x2390660", VA = "0x182392060")]
			get
			{
				return default(SceneInputActions.SceneControlsActions);
			}
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private readonly InputActionMap m_CameraControls;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private SceneInputActions.ICameraControlsActions m_CameraControlsActionsCallbackInterface;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		private readonly InputAction m_CameraControls_ChangeCamera;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		private readonly InputAction m_CameraControls_CameraRotation;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		private readonly InputAction m_CameraControls_CameraPanning;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		private readonly InputAction m_CameraControls_CameraRotationModifier;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x48")]
		private readonly InputAction m_CameraControls_CameraPanningModifier;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x50")]
		private readonly InputAction m_CameraControls_CameraZoom;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x58")]
		private readonly InputActionMap m_SceneControls;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x60")]
		private SceneInputActions.ISceneControlsActions m_SceneControlsActionsCallbackInterface;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x68")]
		private readonly InputAction m_SceneControls_ChangeVehicle;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x70")]
		private readonly InputAction m_SceneControls_FPSMovement;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x78")]
		private readonly InputAction m_SceneControls_ToggleGUI;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x80")]
		private readonly InputAction m_SceneControls_DragObjectModifier;

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public struct CameraControlsActions
		{
			// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public CameraControlsActions(SceneInputActions wrapper)
			{
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000037 RID: 55 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x17000008")]
			public InputAction ChangeCamera
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0x26EF590", Offset = "0x26EDB90", VA = "0x1826EF590")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x17000009")]
			public InputAction CameraRotation
			{
				[Token(Token = "0x6000038")]
				[Address(RVA = "0x26EF5B0", Offset = "0x26EDBB0", VA = "0x1826EF5B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000039 RID: 57 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x1700000A")]
			public InputAction CameraPanning
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x26EF5D0", Offset = "0x26EDBD0", VA = "0x1826EF5D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x1700000B")]
			public InputAction CameraRotationModifier
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x26EF5F0", Offset = "0x26EDBF0", VA = "0x1826EF5F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600003B RID: 59 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x1700000C")]
			public InputAction CameraPanningModifier
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x26EF610", Offset = "0x26EDC10", VA = "0x1826EF610")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x1700000D")]
			public InputAction CameraZoom
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0x26EF630", Offset = "0x26EDC30", VA = "0x1826EF630")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x26EF650", Offset = "0x26EDC50", VA = "0x1826EF650")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x26EF670", Offset = "0x26EDC70", VA = "0x1826EF670")]
			public void Enable()
			{
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x26EF6E0", Offset = "0x26EDCE0", VA = "0x1826EF6E0")]
			public void Disable()
			{
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00002324 File Offset: 0x00000524
			[Token(Token = "0x1700000E")]
			public bool enabled
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x26EF720", Offset = "0x26EDD20", VA = "0x1826EF720")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1674D60", Offset = "0x1673360", VA = "0x181674D60")]
			public static implicit operator InputActionMap(SceneInputActions.CameraControlsActions set)
			{
				return null;
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x26EF750", Offset = "0x26EDD50", VA = "0x1826EF750")]
			public void SetCallbacks(SceneInputActions.ICameraControlsActions instance)
			{
			}

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x0")]
			private SceneInputActions m_Wrapper;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public struct SceneControlsActions
		{
			// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			public SceneControlsActions(SceneInputActions wrapper)
			{
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x1700000F")]
			public InputAction ChangeVehicle
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x26F17D0", Offset = "0x26EFDD0", VA = "0x1826F17D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x17000010")]
			public InputAction FPSMovement
			{
				[Token(Token = "0x6000045")]
				[Address(RVA = "0x26F17F0", Offset = "0x26EFDF0", VA = "0x1826F17F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x17000011")]
			public InputAction ToggleGUI
			{
				[Token(Token = "0x6000046")]
				[Address(RVA = "0x26F1810", Offset = "0x26EFE10", VA = "0x1826F1810")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000047 RID: 71 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x17000012")]
			public InputAction DragObjectModifier
			{
				[Token(Token = "0x6000047")]
				[Address(RVA = "0x26F1830", Offset = "0x26EFE30", VA = "0x1826F1830")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000048 RID: 72 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x26F1850", Offset = "0x26EFE50", VA = "0x1826F1850")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x26F1870", Offset = "0x26EFE70", VA = "0x1826F1870")]
			public void Enable()
			{
			}

			// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x26F18E0", Offset = "0x26EFEE0", VA = "0x1826F18E0")]
			public void Disable()
			{
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600004B RID: 75 RVA: 0x0000233C File Offset: 0x0000053C
			[Token(Token = "0x17000013")]
			public bool enabled
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0x26F1920", Offset = "0x26EFF20", VA = "0x1826F1920")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600004C RID: 76 RVA: 0x00002276 File Offset: 0x00000476
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x26F1950", Offset = "0x26EFF50", VA = "0x1826F1950")]
			public static implicit operator InputActionMap(SceneInputActions.SceneControlsActions set)
			{
				return null;
			}

			// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x26F1970", Offset = "0x26EFF70", VA = "0x1826F1970")]
			public void SetCallbacks(SceneInputActions.ISceneControlsActions instance)
			{
			}

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x0")]
			private SceneInputActions m_Wrapper;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public interface ICameraControlsActions
		{
			// Token: 0x0600004E RID: 78
			[Token(Token = "0x600004E")]
			void OnChangeCamera(InputAction.CallbackContext context);

			// Token: 0x0600004F RID: 79
			[Token(Token = "0x600004F")]
			void OnCameraRotation(InputAction.CallbackContext context);

			// Token: 0x06000050 RID: 80
			[Token(Token = "0x6000050")]
			void OnCameraPanning(InputAction.CallbackContext context);

			// Token: 0x06000051 RID: 81
			[Token(Token = "0x6000051")]
			void OnCameraRotationModifier(InputAction.CallbackContext context);

			// Token: 0x06000052 RID: 82
			[Token(Token = "0x6000052")]
			void OnCameraPanningModifier(InputAction.CallbackContext context);

			// Token: 0x06000053 RID: 83
			[Token(Token = "0x6000053")]
			void OnCameraZoom(InputAction.CallbackContext context);
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		public interface ISceneControlsActions
		{
			// Token: 0x06000054 RID: 84
			[Token(Token = "0x6000054")]
			void OnChangeVehicle(InputAction.CallbackContext context);

			// Token: 0x06000055 RID: 85
			[Token(Token = "0x6000055")]
			void OnFPSMovement(InputAction.CallbackContext context);

			// Token: 0x06000056 RID: 86
			[Token(Token = "0x6000056")]
			void OnToggleGUI(InputAction.CallbackContext context);

			// Token: 0x06000057 RID: 87
			[Token(Token = "0x6000057")]
			void OnDragObjectModifier(InputAction.CallbackContext context);
		}
	}
}
