using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Inventory
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	public class LayoutItemGroup<T> : MonoBehaviour where T : LayoutItem
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x17000540")]
		public int ItemId
		{
			[Token(Token = "0x60027C5")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000541")]
		public List<T> LayoutItems
		{
			[Token(Token = "0x60027C6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x17000542")]
		public bool IsUniqueCollection
		{
			[Token(Token = "0x60027C7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000543")]
		public ItemData ItemData
		{
			[Token(Token = "0x60027C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x60027C9")]
		protected static bool ShouldRunOnValidate()
		{
			return default(bool);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CA")]
		protected virtual void Start()
		{
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CB")]
		protected virtual void Update()
		{
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CC")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CD")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CE")]
		private void UpdateAnimation()
		{
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CF")]
		protected void ResetAnimation()
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D0")]
		public void SpreadOutItems(LayoutItem layoutItem)
		{
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D1")]
		public void PullInItems(LayoutItem layoutItem)
		{
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D2")]
		protected virtual void RefreshItems()
		{
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x60027D3")]
		public virtual bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D4")]
		public virtual void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x60027D5")]
		public int GetActiveVisualCount()
		{
			return default(int);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D6")]
		public LayoutItemGroup()
		{
		}

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x0")]
		[ItemIdPicker(true)]
		[SerializeField]
		protected int _itemId;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected ItemData _itemData;

		// Token: 0x040023BA RID: 9146
		[Token(Token = "0x40023BA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected bool _isUniqueCollection;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<T> _layoutItems;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected AnimationClip _animationClip;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[FieldOffset(Offset = "0x0")]
		[Min(0.1f)]
		[SerializeField]
		private float _animationSpeedMultiplier;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Min(0f)]
		private float _delayTime;

		// Token: 0x040023BF RID: 9151
		[Token(Token = "0x40023BF")]
		[FieldOffset(Offset = "0x0")]
		private bool _previewAnimation;

		// Token: 0x040023C0 RID: 9152
		[Token(Token = "0x40023C0")]
		[FieldOffset(Offset = "0x0")]
		[Range(0f, 1f)]
		private float _animTime;

		// Token: 0x040023C1 RID: 9153
		[Token(Token = "0x40023C1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[EventRef]
		[FormerlySerializedAs("_onHoverOverAudioEvent")]
		protected string _onInteractAudioEvent;

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		[FieldOffset(Offset = "0x0")]
		private float _currentAnimTime;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		[FieldOffset(Offset = "0x0")]
		private float _remainingAnimationDelay;

		// Token: 0x040023C4 RID: 9156
		[Token(Token = "0x40023C4")]
		[FieldOffset(Offset = "0x0")]
		private bool _spreadOut;

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x0")]
		private bool _trackAnimationDelay;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x0")]
		private bool _spreadingOut;

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0x0")]
		private bool _pullingIn;
	}
}
