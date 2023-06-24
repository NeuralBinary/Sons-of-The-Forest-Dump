using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020006AC RID: 1708
	[Token(Token = "0x20006AC")]
	public class CraftingCog : MonoBehaviour
	{
		// Token: 0x06002D30 RID: 11568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x3431B60", Offset = "0x3430160", VA = "0x183431B60")]
		private void Awake()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x3432020", Offset = "0x3430620", VA = "0x183432020")]
		private void OnEnable()
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x34321F0", Offset = "0x34307F0", VA = "0x1834321F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x3432200", Offset = "0x3430800", VA = "0x183432200")]
		private void OnCraftBeginEvent(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x1FE35F0", Offset = "0x1FE1BF0", VA = "0x181FE35F0")]
		private void OnCraftCompleteEvent(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D35")]
		[Address(RVA = "0x34322F0", Offset = "0x34308F0", VA = "0x1834322F0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x34325A0", Offset = "0x3430BA0", VA = "0x1834325A0")]
		private void OnMouseOver()
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x3432710", Offset = "0x3430D10", VA = "0x183432710")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x34329E0", Offset = "0x3430FE0", VA = "0x1834329E0")]
		public bool CogIsVisible()
		{
			return default(bool);
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x3432B50", Offset = "0x3431150", VA = "0x183432B50")]
		public void OnInteract(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3A")]
		[Address(RVA = "0x3432BA0", Offset = "0x34311A0", VA = "0x183432BA0")]
		public void ForceCogOn(bool force)
		{
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x3432BB0", Offset = "0x34311B0", VA = "0x183432BB0")]
		public void ActivateCog(bool enable)
		{
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x3433090", Offset = "0x3431690", VA = "0x183433090")]
		private void CheckForValidRecipe(int itemId)
		{
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CraftingCog()
		{
		}

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _dismantlingCog;

		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		[FieldOffset(Offset = "0x30")]
		[EventRef]
		[SerializeField]
		public string _readyToCraftAudioEvent;

		// Token: 0x0400279F RID: 10143
		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0x38")]
		[EventRef]
		[SerializeField]
		public string _hoverAudioEvent;

		// Token: 0x040027A0 RID: 10144
		[Token(Token = "0x40027A0")]
		[FieldOffset(Offset = "0x40")]
		private EventInstance _hoverAudioEventInstance;

		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0x48")]
		private CraftingSystem _craftingSystem;

		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0x50")]
		private Renderer _renderer;

		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0x58")]
		private bool _craftingInProgress;

		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x59")]
		private bool _isMouseOver;

		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		[FieldOffset(Offset = "0x5A")]
		private bool _cogForcedOn;

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0x5B")]
		private bool _dismantleMode;

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		[FieldOffset(Offset = "0x60")]
		private MeshOutliner _meshOutliner;
	}
}
