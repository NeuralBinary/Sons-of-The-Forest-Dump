using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	[AddComponentMenu("Sons/Gameplay/Cooking/CookingCog")]
	public class CookingCog : MonoBehaviour
	{
		// Token: 0x06003D56 RID: 15702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x35BA860", Offset = "0x35B8E60", VA = "0x1835BA860")]
		private void Awake()
		{
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x35BAB10", Offset = "0x35B9110", VA = "0x1835BAB10")]
		private void OnEnable()
		{
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x35BAD40", Offset = "0x35B9340", VA = "0x1835BAD40")]
		private void OnDisable()
		{
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x35BB0D0", Offset = "0x35B96D0", VA = "0x1835BB0D0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x35BB580", Offset = "0x35B9B80", VA = "0x1835BB580")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5B")]
		[Address(RVA = "0x35BB7F0", Offset = "0x35B9DF0", VA = "0x1835BB7F0")]
		public void OnInteract(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5C")]
		[Address(RVA = "0x35BB940", Offset = "0x35B9F40", VA = "0x1835BB940")]
		public void OnAlternateInteract(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5D")]
		[Address(RVA = "0x35BBA50", Offset = "0x35BA050", VA = "0x1835BBA50")]
		public void Reset()
		{
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5E")]
		[Address(RVA = "0x35BBB30", Offset = "0x35BA130", VA = "0x1835BBB30")]
		public void SetReadyToCook(bool isReady)
		{
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5F")]
		[Address(RVA = "0x35BBCA0", Offset = "0x35BA2A0", VA = "0x1835BBCA0")]
		private void SetBeginCooking()
		{
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x35BBD70", Offset = "0x35BA370", VA = "0x1835BBD70")]
		private void AnimateReadyToCookCog(bool enable)
		{
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CookingCog()
		{
		}

		// Token: 0x040033C8 RID: 13256
		[Token(Token = "0x40033C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040033C9 RID: 13257
		[Token(Token = "0x40033C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _ghostCog;

		// Token: 0x040033CA RID: 13258
		[Token(Token = "0x40033CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _readyToCookCog;

		// Token: 0x040033CB RID: 13259
		[Token(Token = "0x40033CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		public string _readyToCraftAudioEvent;

		// Token: 0x040033CC RID: 13260
		[Token(Token = "0x40033CC")]
		[FieldOffset(Offset = "0x40")]
		[EventRef]
		[SerializeField]
		public string _hoverAudioEvent;

		// Token: 0x040033CD RID: 13261
		[Token(Token = "0x40033CD")]
		[FieldOffset(Offset = "0x48")]
		private EventInstance _hoverAudioEventInstance;

		// Token: 0x040033CE RID: 13262
		[Token(Token = "0x40033CE")]
		[FieldOffset(Offset = "0x50")]
		private bool _isCooking;

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[FieldOffset(Offset = "0x51")]
		private bool _isMouseOver;

		// Token: 0x040033D0 RID: 13264
		[Token(Token = "0x40033D0")]
		[FieldOffset(Offset = "0x52")]
		private bool _isReadyToCook;

		// Token: 0x040033D1 RID: 13265
		[Token(Token = "0x40033D1")]
		[FieldOffset(Offset = "0x58")]
		private MeshOutliner _meshOutliner;
	}
}
