using System;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public abstract class SaveSlotBase : MonoBehaviour
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000E")]
		public Button MainButton
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000F")]
		public Button DeleteButton
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3015C40", Offset = "0x3014240", VA = "0x183015C40")]
		protected void SetButtonCallback(UnityAction sourceEvent)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3015DE0", Offset = "0x30143E0", VA = "0x183015DE0")]
		protected void SetButtonDeleteCallback(UnityAction sourceEvent)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		internal virtual void OnButton()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		internal virtual void OnButtonDelete()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
		internal int GetSaveId()
		{
			return 0;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		internal GameStateData GetGameStateData()
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x3015F30", Offset = "0x3014530", VA = "0x183015F30")]
		internal void Setup(uint saveId, GameStateData data)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x30160E0", Offset = "0x30146E0", VA = "0x1830160E0")]
		internal void Setup(int saveId, GameStateData data)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3016520", Offset = "0x3014B20", VA = "0x183016520")]
		private void RandomizeBackingOrientation()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		internal virtual void RemoveButton()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected SaveSlotBase()
		{
		}

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x30")]
		private int _saveId;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x38")]
		private GameStateData _data;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x40")]
		private UnityAction _buttonUnityAction;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x48")]
		private UnityAction _buttonDeleteUnityAction;
	}
}
