using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class SetSelectable : MonoBehaviour
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3016BD0", Offset = "0x30151D0", VA = "0x183016BD0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3016BF0", Offset = "0x30151F0", VA = "0x183016BF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3016C20", Offset = "0x3015220", VA = "0x183016C20")]
		private void TriggerInvert()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x3016C40", Offset = "0x3015240", VA = "0x183016C40")]
		public void Trigger()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3016C60", Offset = "0x3015260", VA = "0x183016C60")]
		private void SetSelectableValues(List<Selectable> selectables, bool value)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3016EE0", Offset = "0x30154E0", VA = "0x183016EE0")]
		public SetSelectable()
		{
		}

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Selectable> _selectables;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _value;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _setDisabledAsSelected;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _disabledStringValue;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _enabledStringValue;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _onEnable;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _onDisableMirror;
	}
}
