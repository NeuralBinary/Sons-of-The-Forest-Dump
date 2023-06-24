using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200087E RID: 2174
	[Token(Token = "0x200087E")]
	[AddComponentMenu("Sons/Gameplay/CookingCookingSurfaceHookPoint")]
	public class CookingSurfaceHookPoint : MonoBehaviour
	{
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003E0B RID: 15883 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x17000819")]
		private bool IsCooked
		{
			[Token(Token = "0x6003E0B")]
			[Address(RVA = "0x35CA3D0", Offset = "0x35C89D0", VA = "0x1835CA3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x1700081A")]
		private bool IsBurnt
		{
			[Token(Token = "0x6003E0C")]
			[Address(RVA = "0x35CA3E0", Offset = "0x35C89E0", VA = "0x1835CA3E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003E0D RID: 15885 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x1700081B")]
		private bool IsDestroyed
		{
			[Token(Token = "0x6003E0D")]
			[Address(RVA = "0x35CA400", Offset = "0x35C8A00", VA = "0x1835CA400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0x35CA430", Offset = "0x35C8A30", VA = "0x1835CA430")]
		public ItemInstance GetItemInstance()
		{
			return null;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x6003E0F")]
		[Address(RVA = "0x35CA510", Offset = "0x35C8B10", VA = "0x1835CA510")]
		public bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E10")]
		[Address(RVA = "0x35CA5D0", Offset = "0x35C8BD0", VA = "0x1835CA5D0")]
		public void Initialize(ItemInstance itemInstance, CookingRecipe recipe)
		{
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x35CB030", Offset = "0x35C9630", VA = "0x1835CB030")]
		private void SetPerishableStateMp()
		{
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x35CB220", Offset = "0x35C9820", VA = "0x1835CB220")]
		private void OnCookingItemRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x35CB2D0", Offset = "0x35C98D0", VA = "0x1835CB2D0")]
		public void Clear()
		{
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x35CB370", Offset = "0x35C9970", VA = "0x1835CB370")]
		public Transform GetVisualTransform()
		{
			return null;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x35CB4B0", Offset = "0x35C9AB0", VA = "0x1835CB4B0")]
		public void StartCookingAudio()
		{
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x35CB700", Offset = "0x35C9D00", VA = "0x1835CB700")]
		public void StopCookingAudio()
		{
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E17")]
		[Address(RVA = "0x35CB730", Offset = "0x35C9D30", VA = "0x1835CB730")]
		public void Cook()
		{
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E18")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CookingSurfaceHookPoint()
		{
		}

		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PickUp _attachedPickup;

		// Token: 0x04003438 RID: 13368
		[Token(Token = "0x4003438")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		[FieldOffset(Offset = "0x30")]
		private float _destroyTimeRemaining;

		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		[FieldOffset(Offset = "0x34")]
		private float _burntTimeRemaining;

		// Token: 0x0400343B RID: 13371
		[Token(Token = "0x400343B")]
		[FieldOffset(Offset = "0x38")]
		private float _cookTimeRemaining;

		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		[FieldOffset(Offset = "0x40")]
		private EventInstance _duringCookingAudio;

		// Token: 0x0400343D RID: 13373
		[Token(Token = "0x400343D")]
		[FieldOffset(Offset = "0x48")]
		private ItemInstance _itemInstance;

		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		[FieldOffset(Offset = "0x50")]
		private PerishableItemInstanceModule _perishableModule;

		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		[FieldOffset(Offset = "0x58")]
		private CookingRecipe _recipe;

		// Token: 0x04003440 RID: 13376
		[Token(Token = "0x4003440")]
		[FieldOffset(Offset = "0x60")]
		public Action<CookingSurfaceHookPoint> HookPointCleared;
	}
}
