using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Input;
using TheForest.Utils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Gui.Input
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class DynamicInputIcon : MonoBehaviour
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001D")]
		private List<string> GetActionsMenuDropdown
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x3021ED0", Offset = "0x30204D0", VA = "0x183021ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3021F10", Offset = "0x3020510", VA = "0x183021F10")]
		private void OnValidate()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3021F20", Offset = "0x3020520", VA = "0x183021F20")]
		private void SanitizeActionId()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x30220D0", Offset = "0x30206D0", VA = "0x1830220D0")]
		private void Start()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x3022110", Offset = "0x3020710", VA = "0x183022110")]
		private void Awake()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x30222D0", Offset = "0x30208D0", VA = "0x1830222D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3022450", Offset = "0x3020A50", VA = "0x183022450")]
		private void Initialize()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x3022490", Offset = "0x3020A90", VA = "0x183022490")]
		private void SimplifyDefaultInstance()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x3022860", Offset = "0x3020E60", VA = "0x183022860")]
		private static void CopyRectTransform(RectTransform fromTransform, RectTransform toTransform)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3022DE0", Offset = "0x30213E0", VA = "0x183022DE0")]
		private void Update()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3022E40", Offset = "0x3021440", VA = "0x183022E40")]
		private void UpdateHeld()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x3023170", Offset = "0x3021770", VA = "0x183023170")]
		private void SendProgressToHeldInputReceivers()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x30232B0", Offset = "0x30218B0", VA = "0x1830232B0")]
		private void SendStartToHeldInputReceivers()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x30233D0", Offset = "0x30219D0", VA = "0x1830233D0")]
		private void SendStopToHeldInputReceivers()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3023500", Offset = "0x3021B00", VA = "0x183023500")]
		private IHeldInputProgressReceiver[] GetActiveHelInputReceivers()
		{
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x30235F0", Offset = "0x3021BF0", VA = "0x1830235F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x3023A10", Offset = "0x3022010", VA = "0x183023A10")]
		private void OnDisable()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3023D50", Offset = "0x3022350", VA = "0x183023D50")]
		private void ActionPerformed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3023D50", Offset = "0x3022350", VA = "0x183023D50")]
		private void ActionCancelled(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3023D60", Offset = "0x3022360", VA = "0x183023D60")]
		private void ClearHeldAction()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3023EA0", Offset = "0x30224A0", VA = "0x183023EA0")]
		private void ActionStarted()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3023EA0", Offset = "0x30224A0", VA = "0x183023EA0")]
		private void ActionStarted(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3023F50", Offset = "0x3022550", VA = "0x183023F50")]
		public void InvalidateInstancesAndRefresh()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3024190", Offset = "0x3022790", VA = "0x183024190")]
		private void InitializeInstance(InputMapType inputMapType)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x30243E0", Offset = "0x30229E0", VA = "0x1830243E0")]
		private bool TryGetInstance(InputMapType inputMapType, out GameObject result)
		{
			return default(bool);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x30245C0", Offset = "0x3022BC0", VA = "0x1830245C0")]
		private void RefreshInstanceActive()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x3024870", Offset = "0x3022E70", VA = "0x183024870")]
		private bool PassesWhiteList(InputMapType currentType)
		{
			return default(bool);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x3024900", Offset = "0x3022F00", VA = "0x183024900")]
		private void ApplyActiveInstance(IconInstance target)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x3024BF0", Offset = "0x30231F0", VA = "0x183024BF0")]
		private GameObject CreateNewInstance(GameObject defaultInstance)
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x3025400", Offset = "0x3023A00", VA = "0x183025400")]
		private bool HasChangedInput()
		{
			return default(bool);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x30255B0", Offset = "0x3023BB0", VA = "0x1830255B0")]
		private bool CheckForcedSettings(out bool hasChangedInput)
		{
			return default(bool);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x3025620", Offset = "0x3023C20", VA = "0x183025620")]
		public void SetActionId(string actionId)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3025680", Offset = "0x3023C80", VA = "0x183025680")]
		public DynamicInputIcon()
		{
		}

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_iconMap")]
		private InputBindingData _bindingData;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _actionId;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useInputState;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[FormerlySerializedAs("_actionState")]
		private InputState _inputState;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _defaultInstance;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _neverShowProgress;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _showProgressWhenIdle;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x42")]
		[FormerlySerializedAs("_forceGamepad")]
		[SerializeField]
		private bool _forceXboxGamepad;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x43")]
		[SerializeField]
		private bool _forcePsGamepad;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _forceKeyboard;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<InputMapType> _whiteList;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x50")]
		private InputMapType _currentType;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x58")]
		private List<IconInstance> _instances;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _activeInstance;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x68")]
		private bool _usesHeld;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x69")]
		private bool _actionStarted;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x70")]
		private Sons.Input.InputSystem.Action _actionSource;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x80")]
		private float _currentProgress;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x88")]
		private IconInstance _activeTarget;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x90")]
		private bool _initalized;
	}
}
