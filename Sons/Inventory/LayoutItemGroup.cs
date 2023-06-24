using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Inventory
{
	// Token: 0x02000625 RID: 1573
	[Token(Token = "0x2000625")]
	public class LayoutItemGroup<T> : MonoBehaviour where T : LayoutItem
	{
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x17000555")]
		public int ItemId
		{
			[Token(Token = "0x60028DE")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000556")]
		public List<T> LayoutItems
		{
			[Token(Token = "0x60028DF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x17000557")]
		public bool IsOneToOneCollection
		{
			[Token(Token = "0x60028E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E1")]
		public ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x60028E2")]
		protected static bool ShouldRunOnValidate()
		{
			return default(bool);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E3")]
		protected virtual void Start()
		{
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E6")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E7")]
		private void UpdateAnimation()
		{
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E8")]
		protected void ResetAnimation()
		{
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E9")]
		public void SpreadOutItems(LayoutItem layoutItem)
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EA")]
		public void PullInItems(LayoutItem layoutItem)
		{
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EB")]
		protected virtual void RefreshItems()
		{
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x60028EC")]
		public virtual bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028ED")]
		public virtual void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x60028EE")]
		public int GetActiveVisualCount()
		{
			return 0;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EF")]
		public LayoutItemGroup()
		{
		}

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[ItemIdPicker(true)]
		protected int _itemId;

		// Token: 0x040024AA RID: 9386
		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0x0")]
		private ItemData _itemData;

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[FormerlySerializedAs("_isUniqueCollection")]
		protected bool _isOneToOneCollection;

		// Token: 0x040024AC RID: 9388
		[Token(Token = "0x40024AC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<T> _layoutItems;

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected AnimationClip _animationClip;

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Min(0.1f)]
		private float _animationSpeedMultiplier;

		// Token: 0x040024AF RID: 9391
		[Token(Token = "0x40024AF")]
		[FieldOffset(Offset = "0x0")]
		[Min(0f)]
		[SerializeField]
		private float _delayTime;

		// Token: 0x040024B0 RID: 9392
		[Token(Token = "0x40024B0")]
		[FieldOffset(Offset = "0x0")]
		private bool _previewAnimation;

		// Token: 0x040024B1 RID: 9393
		[Token(Token = "0x40024B1")]
		[FieldOffset(Offset = "0x0")]
		[Range(0f, 1f)]
		private float _animTime;

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("_onHoverOverAudioEvent")]
		[SerializeField]
		[EventRef]
		protected string _onInteractAudioEvent;

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[FieldOffset(Offset = "0x0")]
		private float _currentAnimTime;

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		[FieldOffset(Offset = "0x0")]
		private float _remainingAnimationDelay;

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		[FieldOffset(Offset = "0x0")]
		private bool _spreadOut;

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		[FieldOffset(Offset = "0x0")]
		private bool _trackAnimationDelay;

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x0")]
		private bool _spreadingOut;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x0")]
		private bool _pullingIn;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x0")]
		public Action<GameObject> OnRenderableInstanced;
	}
}
