using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x02000722 RID: 1826
	[Token(Token = "0x2000722")]
	[AddComponentMenu("Sons/Gameplay/CookingSurfaceHookPoint")]
	public class CookingSurfaceHookPoint : MonoBehaviour
	{
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		[Token(Token = "0x17000600")]
		private bool IsCooked
		{
			[Token(Token = "0x6002FA1")]
			[Address(RVA = "0x2E26DF0", Offset = "0x2E25DF0", VA = "0x182E26DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Token(Token = "0x17000601")]
		private bool IsBurnt
		{
			[Token(Token = "0x6002FA2")]
			[Address(RVA = "0x2E26DD0", Offset = "0x2E25DD0", VA = "0x182E26DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[Token(Token = "0x17000602")]
		private bool IsDestroyed
		{
			[Token(Token = "0x6002FA3")]
			[Address(RVA = "0x2E26E00", Offset = "0x2E25E00", VA = "0x182E26E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x2E262E0", Offset = "0x2E252E0", VA = "0x182E262E0")]
		public ItemInstance GetItemInstance()
		{
			return null;
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x2E26A70", Offset = "0x2E25A70", VA = "0x182E26A70")]
		public bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x2E26400", Offset = "0x2E25400", VA = "0x182E26400")]
		public void Initialize(ItemInstance itemInstance, CookingRecipe recipe)
		{
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x2E26B70", Offset = "0x2E25B70", VA = "0x182E26B70")]
		private void SetPerishableStateMp()
		{
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x2E26AC0", Offset = "0x2E25AC0", VA = "0x182E26AC0")]
		private void OnCookingItemRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x2E25CD0", Offset = "0x2E24CD0", VA = "0x182E25CD0")]
		public void Clear()
		{
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x2E26370", Offset = "0x2E25370", VA = "0x182E26370")]
		public Transform GetVisualTransform()
		{
			return null;
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x2E26C60", Offset = "0x2E25C60", VA = "0x182E26C60")]
		public void StartCookingAudio()
		{
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x2E26DA0", Offset = "0x2E25DA0", VA = "0x182E26DA0")]
		public void StopCookingAudio()
		{
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x2E25D30", Offset = "0x2E24D30", VA = "0x182E25D30")]
		public void Cook()
		{
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public CookingSurfaceHookPoint()
		{
		}

		// Token: 0x04002A0C RID: 10764
		[Token(Token = "0x4002A0C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PickUp _attachedPickup;

		// Token: 0x04002A0D RID: 10765
		[Token(Token = "0x4002A0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x04002A0E RID: 10766
		[Token(Token = "0x4002A0E")]
		[FieldOffset(Offset = "0x30")]
		private float _destroyTimeRemaining;

		// Token: 0x04002A0F RID: 10767
		[Token(Token = "0x4002A0F")]
		[FieldOffset(Offset = "0x34")]
		private float _burntTimeRemaining;

		// Token: 0x04002A10 RID: 10768
		[Token(Token = "0x4002A10")]
		[FieldOffset(Offset = "0x38")]
		private float _cookTimeRemaining;

		// Token: 0x04002A11 RID: 10769
		[Token(Token = "0x4002A11")]
		[FieldOffset(Offset = "0x40")]
		private EventInstance _duringCookingAudio;

		// Token: 0x04002A12 RID: 10770
		[Token(Token = "0x4002A12")]
		[FieldOffset(Offset = "0x48")]
		private ItemInstance _itemInstance;

		// Token: 0x04002A13 RID: 10771
		[Token(Token = "0x4002A13")]
		[FieldOffset(Offset = "0x50")]
		private PerishableItemInstanceModule _perishableModule;

		// Token: 0x04002A14 RID: 10772
		[Token(Token = "0x4002A14")]
		[FieldOffset(Offset = "0x58")]
		private CookingRecipe _recipe;

		// Token: 0x04002A15 RID: 10773
		[Token(Token = "0x4002A15")]
		[FieldOffset(Offset = "0x60")]
		public Action<CookingSurfaceHookPoint> HookPointCleared;
	}
}
