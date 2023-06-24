using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using Sons.Gameplay.Grabber;
using TheForest.Player.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	[AddComponentMenu("Sons/Actions/PlayerRelocateScrewStructureAction")]
	public class PlayerRelocateScrewStructureAction : MonoBehaviour, IOnPlaceStructureReceiver, IOnCancelStructureReceiver
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x1700025B")]
		public bool IsDismantling
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x2E53870", Offset = "0x2E51E70", VA = "0x182E53870")]
		private void Awake()
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2E53A80", Offset = "0x2E52080", VA = "0x182E53A80")]
		private void Update()
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2E53C30", Offset = "0x2E52230", VA = "0x182E53C30")]
		private void SetTargetStructure(ScrewStructure structure)
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2E54170", Offset = "0x2E52770", VA = "0x182E54170")]
		private void OnStartDismantle(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2E543C0", Offset = "0x2E529C0", VA = "0x182E543C0")]
		private void OnDismantle(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2E544B0", Offset = "0x2E52AB0", VA = "0x182E544B0")]
		private void OnDismantleMP(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2E54520", Offset = "0x2E52B20", VA = "0x182E54520")]
		private void OnCancelDismantle(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2E54560", Offset = "0x2E52B60", VA = "0x182E54560")]
		private void SetIsDismantling(bool isDismantling)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2E54600", Offset = "0x2E52C00", VA = "0x182E54600")]
		public void EnterRelocateStructureState()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2E54840", Offset = "0x2E52E40", VA = "0x182E54840")]
		private void ThrowHeldStructure(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2E54860", Offset = "0x2E52E60", VA = "0x182E54860")]
		private void ThrowHeldStructure()
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2E54A40", Offset = "0x2E53040", VA = "0x182E54A40")]
		private void ToggleInput()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2E54CC0", Offset = "0x2E532C0", VA = "0x182E54CC0")]
		private void ToggleAnim()
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2E54FE0", Offset = "0x2E535E0", VA = "0x182E54FE0", Slot = "4")]
		private void OnPlaceStructure()
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2E550D0", Offset = "0x2E536D0", VA = "0x182E550D0", Slot = "5")]
		private void OnCancelStructure()
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2E55200", Offset = "0x2E53800", VA = "0x182E55200")]
		public PlayerRelocateScrewStructureAction()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2E552C0", Offset = "0x2E538C0", VA = "0x182E552C0")]
		[CompilerGenerated]
		private void <Update>g__LookupTargetScrewStructure|14_0()
		{
		}

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PreviewManager _preview;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _aimTr;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerStructurePlaceAction _placeAction;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HeldScrewStructure _heldScrewStructure;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x48")]
		private bool _isDismantling;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x50")]
		private ScrewStructure _targetStructure;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x58")]
		private readonly GenericGrabberTargetProvider _grabberTargetProvider;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x60")]
		private Action<InputAction.CallbackContext> _dismantleElementStarted;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x68")]
		private Action<InputAction.CallbackContext> _dismantleElementCanceled;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x70")]
		private Action<InputAction.CallbackContext> _dismantleElementPerformed;
	}
}
