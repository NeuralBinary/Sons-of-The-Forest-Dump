using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[AddComponentMenu("Sons/Gui/Options/OptionsGuiManager")]
	public class OptionsGuiManager : MonoBehaviour
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3044890", Offset = "0x3042E90", VA = "0x183044890", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x3044B10", Offset = "0x3043110", VA = "0x183044B10")]
		private void ShowApplyButton()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x3044B70", Offset = "0x3043170", VA = "0x183044B70")]
		private void HideApplyButton()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3044BD0", Offset = "0x30431D0", VA = "0x183044BD0", Slot = "5")]
		internal virtual void UnregisterEvents()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3044EA0", Offset = "0x30434A0", VA = "0x183044EA0", Slot = "6")]
		internal virtual void RegisterEvents()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3045180", Offset = "0x3043780", VA = "0x183045180")]
		private void OnNextPage()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x3045250", Offset = "0x3043850", VA = "0x183045250")]
		private void OnPreviousPage()
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x3045330", Offset = "0x3043930", VA = "0x183045330")]
		private void OnDisable()
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x3045340", Offset = "0x3043940", VA = "0x183045340")]
		private bool HasCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3045490", Offset = "0x3043A90", VA = "0x183045490")]
		public void HideApplyDialog()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x30454F0", Offset = "0x3043AF0", VA = "0x1830454F0")]
		private void ShowApplyDialog()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x3045550", Offset = "0x3043B50", VA = "0x183045550")]
		public void Dispose()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x30458B0", Offset = "0x3043EB0", VA = "0x1830458B0")]
		public void OnResetButton()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x3045A30", Offset = "0x3044030", VA = "0x183045A30")]
		public void OnApplyChanges()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x3045C90", Offset = "0x3044290", VA = "0x183045C90")]
		private void OnBackButton()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x3045E60", Offset = "0x3044460", VA = "0x183045E60")]
		public void OnBack()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3045EE0", Offset = "0x30444E0", VA = "0x183045EE0")]
		private void RefreshActive()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3046040", Offset = "0x3044640", VA = "0x183046040")]
		public void SetActive(OptionsGui target)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x3046050", Offset = "0x3044650", VA = "0x183046050")]
		public void SetActive(OptionsGui target, UnityEvent soundEvent)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x3046290", Offset = "0x3044890", VA = "0x183046290")]
		private void SetActive(OptionsGui target, bool value)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x3046360", Offset = "0x3044960", VA = "0x183046360")]
		private Dictionary<string, object> FindAllDefaultValues()
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x3046500", Offset = "0x3044B00", VA = "0x183046500")]
		public void ResetAllSettingsToDefaultValues()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB4160", VA = "0x180AB5B60")]
		public OptionsGuiManager()
		{
		}

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<OptionsGui> _optionGroups;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_useApplyButtonGroup")]
		[SerializeField]
		private bool _hideShowApplyButtonGroup;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _applyButtonGroup;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _applyDialogGroup;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _resetButton;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _backButton;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OptionsGui _active;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _activeColor;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _inactiveColor;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent _onNextPageUnityEvent;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent _onPreviousPageUnityEvent;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private FmodEmitterBuffer _selectedAudioEvent;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private FmodEmitterBuffer _applyAudioEvent;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private FmodEmitterBuffer _resetAudioEvent;
	}
}
