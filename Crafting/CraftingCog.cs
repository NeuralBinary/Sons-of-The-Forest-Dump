using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	public class CraftingCog : MonoBehaviour
	{
		// Token: 0x060033B8 RID: 13240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x2E57BC0", Offset = "0x2E56BC0", VA = "0x182E57BC0")]
		private void Awake()
		{
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B9")]
		[Address(RVA = "0x2E58270", Offset = "0x2E57270", VA = "0x182E58270")]
		private void OnEnable()
		{
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BA")]
		[Address(RVA = "0x2E58260", Offset = "0x2E57260", VA = "0x182E58260")]
		private void OnDisable()
		{
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BB")]
		[Address(RVA = "0x2E581E0", Offset = "0x2E571E0", VA = "0x182E581E0")]
		private void OnCraftBeginEvent(CraftingRecipe recipe)
		{
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x1CB6340", Offset = "0x1CB5340", VA = "0x181CB6340")]
		private void OnCraftCompleteEvent(CraftingRecipe recipe)
		{
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x2E584A0", Offset = "0x2E574A0", VA = "0x182E584A0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x2E58830", Offset = "0x2E57830", VA = "0x182E58830")]
		private void OnMouseOver()
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x2E58660", Offset = "0x2E57660", VA = "0x182E58660")]
		private void OnMouseExit()
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x0000EC58 File Offset: 0x0000CE58
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x2E58130", Offset = "0x2E57130", VA = "0x182E58130")]
		public bool CogIsVisible()
		{
			return default(bool);
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x2E58450", Offset = "0x2E57450", VA = "0x182E58450")]
		public void OnInteract(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x2E581D0", Offset = "0x2E571D0", VA = "0x182E581D0")]
		public void ForceCogOn(bool force)
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x2E57960", Offset = "0x2E56960", VA = "0x182E57960")]
		public void ActivateCog(bool enable)
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x2E57E40", Offset = "0x2E56E40", VA = "0x182E57E40")]
		private void CheckForValidRecipe(int itemId)
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public CraftingCog()
		{
		}

		// Token: 0x04002CC9 RID: 11465
		[Token(Token = "0x4002CC9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002CCA RID: 11466
		[Token(Token = "0x4002CCA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _dismantlingCog;

		// Token: 0x04002CCB RID: 11467
		[Token(Token = "0x4002CCB")]
		[FieldOffset(Offset = "0x30")]
		[EventRef]
		[SerializeField]
		public string _readyToCraftAudioEvent;

		// Token: 0x04002CCC RID: 11468
		[Token(Token = "0x4002CCC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		public string _hoverAudioEvent;

		// Token: 0x04002CCD RID: 11469
		[Token(Token = "0x4002CCD")]
		[FieldOffset(Offset = "0x40")]
		private EventInstance _hoverAudioEventInstance;

		// Token: 0x04002CCE RID: 11470
		[Token(Token = "0x4002CCE")]
		[FieldOffset(Offset = "0x48")]
		private CraftingSystem _craftingSystem;

		// Token: 0x04002CCF RID: 11471
		[Token(Token = "0x4002CCF")]
		[FieldOffset(Offset = "0x50")]
		private Renderer _renderer;

		// Token: 0x04002CD0 RID: 11472
		[Token(Token = "0x4002CD0")]
		[FieldOffset(Offset = "0x58")]
		private bool _craftingInProgress;

		// Token: 0x04002CD1 RID: 11473
		[Token(Token = "0x4002CD1")]
		[FieldOffset(Offset = "0x59")]
		private bool _isMouseOver;

		// Token: 0x04002CD2 RID: 11474
		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x5A")]
		private bool _cogForcedOn;

		// Token: 0x04002CD3 RID: 11475
		[Token(Token = "0x4002CD3")]
		[FieldOffset(Offset = "0x5B")]
		private bool _dismantleMode;

		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		[FieldOffset(Offset = "0x60")]
		private MeshOutliner _meshOutliner;
	}
}
