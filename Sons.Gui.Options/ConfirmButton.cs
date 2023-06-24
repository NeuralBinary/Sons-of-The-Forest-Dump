using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[AddComponentMenu("Sons/Gui/ConfirmButton")]
	public class ConfirmButton : MonoBehaviour
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x303A4E0", Offset = "0x3038AE0", VA = "0x18303A4E0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x303A4F0", Offset = "0x3038AF0", VA = "0x18303A4F0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x303A650", Offset = "0x3038C50", VA = "0x18303A650")]
		private void ValidateButton()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x303A790", Offset = "0x3038D90", VA = "0x18303A790")]
		private void OnDisable()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x303A800", Offset = "0x3038E00", VA = "0x18303A800")]
		private void OnConfirm()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public ConfirmButton()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoFindButton;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _targetButton;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_onApplyUnityEvent")]
		[SerializeField]
		private UnityEvent _onConfirmUnityEvent;
	}
}
