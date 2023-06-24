using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Sons/Gui/ApplyButton")]
	public class ApplyButton : MonoBehaviour
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x30394B0", Offset = "0x3037AB0", VA = "0x1830394B0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x30394C0", Offset = "0x3037AC0", VA = "0x1830394C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3039540", Offset = "0x3037B40", VA = "0x183039540")]
		private void ValidateButton()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3039680", Offset = "0x3037C80", VA = "0x183039680")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x30396F0", Offset = "0x3037CF0", VA = "0x1830396F0")]
		private void OnApply()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public ApplyButton()
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoFindButton;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _targetButton;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onApplyUnityEvent;
	}
}
