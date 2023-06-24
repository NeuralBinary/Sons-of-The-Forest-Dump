using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Gui.Input
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[CreateAssetMenu(menuName = "Sons/Input", fileName = "InputBindingData", order = 0)]
	public class InputBindingData : ScriptableObject
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000021")]
		public List<InputBindingDefinition> BindingDefinitions
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000022")]
		public InputActionAsset CurrentInputActionAsset
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x3055530", Offset = "0x3053B30", VA = "0x183055530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x30557D0", Offset = "0x3053DD0", VA = "0x1830557D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x3055A30", Offset = "0x3054030", VA = "0x183055A30")]
		private void OnDisable()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x3055BE0", Offset = "0x30541E0", VA = "0x183055BE0")]
		private void OnInputBindingSettingsLoaded()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x3055C50", Offset = "0x3054250", VA = "0x183055C50")]
		private void PatchNonBindableActions()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x3055F60", Offset = "0x3054560", VA = "0x183055F60")]
		[ContextMenu("Run consistency check")]
		private void EditorRunConsistencyCheck()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x3056A70", Offset = "0x3055070", VA = "0x183056A70")]
		[ContextMenu("Refresh controls paths")]
		private void EditorRefreshControlsPaths()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x3056AA0", Offset = "0x30550A0", VA = "0x183056AA0")]
		private void ForceRefreshAllControlPaths(InputActionAsset asset)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x3056BF0", Offset = "0x30551F0", VA = "0x183056BF0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x3056DC0", Offset = "0x30553C0", VA = "0x183056DC0")]
		public GameObject Get(InputMapType currentType, string actionId, out string displayName, out bool isDefaultPrefab)
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3057100", Offset = "0x3055700", VA = "0x183057100")]
		public void StartRebindingOperation(List<string> actionIds, List<string> actionPaths, int controlType, InputBindingDefinition bindingDefinition, Action onBindingStarted, Action onBindingChanged, Action onBindingCancelled)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3057C70", Offset = "0x3056270", VA = "0x183057C70")]
		public void ClearBindings()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3057E20", Offset = "0x3056420", VA = "0x183057E20")]
		public int LookupBindingIndexForGroup(InputAction action, string group)
		{
			return 0;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x3058000", Offset = "0x3056600", VA = "0x183058000")]
		public void RegisterOnActionBindingChanged(string actionId, Action callback)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x3058160", Offset = "0x3056760", VA = "0x183058160")]
		public void UnregisterOnActionBindingChanged(string actionId, Action callback)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x3058280", Offset = "0x3056880", VA = "0x183058280")]
		public void RaiseOnActionBindingChanged(string actionId)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x30584A0", Offset = "0x3056AA0", VA = "0x1830584A0")]
		private static string ConvertControlPathDeviceToSubType(InputDevice device, string buttonControlPath)
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x3058660", Offset = "0x3056C60", VA = "0x183058660")]
		public InputBindingData()
		{
		}

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		public const float BindingDelay = 5f;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		public const string GamepadOverrideGroup = "Gamepad";

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		public const string KeyboardOverrideGroup = "Mouse and Keyboard";

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		public const string GamepadDevicePrefix = "<Gamepad>";

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		public const string MouseDevicePrefix = "<Mouse>";

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		public const string KeyboardDevicePrefix = "<Keyboard>";

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputActionAsset _defaultInputActionAsset;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x20")]
		private InputActionAsset _cachedRuntimeInputActionAsset;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IconAssetDatabase _iconAssetDatabase;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_bindingGroups")]
		private List<InputBindingDefinition> _bindingDefinitions;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x38")]
		private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, Action> _onActionBindingChanged;
	}
}
